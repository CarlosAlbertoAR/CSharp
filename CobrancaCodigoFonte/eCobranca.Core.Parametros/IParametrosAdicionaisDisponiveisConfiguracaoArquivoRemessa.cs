namespace eCobranca.Core.Parametros;

public interface IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa
{
	ParametroConfiguracao GeraHeaderRemessaCnab400();

	ParametroConfiguracao GeraTraillerRemessaCnab400();

	ParametroConfiguracao GeraHeaderArquivoFebraban240();

	ParametroConfiguracao GeraHeaderLoteFebraban240();

	ParametroConfiguracao GeraSegmentoDetalhePFebraban240();

	ParametroConfiguracao GeraSegmentoDetalheQFebraban240();

	ParametroConfiguracao GeraSegmentoDetalheRFebraban240();

	ParametroConfiguracao GeraTraillerLoteFebraban240();

	ParametroConfiguracao GeraTraillerArquivoFebraban240();

	ParametroConfiguracao NomeArquivoRemessa();

	ParametroConfiguracao ModoHomologacao();

	ParametroConfiguracao CodificacaoArquivoRemessa();

	ParametroConfiguracao EnviaSegmentosAdicionaisOutrasInstrucoesRemessa();
}
