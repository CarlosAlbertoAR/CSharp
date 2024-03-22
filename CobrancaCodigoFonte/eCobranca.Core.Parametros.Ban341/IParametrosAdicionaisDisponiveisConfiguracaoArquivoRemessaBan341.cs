namespace eCobranca.Core.Parametros.Ban341;

public interface IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341 : IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa
{
	ParametroConfiguracao GeraRegistroDetalheRemessaCnab400();

	ParametroConfiguracao GeraRegistroDetalheOpcionalMultaRemessaCnab400();

	ParametroConfiguracao GeraRegistroDetalheOpcionalAvalistaRemessaCnab400();

	ParametroConfiguracao GeraRegistroMensagemFrenteRemessaCnab400();

	ParametroConfiguracao GeraRegistroMensagemVersoRemessaCnab400();

	ParametroConfiguracao PrimeiraInstrucaoCobranca();

	ParametroConfiguracao SegundaInstrucaoCobranca();
}
