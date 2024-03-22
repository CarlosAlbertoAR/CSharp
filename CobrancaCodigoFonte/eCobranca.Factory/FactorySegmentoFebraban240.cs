using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public abstract class FactorySegmentoFebraban240
{
	public FactorySegmentoFebraban240()
	{
	}

	public abstract SegmentoFebraban240 NovoSegmento(EnumTipoSegmentoFebraban240 tipoSegmento, long sequenciaLote, long sequenciaSegmento, bool segmentoDeRemessa);
}
