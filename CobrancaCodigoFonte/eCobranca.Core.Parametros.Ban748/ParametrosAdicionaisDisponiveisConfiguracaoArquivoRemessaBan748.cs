using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban748;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI)));
	}

	public ParametroConfiguracao GeraRegistroTipo1RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_1_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraRegistroTipo2RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_2_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraRegistroTipo6RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_6_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraRegistroTipo7RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_7_REMESSA_CNAB400);
	}
}
