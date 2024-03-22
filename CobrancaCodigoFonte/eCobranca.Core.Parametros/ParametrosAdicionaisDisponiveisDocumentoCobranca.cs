using System.Collections;
using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros;

public class ParametrosAdicionaisDisponiveisDocumentoCobranca : IParametrosAdicionaisDisponiveisDocumentoCobranca
{
	protected ArrayList parametros;

	public ArrayList Parametros => parametros;

	public ParametrosAdicionaisDisponiveisDocumentoCobranca()
	{
		parametros = new ArrayList();
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.DOCUMENTO_COBRANCA, EnumChaveContexto.GERAL)));
	}

	public ParametroConfiguracao CodigoDesconto2()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_DESCONTO2);
	}

	public ParametroConfiguracao DataDesconto2()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2);
	}

	public ParametroConfiguracao ValorDesconto2()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2);
	}

	public ParametroConfiguracao CodigoDesconto3()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_DESCONTO3);
	}

	public ParametroConfiguracao DataDesconto3()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO3);
	}

	public ParametroConfiguracao ValorDesconto3()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO3);
	}

	public ParametroConfiguracao EnderecoSacadorAvalista()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_ENDERECO_SACADOR_AVALISTA);
	}

	public ParametroConfiguracao BairroSacadorAvalista()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_BAIRRO_SACADOR_AVALISTA);
	}

	public ParametroConfiguracao CepSacadorAvalista()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CEP_SACADOR_AVALISTA);
	}

	public ParametroConfiguracao CidadeSacadorAvalista()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_CIDADE_SACADOR_AVALISTA);
	}

	public ParametroConfiguracao UfSacadorAvalista()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_UF_SACADOR_AVALISTA);
	}

	public ParametroConfiguracao Mensagem1Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM1_BOLETO);
	}

	public ParametroConfiguracao Mensagem2Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM2_BOLETO);
	}

	public ParametroConfiguracao Mensagem3Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM3_BOLETO);
	}

	public ParametroConfiguracao Mensagem4Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM4_BOLETO);
	}

	public ParametroConfiguracao Mensagem5Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM5_BOLETO);
	}

	public ParametroConfiguracao Mensagem6Boleto()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM6_BOLETO);
	}
}
