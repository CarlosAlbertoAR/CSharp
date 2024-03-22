using System.Collections;
using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros;

public class ParametrosAdicionaisDisponiveisConfiguracaoBoleto : IParametrosAdicionaisDisponiveisConfiguracaoBoleto
{
	protected ArrayList parametros;

	public ArrayList Parametros => parametros;

	public ParametrosAdicionaisDisponiveisConfiguracaoBoleto()
	{
		parametros = new ArrayList();
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_BOLETO, EnumChaveContexto.GERAL)));
	}

	public ParametroConfiguracao MargemEsquerda()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MARGEM_ESQUERDA);
	}

	public ParametroConfiguracao MargemDireita()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MARGEM_DIREITA);
	}

	public ParametroConfiguracao MargemSuperior()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MARGEM_SUPERIOR);
	}

	public ParametroConfiguracao MargemInferior()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MARGEM_INFERIOR);
	}

	public ParametroConfiguracao LarguraCodigoBarras()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_LARGURA_CODIGO_BARRAS);
	}

	public ParametroConfiguracao AlturaCodigoBarras()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_ALTURA_CODIGO_BARRAS);
	}

	public ParametroConfiguracao PagamentoSomenteNoBancoCedente()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE);
	}

	public ParametroConfiguracao GeraMensagemAutomaticaJuros()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_GERA_MENSAGEM_AUTOMATICA_JUROS);
	}

	public ParametroConfiguracao GeraMensagemAutomaticaDesconto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_GERA_MENSAGEM_AUTOMATICA_DESCONTO);
	}

	public ParametroConfiguracao GeraMensagemAutomaticaMulta()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_GERA_MENSAGEM_AUTOMATICA_MULTA);
	}

	public ParametroConfiguracao GeraMensagemAutomaticaProtesto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_GERA_MENSAGEM_AUTOMATICA_PROTESTO);
	}

	public ParametroConfiguracao QuebrarLinhasMensagensAutomaticas()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_QUEBRAR_LINHAS_MENSAGENS_AUTOMATICAS);
	}

	public ParametroConfiguracao ExibirRazaoSocialBeneficiario()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_EXIBIR_RAZAO_SOCIAL_BENEFICIARIO);
	}

	public ParametroConfiguracao FonteCampoInstrucoes()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_FONTE_CAMPO_INSTRUCOES);
	}

	public ParametroConfiguracao ModeloBoletoSecundario()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MODELO_BOLETO_SECUNDARIO);
	}

	public ParametroConfiguracao AplicarQuebraPaginaGeracaoBoletos()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_APLICAR_QUEBRA_PAGINA_GERACAO_BOLETOS);
	}

	public ParametroConfiguracao ExibeMensagemHibridaDeJurosMultaDesconto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_MENSAGEM_HIBRIDA_JUROS_MULTA_DESCONTO);
	}

	public ParametroConfiguracao ExibeConteudoCampoInstrucoesEmCaixaAlta()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_EM_CAIXA_ALTA);
	}

	public ParametroConfiguracao ExibeConteudoCampoInstrucoesNasInformacoesExtrasDoPagador()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_NAS_INFORMACOES_EXTRAS_PAGADOR);
	}

	public ParametroConfiguracao MensagemAoPagador()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_MENSAGEM_AO_PAGADOR);
	}

	public ParametroConfiguracao SenhaBloqueioBoletos()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_SENHA_BLOQUEIO_BOLETOS);
	}

	public ParametroConfiguracao EnveloparImagemDoBoletoEmArquivoPDF()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_ENVELOPAR_IMAGEM_DE_BOLETO_EM_ARQUIVO_PDF);
	}

	public ParametroConfiguracao ComprimirPDF()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.BOL_COMPRIMIR_PDF);
	}
}
