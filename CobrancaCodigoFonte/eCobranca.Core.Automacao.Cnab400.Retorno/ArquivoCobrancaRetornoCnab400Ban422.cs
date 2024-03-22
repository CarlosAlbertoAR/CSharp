using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Atributos;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban422;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban422 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban422(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
		header = new HeaderRetornoCnab400Ban422();
		trailler = new TraillerRetornoCnab400Ban422();
	}

	public override ArrayList CarregarArquivoRetornoCnab400()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug($"Carregando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				if (base.Lote != null)
				{
					foreach (RegistroTransacaoTipo1RetornoCnab400Ban422 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban422).NumeroSequencialGeracaoArquivo.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoOcorrenciaRetorno.Valor.Trim();
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN422_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack(item.DataOcorrenciaNoBanco.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban422).CodigoBanco.Valor.Substring(0, 3);
						ocorrenciaCobranca.CodigoAgencia = item.IdentificacaoBeneficiario.Valor.Substring(0, 5);
						ocorrenciaCobranca.NumeroContaCorrente = item.IdentificacaoBeneficiario.Valor.Substring(5, 9);
						ocorrenciaCobranca.Nossonumero = item.NossoNumero.Valor.Trim();
						ocorrenciaCobranca.NumeroDocumento = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorNominal.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack(item.TarifaCobranca.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack(item.DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorIOF = (double)doubleToStringConverter.ConvertBack(item.ValorIof.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack(item.ValorOutrasDespesas.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.ValorJurosDeMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack(item.ValorOutrosCreditos.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack(item.ValorPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(item.CodigoRejeicao.Valor.Trim());
						switch (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN422_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno))
						{
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO:
						case EnumCodigoMovimentoRetorno.LIQUIDADO_EM_CARTORIO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO2:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3:
							ocorrenciaCobranca.OcorreuPagamento = true;
							break;
						default:
							ocorrenciaCobranca.OcorreuPagamento = false;
							ocorrenciaCobranca.ValorPago = 0.0;
							break;
						}
						arrayList.Add(ocorrenciaCobranca);
					}
					return arrayList;
				}
				return arrayList;
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return arrayList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCarregandoArquivoRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}

	private ArrayList CarregarMotivosOcorrencia(string codigoRejeicao)
	{
		ArrayList arrayList = new ArrayList();
		string text = EnumUtil.ObterDescricaoPeloCodigoEChave<EnumCodigoRejeicaoRetorno>(codigoRejeicao, new AtributoChave(EnumChaveContexto.BAN422_CNAB400));
		if (!string.IsNullOrEmpty(text))
		{
			MotivoOcorrenciaCobranca motivoOcorrenciaCobranca = new MotivoOcorrenciaCobranca();
			motivoOcorrenciaCobranca.Codigo = codigoRejeicao;
			motivoOcorrenciaCobranca.Descricao = text;
			arrayList.Add(motivoOcorrenciaCobranca);
		}
		return arrayList;
	}
}
