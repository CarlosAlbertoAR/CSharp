using System.Collections;
using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa : IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa
{
	protected ArrayList parametros;

	public ArrayList Parametros => parametros;

	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa()
	{
		parametros = new ArrayList();
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumChaveContexto.GERAL)));
	}

	public ParametroConfiguracao GeraHeaderArquivoFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_ARQUIVO_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraHeaderLoteFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_LOTE_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraSegmentoDetalhePFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_P_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraSegmentoDetalheQFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_Q_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraSegmentoDetalheRFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_R_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraTraillerLoteFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_LOTE_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraTraillerArquivoFebraban240()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_ARQUIVO_REMESSA_FEBRABAN240);
	}

	public ParametroConfiguracao GeraHeaderRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraTraillerRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_REMESSA_CNAB400);
	}

	public ParametroConfiguracao NomeArquivoRemessa()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_NOME_ARQUIVO_REMESSA);
	}

	public ParametroConfiguracao ModoHomologacao()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_MODO_HOMOLOGACAO);
	}

	public ParametroConfiguracao CodificacaoArquivoRemessa()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_CODIFICACAO_ARQUIVO_REMESSA);
	}

	public ParametroConfiguracao EnviaSegmentosAdicionaisOutrasInstrucoesRemessa()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_ENVIA_SEGMENTOS_ADICIONAIS_OUTRAS_INSTRUCOES_REMESSA);
	}
}
