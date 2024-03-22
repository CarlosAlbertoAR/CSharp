using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban004;

public class ParametrosAdicionaisDisponiveisDocumentoCobrancaBan004 : ParametrosAdicionaisDisponiveisDocumentoCobranca, IParametrosAdicionaisDisponiveisDocumentoCobrancaBan004
{
	public ParametrosAdicionaisDisponiveisDocumentoCobrancaBan004()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.DOCUMENTO_COBRANCA, EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL)));
	}

	public ParametroConfiguracao CodigoInstrucao()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_INSTRUCAO);
	}
}
