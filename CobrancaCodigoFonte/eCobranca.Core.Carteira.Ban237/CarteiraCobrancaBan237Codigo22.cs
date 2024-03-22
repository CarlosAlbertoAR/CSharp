using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban237;

[Serializable]
public class CarteiraCobrancaBan237Codigo22 : CarteiraCobrancaBan237, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "22";

	public CarteiraCobrancaBan237Codigo22(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
		configuracaoBoleto.NovoParametroAdicional(configuracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente()).Valor = "S";
	}

	public CarteiraCobrancaBan237Codigo22(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "22";
	}
}
