using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;

public interface IDetalheRemessaCnab400Ban756
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroConvenioBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca NumeroParcela { get; }

	CampoLayoutArquivoCobranca GrupoValor { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IndicativoMensagemSacadorAvalista { get; }

	CampoLayoutArquivoCobranca PrefixoTitulo { get; }

	CampoLayoutArquivoCobranca VariacaoCarteira { get; }

	CampoLayoutArquivoCobranca ContaCaucao { get; }

	CampoLayoutArquivoCobranca NumeroContratoGarantia { get; }

	CampoLayoutArquivoCobranca DVNumeroContratoGarantia { get; }

	CampoLayoutArquivoCobranca NumeroBordero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca TipoEmissao { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca Comando { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca Vencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca PrefixoCooperativa { get; }

	CampoLayoutArquivoCobranca DVPrefixoCooperativa { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca TipoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Instrucao1 { get; }

	CampoLayoutArquivoCobranca Instrucao2 { get; }

	CampoLayoutArquivoCobranca TaxaJurosMes { get; }

	CampoLayoutArquivoCobranca TaxaMulta { get; }

	CampoLayoutArquivoCobranca TipoDistribuicao { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UFPagador { get; }

	CampoLayoutArquivoCobranca ObservacoesOuMensagemOuSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroDiasProtesto { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
