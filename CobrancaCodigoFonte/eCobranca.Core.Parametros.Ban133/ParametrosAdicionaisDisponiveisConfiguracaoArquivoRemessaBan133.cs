using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban133;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan133 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan133
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan133()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.CRESOL)));
	}

	public ParametroConfiguracao GeraRegistroDetalheRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400_BAN133);
	}
}
