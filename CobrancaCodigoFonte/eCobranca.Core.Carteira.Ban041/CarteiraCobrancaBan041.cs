using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Retorno;
using eCobranca.Core.Carteira.Ban041.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban041.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Parametros.Ban041;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041;

[Serializable]
public abstract class CarteiraCobrancaBan041 : CarteiraCobranca, ISerializable
{
	public CarteiraCobrancaBan041(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan041(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override FactorySegmentoFebraban240 CarregarFabricaSegmentoFebraban240()
	{
		return new FactorySegmentoFebraban240Padrao();
	}

	protected override ConfiguracaoBoleto CarregarConfiguracaoBoleto()
	{
		ConfiguracaoBoleto result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de boleto do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			ArrayList names = EnumUtil.GetNames(typeof(EnumTipoModeloBoleto));
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < names.Count; i++)
			{
				EnumTipoModeloBoleto tipoModelo = (EnumTipoModeloBoleto)Enum.Parse(typeof(EnumTipoModeloBoleto), names[i].ToString().ToUpper());
				if (!tipoModelo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO))
				{
					ModeloBoleto modelo = base.FactoryModeloBoleto.GetModelo(tipoModelo, this);
					if (modelo != null)
					{
						arrayList.Add(modelo);
					}
				}
			}
			result = new ConfiguracaoBoleto(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this, "SAC BANRISUL – 0800 646 1515 Ouvidoria Santander: 0800 644 2200 (dias úteis, das 9h às 18h)", "041-8", GetCodigoCarteiraImpressao());
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa()
	{
		ConfiguracaoArquivoRemessa configuracaoArquivoRemessa = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this, 0, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada);
			configuracaoArquivoRemessa.DiretorioArquivoRemessa = "C:\\eCobranca\\Remessas\\";
			configuracaoArquivoRemessa.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.FEBRABAN240.ToString();
			configuracaoArquivoRemessa.SequenciaLote = 1;
			configuracaoArquivoRemessa.CodigoMovimentoRemessaPadrao = ((ItemLista)configuracaoArquivoRemessa.CodigosMovimentoRemessa[0]).Valor;
			return configuracaoArquivoRemessa;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return configuracaoArquivoRemessa;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			return configuracaoArquivoRemessa;
		}
	}

	protected override ArquivoCobrancaRemessaFebraban240 CarregarArquivoRemessaFebraban240()
	{
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban041)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL);
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban041(this);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban041();
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]");
			result = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ArquivoCobrancaRetornoFebraban240 CarregarArquivoRetornoFebraban240()
	{
		return (ArquivoCobrancaRetornoFebraban240)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban041)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban041(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban041();
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return null;
	}

	protected override ConfiguracaoImpressao CarregarConfiguracaoImpressao()
	{
		ConfiguracaoImpressao result = null;
		try
		{
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			result = new ConfiguracaoImpressao(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoImpressao(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ConfiguracaoEmail CarregarConfiguracaoEmail()
	{
		ConfiguracaoEmail result = null;
		try
		{
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			result = new ConfiguracaoEmail(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoImpressao(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ConfiguracaoDocumentoCobranca CarregarConfiguracaoDocumentoCobranca()
	{
		ConfiguracaoDocumentoCobranca result = null;
		try
		{
			Logger.Debug($"Carregando configuração de documentos de cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			result = new ConfiguracaoDocumentoCobrancaBan041(GetGuid(), EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.ToString(), base.ModoUso, this);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoDocumentoCobranca(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoArquivoRemessa.DataUltimaRemessa == DateTime.Today && base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria >= base.ConfiguracaoArquivoRemessa.LimiteRemessasDiaria)
			{
				throw ExcecaoECobranca.Remessa.LimiteArquivosRemessaAtingido(base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria);
			}
			Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			remessaFebraban240.Preparar(this);
			remessaFebraban240.NovoLote(dcList);
			(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban041).Preparar(this, remessaFebraban240);
			comandoGerarRemessaFebraban240.Execute();
			result = remessaFebraban240.GerarArquivoRemessa();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoArquivoRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GerarArquivoRemessaCNAB400(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
				remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
				remessaCnab400.CriarLote(dcList);
				(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban041).Preparar(this, remessaCnab400);
				comandoGerarRemessaCnab400.Execute();
				result = remessaCnab400.GerarArquivoRemessa();
				return result;
			}
			throw ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoArquivoRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		return string.Empty;
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban041).Preparar(this, retornoFebraban240);
			comandoProcessarRetornoFebraban240.Execute();
			result = retornoFebraban240.CarregarArquivoRetornoFebraban240();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoArquivoRetornoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ArrayList CarregarArquivoRetornoCnab400(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban041).Preparar(this, retornoCnab400);
			comandoProcessarRetornoCnab400.Execute();
			result = retornoCnab400.CarregarArquivoRetornoCnab400();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoArquivoRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		return new ArrayList();
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan041();
	}

	protected override string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = base.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + "9" + dc.CodigoBarras.Substring(19, 1) + dc.CodigoBarras.Substring(20, 1) + dc.CodigoBarras.Substring(21, 3);
			string text2 = text + CalcularDVLinhaDigitavel(text);
			text2 = text2.Insert(5, ".");
			string text3 = dc.CodigoBarras.Substring(24, 1) + dc.CodigoBarras.Substring(25, 7) + dc.CodigoBarras.Substring(32, 2);
			string text4 = text3 + CalcularDVLinhaDigitavel(text3);
			text4 = text4.Insert(5, ".");
			string text5 = dc.CodigoBarras.Substring(34, 6) + "40" + dc.CodigoBarras.Substring(42, 2);
			string text6 = text5 + CalcularDVLinhaDigitavel(text5);
			text6 = text6.Insert(5, ".");
			string text7 = dc.CodigoBarras.Substring(4, 1);
			string text8 = "";
			text8 = ((!base.ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO)) ? (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10)) : (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(1.0, 10)));
			result = text2 + " " + text4 + " " + text6 + " " + text7 + " " + text8;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoLinhaDigitavel(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			stringBuilder.Clear();
			if (base.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				stringBuilder.Append("1");
			}
			else
			{
				stringBuilder.Append("2");
			}
			stringBuilder.Append("1");
			stringBuilder.Append(StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[0] as DadoConfiguracao).Valor, 1));
			stringBuilder.Append(StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[1] as DadoConfiguracao).Valor, 1));
			stringBuilder.Append(StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[1] as DadoConfiguracao).Valor, 2));
			stringBuilder.Append(StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1));
			stringBuilder.Append("40");
			int num = 0;
			int num2 = 0;
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append(stringBuilder.ToString());
			int num3 = 2;
			int num4 = 2;
			int num5 = 1;
			int num6 = 0;
			for (int num7 = stringBuilder2.Length - 1; num7 >= 0; num7--)
			{
				int num8 = Convert.ToInt32(stringBuilder2[num7].ToString()) * num3;
				if (num8 > 9)
				{
					num8 -= 9;
				}
				num6 += num8;
				num3 = ((num3 != num4) ? (num3 + 1) : num5);
			}
			int num9 = num6 % 10;
			num = 10 - num9;
			bool flag = true;
			while (flag)
			{
				if (num == 10)
				{
					num = 0;
				}
				stringBuilder2.Clear();
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder2.Append(num);
				num3 = 2;
				num4 = 7;
				num5 = 2;
				num6 = 0;
				for (int num10 = stringBuilder2.Length - 1; num10 >= 0; num10--)
				{
					int num11 = Convert.ToInt32(stringBuilder2[num10].ToString());
					num6 += num11 * num3;
					num3 = ((num3 != num4) ? (num3 + 1) : num5);
				}
				num9 = ((num6 >= 11) ? (num6 % 11) : num6);
				if (num9 != 1)
				{
					flag = false;
				}
				else
				{
					num++;
				}
			}
			num2 = 11 - num9;
			stringBuilder.Append(num.ToString());
			stringBuilder.Append(num2.ToString());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCampoLivre(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return stringBuilder.ToString();
	}

	protected override string GerarNossoNumeroCompleto(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug($"Obtendo nosso número completo para o documento [{dc.NumeroDocumento}]");
			string nossoNumeroSemDV = GetNossoNumeroSemDV(dc);
			string text = "";
			if (dc.CalculaDacNossoNumero)
			{
				text = GetDVNossoNumero(nossoNumeroSemDV);
			}
			stringBuilder.Append(nossoNumeroSemDV);
			if (text != "")
			{
				stringBuilder.Append(".");
				stringBuilder.Append(text);
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroCompletoDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		dc.NossoNumeroSemMascara = StringUtil.RemoverMascara(stringBuilder.ToString());
		return stringBuilder.ToString();
	}

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			DateTime.Today.Year.ToString().Substring(2, 2);
			string mascara = (base.DadosConfiguracao[6] as DadoConfiguracao).Mascara;
			string valor = (base.DadosConfiguracao[4] as DadoConfiguracao).Valor;
			string valor2 = (base.DadosConfiguracao[5] as DadoConfiguracao).Valor;
			string valor3 = (base.DadosConfiguracao[6] as DadoConfiguracao).Valor;
			valor3 = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor, valor2, mascara) : StringUtil.IncrementString(valor3, valor, valor2, mascara));
			if (string.IsNullOrEmpty(valor3))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor2);
			}
			(base.DadosConfiguracao[6] as DadoConfiguracao).Valor = valor3;
			result = valor3;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroSemDV(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string CalcularDVNossoNumero(string nossoNumeroSemDV)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			stringBuilder.Append(nossoNumeroSemDV);
			Logger.Debug($"Gerando DV para o nosso número [{stringBuilder.ToString()}]");
			int num3 = 2;
			int num4 = 2;
			int num5 = 1;
			int num6 = 0;
			for (int num7 = stringBuilder.Length - 1; num7 >= 0; num7--)
			{
				int num8 = Convert.ToInt32(stringBuilder[num7].ToString()) * num3;
				if (num8 > 9)
				{
					num8 -= 9;
				}
				num6 += num8;
				num3 = ((num3 != num4) ? (num3 + 1) : num5);
			}
			int num9 = num6 % 10;
			num = 10 - num9;
			stringBuilder.Append(num.ToString());
			bool flag = true;
			while (flag)
			{
				stringBuilder.Clear();
				stringBuilder.Append(nossoNumeroSemDV);
				stringBuilder.Append(num);
				num3 = 2;
				num4 = 7;
				num5 = 2;
				num6 = 0;
				for (int num10 = stringBuilder.Length - 1; num10 >= 0; num10--)
				{
					int num11 = Convert.ToInt32(stringBuilder[num10].ToString());
					num6 += num11 * num3;
					num3 = ((num3 != num4) ? (num3 + 1) : num5);
				}
				num9 = ((num6 >= 11) ? (num6 % 11) : num6);
				if (num9 != 1)
				{
					flag = false;
				}
				else
				{
					num++;
				}
			}
			num2 = 11 - num9;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculadoDVNossoNumeroDocumentoCobranca(stringBuilder.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num.ToString() + num2);
	}

	public override ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis()
	{
		return new ParametrosAdicionaisDisponiveisBan041();
	}

	protected override string GerarNomeArquivoRemessa()
	{
		long sequenciaRemessa = base.ConfiguracaoArquivoRemessa.SequenciaRemessa;
		string text = ((sequenciaRemessa.ToString().Length > 8) ? StringUtil.ZerosLeft("1", 8) : StringUtil.ZerosLeft(sequenciaRemessa.ToString(), 8));
		base.ConfiguracaoArquivoRemessa.SequenciaRemessa = Convert.ToInt32(text) + 1;
		string text2 = "";
		if ((EnumLayoutArquivoRemessa)(object)base.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>() == EnumLayoutArquivoRemessa.FEBRABAN240)
		{
			return "REM" + text + ".240";
		}
		return "REM" + text + ".400";
	}

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return CalcularDVNossoNumero(nossoNumero);
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código agência beneficiária", "Agência", "0000.00");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "Código do beneficiário", "Código do beneficiário", "000000.0.00");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("TipoCobranca", "Tipo de cobrança", "Tipo de cobrança", "00");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "00000000");
		value.Valor = "00000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "00000000");
		value.Valor = "99999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "00000000");
		value.Valor = "00000000";
		base.DadosConfiguracao.Add(value);
	}

	public override string GetMascaraNossoNumero()
	{
		return "00000000.00";
	}

	protected override string GetInicioSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[4]).Valor;
	}

	protected override string GetFimSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
	}

	protected override string GetSequenciaAtualNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor;
	}
}
