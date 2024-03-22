using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheOpcionalFebraban240Padrao : SegmentoDetalheOpcionalFebraban240, ISegmentoDetalheOpcionalFebraban240Padrao
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistroOpcional => campos[7];

	public SegmentoDetalheOpcionalFebraban240Padrao(string identificacaoRegistroOpcional, long sequenciaLote, long sequenciaSegmento)
		: base(identificacaoRegistroOpcional, sequenciaLote, sequenciaSegmento)
	{
	}
}
