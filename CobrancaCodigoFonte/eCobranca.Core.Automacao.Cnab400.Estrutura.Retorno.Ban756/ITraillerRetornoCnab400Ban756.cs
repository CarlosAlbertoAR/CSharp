using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban756;

public interface ITraillerRetornoCnab400Ban756
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca CodigoAgencicaRemetente { get; }

	CampoLayoutArquivoCobranca SiglaCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca EnderecoCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca BairroCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca CepCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca CidadeCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca UFCooperativaRemetente { get; }

	CampoLayoutArquivoCobranca DataMovimento { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistros { get; }

	CampoLayoutArquivoCobranca UltimoNossoNumero { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
