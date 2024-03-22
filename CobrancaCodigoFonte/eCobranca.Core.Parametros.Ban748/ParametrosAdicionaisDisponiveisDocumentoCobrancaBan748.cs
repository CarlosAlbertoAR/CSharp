using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban748;

public class ParametrosAdicionaisDisponiveisDocumentoCobrancaBan748 : ParametrosAdicionaisDisponiveisDocumentoCobranca, IParametrosAdicionaisDisponiveisDocumentoCobrancaBan748
{
	public ParametrosAdicionaisDisponiveisDocumentoCobrancaBan748()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.DOCUMENTO_COBRANCA, EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI)));
	}

	public ParametroConfiguracao CampoAlterado()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CAMPO_ALTERADO);
	}
}
