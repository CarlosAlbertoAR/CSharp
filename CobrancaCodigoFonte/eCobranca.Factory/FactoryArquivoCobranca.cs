using System;
using System.Diagnostics;
using eCobranca.Core.Automacao;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactoryArquivoCobranca
{
	public static ArquivoCobranca CriarArquivoRemessa(Guid guid, EnumLayoutArquivoRemessa tipoLayoutRemessa, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
	{
		ArquivoCobranca result = null;
		try
		{
			Logger.Debug($"Obtendo instância de arquivo de cobrança de remessa no layout [{tipoLayoutRemessa.ToString()}]");
			switch (tipoLayoutRemessa)
			{
			case EnumLayoutArquivoRemessa.FEBRABAN240:
				result = new ArquivoCobrancaRemessaFebraban240(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRemessa.CNAB400:
				result = GetRemessaCnab400(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRemessa.CBR641:
				result = GetRemessaCnab400(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRemessa.FEBRABAN150:
				throw ExcecaoECobranca.CarteiraCobranca.RemesssaFebraban150NaoImplementadoParaCarteira();
			default:
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.LayoutRemessaAindaNaoImplementado(tipoLayoutRemessa.ToString()), new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoArquivoCobrancaDeRemessa(tipoLayoutRemessa.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static ArquivoCobranca CriarArquivoRetorno(Guid guid, EnumLayoutArquivoRetorno tipoLayoutRetorno, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
	{
		ArquivoCobranca result = null;
		try
		{
			Logger.Debug($"Obtendo instância de arquivo de cobrança de retorno no layout [{tipoLayoutRetorno.ToString()}]");
			switch (tipoLayoutRetorno)
			{
			case EnumLayoutArquivoRetorno.FEBRABAN240:
				result = GetRetornoFebraban240(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRetorno.CNAB400:
				result = GetRetornoCnab400(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRetorno.CBR643:
				result = GetRetornoCnab400(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumLayoutArquivoRetorno.FEBRABAN150:
				result = new ArquivoCobrancaRetornoFebraban150(guid, tipoCarteiraCobranca, banco);
				return result;
			default:
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.LayoutRetornoAindaNaoImplementado(tipoLayoutRetorno.ToString()), new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoArquivoCobrancaDeRetorno(tipoLayoutRetorno.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static ArquivoCobranca GetRemessaCnab400(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
	{
		ArquivoCobranca result = null;
		try
		{
			switch (banco)
			{
			case EnumCodigoBanco.BANCO_DO_BRASIL:
				result = new ArquivoCobrancaRemessaCnab400Ban001(guid, new HeaderRemessaCnab400Ban001(1L), new TraillerRemessaCnab400Ban001(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL:
				result = new ArquivoCobrancaRemessaCnab400Ban004(guid, new HeaderRemessaCnab400Ban004(1L), new TraillerRemessaCnab400Ban004(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO:
				result = new ArquivoCobrancaRemessaCnab400Ban021(guid, new HeaderRemessaCnab400Ban021(1L), new TraillerRemessaCnab400Ban021(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_SANTANDER:
				result = new ArquivoCobrancaRemessaCnab400Ban033(guid, new HeaderRemessaCnab400Ban033(1L), new TraillerRemessaCnab400Ban033(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL:
				result = new ArquivoCobrancaRemessaCnab400Ban041(guid, new HeaderRemessaCnab400Ban041(1L), new TraillerRemessaCnab400Ban041(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.UNIPRIME_NORTE_PARANA:
				result = new ArquivoCobrancaRemessaCnab400Ban084(guid, new HeaderRemessaCnab400Ban084(1L), new TraillerRemessaCnab400Ban084(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO:
				if (tipoCarteiraCobranca == EnumTipoCarteiraCobranca.BAN097_CODIGO_18)
				{
					result = new ArquivoCobrancaRemessaCnab400Ban097(guid, new HeaderRemessaCnab400Ban097(1L), new TraillerRemessaCnab400Ban097(0L, guid), tipoCarteiraCobranca);
					return result;
				}
				result = new ArquivoCobrancaRemessaCnab400Ban097CobrancaSimples(guid, new HeaderRemessaCnab400Ban097CobrancaSimples(1L), new TraillerRemessaCnab400Ban097(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED:
				result = new ArquivoCobrancaRemessaCnab400Ban099(guid, new HeaderRemessaCnab400Ban099(1L), new TraillerRemessaCnab400Ban099(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL:
				result = new ArquivoCobrancaRemessaCnab400Ban104(guid, new HeaderRemessaCnab400Ban104(1L), new TraillerRemessaCnab400Ban104(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.CRESOL:
				result = new ArquivoCobrancaRemessaCnab400Ban133(guid, new HeaderRemessaCnab400Ban133(1L), new TraillerRemessaCnab400Ban133(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.UNICRED:
				result = new ArquivoCobrancaRemessaCnab400Ban136(guid, new HeaderRemessaCnab400Ban136(1L), new TraillerRemessaCnab400Ban136(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_BRADESCO:
				result = new ArquivoCobrancaRemessaCnab400Ban237(guid, new HeaderRemessaCnab400Ban237(1L), new TraillerRemessaCnab400Ban237(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_ITAU:
				result = new ArquivoCobrancaRemessaCnab400Ban341(guid, new HeaderRemessaCnab400Ban341(1L), new TraillerRemessaCnab400Ban341(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.HSBC_BANK_BRASIL:
				result = new ArquivoCobrancaRemessaCnab400Ban399(guid, new HeaderRemessaCnab400Ban399(1L), new TraillerRemessaCnab400Ban399(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_SAFRA:
				result = new ArquivoCobrancaRemessaCnab400Ban422(guid, new HeaderRemessaCnab400Ban422(1L), new TraillerRemessaCnab400Ban422(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI:
				result = new ArquivoCobrancaRemessaCnab400Ban748(guid, new HeaderRemessaCnab400Ban748(1L), new TraillerRemessaCnab400Ban748(0L, guid), tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL:
				result = new ArquivoCobrancaRemessaCnab400Ban756(guid, new HeaderRemessaCnab400Ban756(1L), new TraillerRemessaCnab400Ban756(0L, guid), tipoCarteiraCobranca);
				return result;
			default:
				return result;
			case EnumCodigoBanco.BANCO_DA_AMAZONIA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_PERNAMBUCO:
			case EnumCodigoBanco.BANCO_ALFA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SANTA_CATARINA:
			case EnumCodigoBanco.BANCO_BVA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SERGIPE:
			case EnumCodigoBanco.BPN_BRASIL_BANCO_MULTIPLO:
			case EnumCodigoBanco.BANCO_DE_BRASILIA:
			case EnumCodigoBanco.BANCO_J_SAFRA:
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS:
			case EnumCodigoBanco.BANCO_BBM:
			case EnumCodigoBanco.BANCO_FIBRA:
			case EnumCodigoBanco.BANCO_ABC_BRASIL:
			case EnumCodigoBanco.BANCO_CACIQUE:
			case EnumCodigoBanco.BANCO_CEDULA:
			case EnumCodigoBanco.BANCO_INDL_E_COML_BICBANCO:
			case EnumCodigoBanco.BANCO_ABN_AMRO:
			case EnumCodigoBanco.BANCO_MERCANTIL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_BMC:
			case EnumCodigoBanco.BANCO_RURAL:
			case EnumCodigoBanco.BANCO_LUSO_BRASILEIRO:
			case EnumCodigoBanco.BANCO_INDUSTRIAL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_PAULISTA:
			case EnumCodigoBanco.BANCO_PANAMERICANO:
			case EnumCodigoBanco.BANCO_INTERCAP:
			case EnumCodigoBanco.BANCO_RENDIMENTO:
			case EnumCodigoBanco.BANCO_TRIBANCO:
			case EnumCodigoBanco.BANCO_SOFISA:
			case EnumCodigoBanco.BANCO_PINE:
			case EnumCodigoBanco.BANCO_INDUSVAL:
			case EnumCodigoBanco.BANCO_VOTORANTIM:
			case EnumCodigoBanco.BANCO_DAYCOVAL:
			case EnumCodigoBanco.BANCO_BANIF_PRIMUS:
			case EnumCodigoBanco.BANCO_CREDIBEL:
			case EnumCodigoBanco.BANCO_GERDAU:
			case EnumCodigoBanco.BANCO_MORADA:
			case EnumCodigoBanco.BANCO_GALVAO_DE_NEGOCIOS:
			case EnumCodigoBanco.BANCO_RIBEIRAO_PRETO:
			case EnumCodigoBanco.BANCO_CITIBANK:
			case EnumCodigoBanco.BR_BANCO_MERCANTIL:
			case EnumCodigoBanco.NBC_BANK_BRASIL_BANCO_MULTIPLO:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA:
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoArquivoCobrancaDeRemessa(EnumLayoutArquivoRemessa.CNAB400.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static ArquivoCobranca GetRetornoCnab400(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
	{
		ArquivoCobranca result = null;
		try
		{
			switch (banco)
			{
			case EnumCodigoBanco.BANCO_DO_BRASIL:
				result = new ArquivoCobrancaRetornoCnab400Ban001(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL:
				result = new ArquivoCobrancaRetornoCnab400Ban004(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO:
				result = new ArquivoCobrancaRetornoCnab400Ban021(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL:
				result = new ArquivoCobrancaRetornoCnab400Ban041(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.UNIPRIME_NORTE_PARANA:
				result = new ArquivoCobrancaRetornoCnab400Ban084(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO:
				if (tipoCarteiraCobranca == EnumTipoCarteiraCobranca.BAN097_CODIGO_18)
				{
					result = new ArquivoCobrancaRetornoCnab400Ban097(guid, tipoCarteiraCobranca);
					return result;
				}
				result = new ArquivoCobrancaRetornoCnab400Ban097CobrancaSimples(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED:
				result = new ArquivoCobrancaRetornoCnab400Ban099(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL:
				result = new ArquivoCobrancaRetornoCnab400Ban104(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.CRESOL:
				result = new ArquivoCobrancaRetornoCnab400Ban133(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.UNICRED:
				result = new ArquivoCobrancaRetornoCnab400Ban136(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_BRADESCO:
				result = new ArquivoCobrancaRetornoCnab400Ban237(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_ITAU:
				result = new ArquivoCobrancaRetornoCnab400Ban341(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.HSBC_BANK_BRASIL:
				result = new ArquivoCobrancaRetornoCnab400Ban399(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_SAFRA:
				result = new ArquivoCobrancaRetornoCnab400Ban422(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI:
				result = new ArquivoCobrancaRetornoCnab400Ban748(guid, tipoCarteiraCobranca);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL:
				result = new ArquivoCobrancaRetornoCnab400Ban756(guid, tipoCarteiraCobranca);
				return result;
			default:
				return result;
			case EnumCodigoBanco.BANCO_DA_AMAZONIA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_PERNAMBUCO:
			case EnumCodigoBanco.BANCO_ALFA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SANTA_CATARINA:
			case EnumCodigoBanco.BANCO_SANTANDER:
			case EnumCodigoBanco.BANCO_BVA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SERGIPE:
			case EnumCodigoBanco.BPN_BRASIL_BANCO_MULTIPLO:
			case EnumCodigoBanco.BANCO_DE_BRASILIA:
			case EnumCodigoBanco.BANCO_J_SAFRA:
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS:
			case EnumCodigoBanco.BANCO_BBM:
			case EnumCodigoBanco.BANCO_FIBRA:
			case EnumCodigoBanco.BANCO_ABC_BRASIL:
			case EnumCodigoBanco.BANCO_CACIQUE:
			case EnumCodigoBanco.BANCO_CEDULA:
			case EnumCodigoBanco.BANCO_INDL_E_COML_BICBANCO:
			case EnumCodigoBanco.BANCO_ABN_AMRO:
			case EnumCodigoBanco.BANCO_MERCANTIL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_BMC:
			case EnumCodigoBanco.BANCO_RURAL:
			case EnumCodigoBanco.BANCO_LUSO_BRASILEIRO:
			case EnumCodigoBanco.BANCO_INDUSTRIAL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_PAULISTA:
			case EnumCodigoBanco.BANCO_PANAMERICANO:
			case EnumCodigoBanco.BANCO_INTERCAP:
			case EnumCodigoBanco.BANCO_RENDIMENTO:
			case EnumCodigoBanco.BANCO_TRIBANCO:
			case EnumCodigoBanco.BANCO_SOFISA:
			case EnumCodigoBanco.BANCO_PINE:
			case EnumCodigoBanco.BANCO_INDUSVAL:
			case EnumCodigoBanco.BANCO_VOTORANTIM:
			case EnumCodigoBanco.BANCO_DAYCOVAL:
			case EnumCodigoBanco.BANCO_BANIF_PRIMUS:
			case EnumCodigoBanco.BANCO_CREDIBEL:
			case EnumCodigoBanco.BANCO_GERDAU:
			case EnumCodigoBanco.BANCO_MORADA:
			case EnumCodigoBanco.BANCO_GALVAO_DE_NEGOCIOS:
			case EnumCodigoBanco.BANCO_RIBEIRAO_PRETO:
			case EnumCodigoBanco.BANCO_CITIBANK:
			case EnumCodigoBanco.BR_BANCO_MERCANTIL:
			case EnumCodigoBanco.NBC_BANK_BRASIL_BANCO_MULTIPLO:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA:
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoArquivoCobrancaDeRetorno(EnumLayoutArquivoRetorno.CNAB400.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static ArquivoCobranca GetRetornoFebraban240(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
	{
		ArquivoCobranca result = null;
		try
		{
			switch (banco)
			{
			case EnumCodigoBanco.BANCO_DO_BRASIL:
				result = new ArquivoCobrancaRetornoFebraban240Ban001(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_DA_AMAZONIA:
				result = new ArquivoCobrancaRetornoFebraban240Ban003(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_SANTANDER:
				result = new ArquivoCobrancaRetornoFebraban240Ban033(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA:
				result = new ArquivoCobrancaRetornoFebraban240Ban037(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL:
				result = new ArquivoCobrancaRetornoFebraban240Ban041(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS:
				result = new ArquivoCobrancaRetornoFebraban240Ban085(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO:
				result = new ArquivoCobrancaRetornoFebraban240Ban097(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL:
				result = new ArquivoCobrancaRetornoFebraban240Ban104(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_BRADESCO:
				result = new ArquivoCobrancaRetornoFebraban240Ban237(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_ITAU:
				result = new ArquivoCobrancaRetornoFebraban240Ban341(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.HSBC_BANK_BRASIL:
				result = new ArquivoCobrancaRetornoFebraban240Ban399(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_SAFRA:
				result = new ArquivoCobrancaRetornoFebraban240Ban422(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI:
				result = new ArquivoCobrancaRetornoFebraban240Ban748(guid, tipoCarteiraCobranca, banco);
				return result;
			case EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL:
				if (tipoCarteiraCobranca == EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL)
				{
					result = new ArquivoCobrancaRetornoFebraban240Ban756CorrespondenteBancoBrasil(guid, tipoCarteiraCobranca, banco);
					return result;
				}
				result = new ArquivoCobrancaRetornoFebraban240Ban756(guid, tipoCarteiraCobranca, banco);
				return result;
			default:
				return result;
			case EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_PERNAMBUCO:
			case EnumCodigoBanco.BANCO_ALFA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SANTA_CATARINA:
			case EnumCodigoBanco.BANCO_BVA:
			case EnumCodigoBanco.BANCO_DO_ESTADO_DE_SERGIPE:
			case EnumCodigoBanco.BPN_BRASIL_BANCO_MULTIPLO:
			case EnumCodigoBanco.BANCO_DE_BRASILIA:
			case EnumCodigoBanco.BANCO_J_SAFRA:
			case EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED:
			case EnumCodigoBanco.BANCO_BBM:
			case EnumCodigoBanco.BANCO_FIBRA:
			case EnumCodigoBanco.BANCO_ABC_BRASIL:
			case EnumCodigoBanco.BANCO_CACIQUE:
			case EnumCodigoBanco.BANCO_CEDULA:
			case EnumCodigoBanco.BANCO_INDL_E_COML_BICBANCO:
			case EnumCodigoBanco.BANCO_ABN_AMRO:
			case EnumCodigoBanco.BANCO_MERCANTIL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_BMC:
			case EnumCodigoBanco.BANCO_RURAL:
			case EnumCodigoBanco.BANCO_LUSO_BRASILEIRO:
			case EnumCodigoBanco.BANCO_INDUSTRIAL_DO_BRASIL:
			case EnumCodigoBanco.BANCO_PAULISTA:
			case EnumCodigoBanco.BANCO_PANAMERICANO:
			case EnumCodigoBanco.BANCO_INTERCAP:
			case EnumCodigoBanco.BANCO_RENDIMENTO:
			case EnumCodigoBanco.BANCO_TRIBANCO:
			case EnumCodigoBanco.BANCO_SOFISA:
			case EnumCodigoBanco.BANCO_PINE:
			case EnumCodigoBanco.BANCO_INDUSVAL:
			case EnumCodigoBanco.BANCO_VOTORANTIM:
			case EnumCodigoBanco.BANCO_DAYCOVAL:
			case EnumCodigoBanco.BANCO_BANIF_PRIMUS:
			case EnumCodigoBanco.BANCO_CREDIBEL:
			case EnumCodigoBanco.BANCO_GERDAU:
			case EnumCodigoBanco.BANCO_MORADA:
			case EnumCodigoBanco.BANCO_GALVAO_DE_NEGOCIOS:
			case EnumCodigoBanco.BANCO_RIBEIRAO_PRETO:
			case EnumCodigoBanco.BANCO_CITIBANK:
			case EnumCodigoBanco.BR_BANCO_MERCANTIL:
			case EnumCodigoBanco.NBC_BANK_BRASIL_BANCO_MULTIPLO:
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoArquivoCobrancaDeRetorno(EnumLayoutArquivoRetorno.FEBRABAN240.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
