using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;

public interface IDetalheOpcionalRemessaCnab400Ban097CobrancaSimples
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca LogradouroSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroLogradouroSacadorAvalista { get; }

	CampoLayoutArquivoCobranca ComplementoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca BairroSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CidadeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UfSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca InstrucaoTitulo { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca TipoJuros { get; }

	CampoLayoutArquivoCobranca TipoCarenciaJuros { get; }

	CampoLayoutArquivoCobranca DiasCarenciaJuros { get; }

	CampoLayoutArquivoCobranca ValorMulta { get; }

	CampoLayoutArquivoCobranca TipoMulta { get; }

	CampoLayoutArquivoCobranca TipoCarenciaMulta { get; }

	CampoLayoutArquivoCobranca DiasCarenciaMulta { get; }

	CampoLayoutArquivoCobranca DataPrimeiroDesconto { get; }

	CampoLayoutArquivoCobranca ValorPrimeiroDesconto { get; }

	CampoLayoutArquivoCobranca TipoPrimeiroDesconto { get; }

	CampoLayoutArquivoCobranca DataSegundoDesconto { get; }

	CampoLayoutArquivoCobranca ValorSegundoDesconto { get; }

	CampoLayoutArquivoCobranca TipoSegundoDesconto { get; }

	CampoLayoutArquivoCobranca DataTerceiroDesconto { get; }

	CampoLayoutArquivoCobranca ValorTerceiroDesconto { get; }

	CampoLayoutArquivoCobranca TipoTerceiroDesconto { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
