namespace eCobranca.Core.Parametros.Ban104;

public class ParametrosAdicionaisDisponiveisBan104 : ParametrosAdicionaisDisponiveis
{
	public override ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa CarregarParametrosAdicionaisDisponiveisRemessa()
	{
		return new ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan104();
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
