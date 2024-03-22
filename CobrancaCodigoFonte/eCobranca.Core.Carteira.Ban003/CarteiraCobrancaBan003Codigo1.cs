using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira.Ban003.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban003.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban003;

[Serializable]
public class CarteiraCobrancaBan003Codigo1 : CarteiraCobrancaBan003, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "1";

	public CarteiraCobrancaBan003Codigo1(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan003Codigo1(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override FactorySegmentoFebraban240 CarregarFabricaSegmentoFebraban240()
	{
		return new FactorySegmentoFebraban240Padrao();
	}

	protected override ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa()
	{
		ConfiguracaoArquivoRemessa configuracaoArquivoRemessa = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.BANCO_DA_AMAZONIA.ToString(), base.ModoUso, this, 0, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada);
			configuracaoArquivoRemessa.DiretorioArquivoRemessa = "C:\\eCobranca\\Remessas\\";
			configuracaoArquivoRemessa.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.FEBRABAN240.ToString();
			configuracaoArquivoRemessa.SequenciaLote = 1;
			configuracaoArquivoRemessa.SequenciaRemessaDiaria = 1;
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
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DA_AMAZONIA);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban003(this);
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno configuracaoArquivoRetorno = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]");
			configuracaoArquivoRetorno = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.BANCO_DA_AMAZONIA.ToString(), base.ModoUso, this);
			configuracaoArquivoRetorno.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.FEBRABAN240.ToString();
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
		return (ArquivoCobrancaRetornoFebraban240Ban003)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_DA_AMAZONIA);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return null;
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban003(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return null;
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
			remessaFebraban240.Preparar(this);
			remessaFebraban240.NovoLote(dcList);
			(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban003).Preparar(this, remessaFebraban240);
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
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override string GerarNomeArquivoRemessa()
	{
		if (base.ConfiguracaoArquivoRemessa.DataUltimaRemessa == DateTime.Today)
		{
			base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria++;
		}
		else
		{
			base.ConfiguracaoArquivoRemessa.DataUltimaRemessa = DateTime.Today;
			base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria = 1;
		}
		return "VAN_AMZ_" + DateTime.Today.ToString("yyyy") + DateTime.Today.ToString("MM") + DateTime.Today.ToString("dd") + ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor + "CNAB240REM." + StringUtil.ZerosLeft(base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria.ToString(), 3);
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban003).Preparar(this, retornoFebraban240);
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
		throw ExcecaoECobranca.CarteiraCobranca.RetornoCnab400NaoImplementadoParaCarteira();
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		throw ExcecaoECobranca.CarteiraCobranca.RetornoFebraban150NaoImplementadoParaCarteira();
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "1";
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		return StringUtil.RemoverMascara(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor) + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + dc.DataVencimento.Value.ToString("ddMMyy") + "00000000";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoConvenio", "Código do convênio", "Código do convênio", "00000");
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
		value = new DadoConfiguracao("CodigoCliente", "Código do cliente", "Código do cliente", "0000000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca: Utilize um dos valores da lista ConfiguracaoDocumentoCobranca.ModalidadesCobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_DA_AMAZONIA)));
		base.DadosConfiguracao.Add(value);
	}

	public override string GetMascaraNossoNumero()
	{
		return "0000000";
	}
}
