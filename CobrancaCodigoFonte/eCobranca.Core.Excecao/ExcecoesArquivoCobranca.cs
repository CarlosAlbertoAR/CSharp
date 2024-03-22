using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesArquivoCobranca
{
	public ExcecaoGenerica FalhaCriandoFabricaArquivoCobranca(Exception e)
	{
		return new ExcecaoGenerica(5000, $"Falha criando fábrica de arquivo de cobrança.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaCriandoArquivoCobrancaDeRemessa(string layoutRemessa, Exception e)
	{
		return new ExcecaoGenerica(5001, $"Falha criando arquivo de cobrança de remessa no layout [{layoutRemessa}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaCriandoArquivoCobrancaDeRetorno(string layoutRetorno, Exception e)
	{
		return new ExcecaoGenerica(5002, $"Falha criando arquivo de cobrança de retorno no layout [{layoutRetorno}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaCriandoFabricaSegmentoDetalheFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5003, $"Falha criando fábrica de segmento de detalhe Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoSegmentoDetalheFebraban240(string segmento, Exception e)
	{
		return new ExcecaoGenerica(5004, $"Falha criando [{segmento}] de detalhe Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoHeaderArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5005, $"Falha inicializando Header de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroHeaderArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5006, $"Falha gerando registro Header de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroHeaderArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5007, $"Falha carregando registro Header de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroHeaderArquivoNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5008, $"Registro Header de Arquivo não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoHeaderLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5009, $"Falha inicializando registro Header de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroHeaderLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5010, $"Falha gerando registro Header de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroHeaderLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5011, $"Falha carregando registro Header de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroHeaderLoteNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5012, $"Registro Header de Lote não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoBaseDetalheFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5013, $"Falha inicializando Segmento Base de Detalhe Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoBaseDetalheOpcionalFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5014, $"Falha inicializando Segmento Base de Detalhe Opcional Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoPFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5015, $"Falha inicializando Segmento de Detalhe P Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroSegmentoPFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5016, $"Falha gerando registro do Segmento de Detalhe P Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoQFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5017, $"Falha inicializando Segmento de Detalhe Q Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroSegmentoQFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5018, $"Falha gerando registro do Segmento de Detalhe Q Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoRFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5019, $"Falha inicializando Segmento de Detalhe R Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroSegmentoRFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5020, $"Falha gerando registro do Segmento de Detalhe R Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoSFebraban240Impressao(Exception e)
	{
		return new ExcecaoGenerica(5021, $"Falha inicializando Segmento de Detalhe S Impressão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoSFebraban240ImpressaoTipo1e2(Exception e)
	{
		return new ExcecaoGenerica(5021, $"Falha inicializando Segmento de Detalhe S Impressão Tipo 1 e 2 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoSFebraban240ImpressaoTipo3(Exception e)
	{
		return new ExcecaoGenerica(5021, $"Falha inicializando Segmento de Detalhe S Impressão Tipo 3 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoTFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5022, $"Falha inicializando Segmento de Detalhe T Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroSegmentoTFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5023, $"Falha carregando registro do Segmento de Detalhe T Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroSegmentoTNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5024, $"Registro Segmento T não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoUFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5025, $"Falha inicializando Segmento de Detalhe U Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroSegmentoUFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5026, $"Falha carregando registro do Segmento de Detalhe U Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroSegmentoUNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5027, $"Registro Segmento U não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoY01Febraban240(Exception e)
	{
		return new ExcecaoGenerica(5028, $"Falha inicializando Segmento de Detalhe Y01 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoY04Febraban240(Exception e)
	{
		return new ExcecaoGenerica(5029, $"Falha inicializando Segmento de Detalhe Y04 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoY05Febraban240(Exception e)
	{
		return new ExcecaoGenerica(5030, $"Falha inicializando Segmento de Detalhe Y05 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoY50Febraban240(Exception e)
	{
		return new ExcecaoGenerica(5031, $"Falha inicializando Segmento de Detalhe Y50 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoY51Febraban240(Exception e)
	{
		return new ExcecaoGenerica(5032, $"Falha inicializando Segmento de Detalhe Y51 Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoTraillerArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5033, $"Falha inicializando Trailler de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroTraillerArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5034, $"Falha gerando registro Trailler de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroTraillerArquivoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5035, $"Falha carregando registro Trailler de Arquivo Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroTraillerArquivoNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5036, $"Registro Trailler de Arquivo não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoTraillerLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5037, $"Falha inicializando Trailler de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroTraillerLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5038, $"Falha gerando registro Trailler de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroTraillerLoteFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5039, $"Falha carregando registro Trailler de Lote Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroTraillerLoteNaoAtendeAoPadraoFebraban240()
	{
		return new ExcecaoGenerica(5040, $"Registro Trailler de Lote não atende ao padrão Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoArquivoCobrancaRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5041, $"Falha na inicialização do arquivo de cobrança de remessa no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoNovoLoteRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5042, $"Falha criando novo lote no arquivo de remessa no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5043, $"Falha gerando arquivo de remessa no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaInicializandoLoteCobrancaRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5044, $"Falha ao iniciar lote de cobrança de remessa no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoNovoSegmentoDetalheRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5045, $"Falha criando novo segmento de detalhe de remessa no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoArquivoCobrancaRetornoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5046, $"Falha ao iniciar arquivo de cobrança de retorno no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5047, $"Falha ao carregar arquivo de retorno no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaObtendoMotivosOcorrenciaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5048, $"Falha obtendo motivos de ocorrência do padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoLoteCobrancaRetornoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5049, $"Falha ao iniciar lote de cobrança de retorno no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoNovoSegmentoDetalheRetornoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5050, $"Falha criando novo segmento de detalhe de retorno no padrão Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRegistroHeaderArquivoRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5051, $"Falha gerando registro Header de Arquivo de remessa Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RegistroHeaderArquivoRemessaNaoAtendeAoPadraoCnab400()
	{
		return new ExcecaoGenerica(5052, $"Registro Header de Arquivo de remessa não atende ao padrão Cnab400.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoRemessaCnab400(string segmento, Exception e)
	{
		return new ExcecaoGenerica(5053, $"Falha na inicialização do segmento [{segmento}] de remessa Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoRegistroSegmentoCnab400(string segmento, Exception e)
	{
		return new ExcecaoGenerica(5054, $"Falha carregando registro [{segmento}] de retorno Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoArquivoCobrancaRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5055, $"Falha na inicialização do arquivo de cobrança de remessa no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoLoteCobrancaRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5056, $"Falha ao iniciar lote de cobrança de remessa no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoLoteRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5057, $"Falha criando lote no arquivo de remessa no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoFabricaSegmentoDetalheCnab400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(5058, $"Falha criando fábrica de segmento de detalhe Cnab400 para o banco [{banco.ToString()}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoSegmentoDetalheCnab400(string segmento, Exception e)
	{
		return new ExcecaoGenerica(5059, $"Falha criando [{segmento}] de detalhe Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoNovoSegmentoDetalheRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5060, $"Falha criando novo segmento de detalhe de remessa no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica LimiteCaracteresExcedidoParaPropriedade(string nomePropriedade, int max)
	{
		return new ExcecaoGenerica(5061, $"Limite de [{max}] caracteres excedido para a propriedade [{nomePropriedade}].", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5062, $"Falha gerando arquivo de remessa no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoRetornoCnab400(string segmento, Exception e)
	{
		return new ExcecaoGenerica(5063, $"Falha na inicialização do segmento [{segmento}] de retorno Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoLoteCobrancaRetornoCnab400(Exception e)
	{
		return new ExcecaoGenerica(5064, $"Falha ao iniciar lote de cobrança de retorno no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoArquivoCobrancaRetornoCnab400(Exception e)
	{
		return new ExcecaoGenerica(5065, $"Falha na inicialização do arquivo de cobrança de retorno no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoCnab400(Exception e)
	{
		return new ExcecaoGenerica(5066, $"Falha ao carregar arquivo de retorno no padrão Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaGerandoRegistrosDoLoteRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(5067, $"Falha gerando registros do lote da remessa Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaGerandoSegmentoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(5068, $"Falha gerando segmentos do layout Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica RegistroNaoAtendeAoLayoutFebraban240()
	{
		return new ExcecaoGenerica(5069, $"Registro não atende ao layout do Febraban240.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoFabricaSegmentoDetalheFebraban150(Exception e)
	{
		return new ExcecaoGenerica(5070, $"Falha criando fábrica de segmento de detalhe Febraban150.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoSegmentoBaseDetalheFebraban150(Exception e)
	{
		return new ExcecaoGenerica(5071, $"Falha inicializando Segmento Base de Detalhe Febraban150.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoFebraban150(Exception e)
	{
		return new ExcecaoGenerica(5072, $"Falha ao carregar arquivo de retorno no padrão Febraban150.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}
}
