using System;
using System.Linq;
using eCobranca.Atributos;
using eCobranca.Core.Dicionario;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Repositorio;

public class RepositorioCodigosCobrancaBan756 : RepositorioCodigosCobranca
{
	private const EnumCodigoBanco BANCO_756 = EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL;

	public RepositorioCodigosCobrancaBan756(EnumTipoCarteiraCobranca carteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, carteira)
	{
	}

	protected override void PreencherCodigosConfiguracaoDocumentoCobranca()
	{
		AtributoChave atributoChave = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.FEBRABAN240)));
		AtributoChave atributoChave2 = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.CNAB400)));
		if (carteira != EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		{
			atributoChave.Chaves = contextoFebraban240.Chaves.Concat(new Enum[1] { carteira }).ToArray();
			atributoChave2.Chaves = contextoCnab400.Chaves.Concat(new Enum[1] { carteira }).ToArray();
		}
		tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoFebraban240);
		tiposDocumentosCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoCnab400);
		codigosAceiteFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoAceite, AtributoChave>(contextoFebraban240);
		codigosAceiteCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoAceite, AtributoChave>(contextoCnab400);
		codigosDescontoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoDesconto, AtributoChave>(contextoFebraban240);
		codigosDescontoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoDesconto, AtributoChave>(contextoCnab400);
		codigosJurosFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoJuros, AtributoChave>(atributoChave);
		codigosJurosCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoJuros, AtributoChave>(atributoChave2);
		codigosProtestoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoProtesto, AtributoChave>(contextoFebraban240);
		codigosProtestoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoProtesto, AtributoChave>(contextoCnab400);
		codigosMoedaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMoeda, AtributoChave>(contextoFebraban240);
		codigosMoedaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMoeda, AtributoChave>(contextoCnab400);
		codigosBaixaDevolucaoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoBaixaDevolucao, AtributoChave>(contextoFebraban240);
		codigosBaixaDevolucaoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoBaixaDevolucao, AtributoChave>(contextoCnab400);
		codigosMultaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoFebraban240);
		codigosMultaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoCnab400);
		codigosInstrucaoCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoFebraban240);
		codigosInstrucaoCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoCnab400);
	}
}
