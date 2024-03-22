using System;
using System.Collections;
using System.Linq;
using eCobranca.Atributos;
using eCobranca.Core.Dicionario;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Repositorio;

public class RepositorioCodigosCobranca : ICodigosConfiguracaoBoleto, ICodigosConfiguracaoImpressao, ICodigosConfiguracaoEmail, ICodigosConfiguracaoRemessa, ICodigosConfiguracaoRetorno, ICodigosConfiguracaoDocumentoCobranca
{
	protected AtributoChave contextoFebraban240;

	protected AtributoChave contextoCnab400;

	protected EnumCodigoBanco banco;

	protected EnumTipoCarteiraCobranca carteira;

	protected ArrayList tiposModelosBoleto = new ArrayList();

	protected ArrayList formatosBoleto = new ArrayList();

	protected ArrayList tiposPropaganda = new ArrayList();

	protected ArrayList tiposNomenclaturaBoleto = new ArrayList();

	protected ArrayList modosImpressao = new ArrayList();

	protected ArrayList formatosSaida = new ArrayList();

	protected ArrayList modosSaida = new ArrayList();

	protected ArrayList servidoresSMTP = new ArrayList();

	protected ArrayList layoutsArquivoRemessa = new ArrayList();

	protected ArrayList codigosMovimentoRemessaCnab400 = new ArrayList();

	protected ArrayList codigosMovimentoRemessaFebraban240 = new ArrayList();

	protected ArrayList layoutsArquivoRetorno = new ArrayList();

	protected ArrayList tiposDocumentosCobrancaFebraban240 = new ArrayList();

	protected ArrayList tiposDocumentosCobrancaCnab400 = new ArrayList();

	protected ArrayList codigosAceiteFebraban240 = new ArrayList();

	protected ArrayList codigosAceiteCnab400 = new ArrayList();

	protected ArrayList codigosDescontoFebraban240 = new ArrayList();

	protected ArrayList codigosDescontoCnab400 = new ArrayList();

	protected ArrayList codigosJurosFebraban240 = new ArrayList();

	protected ArrayList codigosJurosCnab400 = new ArrayList();

	protected ArrayList codigosProtestoFebraban240 = new ArrayList();

	protected ArrayList codigosProtestoCnab400 = new ArrayList();

	protected ArrayList codigosMoedaFebraban240 = new ArrayList();

	protected ArrayList codigosMoedaCnab400 = new ArrayList();

	protected ArrayList codigosBaixaDevolucaoFebraban240 = new ArrayList();

	protected ArrayList codigosBaixaDevolucaoCnab400 = new ArrayList();

	protected ArrayList codigosMultaFebraban240 = new ArrayList();

	protected ArrayList codigosMultaCnab400 = new ArrayList();

	protected ArrayList codigosInstrucaoCobrancaFebraban240 = new ArrayList();

	protected ArrayList codigosInstrucaoCobrancaCnab400 = new ArrayList();

	protected ArrayList modalidadesCobranca = new ArrayList();

	public ArrayList FormatosBoleto => formatosBoleto;

	public ArrayList TiposPropaganda => tiposPropaganda;

	public ArrayList TiposNomenclaturaBoleto => tiposNomenclaturaBoleto;

	public ArrayList TiposModelosBoleto => tiposModelosBoleto;

	public ArrayList ModosImpressao => modosImpressao;

	public ArrayList FormatosSaida => formatosSaida;

	public ArrayList ModosSaida => modosSaida;

	public ArrayList ServidoresSMTP => servidoresSMTP;

	public ArrayList LayoutsArquivoRemessa => layoutsArquivoRemessa;

	public ArrayList CodigosMovimentoRemessaCnab400 => codigosMovimentoRemessaCnab400;

	public ArrayList CodigosMovimentoRemessaFebraban240 => codigosMovimentoRemessaFebraban240;

	public ArrayList LayoutsArquivoRetorno => layoutsArquivoRetorno;

	public ArrayList TiposDocumentosCobrancaFebraban240 => tiposDocumentosCobrancaFebraban240;

	public ArrayList TiposDocumentosCobrancaCnab400 => tiposDocumentosCobrancaCnab400;

	public ArrayList CodigosAceiteFebraban240 => codigosAceiteFebraban240;

	public ArrayList CodigosAceiteCnab400 => codigosAceiteCnab400;

	public ArrayList CodigosDescontoFebraban240 => codigosDescontoFebraban240;

	public ArrayList CodigosDescontoCnab400 => codigosDescontoCnab400;

	public ArrayList CodigosJurosFebraban240 => codigosJurosFebraban240;

	public ArrayList CodigosJurosCnab400 => codigosJurosCnab400;

	public ArrayList CodigosProtestoFebraban240 => codigosProtestoFebraban240;

	public ArrayList CodigosProtestoCnab400 => codigosProtestoCnab400;

	public ArrayList CodigosMoedaFebraban240 => codigosMoedaFebraban240;

	public ArrayList CodigosMoedaCnab400 => codigosMoedaCnab400;

	public ArrayList CodigosBaixaDevolucaoCnab400 => codigosBaixaDevolucaoCnab400;

	public ArrayList CodigosBaixaDevolucaoFebraban240 => codigosBaixaDevolucaoFebraban240;

	public ArrayList CodigosMultaFebraban240 => codigosMultaFebraban240;

	public ArrayList CodigosMultaCnab400 => codigosMultaCnab400;

	public ArrayList CodigosInstrucaoCobrancaFebraban240 => codigosInstrucaoCobrancaFebraban240;

	public ArrayList CodigosInstrucaoCobrancaCnab400 => codigosInstrucaoCobrancaCnab400;

	public ArrayList ModalidadesCobranca => modalidadesCobranca;

	public RepositorioCodigosCobranca(EnumCodigoBanco banco, EnumTipoCarteiraCobranca carteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
	{
		this.banco = banco;
		this.carteira = carteira;
		EnumChaveContexto enumChaveContexto = ((banco != 0) ? DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(this.banco, EnumLayoutCobranca.CNAB400)) : DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(this.banco, EnumLayoutCobranca.CBR641)));
		EnumChaveContexto valor = DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(this.banco, EnumLayoutCobranca.FEBRABAN240));
		contextoFebraban240 = new AtributoChave(valor);
		contextoCnab400 = new AtributoChave(enumChaveContexto);
		PreencherConfiguracoes();
	}

	private void PreencherConfiguracoes()
	{
		PrePreenchimentoConfiguracoes();
		PreencherCodigosConfiguracaoBoleto();
		PreencherCodigosConfiguracaoDocumentoCobranca();
		PreencherCodigosConfiguracaoEmail();
		PreencherCodigosConfiguracaoImpressao();
		PreencherCodigosConfiguracaoRemessa();
		PreencherCodigosConfiguracaoRetorno();
	}

	protected virtual void PrePreenchimentoConfiguracoes()
	{
	}

	protected virtual void PreencherCodigosConfiguracaoBoleto()
	{
		tiposModelosBoleto = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoModeloBoleto, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		formatosBoleto = EnumUtil.GetEnumByAttributeToItemLista<EnumFormatoModeloBoleto, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		tiposPropaganda = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoPropaganda, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		tiposNomenclaturaBoleto = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoNomenclaturaBoleto, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
	}

	protected virtual void PreencherCodigosConfiguracaoImpressao()
	{
		modosImpressao = EnumUtil.GetEnumByAttributeToItemLista<EnumModoImpressao, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		formatosSaida = EnumUtil.GetEnumByAttributeToItemLista<EnumFormatoSaida, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		modosSaida = EnumUtil.GetEnumByAttributeToItemLista<EnumModoSaida, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
	}

	protected virtual void PreencherCodigosConfiguracaoEmail()
	{
		servidoresSMTP = EnumUtil.GetEnumByAttributeToItemLista<EnumServidorSMTP, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
	}

	protected virtual void PreencherCodigosConfiguracaoRemessa()
	{
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoFebraban240));
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(contextoCnab400));
		codigosMovimentoRemessaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoCnab400);
		codigosMovimentoRemessaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMovimentoRemessa, AtributoChave>(contextoFebraban240);
	}

	protected virtual void PreencherCodigosConfiguracaoRetorno()
	{
		layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoFebraban240));
		layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(contextoCnab400));
	}

	protected virtual void PreencherCodigosConfiguracaoDocumentoCobranca()
	{
		if (carteira != EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		{
			contextoFebraban240.Chaves = contextoFebraban240.Chaves.Concat(new Enum[1] { carteira }).ToArray();
			contextoCnab400.Chaves = contextoCnab400.Chaves.Concat(new Enum[1] { carteira }).ToArray();
		}
		tiposDocumentosCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoFebraban240);
		tiposDocumentosCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumTipoDocumentoCobranca, AtributoChave>(contextoCnab400);
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
		codigosMultaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoFebraban240);
		codigosMultaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(contextoCnab400);
		codigosInstrucaoCobrancaFebraban240 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoFebraban240);
		codigosInstrucaoCobrancaCnab400 = EnumUtil.GetEnumByAttributeToItemLista<EnumInstrucaoCobranca, AtributoChave>(contextoCnab400);
	}
}
