using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban756;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan756 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan756
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan756()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL)));
	}

	public ParametroConfiguracao GeraDetalheRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_REMESSA_CNAB400);
	}

	public ParametroConfiguracao PrimeiraInstrucaoCodificada()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_PRIMEIRA_INSTRUCAO_CODIFICADA);
	}

	public ParametroConfiguracao SegundaInstrucaoCodificada()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_SEGUNDA_INSTRUCAO_CODIFICADA);
	}
}
