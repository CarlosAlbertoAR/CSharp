namespace eCobranca.Core.Parametros;

public interface IParametrosAdicionaisDisponiveisConfiguracaoImpressao
{
	ParametroConfiguracao AlturaPagina();

	ParametroConfiguracao LarguraPagina();

	ParametroConfiguracao OrientacaoPagina();

	ParametroConfiguracao ImpressoraPersonalizada();
}
