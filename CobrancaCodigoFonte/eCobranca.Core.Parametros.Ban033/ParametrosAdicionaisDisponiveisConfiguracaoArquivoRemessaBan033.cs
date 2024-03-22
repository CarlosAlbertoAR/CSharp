using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban033;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan033 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan033
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan033()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_SANTANDER)));
	}

	public ParametroConfiguracao GeraRegistroTipo1RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_1_REMESSA_CNAB400);
	}

	public ParametroConfiguracao UtilizaCodigoDeCobrancaNova()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_UTILIZA_CODIGO_DE_COBRANCA_NOVA);
	}
}
