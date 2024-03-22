using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;

public interface ITraillerRetornoCnab400Ban399
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoArquivo { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoServico { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosEmSer { get; }

	CampoLayoutArquivoCobranca ValorTotulosEmSer { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
