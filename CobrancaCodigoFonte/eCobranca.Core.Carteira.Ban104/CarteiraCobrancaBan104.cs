using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Parametros.Ban104;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104;

[Serializable]
public abstract class CarteiraCobrancaBan104 : CarteiraCobranca, ISerializable
{
	public CarteiraCobrancaBan104(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan104(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ConfiguracaoBoleto CarregarConfiguracaoBoleto()
	{
		ConfiguracaoBoleto result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de boleto do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
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
			result = new ConfiguracaoBoleto(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this, "SAC CAIXA: 0800 726 0101 (informações, reclamações, sugestões e elogios).       Para pessoas com deficiência auditiva ou de fala: 0800 726 2492                               Ouvidoria: 0800 725 7474                                                       caixa.gov.br                               ", "104-0", GetCodigoCarteiraImpressao());
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
			Logger.Debug($"Criando configuração inicial de remessa de carteiras do banco do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]");
			configuracaoArquivoRemessa = new ConfiguracaoArquivoRemessa(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this, 0, base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada);
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

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno result = null;
		try
		{
			Logger.Debug($"Criando configuração inicial de retorno de carteiras do banco do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]");
			result = new ConfiguracaoArquivoRetorno(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this);
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

	protected override ConfiguracaoImpressao CarregarConfiguracaoImpressao()
	{
		ConfiguracaoImpressao result = null;
		try
		{
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			result = new ConfiguracaoImpressao(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de impressão de documentos de cobrança do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			result = new ConfiguracaoEmail(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this);
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
			Logger.Debug($"Carregando configuração de documentos de cobrança do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			result = new ConfiguracaoDocumentoCobranca(GetGuid(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString(), base.ModoUso, this);
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

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		return string.Empty;
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		return new ArrayList();
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan104();
	}

	public override ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis()
	{
		return new ParametrosAdicionaisDisponiveisBan104();
	}

	protected override string GerarNomeArquivoRemessa()
	{
		long sequenciaRemessa = base.ConfiguracaoArquivoRemessa.SequenciaRemessa;
		string text = ((sequenciaRemessa.ToString().Length > 5) ? StringUtil.ZerosLeft("1", 5) : StringUtil.ZerosLeft(sequenciaRemessa.ToString(), 5));
		base.ConfiguracaoArquivoRemessa.SequenciaRemessa = Convert.ToInt32(text) + 1;
		return "E" + StringUtil.ZerosLeft(DateTime.Today.Day.ToString(), 2) + text + ".REM";
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
