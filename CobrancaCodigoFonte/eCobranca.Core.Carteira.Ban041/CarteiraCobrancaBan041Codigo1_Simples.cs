using System;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041;

[Serializable]
public class CarteiraCobrancaBan041Codigo1_Simples : CarteiraCobrancaBan041, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "1";

	public CarteiraCobrancaBan041Codigo1_Simples(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan041Codigo1_Simples(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "1";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca utilizada pela carteira de cobrança", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL)));
		base.DadosConfiguracao.Insert(3, value);
	}
}
