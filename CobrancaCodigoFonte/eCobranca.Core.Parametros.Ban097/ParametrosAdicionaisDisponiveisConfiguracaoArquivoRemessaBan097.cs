using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban097;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO)));
	}

	public ParametroConfiguracao TipoCarenciaJuros()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_JUROS_CNAB400);
	}

	public ParametroConfiguracao TipoCarenciaMulta()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_MULTA_CNAB400);
	}

	public ParametroConfiguracao CarenciaCobrancaJuros()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_JUROS);
	}

	public ParametroConfiguracao CarenciaCobrancaMulta()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_MULTA);
	}

	public ParametroConfiguracao GeraDetalheRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraDetalheOpcionalRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_OPCIONAL_REMESSA_CNAB400);
	}

	public ParametroConfiguracao TipoEnvioProtesto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_TIPO_ENVIO_PROTESTO_REMESSA_CNAB400);
	}
}
