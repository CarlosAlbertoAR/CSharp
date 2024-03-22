using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public abstract class CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17Posicoes : CarteiraCobrancaBan001Convenio6Digitos, ISerializable
{
	public CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17Posicoes(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17Posicoes(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		base.DadosConfiguracao[6] = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "00000000000000000");
		((DadoConfiguracao)base.DadosConfiguracao[6]).Valor = "00000000000000001";
		base.DadosConfiguracao[7] = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "00000000000000000");
		((DadoConfiguracao)base.DadosConfiguracao[7]).Valor = "99999999999999999";
		base.DadosConfiguracao[8] = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "00000000000000000");
		((DadoConfiguracao)base.DadosConfiguracao[8]).Valor = "00000000000000000";
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[2]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + "21";
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

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[8]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[8]).Mascara;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[7]).Valor;
			valor = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor2, valor3, mascara) : StringUtil.IncrementString(valor, valor2, valor3, mascara));
			if (string.IsNullOrEmpty(valor))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor3);
			}
			((DadoConfiguracao)base.DadosConfiguracao[8]).Valor = valor;
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
		return "";
	}
}
