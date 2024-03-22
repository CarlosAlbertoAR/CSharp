using System;
using System.Collections;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoDocumentoCobrancaBan033 : ConfiguracaoDocumentoCobranca
{
	public ConfiguracaoDocumentoCobrancaBan033(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
		: base(guid, banco, modoUso, carteira)
	{
		modalidadesCobranca = CarregarModalidades();
	}

	public ConfiguracaoDocumentoCobrancaBan033(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ArrayList CarregarModalidades()
	{
		return EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(banco, (EnumTipoCarteiraCobranca)(object)carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>()));
	}
}
