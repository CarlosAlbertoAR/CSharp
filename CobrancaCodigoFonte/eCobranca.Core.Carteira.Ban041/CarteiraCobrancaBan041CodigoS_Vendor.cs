using System;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041;

[Serializable]
public class CarteiraCobrancaBan041CodigoS_Vendor : CarteiraCobrancaBan041, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "C";

	public CarteiraCobrancaBan041CodigoS_Vendor(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan041CodigoS_Vendor(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "C";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca utilizada pela carteira de cobrança", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL)));
		base.DadosConfiguracao.Insert(3, value);
		value = new DadoConfiguracao("CodigoServico", "Código de serviço", "Código de serviço", "0000");
		base.DadosConfiguracao.Add(value);
	}
}
