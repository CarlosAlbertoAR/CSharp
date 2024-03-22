using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;

public interface IRegistroTransacaoTipo7RemessaCnab400Ban237
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca EnderecoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca PrefixoCepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca SufixoCepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CidadeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UFSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca Agencia { get; }

	CampoLayoutArquivoCobranca ContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
