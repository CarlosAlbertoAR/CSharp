namespace eCobranca.Core.Parametros.Ban422;

public class ParametrosAdicionaisDisponiveisBan422 : ParametrosAdicionaisDisponiveis
{
	public override ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa CarregarParametrosAdicionaisDisponiveisRemessa()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan422();
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
		return new ParametrosAdicionaisDisponiveisDocumentoCobranca();
	}

	public override ParametrosAdicionaisDisponiveisConfiguracaoImpressao CarregarParametrosAdicionaisDisponiveisImpressao()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoImpressao();
	}
}
