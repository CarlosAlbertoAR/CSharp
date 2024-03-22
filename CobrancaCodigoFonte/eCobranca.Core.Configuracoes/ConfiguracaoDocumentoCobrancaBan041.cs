using System;
using System.Collections;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoDocumentoCobrancaBan041 : ConfiguracaoDocumentoCobranca
{
	public ConfiguracaoDocumentoCobrancaBan041(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
		: base(guid, banco, modoUso, carteira)
	{
		modalidadesCobranca = CarregarModalidades();
	}

	public ConfiguracaoDocumentoCobrancaBan041(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ArrayList CarregarModalidades()
	{
		return EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(banco, carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>()));
	}
}
