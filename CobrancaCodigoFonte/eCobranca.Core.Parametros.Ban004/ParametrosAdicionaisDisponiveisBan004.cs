namespace eCobranca.Core.Parametros.Ban004;

public class ParametrosAdicionaisDisponiveisBan004 : ParametrosAdicionaisDisponiveis
{
	public override ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa CarregarParametrosAdicionaisDisponiveisRemessa()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan004();
	}

	public override ParametrosAdicionaisDisponiveisConfiguracaoBoleto CarregarParametrosAdicionaisDisponiveisBoleto()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoBoleto();
	}

	public override ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca CarregarParametrosAdicionaisDisponiveisCarteira()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca();
	}

	public override ParametrosAdicionaisDisponiveisDocumentoCobranca CarregarParametrosAdicionaisDisponiveisDocumento()
	{
		return new ParametrosAdicionaisDisponiveisDocumentoCobrancaBan004();
	}

	public override ParametrosAdicionaisDisponiveisConfiguracaoImpressao CarregarParametrosAdicionaisDisponiveisImpressao()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoImpressao();
	}
}
