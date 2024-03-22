using System;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

internal class ArquivoCobrancaRemessaCnab400Ban084 : ArquivoCobrancaRemessaCnab400
{
	public ArquivoCobrancaRemessaCnab400Ban084(Guid guid, HeaderRemessaCnab400 header, TraillerRemessaCnab400 trailler, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, header, trailler, tipoCarteiraCobranca)
	{
	}

	public override LoteCobrancaRemessaCnab400 CarregarLote()
	{
		return new LoteCobrancaRemessaCnab400Ban084();
	}
}
