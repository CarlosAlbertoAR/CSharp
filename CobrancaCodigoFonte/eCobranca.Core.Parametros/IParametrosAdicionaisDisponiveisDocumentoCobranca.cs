namespace eCobranca.Core.Parametros;

public interface IParametrosAdicionaisDisponiveisDocumentoCobranca
{
	ParametroConfiguracao CodigoDesconto2();

	ParametroConfiguracao DataDesconto2();

	ParametroConfiguracao ValorDesconto2();

	ParametroConfiguracao CodigoDesconto3();

	ParametroConfiguracao DataDesconto3();

	ParametroConfiguracao ValorDesconto3();

	ParametroConfiguracao EnderecoSacadorAvalista();

	ParametroConfiguracao BairroSacadorAvalista();

	ParametroConfiguracao CepSacadorAvalista();

	ParametroConfiguracao CidadeSacadorAvalista();

	ParametroConfiguracao UfSacadorAvalista();

	ParametroConfiguracao Mensagem1Boleto();

	ParametroConfiguracao Mensagem2Boleto();

	ParametroConfiguracao Mensagem3Boleto();

	ParametroConfiguracao Mensagem4Boleto();

	ParametroConfiguracao Mensagem5Boleto();

	ParametroConfiguracao Mensagem6Boleto();
}
