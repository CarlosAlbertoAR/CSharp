using System;
using eCobranca.Atributos;
using eCobranca.Core.Dicionario;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Repositorio;

public class RepositorioCodigosCobrancaBan237 : RepositorioCodigosCobranca
{
	private const EnumCodigoBanco BAN_237 = EnumCodigoBanco.BANCO_BRADESCO;

	private AtributoChave contextoFebraban240Especifico;

	private AtributoChave contextoCnab400Especifico;

	public RepositorioCodigosCobrancaBan237(EnumTipoCarteiraCobranca carteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(EnumCodigoBanco.BANCO_BRADESCO, carteira)
	{
		DefinirContextoEspecifico(carteira);
	}

	protected override void PrePreenchimentoConfiguracoes()
	{
		DefinirContextoEspecifico(carteira);
	}

	private void DefinirContextoEspecifico(EnumTipoCarteiraCobranca carteira)
	{
		switch (carteira)
		{
		case EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA:
			contextoFebraban240Especifico = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.FEBRABAN240)));
			contextoCnab400Especifico = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.CNAB400)));
			break;
		case EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED:
			contextoFebraban240Especifico = new AtributoChave(EnumChaveContexto.BAN237_UNICRED_FEBRABAN240);
			contextoCnab400Especifico = new AtributoChave(EnumChaveContexto.BAN237_UNICRED_CNAB400);
			break;
		case EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL:
			contextoFebraban240Especifico = new AtributoChave(EnumChaveContexto.BAN237_CRESOL_FEBRABAN240);
			contextoCnab400Especifico = new AtributoChave(EnumChaveContexto.BAN237_CRESOL_CNAB400);
			break;
		default:
			contextoFebraban240Especifico = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.FEBRABAN240)));
			contextoCnab400Especifico = new AtributoChave(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.CNAB400)));
			break;
		}
	}

	protected override void PreencherCodigosConfiguracaoRemessa()
	{
		if (carteira == EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL || carteira == EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED)
		{
			layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoFebraban240Especifico));
			layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoCnab400Especifico));
			codigosMovimentoRemessaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoCnab400Especifico);
			codigosMovimentoRemessaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoFebraban240Especifico);
		}
		else
		{
			layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoFebraban240));
			layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoCnab400));
			codigosMovimentoRemessaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoCnab400);
			codigosMovimentoRemessaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoFebraban240);
		}
	}

	protected override void PreencherCodigosConfiguracaoRetorno()
	{
		if (carteira == EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL || carteira == EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED)
		{
			layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoFebraban240Especifico));
			layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoCnab400Especifico));
		}
		else
		{
			layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoFebraban240));
			layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoCnab400));
		}
	}

	protected override void PreencherCodigosConfiguracaoDocumentoCobranca()
	{
		switch (carteira)
		{
		case EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED:
			modalidadesCobranca = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED));
			tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoFebraban240Especifico);
			tiposDocumentosCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoCnab400Especifico);
			codigosMultaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoFebraban240);
			codigosMultaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoCnab400);
			break;
		case EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL:
			modalidadesCobranca = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL));
			tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoFebraban240Especifico);
			tiposDocumentosCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoCnab400Especifico);
			codigosMultaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoFebraban240Especifico);
			codigosMultaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoCnab400Especifico);
			break;
		default:
			modalidadesCobranca = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(banco));
			if (modalidadesCobranca.Count == 0)
			{
				modalidadesCobranca = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
			}
			tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoFebraban240);
			tiposDocumentosCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoCnab400);
			codigosMultaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoFebraban240);
			codigosMultaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoCnab400);
			break;
		}
		codigosAceiteFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoAceite, AtributoChave>(contextoFebraban240);
		codigosAceiteCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoAceite, AtributoChave>(contextoCnab400);
		codigosDescontoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoDesconto, AtributoChave>(contextoFebraban240);
		codigosDescontoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoDesconto, AtributoChave>(contextoCnab400);
		codigosJurosFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoJuros, AtributoChave>(contextoFebraban240);
		codigosJurosCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoJuros, AtributoChave>(contextoCnab400);
		codigosProtestoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoProtesto, AtributoChave>(contextoFebraban240);
		codigosProtestoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoProtesto, AtributoChave>(contextoCnab400);
		codigosMoedaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMoeda, AtributoChave>(contextoFebraban240);
		codigosMoedaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMoeda, AtributoChave>(contextoCnab400);
		codigosBaixaDevolucaoFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoBaixaDevolucao, AtributoChave>(contextoFebraban240);
		codigosBaixaDevolucaoCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoBaixaDevolucao, AtributoChave>(contextoCnab400);
		codigosInstrucaoCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoFebraban240);
		codigosInstrucaoCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoCnab400);
	}
}
