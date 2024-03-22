using System;
using System.Collections;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoDocumentoCobrancaBan237Unicred : ConfiguracaoDocumentoCobranca
{
	public ConfiguracaoDocumentoCobrancaBan237Unicred(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
		: base(guid, banco, modoUso, carteira)
	{
		tiposDocumentosCobrancaFebraban240.Clear();
		modalidadesCobranca.Clear();
		tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_FEBRABAN240));
		modalidadesCobranca = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_BRADESCO, EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED));
	}

	public ConfiguracaoDocumentoCobrancaBan237Unicred(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		base.CarregarListas(repositorio);
		tiposDocumentosCobrancaFebraban240.Clear();
		tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_FEBRABAN240));
	}

	protected override ArrayList CarregarModalidades()
	{
		return EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_BRADESCO, EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED));
	}
}
