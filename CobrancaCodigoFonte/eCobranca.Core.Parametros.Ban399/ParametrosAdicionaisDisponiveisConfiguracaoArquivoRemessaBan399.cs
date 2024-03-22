using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban399;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan399 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan399
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan399()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.HSBC_BANK_BRASIL)));
	}

	public ParametroConfiguracao GeraRegistroTipo1RemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400);
	}
}
