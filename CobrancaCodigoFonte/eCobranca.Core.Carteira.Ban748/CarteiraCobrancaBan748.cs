using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Atributos;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Retorno;
using eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Parametros.Ban748;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748;

[Serializable]
public abstract class CarteiraCobrancaBan748 : CarteiraCobranca, ISerializable
{
	public CarteiraCobrancaBan748(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan748(SerializationInfo serobj, StreamingContext scontext)
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
			Logger.Debug($"Criando configuração inicial de boleto do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
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
			result = new ConfiguracaoBoleto(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this, "SAC Sicredi: 0800 724 7220 (Informações, elogios e reclamações) ou 0800 724 0525 (deficientes auditivos ou de fala). Ouvidoria Sicredi: 0800 646 2519 (dias úteis, das 8h às 18h)", "748-X", GetCodigoCarteiraImpressao());
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
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this, 10, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada);
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
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban748)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI);
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban748(this);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban748();
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]");
			result = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this);
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
		return (ArquivoCobrancaRetornoFebraban240)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban748)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban748(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban748();
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			result = new ConfiguracaoImpressao(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			result = new ConfiguracaoEmail(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			result = new ConfiguracaoDocumentoCobranca(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			remessaFebraban240.Preparar(this);
			remessaFebraban240.NovoLote(dcList);
			(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban748).Preparar(this, remessaFebraban240);
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
				Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
				remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
				remessaCnab400.CriarLote(dcList);
				(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban748).Preparar(this, remessaCnab400);
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
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban748).Preparar(this, retornoFebraban240);
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
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban748).Preparar(this, retornoCnab400);
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

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			string text = DateTime.Today.Year.ToString().Substring(2, 2);
			string valor = (base.DadosConfiguracao[3] as DadoConfiguracao).Valor;
			string mascara = (base.DadosConfiguracao[7] as DadoConfiguracao).Mascara;
			string valor2 = (base.DadosConfiguracao[5] as DadoConfiguracao).Valor;
			string valor3 = (base.DadosConfiguracao[6] as DadoConfiguracao).Valor;
			string valor4 = (base.DadosConfiguracao[7] as DadoConfiguracao).Valor;
			valor4 = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor2, valor3, mascara) : StringUtil.IncrementString(valor4, valor2, valor3, mascara));
			if (string.IsNullOrEmpty(valor4))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor3);
			}
			(base.DadosConfiguracao[7] as DadoConfiguracao).Valor = valor4;
			result = text + valor + valor4;
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
		string text = "";
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			string value = StringUtil.RemoverMascara((base.DadosConfiguracao[0] as DadoConfiguracao).Valor);
			string value2 = StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor);
			string value3 = DateTime.Today.Year.ToString().Substring(2, 2);
			string value4 = StringUtil.RemoverMascara((base.DadosConfiguracao[3] as DadoConfiguracao).Valor);
			string value5 = StringUtil.RemoverMascara(nossoNumeroSemDV.Substring(nossoNumeroSemDV.Length - 5, 5));
			stringBuilder.Append(value);
			stringBuilder.Append(value2);
			stringBuilder.Append(value3);
			stringBuilder.Append(value4);
			stringBuilder.Append(value5);
			Logger.Debug($"Gerando DV para o nosso número [{stringBuilder.ToString()}]");
			int num = 2;
			int num2 = 9;
			int num3 = 2;
			int num4 = 0;
			for (int num5 = stringBuilder.Length - 1; num5 >= 0; num5--)
			{
				int num6 = Convert.ToInt32(stringBuilder[num5].ToString());
				num4 += num6 * num;
				num = ((num != num2) ? (num + 1) : num3);
			}
			int num7 = num4 % 11;
			if (num7 == 0)
			{
				text = "0";
			}
			else
			{
				int num8 = 11 - num7;
				text = ((num8 <= 9) ? num8.ToString() : "0");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculadoDVNossoNumeroDocumentoCobranca(stringBuilder.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(text);
	}

	public override ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis()
	{
		return new ParametrosAdicionaisDisponiveisBan748();
	}

	protected override string GerarNomeArquivoRemessa()
	{
		string value = StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor);
		int month = DateTime.Today.Month;
		string value2 = ((month <= 9) ? month.ToString() : (month switch
		{
			11 => "N", 
			10 => "O", 
			_ => "D", 
		}));
		string value3 = StringUtil.ZerosLeft(DateTime.Today.Day.ToString(), 2);
		string text = "";
		_ = base.ConfiguracaoArquivoRemessa.DataUltimaRemessa;
		if (DateTime.Today.Equals(base.ConfiguracaoArquivoRemessa.DataUltimaRemessa))
		{
			int num = ++base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria;
			if (num == 10)
			{
				num = 0;
			}
			text = "RM" + num;
		}
		else
		{
			text = "CRM";
			base.ConfiguracaoArquivoRemessa.DataUltimaRemessa = DateTime.Today;
			base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria = 1;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value);
		stringBuilder.Append(value2);
		stringBuilder.Append(value3);
		stringBuilder.Append(".");
		stringBuilder.Append(text);
		return stringBuilder.ToString();
	}

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return CalcularDVNossoNumero(nossoNumero);
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Cooperativa de crédito/agência beneficiária - Posto", "Agência/Posto", "0000.00");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "00000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "Número do código do beneficiário", "Código do beneficiário", "00000");
		base.DadosConfiguracao.Add(value);
		ArrayList arrayList = new ArrayList();
		arrayList.Add(new ItemLista("2", "prefixo 2", "", "Será utilizado como prefixo do nosso número o dígito 2.", "2"));
		arrayList.Add(new ItemLista("3", "prefixo 3", "", "Será utilizado como prefixo do nosso número o dígito 3.", "3"));
		arrayList.Add(new ItemLista("4", "prefixo 4", "", "Será utilizado como prefixo do nosso número o dígito 4.", "4"));
		arrayList.Add(new ItemLista("5", "prefixo 5", "", "Será utilizado como prefixo do nosso número o dígito 5.", "5"));
		arrayList.Add(new ItemLista("6", "prefixo 6", "", "Será utilizado como prefixo do nosso número o dígito 6.", "6"));
		arrayList.Add(new ItemLista("7", "prefixo 7", "", "Será utilizado como prefixo do nosso número o dígito 7.", "7"));
		arrayList.Add(new ItemLista("8", "prefixo 8", "", "Será utilizado como prefixo do nosso número o dígito 8.", "8"));
		arrayList.Add(new ItemLista("9", "prefixo 9", "", "Será utilizado como prefixo do nosso número o dígito 9.", "9"));
		value = new DadoConfiguracao("PrefixoNossoNumero", "Prefixo do nosso número quando emitido pelo cedente", "Prefixo nosso número", "0", arrayList);
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "00000");
		value.Valor = "00001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "00000");
		value.Valor = "99999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "00000");
		value.Valor = "00000";
		base.DadosConfiguracao.Add(value);
	}

	public override string GetMascaraNossoNumero()
	{
		return "00000000-0";
	}

	protected override string GetInicioSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
	}

	protected override string GetFimSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor;
	}

	protected override string GetSequenciaAtualNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[7]).Valor;
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan748();
	}
}
