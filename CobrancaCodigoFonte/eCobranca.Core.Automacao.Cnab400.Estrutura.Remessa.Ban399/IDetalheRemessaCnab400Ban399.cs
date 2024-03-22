using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;

public interface IDetalheRemessaCnab400Ban399
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca SubContaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DataDesconto2 { get; }

	CampoLayoutArquivoCobranca ValorDesconto2 { get; }

	CampoLayoutArquivoCobranca DataDesconto3 { get; }

	CampoLayoutArquivoCobranca ValorDesconto3 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca BancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaDepositaria { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca TipoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Instrucao1 { get; }

	CampoLayoutArquivoCobranca Instrucao2 { get; }

	CampoLayoutArquivoCobranca ValorJurosDeMora { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimentoMulta { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca InstrucaoDeNaoRecebimento { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca PrefixoCepPagador { get; }

	CampoLayoutArquivoCobranca SufixoCepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UfPagador { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca TipoBoletoUtilizado { get; }

	CampoLayoutArquivoCobranca PrazoProtesto { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
