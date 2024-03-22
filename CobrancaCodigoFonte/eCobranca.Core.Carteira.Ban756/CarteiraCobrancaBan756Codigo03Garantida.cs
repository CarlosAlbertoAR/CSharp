using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756;

[Serializable]
public class CarteiraCobrancaBan756Codigo03Garantida : CarteiraCobrancaBan756, ISerializable
{
	public CarteiraCobrancaBan756Codigo03Garantida(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan756Codigo03Garantida(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		ArrayList arrayList = new ArrayList();
		ItemLista value = new ItemLista(EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.Codigo(), EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.Descricao(), EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.Sigla(), EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.Ajuda(), EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.ToString());
		arrayList.Add(value);
		DadoConfiguracao value2 = new DadoConfiguracao("Modalidade", "Modalidade de cobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI)));
		base.DadosConfiguracao.Insert(3, value2);
		value2 = new DadoConfiguracao("NumeroContrato", "Número do contrato", "Número do contrato", "00000-0");
		base.DadosConfiguracao.Add(value2);
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			string value = (base.DadosConfiguracao[3] as DadoConfiguracao).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			string value2 = StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[0] as DadoConfiguracao).Valor, 1);
			string value3 = "03";
			string value4 = StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor).Substring(1);
			string value5 = StringUtil.RemoverMascara(dc.NossoNumero);
			string value6 = ((dc.NumeroParcelaCarnet > 0) ? StringUtil.ZerosLeft(dc.NumeroParcelaCarnet.ToString(), 3) : "001");
			stringBuilder.Append(value);
			stringBuilder.Append(value2);
			stringBuilder.Append(value3);
			stringBuilder.Append(value4);
			stringBuilder.Append(value5);
			stringBuilder.Append(value6);
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

	public override string GetCodigoCarteiraImpressao()
	{
		return EnumModalidadeCarteiraCobranca.COBRANCA_CAUCIONADA3.Codigo();
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
