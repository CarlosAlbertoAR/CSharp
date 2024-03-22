using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban004;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan004 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan004
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan004()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL)));
	}

	public ParametroConfiguracao GeraDetalheRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_REMESSA_CNAB400);
	}
}
