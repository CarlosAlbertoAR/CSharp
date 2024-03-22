using System.Collections;

namespace eCobranca.Core.Repositorio;

public interface ICodigosConfiguracaoDocumentoCobranca
{
	ArrayList TiposDocumentosCobrancaFebraban240 { get; }

	ArrayList TiposDocumentosCobrancaCnab400 { get; }

	ArrayList CodigosAceiteFebraban240 { get; }

	ArrayList CodigosAceiteCnab400 { get; }

	ArrayList CodigosDescontoFebraban240 { get; }

	ArrayList CodigosDescontoCnab400 { get; }

	ArrayList CodigosJurosFebraban240 { get; }

	ArrayList CodigosJurosCnab400 { get; }

	ArrayList CodigosProtestoFebraban240 { get; }

	ArrayList CodigosProtestoCnab400 { get; }

	ArrayList CodigosMoedaFebraban240 { get; }

	ArrayList CodigosMoedaCnab400 { get; }

	ArrayList CodigosBaixaDevolucaoCnab400 { get; }

	ArrayList CodigosMultaFebraban240 { get; }

	ArrayList CodigosMultaCnab400 { get; }

	ArrayList CodigosInstrucaoCobrancaFebraban240 { get; }

	ArrayList CodigosInstrucaoCobrancaCnab400 { get; }
}
