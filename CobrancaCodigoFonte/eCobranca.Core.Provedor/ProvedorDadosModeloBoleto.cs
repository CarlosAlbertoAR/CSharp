using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoleto : IProvedorDadosModeloBoleto
{
	public const string VAZIO = "";

	public const string DUAS_CASAS_DECIMAIS = "F2";

	public const string TRES_CASAS_DECIMAIS = "F3";

	public const string QUATRO_CASAS_DECIMAIS = "F4";

	public const string CINCO_CASAS_DECIMAIS = "F5";

	public const string SIMBOLO_REAL = "R$";

	public const string SIMBOLO_COMPENSACAO = "|";

	public const string LINHA_DIGITAVEL_1 = "LinhaDigitavel1";

	public const string LINHA_DIGITAVEL_2 = "LinhaDigitavel2";

	public const string ESTILO_CABECALHO_CAMPO_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_CabecalhoCampo";

	public const string ESTILO_CABECALHO_CAMPO_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_CabecalhoCampo";

	public const string ESTILO_CONTEUDO_CAMPO_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_ConteudoCampo";

	public const string ESTILO_CONTEUDO_CAMPO_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_ConteudoCampo";

	public const string ESTILO_LOGOTIPO_BANCO_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_LogotipoBanco";

	public const string ESTILO_LOGOTIPO_BANCO_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_LogotipoBanco";

	public const string ESTILO_CODIGO_BANCO_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_CodigoBanco";

	public const string ESTILO_CODIGO_BANCO_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_CodigoBanco";

	public const string ESTILO_LINHA_DIGITAVEL_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_LinhaDigitavel";

	public const string ESTILO_LINHA_DIGITAVEL_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_LinhaDigitavel";

	public const string ESTILO_CONTEUDO_CAMPO_VALOR_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_ConteudoCampoValor";

	public const string ESTILO_CONTEUDO_CAMPO_VALOR_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_ConteudoCampoValor";

	public const string ESTILO_INSTRUCOES_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_Instrucoes";

	public const string ESTILO_INSTRUCOES_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_Instrucoes";

	public const string ESTILO_DADOS_PAGADOR_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_DadosPagador";

	public const string ESTILO_DADOS_PAGADOR_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_DadosPagador";

	public const string ESTILO_DADOS_AVALISTA_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_DadosAvalista";

	public const string ESTILO_DADOS_AVALISTA_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_DadosAvalista";

	public const string ESTILO_AUTENTICACAO_MECANICA_FICHA_NORMAL = "FICHA_COMPENSACAO_NORMAL_AutenticacaoMecanica";

	public const string ESTILO_AUTENTICACAO_MECANICA_FICHA_REDUZIDA = "FICHA_COMPENSACAO_REDUZIDA_AutenticacaoMecanica";

	public const int ALTURA_MAXIMA_CAMPO_DEMONSTRATIVO_UNICO = 330;

	public const int ALTURA_MAXIMA_CAMPO_DEMONSTRATIVO_COMPOSTO = 450;

	protected const int QUANTIDADE_MAXIMA_CARACTERES_IDENTIFICACAO_BENEFICIARIO = 120;

	protected CarteiraCobranca carteira;

	protected DocumentoCobranca dc;

	protected ModeloBoleto mb;

	protected string diretorioTemporarioImagens = AppDomain.CurrentDomain.BaseDirectory + "\\Temp\\";

	protected string namespaceImagens = "eCobranca/Core/Modelo/Imagens/";

	protected Interleaved2of5 i25;

	protected EnumCodigoProtesto[] codigosParaNaoProtestar;

	public ProvedorDadosModeloBoleto()
	{
		i25 = new Interleaved2of5();
		codigosParaNaoProtestar = new EnumCodigoProtesto[10]
		{
			EnumCodigoProtesto.DEVOLVER_NAO_PROTESTAR,
			EnumCodigoProtesto.NAO_HA_INSTRUCOES,
			EnumCodigoProtesto.NAO_NAGATIVAR,
			EnumCodigoProtesto.NAO_NEGATIVAR,
			EnumCodigoProtesto.NAO_PROTESTAR,
			EnumCodigoProtesto.NAO_PROTESTAR2,
			EnumCodigoProtesto.NAO_PROTESTAR3,
			EnumCodigoProtesto.NAO_PROTESTAR4,
			EnumCodigoProtesto.NAO_PROTESTAR5,
			EnumCodigoProtesto.NEGATIVACAO_SEM_PROTESTO
		};
	}

	public virtual string GetLogoTipoBanco()
	{
		return ImageUtil.GetInstance().ExtrairImagemDosRecursos(namespaceImagens, carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + ".jpg", diretorioTemporarioImagens);
	}

	public virtual string GetNumeroBanco()
	{
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.CodigoBancoImpressao))
		{
			return "|" + carteira.ConfiguracaoBoleto.CodigoBancoImpressao + "|";
		}
		return "";
	}

	public virtual string GetVencimento()
	{
		if (dc != null)
		{
			if (dc.DataVencimento.HasValue)
			{
				return dc.DataVencimento.Value.ToShortDateString();
			}
			return "";
		}
		return DateTime.Today.ToShortDateString();
	}

	public virtual string GetAgenciaCodigoCedente()
	{
		if (((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor == null || ((DadoConfiguracao)carteira.DadosConfiguracao[1]).Valor == null)
		{
			return "";
		}
		return ((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor + "/" + ((DadoConfiguracao)carteira.DadosConfiguracao[1]).Valor;
	}

	public virtual string GetMoeda()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.Moeda))
			{
				return dc.Moeda.ToEnum<EnumCodigoMoeda>().Sigla();
			}
			return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Sigla();
		}
		return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Sigla();
	}

	public virtual string GetQuantidade()
	{
		return "";
	}

	public virtual string GetValorDocumento()
	{
		if (dc != null)
		{
			if (!carteira.ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO))
			{
				if (!(dc.ValorDocumento <= 0.0))
				{
					return MaskUtil.AplicarMascaraValorMonetario(dc.ValorDocumento);
				}
				return "";
			}
			return MaskUtil.AplicarMascaraValorMonetario(1.0);
		}
		return MaskUtil.AplicarMascaraValorMonetario(1.0);
	}

	public virtual string GetValorDesconto()
	{
		if (dc != null)
		{
			if (!(dc.ValorDesconto <= 0.0))
			{
				return MaskUtil.AplicarMascaraValorMonetario(dc.ValorDesconto);
			}
			return "";
		}
		return MaskUtil.AplicarMascaraValorMonetario(0.0);
	}

	public virtual string GetValorJuros()
	{
		if (dc != null)
		{
			if (!(dc.ValorJurosDiasAtraso <= 0.0))
			{
				return MaskUtil.AplicarMascaraValorMonetario(dc.ValorJurosDiasAtraso);
			}
			return "";
		}
		return MaskUtil.AplicarMascaraValorMonetario(0.0);
	}

	public virtual string GetNossoNumero()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.NossoNumero))
			{
				return dc.NossoNumero;
			}
			return "";
		}
		return "";
	}

	public virtual string GetNumeroDocumento()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.NumeroDocumento))
			{
				return dc.NumeroDocumento;
			}
			return "";
		}
		return "0000001001";
	}

	public virtual string GetNomeCedente()
	{
		if (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBIR_RAZAO_SOCIAL_BENEFICIARIO, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibirRazaoSocialBeneficiario(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S" && true && !string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.RazaoSocialBeneficiario))
		{
			return StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.RazaoSocialBeneficiario, 40);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario))
		{
			return StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario, 40);
		}
		return "";
	}

	public virtual string GetIdentificacaoCedente()
	{
		string empty = string.Empty;
		empty += GetNomeCedente();
		if (carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario.Length + carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario.Length + carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario.Length + carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario.Length + carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario.Length + carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario.Length > 120)
		{
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario))
			{
				empty = empty + " CNPJ/CPF:" + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario, 18) + Environment.NewLine;
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario))
			{
				empty = empty + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario, 40);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario))
			{
				empty = empty + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario, 20);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario))
			{
				empty = empty + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario, 30);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario))
			{
				empty = empty + "-" + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario, 2);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario))
			{
				empty = empty + " CEP:" + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario, 10);
			}
		}
		else
		{
			empty = empty + " CNPJ/CPF:" + carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario + Environment.NewLine;
			empty = empty + " " + carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario;
			empty = empty + " " + carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario;
			empty = empty + " " + carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario;
			empty = empty + "-" + carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario;
			empty = empty + " CEP:" + carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario;
		}
		return empty;
	}

	public virtual string GetLocalPagamento()
	{
		if (!(ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") || 1 == 0)
		{
			if (!string.IsNullOrEmpty(dc.LocalPagamento))
			{
				return StringUtil.TruncateString(dc.LocalPagamento.ToUpper(), 90);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LocalPagamento))
			{
				return StringUtil.TruncateString(carteira.ConfiguracaoBoleto.LocalPagamento.ToUpper(), 90);
			}
			return StringUtil.TruncateString($"PAGÁVEL EM QUALQUER BANCO", 90);
		}
		return StringUtil.TruncateString($"PAGÁVEL APENAS NAS AGÊNCIAS DO {carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Descricao()}.".ToUpper(), 90);
	}

	public virtual string GetDataDocumento()
	{
		if (!dc.DataDocumento.HasValue)
		{
			return default(DateTime).ToShortDateString();
		}
		return dc.DataDocumento.Value.ToShortDateString();
	}

	public virtual string GetEspecieDocumento()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.TipoDocumentoCobranca))
			{
				return dc.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Sigla();
			}
			return carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Sigla();
		}
		return carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Sigla();
	}

	public virtual string GetAceite()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.Aceite))
			{
				return dc.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			return carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
		}
		return carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
	}

	public virtual string GetDataProcessamento()
	{
		if (!dc.DataProcessamento.HasValue)
		{
			return default(DateTime).ToShortDateString();
		}
		return dc.DataProcessamento.Value.ToShortDateString();
	}

	public virtual string GetCodigoUsoBanco()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.CodigoUsoBanco))
			{
				return dc.CodigoUsoBanco;
			}
			return "";
		}
		return "";
	}

	public virtual string GetCarteira()
	{
		if (!string.IsNullOrEmpty(carteira.GetCodigoCarteiraImpressao()))
		{
			return carteira.GetCodigoCarteiraImpressao();
		}
		return carteira.ConfiguracaoBoleto.CodigoCarteiraImpressao;
	}

	public virtual string GetInstrucoesCaixa()
	{
		string empty = string.Empty;
		empty = "\n";
		string text = "";
		bool flag = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		int num = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_QUEBRAR_LINHAS_MENSAGENS_AUTOMATICAS, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.QuebrarLinhasMensagensAutomaticas(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? 1 : 0);
		bool flag2 = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_MENSAGEM_HIBRIDA_JUROS_MULTA_DESCONTO, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibeMensagemHibridaDeJurosMultaDesconto(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		bool flag3 = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_EM_CAIXA_ALTA, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibeConteudoCampoInstrucoesEmCaixaAlta(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		if (num == 0)
		{
			empty = " ";
		}
		text += (flag ? string.Format("Pagável somente no {0}." + empty, carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Descricao()) : "");
		if (dc != null)
		{
			double num2 = 0.0;
			num2 = ((!(dc.ValorMultaAtraso > 0.0)) ? ((!(dc.PercentualMultaAtraso > 0.0)) ? 0.0 : (num2 = dc.PercentualMultaAtraso / 100.0 * dc.ValorDocumento)) : (num2 = dc.ValorMultaAtraso));
			text = ((!flag2) ? (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de R$ " + num2.ToString("F2") + "." + empty) : "")) : (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de  " + (num2 / dc.ValorDocumento * 100.0).ToString("F2") + "% no valor de R$ " + num2.ToString("F2") + "." + empty) : "")));
			double num3 = 0.0;
			num3 = ((!(dc.ValorJurosDiasAtraso > 0.0)) ? ((!(dc.PercentualJurosDiaAtraso > 0.0)) ? 0.0 : (num3 = dc.PercentualJurosDiaAtraso / 100.0 * dc.ValorDocumento)) : (num3 = dc.ValorJurosDiasAtraso));
			text = ((!flag2) ? (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")) : (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")));
			double num4 = 0.0;
			num4 = ((!(dc.ValorDesconto > 0.0)) ? ((!(dc.PercentualDesconto > 0.0)) ? 0.0 : (num4 = dc.PercentualDesconto / 100.0 * dc.ValorDocumento)) : (num4 = dc.ValorDesconto));
			string text2 = (dc.DataLimiteDesconto.HasValue ? (" até " + dc.DataLimiteDesconto.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " ") : "antes do vencimento ");
			text = ((!flag2) ? (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? string.Format("Em caso de pagamento " + text2 + " conceder R$ " + num4.ToString("F2") + " de desconto. " + empty) : "")) : (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? ("Em caso de pagamento " + text2 + " conceder " + (num4 / dc.ValorDocumento * 100.0).ToString("F2") + "% de desconto que corresponde a R$ " + num4.ToString("F2") + ". " + empty) : "")));
			if (dc.GeraMensagemProtesto)
			{
				EnumCodigoProtesto value = CodigoProtestoVigente();
				if (!codigosParaNaoProtestar.Contains(value))
				{
					text += ((!dc.GeraMensagemProtesto || (dc.DiasProtesto <= 0 && carteira.ConfiguracaoDocumentoCobranca.DiasProtesto <= 0)) ? "" : ((dc.DiasProtesto <= 0) ? "" : (ProtestarEmDiasUteis(value) ? string.Format("Protestar após {0} dias úteis da data de vencimento do título. " + empty, dc.DiasProtesto) : string.Format("Protestar após {0} dias corridos da data de vencimento do título. " + empty, dc.DiasProtesto))));
				}
			}
			string empty2 = string.Empty;
			empty2 = dc.InstrucaoCaixa;
			text += empty2;
			if (flag3)
			{
				text = text.ToUpper();
			}
		}
		return text;
	}

	public virtual string GetNomeSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.NomePagador))
			{
				return StringUtil.TruncateString(dc.NomePagador, 50);
			}
			return "";
		}
		return "Nome do pagador";
	}

	public virtual string GetCnpjSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.CnpjPagador))
			{
				return StringUtil.TruncateString(dc.CnpjPagador, 18);
			}
			return "";
		}
		return "";
	}

	public virtual string GetCpfSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.CpfPagador))
			{
				return StringUtil.TruncateString(dc.CpfPagador, 14);
			}
			return "";
		}
		return StringUtil.AplicarMascara("00000000000", "000.000.000-00");
	}

	public virtual string GetEnderecoSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.EnderecoPagador))
			{
				return StringUtil.TruncateString(dc.EnderecoPagador, 40);
			}
			return "";
		}
		return "Endereço do pagador";
	}

	public virtual string GetBairroSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.BairroPagador))
			{
				return StringUtil.TruncateString(dc.BairroPagador, 20);
			}
			return "";
		}
		return "Bairro do pagador";
	}

	public virtual string GetCidadeSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.CidadePagador))
			{
				return StringUtil.TruncateString(dc.CidadePagador, 30);
			}
			return "";
		}
		return "Cidade do pagador";
	}

	public virtual string GetUfSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.UfPagador))
			{
				return StringUtil.TruncateString(dc.UfPagador, 2);
			}
			return "";
		}
		return "Uf do pagador";
	}

	public virtual string GetCepSacado()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.CepPagador))
			{
				return StringUtil.TruncateString(dc.CepPagador, 10);
			}
			return "";
		}
		return StringUtil.AplicarMascara("00000000", "00000-000");
	}

	public string GetIdentificacaoSacado()
	{
		string text = string.Empty;
		if (dc != null)
		{
			text += (string.IsNullOrEmpty(dc.NomePagador) ? "" : StringUtil.TruncateString(dc.NomePagador, 50));
			text += (string.IsNullOrEmpty(dc.CelularPagador) ? "" : (" Fone: " + StringUtil.TruncateString(dc.CelularPagador, 15)));
			text += (string.IsNullOrEmpty(dc.CnpjPagador) ? "" : (" CNPJ:" + StringUtil.TruncateString(dc.CnpjPagador, 18) + Environment.NewLine));
			text += (string.IsNullOrEmpty(dc.CpfPagador) ? "" : (" CPF:" + StringUtil.TruncateString(dc.CpfPagador, 14) + Environment.NewLine));
			text += (string.IsNullOrEmpty(dc.EnderecoPagador) ? "" : StringUtil.TruncateString(dc.EnderecoPagador, 40));
			text += (string.IsNullOrEmpty(dc.BairroPagador) ? "" : (", " + StringUtil.TruncateString(dc.BairroPagador, 20)));
			text += (string.IsNullOrEmpty(dc.CidadePagador) ? "" : (", " + StringUtil.TruncateString(dc.CidadePagador, 30)));
			text += (string.IsNullOrEmpty(dc.UfPagador) ? "" : ("-" + StringUtil.TruncateString(dc.UfPagador, 2)));
			text += (string.IsNullOrEmpty(dc.CepPagador) ? "" : (" CEP:" + StringUtil.TruncateString(dc.CepPagador, 10)));
		}
		return text;
	}

	public virtual string GetIdentificacaoSacadorAvalista()
	{
		string text = string.Empty;
		if (dc != null)
		{
			text += (string.IsNullOrEmpty(dc.SacadorAvalista) ? "" : StringUtil.TruncateString(dc.SacadorAvalista, 85));
			text += (string.IsNullOrEmpty(dc.CnpjAvalista) ? "" : (" CNPJ:" + StringUtil.TruncateString(dc.CnpjAvalista, 18) + Environment.NewLine));
			text += (string.IsNullOrEmpty(dc.CpfAvalista) ? "" : (" CPF:" + StringUtil.TruncateString(dc.CpfAvalista, 14) + Environment.NewLine));
		}
		return text;
	}

	public virtual string GetLinhaDigitavel()
	{
		if (!string.IsNullOrEmpty(dc.LinhaDigitavel))
		{
			return dc.LinhaDigitavel;
		}
		return "";
	}

	public virtual string GetCodigoBarras()
	{
		if (!string.IsNullOrEmpty(dc.CodigoBarras))
		{
			return CriarCodigoBarrasPadraoI25(dc.CodigoBarras);
		}
		return "";
	}

	public virtual string GetContatoSac()
	{
		if (!carteira.ConfiguracaoBoleto.ExibeSAC)
		{
			return string.Empty;
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.DadosSAC))
		{
			return StringUtil.FormatStringToSizedString(carteira.ConfiguracaoBoleto.DadosSAC, 300);
		}
		return string.Empty;
	}

	public virtual string GetLogotipoCedente()
	{
		if (!carteira.ConfiguracaoBoleto.ExibeLogotipoBeneficiario)
		{
			return ImageUtil.GetInstance().ExtrairImagemDosRecursos("eCobranca/Core/Modelo/Imagens/", carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + ".jpg", diretorioTemporarioImagens);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LogotipoBeneficiario))
		{
			return carteira.ConfiguracaoBoleto.LogotipoBeneficiario;
		}
		return ImageUtil.GetInstance().ExtrairImagemDosRecursos("eCobranca/Core/Modelo/Imagens/", carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + ".jpg", diretorioTemporarioImagens);
	}

	public virtual string GetValorOutrosAcrescimos()
	{
		if (dc != null)
		{
			if (!(dc.ValorOutrosAcrescimos <= 0.0))
			{
				return MaskUtil.AplicarMascaraValorMonetario(dc.ValorOutrosAcrescimos);
			}
			return "";
		}
		return MaskUtil.AplicarMascaraValorMonetario(0.0);
	}

	public virtual string GetInformacoesExtras()
	{
		string text = string.Empty;
		string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_MENSAGEM_AO_PAGADOR, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.MensagemAoPagador(), carteira.ConfiguracaoBoleto.ParametrosAdicionais);
		int num = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_NAS_INFORMACOES_EXTRAS_PAGADOR, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibeConteudoCampoInstrucoesNasInformacoesExtrasDoPagador(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? 1 : 0);
		if (!string.IsNullOrEmpty(valorParametroAdicional))
		{
			text = (string.IsNullOrEmpty(text) ? valorParametroAdicional : (text + Environment.NewLine + valorParametroAdicional));
		}
		if (num != 0)
		{
			text = (string.IsNullOrEmpty(text) ? GetInstrucoesCaixa() : (text + Environment.NewLine + GetInstrucoesCaixa()));
		}
		if (!string.IsNullOrEmpty(dc.InformacoesExtras))
		{
			text = (string.IsNullOrEmpty(text) ? dc.InformacoesExtras : (text + Environment.NewLine + dc.InformacoesExtras));
		}
		return text;
	}

	public virtual string GetDemonstrativo()
	{
		if (dc != null && !string.IsNullOrEmpty(dc.Demonstrativo))
		{
			return dc.Demonstrativo;
		}
		return string.Empty;
	}

	public virtual string GetUrlOrigem()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.URLOrigem))
			{
				return dc.URLOrigem;
			}
			return "";
		}
		return "";
	}

	public virtual string GetPropaganda()
	{
		if (!carteira.ConfiguracaoBoleto.ExibePropaganda)
		{
			return "";
		}
		if (string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.Propaganda) || string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.TipoPropaganda))
		{
			return "";
		}
		if (!(carteira.ConfiguracaoBoleto.TipoPropaganda == EnumTipoPropaganda.IMAGEM.ToString()))
		{
			return "";
		}
		return carteira.ConfiguracaoBoleto.Propaganda;
	}

	public virtual string GetLinhaDigitavelEspelho()
	{
		if (!carteira.ConfiguracaoBoleto.ExibeEspelhoLinhaDigitavel)
		{
			return "";
		}
		return dc.LinhaDigitavel;
	}

	public virtual string GetNumeroBancoRecibo()
	{
		if (!carteira.ConfiguracaoBoleto.ExibeCodigoBancoCompensacaoRecibo)
		{
			return "";
		}
		return "|" + carteira.ConfiguracaoBoleto.CodigoBancoImpressao + "|";
	}

	public virtual string GetImagemAutenticacaoMecanica()
	{
		return carteira.ConfiguracaoBoleto.DiretorioImagens + "AutenticacaoMecanica.jpg";
	}

	public virtual string GetEstiloLinhaDigitavel()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_LinhaDigitavel";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_LinhaDigitavel";
	}

	public virtual string GetAlturaCampoDemonstrativoReciboEntrega()
	{
		string result = "0";
		if (mb.Tipo == EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA)
		{
			if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega > 0)
			{
				if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega + carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador > 450)
				{
					int num = 0;
					int num2 = 0;
					double num3 = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega + carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador;
					if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega > 0)
					{
						num2 = Convert.ToInt32(Convert.ToDouble(carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega) / num3 * 450.0);
						num = 450 - num2;
					}
					else
					{
						num = 450;
					}
					carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega = num2;
					carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador = num;
					result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega.ToString();
				}
				else
				{
					result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega.ToString();
				}
			}
		}
		else if (mb.Tipo == EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA && carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega > 0)
		{
			if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega > 330)
			{
				carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega = 300;
			}
			result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega.ToString();
		}
		return result;
	}

	public virtual string GetAlturaCampoDemonstrativoReciboPagador()
	{
		string result = "0";
		if (mb.GetType() == typeof(ModeloBoletoPersonalizado))
		{
			result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador.ToString();
		}
		else if (mb.GetType() == typeof(ModeloBoletoPadraoSacadoEntregaPaginaInteira))
		{
			if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador > 0)
			{
				if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega + carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador > 450)
				{
					int num = 0;
					int num2 = 0;
					double num3 = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega + carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador;
					if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega > 0)
					{
						num2 = Convert.ToInt32(Convert.ToDouble(carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega) / num3 * 450.0);
						num = 450 - num2;
					}
					else
					{
						num = 450;
					}
					carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega = num2;
					carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador = num;
					result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador.ToString();
				}
				else
				{
					result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador.ToString();
				}
			}
		}
		else if (mb.GetType() == typeof(ModeloBoletoPadraoSacadoPaginaInteira) && carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador > 0)
		{
			if (carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador > 330)
			{
				carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador = 330;
			}
			result = carteira.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador.ToString();
		}
		return result;
	}

	public virtual string GetEstiloCabecalhoCampoFichaCompensacao()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_CabecalhoCampo";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_CabecalhoCampo";
	}

	public virtual string GetEstiloConteudoCampoFichaCompensacao()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_ConteudoCampo";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_ConteudoCampo";
	}

	public string GetEstiloLogotipoBanco()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_LogotipoBanco";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_LogotipoBanco";
	}

	public string GetEstiloCodigoBanco()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_CodigoBanco";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_CodigoBanco";
	}

	public string GetEstiloConteudoCampoValorFichaCompensacao()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_ConteudoCampo";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_ConteudoCampo";
	}

	public string GetEstiloIntrucoesFichaCompensacao()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_Instrucoes";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_Instrucoes";
	}

	public string GetEstiloDadosPagador()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_DadosPagador";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_DadosPagador";
	}

	public string GetEstiloDadosAvalista()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_DadosAvalista";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_DadosAvalista";
	}

	public string GetEstiloAutenticacaoMecanica()
	{
		if (mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA && mb.Tipo != EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA)
		{
			return "FICHA_COMPENSACAO_NORMAL_AutenticacaoMecanica";
		}
		return "FICHA_COMPENSACAO_REDUZIDA_AutenticacaoMecanica";
	}

	public string GetTipoPropaganda()
	{
		return carteira.ConfiguracaoBoleto.TipoPropaganda;
	}

	public string GetCelularPagador()
	{
		if (string.IsNullOrEmpty(dc.CelularPagador))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.CelularPagador, 15);
	}

	public string GetEnderecoSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.EnderecoSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.EnderecoSacadorAvalista, 30);
	}

	public string GetNumeroEnderecoSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.NumeroEnderecoSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.NumeroEnderecoSacadorAvalista, 6);
	}

	public string GetComplementoSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.ComplementoSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.ComplementoSacadorAvalista, 30);
	}

	public string GetBairroSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.BairroSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.BairroSacadorAvalista, 20);
	}

	public string GetCidadeSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.CidadeSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.CidadeSacadorAvalista, 30);
	}

	public string GetUfSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.UfSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.UfSacadorAvalista, 2);
	}

	public string GetCepSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.CepSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.CepSacadorAvalista, 10);
	}

	public string GetTelefoneSacadorAvalista()
	{
		if (string.IsNullOrEmpty(dc.TelefoneSacadorAvalista))
		{
			return "";
		}
		return StringUtil.TruncateString(dc.TelefoneSacadorAvalista, 15);
	}

	public string GetPrefixoNomenclaturaBoleto()
	{
		if (string.IsNullOrEmpty(dc.PrefixoNomenclaturaBoleto))
		{
			return "";
		}
		return dc.PrefixoNomenclaturaBoleto;
	}

	public string GetNomenclaturaBoleto()
	{
		if (string.IsNullOrEmpty(dc.NomenclaturaBoleto))
		{
			return "";
		}
		return dc.NomenclaturaBoleto;
	}

	public string GetDiretorioGeracaoBoleto()
	{
		if (string.IsNullOrEmpty(dc.DiretorioGeracaoBoleto))
		{
			return "";
		}
		return dc.DiretorioGeracaoBoleto;
	}

	protected string CriarCodigoBarrasPadraoI25(string codigoBarras)
	{
		string result = "";
		try
		{
			Logger.Debug($"Obtendo imagens para formação do código de barras [{codigoBarras}]");
			i25.Preparar(carteira.ConfiguracaoBoleto, autoQuietZones: true, autoStartStopMarks: true);
			result = i25.GetRenderedHtmlString(i25.EncodeValue(codigoBarras), modoFastReports: true);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaCriandoCodigoBarrasI25(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected virtual bool ProtestarEmDiasUteis(EnumCodigoProtesto? codigoProtesto)
	{
		bool result = true;
		if (!codigoProtesto.HasValue)
		{
			codigoProtesto = CodigoProtestoVigente();
		}
		switch (codigoProtesto)
		{
		case EnumCodigoProtesto.NAO_HA_INSTRUCOES:
		case EnumCodigoProtesto.NAO_PROTESTAR2:
		case EnumCodigoProtesto.NAO_PROTESTAR3:
		case EnumCodigoProtesto.DEVOLVER_NAO_PROTESTAR:
		case EnumCodigoProtesto.NAO_PROTESTAR:
		case EnumCodigoProtesto.NAO_PROTESTAR4:
		case EnumCodigoProtesto.NEGATIVACAO_SEM_PROTESTO:
		case EnumCodigoProtesto.NAO_NEGATIVAR:
		case EnumCodigoProtesto.CANCELAMENTO_PROTESTO_AUTOMATICO:
		case EnumCodigoProtesto.NAO_NAGATIVAR:
		case EnumCodigoProtesto.NAO_PROTESTAR5:
			result = true;
			break;
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS:
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS2:
		case EnumCodigoProtesto.NEGATIVAR_DIAS_CORRIDOS:
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS3:
		case EnumCodigoProtesto.NEGATIVAR_DIAS_CORRIDOS2:
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS4:
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS5:
			result = false;
			break;
		case EnumCodigoProtesto.PROTESTAR_DIAS_UTEIS:
		case EnumCodigoProtesto.UTILIZAR_PERFIL_CEDENTE:
		case EnumCodigoProtesto.PROTESTAR_FIM_FALIMENTAR_DIAS_UTEIS:
		case EnumCodigoProtesto.PROTESTAR_FIM_FALIMENTAR_DIAS_CORRIDOS:
		case EnumCodigoProtesto.PROTESTO_FALIMENTAR:
		case EnumCodigoProtesto.PROTESTO_NORMAL:
		case EnumCodigoProtesto.PROTESTAR_DIAS_UTEIS2:
		case EnumCodigoProtesto.NEGATIVAR_DIAS_UTEIS:
		case EnumCodigoProtesto.NEGATIVAR:
		case EnumCodigoProtesto.NEGATIVACAO_BOLETOS_VIA_SERASA:
		case EnumCodigoProtesto.ASSUMIR_DEFINICAO_BANCO:
			result = true;
			break;
		}
		return result;
	}

	protected EnumCodigoProtesto CodigoProtestoVigente()
	{
		if (!string.IsNullOrEmpty(dc.CodigoProtesto))
		{
			return (EnumCodigoProtesto)(object)dc.CodigoProtesto?.ToEnum<EnumCodigoProtesto>();
		}
		return (EnumCodigoProtesto)(object)carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto?.ToEnum<EnumCodigoProtesto>();
	}

	public void Preparar(CarteiraCobranca carteira, DocumentoCobranca documento, ModeloBoleto modelo)
	{
		this.carteira = carteira;
		dc = documento;
		mb = modelo;
	}
}
