using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public abstract class CarteiraCobrancaBan001Convenio4Digitos : CarteiraCobrancaBan001, ISerializable
{
	public CarteiraCobrancaBan001Convenio4Digitos(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio4Digitos(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "0000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "00000000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "Número do código do convênio", "Código do convênio", "0000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Variacao", "Código de variação da carteira", "Variação da carteira", "000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("SiglaCedente", "Sigla utilizada pelo cedente", "Sigla do cedente", "AAAAAAAAAA");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca utilizada pela carteira de cobrança", "Modalidade de cobrança", "00", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_DO_BRASIL)));
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
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[2]).Valor;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[8]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[8]).Mascara;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor;
			string valor4 = ((DadoConfiguracao)base.DadosConfiguracao[7]).Valor;
			valor2 = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor3, valor4, mascara) : StringUtil.IncrementString(valor2, valor3, valor4, mascara));
			if (string.IsNullOrEmpty(valor2))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor4);
			}
			((DadoConfiguracao)base.DadosConfiguracao[8]).Valor = valor2;
			result = valor + valor2;
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

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca;
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

	public override string GetMascaraNossoNumero()
	{
		return "00000000000-0";
	}
}
