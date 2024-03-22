using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;

public interface IRegistroTransacaoTipo2RemessaCnab400Ban099
{
	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca Mensagem3 { get; }

	CampoLayoutArquivoCobranca Mensagem4 { get; }

	CampoLayoutArquivoCobranca DataDesconto2 { get; }

	CampoLayoutArquivoCobranca ValorDesconto2 { get; }

	CampoLayoutArquivoCobranca DataDesconto3 { get; }

	CampoLayoutArquivoCobranca ValorDesconto3 { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca Agencia { get; }

	CampoLayoutArquivoCobranca ContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
