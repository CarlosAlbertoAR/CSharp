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
using eCobranca.Core.Carteira.Ban003.Comandos.Febraban150.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban003;

[Serializable]
public class CarteiraCobrancaBan003CodigoCNR : CarteiraCobrancaBan003, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "CNR";

	public CarteiraCobrancaBan003CodigoCNR(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan003CodigoCNR(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ArquivoCobrancaRemessaFebraban240 CarregarArquivoRemessaFebraban240()
	{
		return null;
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return null;
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno configuracaoArquivoRetorno = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]");
			configuracaoArquivoRetorno = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_DA_AMAZONIA.ToString(), base.ModoUso, this);
			configuracaoArquivoRetorno.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.FEBRABAN150.ToString();
			return configuracaoArquivoRetorno;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return configuracaoArquivoRetorno;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoConfiguracaoArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			return configuracaoArquivoRetorno;
		}
	}

	protected override ArquivoCobrancaRetornoFebraban240 CarregarArquivoRetornoFebraban240()
	{
		return null;
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return null;
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return (ArquivoCobrancaRetornoFebraban150)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN150, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DA_AMAZONIA);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return new ComandoCarregarArquivoRetornoFebraban150Ban003();
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override string GerarArquivoRemessaCNAB400(ArrayList dcList)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		throw ExcecaoECobranca.CarteiraCobranca.RetornoFebraban240NaoImplementadoParaCarteira();
	}

	protected override ArrayList CarregarArquivoRetornoCnab400(string nomeArquivoRetorno)
	{
		throw ExcecaoECobranca.CarteiraCobranca.RetornoCnab400NaoImplementadoParaCarteira();
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno FEBRABAN150 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...)");
			retornoFebraban150.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban150 as ComandoCarregarArquivoRetornoFebraban150Ban003).Preparar(this, retornoFebraban150);
			comandoProcessarRetornoFebraban150.Execute();
			result = retornoFebraban150.CarregarArquivoRetornoFebraban150();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoArquivoRetornoFebraban150(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "CNR";
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			stringBuilder.Append(StringUtil.RemoverMascara((base.DadosConfiguracao[0] as DadoConfiguracao).Valor));
			stringBuilder.Append(StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor));
			stringBuilder.Append(StringUtil.RemoverMascara(dc.NossoNumero));
			stringBuilder.Append("8");
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

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoConvenio", "Código do convênio", "Código do convênio", "0000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "0000000000000000");
		value.Valor = "0000000000000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "0000000000000000");
		value.Valor = "9999999999999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "0000000000000000");
		value.Valor = "0000000000000000";
		base.DadosConfiguracao.Add(value);
	}
}
