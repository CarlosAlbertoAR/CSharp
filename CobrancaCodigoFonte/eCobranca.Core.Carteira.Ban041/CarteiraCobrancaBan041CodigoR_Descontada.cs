using System;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041;

[Serializable]
public class CarteiraCobrancaBan041CodigoR_Descontada : CarteiraCobrancaBan041, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "R";

	public CarteiraCobrancaBan041CodigoR_Descontada(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan041CodigoR_Descontada(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "R";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca utilizada pela carteira de cobrança", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL)));
		base.DadosConfiguracao.Insert(3, value);
		value = new DadoConfiguracao("CodigoServico", "Código de serviço", "Código de serviço", "0000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoClienteOfficeBanking", "Código do cliente no Office Banking", "Código do cliente no Office Banking", "0000000000");
		base.DadosConfiguracao.Add(value);
	}
}
