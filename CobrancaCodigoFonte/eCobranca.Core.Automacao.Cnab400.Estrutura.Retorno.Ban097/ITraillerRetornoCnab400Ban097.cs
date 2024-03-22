using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public interface ITraillerRetornoCnab400Ban097
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoServico { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca Agencia { get; }

	CampoLayoutArquivoCobranca SiglaAgencia { get; }

	CampoLayoutArquivoCobranca EnderecoAgencia { get; }

	CampoLayoutArquivoCobranca BairroAgencia { get; }

	CampoLayoutArquivoCobranca CepAgencia { get; }

	CampoLayoutArquivoCobranca CidadeAgencia { get; }

	CampoLayoutArquivoCobranca EstadoAgencia { get; }

	CampoLayoutArquivoCobranca DataMovimento { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistros { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
