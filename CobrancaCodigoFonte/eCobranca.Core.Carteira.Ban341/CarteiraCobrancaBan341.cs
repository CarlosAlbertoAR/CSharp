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
using eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Retorno;
using eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Parametros.Ban341;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public abstract class CarteiraCobrancaBan341 : CarteiraCobranca, ISerializable
{
	public CarteiraCobrancaBan341(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341(SerializationInfo serobj, StreamingContext scontext)
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
			Logger.Debug($"Criando configuração inicial de boleto do [{EnumCodigoBanco.BANCO_ITAU}]...");
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
			result = new ConfiguracaoBoleto(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this, "SAC Itaú: 0800 728 0728 (gratuito, qualquer localidade) ou 0800 722 1722 (deficientes auditivos ou de fala). Ouvidoria Itaú: 0800 570 0011 (dias úties, das 9h às 18h)", "341-7", GetCodigoCarteiraImpressao());
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

	protected override ConfiguracaoImpressao CarregarConfiguracaoImpressao()
	{
		ConfiguracaoImpressao result = null;
		try
		{
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			result = new ConfiguracaoImpressao(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			result = new ConfiguracaoEmail(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de documentos de cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			result = new ConfiguracaoDocumentoCobranca(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this);
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

	protected override ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa()
	{
		ConfiguracaoArquivoRemessa configuracaoArquivoRemessa = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.BANCO_ITAU}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this, 0, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada);
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
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_ITAU);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban341)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_ITAU);
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban341(this);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban341();
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_ITAU}]");
			result = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_ITAU.ToString(), base.ModoUso, this);
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
		return (ArquivoCobrancaRetornoFebraban240)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_ITAU);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban341)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_ITAU);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban341(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban341();
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return null;
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_ITAU}]...");
				remessaFebraban240.Preparar(this);
				remessaFebraban240.NovoLote(dcList);
				(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban341).Preparar(this, remessaFebraban240);
				comandoGerarRemessaFebraban240.Execute();
				result = remessaFebraban240.GerarArquivoRemessa();
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoArquivoRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GerarArquivoRemessaCNAB400(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.BANCO_ITAU}]...");
			remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
			remessaCnab400.CriarLote(dcList);
			(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban341).Preparar(this, remessaCnab400);
			comandoGerarRemessaCnab400.Execute();
			result = remessaCnab400.GerarArquivoRemessa();
			return result;
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
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban341).Preparar(this, retornoFebraban240);
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
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban341).Preparar(this, retornoCnab400);
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
				stringBuilder.Append("-");
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

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "0000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "00000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoFlash", "Código Flash", "Código Flash", "AAA");
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

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[5]).Mascara;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[3]).Valor;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[4]).Valor;
			valor = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor2, valor3, mascara) : StringUtil.IncrementString(valor, valor2, valor3, mascara));
			if (string.IsNullOrEmpty(valor))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor3);
			}
			((DadoConfiguracao)base.DadosConfiguracao[5]).Valor = valor;
			result = valor;
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

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return CalcularDVNossoNumero(nossoNumero);
	}

	protected override string CalcularDVNossoNumero(string nossoNumeroSemDV)
	{
		string text = "";
		try
		{
			return DVGenerator.GetDVModulo10(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + nossoNumeroSemDV);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculadoDVNossoNumeroDocumentoCobranca(nossoNumeroSemDV, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(text);
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + DVGenerator.GetDVModulo10(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1)) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + DVGenerator.GetDVModulo10(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1)) + StringUtil.ZerosLeft("", 3);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCampoLivre(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GerarNomeArquivoRemessa()
	{
		string text = base.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
		text = ((text.Length > 5) ? StringUtil.ZerosLeft("1", 5) : StringUtil.ZerosLeft(text, 5));
		base.ConfiguracaoArquivoRemessa.SequenciaRemessa = Convert.ToInt32(text) + 1;
		return "REM" + text + ".TXT";
	}

	protected override string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = EnumCodigoBanco.BANCO_ITAU.Codigo() + "9" + configuracaoCarteiraCobranca.CodigoCarteiraCobranca + dc.NossoNumero.Substring(0, 2);
			string text2 = text + DVGenerator.GetDVModulo10(text);
			text2 = text2.Insert(5, ".");
			string text3 = dc.NossoNumero.Substring(2, 6) + dc.NossoNumero.Substring(dc.NossoNumero.Length - 1) + ((DadoConfiguracao)base.DadosConfiguracao[0]).Valor.Substring(0, 3);
			string text4 = text3 + DVGenerator.GetDVModulo10(text3);
			text4 = text4.Insert(5, ".");
			string text5 = ((DadoConfiguracao)base.DadosConfiguracao[0]).Valor.Substring(3, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 2) + StringUtil.ZerosLeft("", 3);
			string text6 = text5 + DVGenerator.GetDVModulo10(text5);
			text6 = text6.Insert(5, ".");
			string text7 = dc.CodigoBarras.Substring(4, 1);
			string text8 = GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10);
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

	public override ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis()
	{
		return new ParametrosAdicionaisDisponiveisBan341();
	}

	public override string GetMascaraNossoNumero()
	{
		return "00000000-0";
	}

	protected override string GetInicioSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[3]).Valor;
	}

	protected override string GetFimSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[4]).Valor;
	}

	protected override string GetSequenciaAtualNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan341();
	}
}
