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
using eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Retorno;
using eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Parametros.Ban756;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756;

[Serializable]
public abstract class CarteiraCobrancaBan756 : CarteiraCobranca, ISerializable
{
	public CarteiraCobrancaBan756(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan756(SerializationInfo serobj, StreamingContext scontext)
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
			Logger.Debug($"Criando configuração inicial de boleto do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
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
			result = new ConfiguracaoBoleto(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this, "SAC Sicoob: 0800 724 4420 (Informações, elogios e reclamações) ou 0800 940 0458 (deficientes auditivos ou de fala). Ouvidoria Sicoob: 0800 725 0996 (dias úteis, das 8h às 20h)", "756-0", GetCodigoCarteiraImpressao());
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
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this, 10, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>());
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
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban756)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL);
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban756(this);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban756();
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]");
			result = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this);
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
		return (ArquivoCobrancaRetornoFebraban240)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban756)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban756(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban756();
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			result = new ConfiguracaoImpressao(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			result = new ConfiguracaoEmail(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de documentos de cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			result = new ConfiguracaoDocumentoCobranca(GetGuid(), EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.ToString(), base.ModoUso, this, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>());
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
			Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			remessaFebraban240.Preparar(this);
			remessaFebraban240.NovoLote(dcList);
			(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban756).Preparar(this, remessaFebraban240);
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
				Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
				remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
				remessaCnab400.CriarLote(dcList);
				(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban756).Preparar(this, remessaCnab400);
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
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban756).Preparar(this, retornoFebraban240);
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
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban756).Preparar(this, retornoCnab400);
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
		return new ProvedorDadosModeloBoletoBan756();
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Cooperativa-DV", "Cooperativa sicoob", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "00000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "Número do código do beneficiário", "Código do beneficiário", "0000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "0000000");
		value.Valor = "0000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "0000000");
		value.Valor = "9999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "0000000");
		value.Valor = "0000000";
		base.DadosConfiguracao.Add(value);
	}

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
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

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return CalcularDVNossoNumero(nossoNumero);
	}

	protected override string CalcularDVNossoNumero(string nossoNumeroSemDV)
	{
		string text = "";
		StringBuilder stringBuilder = new StringBuilder();
		string text2 = "3197";
		try
		{
			string value = StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[0] as DadoConfiguracao).Valor, 1);
			string value2 = StringUtil.ZerosLeft(StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor), 10);
			string value3 = StringUtil.ZerosLeft(nossoNumeroSemDV, 7);
			stringBuilder.Append(value);
			stringBuilder.Append(value2);
			stringBuilder.Append(value3);
			Logger.Debug($"Gerando DV para o nosso número [{stringBuilder.ToString()}]");
			int num = 0;
			int num2 = 3;
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < stringBuilder.Length; i++)
			{
				int num5 = Convert.ToInt32(stringBuilder[i].ToString());
				int num6 = Convert.ToInt32(text2[num].ToString());
				num4 += num5 * num6;
				num = ((num != num2) ? (num + 1) : num3);
			}
			int num7 = num4 % 11;
			text = ((11 - num7 >= 10) ? "0" : (11 - num7).ToString());
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

	protected override string GerarNomeArquivoRemessa()
	{
		long sequenciaRemessa = base.ConfiguracaoArquivoRemessa.SequenciaRemessa;
		string text = ((sequenciaRemessa.ToString().Length > 8) ? StringUtil.ZerosLeft("1", 8) : StringUtil.ZerosLeft(sequenciaRemessa.ToString(), 8));
		base.ConfiguracaoArquivoRemessa.SequenciaRemessa = Convert.ToInt32(text) + 1;
		return "REM" + text + ".TXT";
	}

	public override ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis()
	{
		return new ParametrosAdicionaisDisponiveisBan756();
	}

	public override string GetMascaraNossoNumero()
	{
		return "0000000-0";
	}
}
