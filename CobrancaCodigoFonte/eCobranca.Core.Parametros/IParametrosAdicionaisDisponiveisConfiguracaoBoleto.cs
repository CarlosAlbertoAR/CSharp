namespace eCobranca.Core.Parametros;

public interface IParametrosAdicionaisDisponiveisConfiguracaoBoleto
{
	ParametroConfiguracao MargemEsquerda();

	ParametroConfiguracao MargemDireita();

	ParametroConfiguracao MargemSuperior();

	ParametroConfiguracao MargemInferior();

	ParametroConfiguracao LarguraCodigoBarras();

	ParametroConfiguracao AlturaCodigoBarras();

	ParametroConfiguracao PagamentoSomenteNoBancoCedente();

	ParametroConfiguracao GeraMensagemAutomaticaJuros();

	ParametroConfiguracao GeraMensagemAutomaticaDesconto();

	ParametroConfiguracao GeraMensagemAutomaticaMulta();

	ParametroConfiguracao GeraMensagemAutomaticaProtesto();

	ParametroConfiguracao QuebrarLinhasMensagensAutomaticas();

	ParametroConfiguracao ExibirRazaoSocialBeneficiario();

	ParametroConfiguracao FonteCampoInstrucoes();

	ParametroConfiguracao ModeloBoletoSecundario();

	ParametroConfiguracao AplicarQuebraPaginaGeracaoBoletos();

	ParametroConfiguracao ExibeMensagemHibridaDeJurosMultaDesconto();

	ParametroConfiguracao ExibeConteudoCampoInstrucoesEmCaixaAlta();

	ParametroConfiguracao ExibeConteudoCampoInstrucoesNasInformacoesExtrasDoPagador();

	ParametroConfiguracao MensagemAoPagador();

	ParametroConfiguracao SenhaBloqueioBoletos();

	ParametroConfiguracao EnveloparImagemDoBoletoEmArquivoPDF();

	ParametroConfiguracao ComprimirPDF();
}
