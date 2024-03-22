namespace eCobranca.Core.Parametros.Ban097;

public interface IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097
{
	ParametroConfiguracao GeraDetalheRemessaCnab400();

	ParametroConfiguracao GeraDetalheOpcionalRemessaCnab400();

	ParametroConfiguracao TipoCarenciaJuros();

	ParametroConfiguracao TipoCarenciaMulta();

	ParametroConfiguracao CarenciaCobrancaJuros();

	ParametroConfiguracao CarenciaCobrancaMulta();

	ParametroConfiguracao TipoEnvioProtesto();
}
