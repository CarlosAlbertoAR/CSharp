using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban136;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan136 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan136
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan136()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.UNICRED)));
	}

	public ParametroConfiguracao GeraRegistroTipo1RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO1_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraRegistroTipo5RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO5_REMESSA_CNAB400);
	}
}
