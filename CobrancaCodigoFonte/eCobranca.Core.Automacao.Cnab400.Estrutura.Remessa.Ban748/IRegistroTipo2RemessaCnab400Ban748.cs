using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public interface IRegistroTipo2RemessaCnab400Ban748
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca InstrucaoImpressao1 { get; }

	CampoLayoutArquivoCobranca InstrucaoImpressao2 { get; }

	CampoLayoutArquivoCobranca InstrucaoImpressao3 { get; }

	CampoLayoutArquivoCobranca InstrucaoImpressao4 { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
