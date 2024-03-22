namespace eCobranca.Core.Parametros;

public abstract class ParametrosAdicionaisDisponiveis
{
	private ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa remessa;

	private ParametrosAdicionaisDisponiveisConfiguracaoBoleto boleto;

	private ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca carteira;

	private ParametrosAdicionaisDisponiveisDocumentoCobranca documento;

	private ParametrosAdicionaisDisponiveisConfiguracaoImpressao impressao;

	public ParametrosAdicionaisDisponiveisConfiguracaoImpressao Impressao => impressao;

	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa Remessa => remessa;

	public ParametrosAdicionaisDisponiveisConfiguracaoBoleto Boleto => boleto;

	public ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca Carteira => carteira;

	public ParametrosAdicionaisDisponiveisDocumentoCobranca Documento => documento;

	public ParametrosAdicionaisDisponiveis()
	{
		remessa = CarregarParametrosAdicionaisDisponiveisRemessa();
		boleto = CarregarParametrosAdicionaisDisponiveisBoleto();
		carteira = CarregarParametrosAdicionaisDisponiveisCarteira();
		documento = CarregarParametrosAdicionaisDisponiveisDocumento();
		impressao = CarregarParametrosAdicionaisDisponiveisImpressao();
	}

	public abstract ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa CarregarParametrosAdicionaisDisponiveisRemessa();

	public abstract ParametrosAdicionaisDisponiveisConfiguracaoBoleto CarregarParametrosAdicionaisDisponiveisBoleto();

	public abstract ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca CarregarParametrosAdicionaisDisponiveisCarteira();

	public abstract ParametrosAdicionaisDisponiveisDocumentoCobranca CarregarParametrosAdicionaisDisponiveisDocumento();

	public abstract ParametrosAdicionaisDisponiveisConfiguracaoImpressao CarregarParametrosAdicionaisDisponiveisImpressao();
}
