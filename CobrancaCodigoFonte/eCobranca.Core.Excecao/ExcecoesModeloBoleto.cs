using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesModeloBoleto
{
	public ExcecaoGenerica FalhaCriandoArquivoCobrancaDeRetorno(Exception e)
	{
		return new ExcecaoGenerica(4000, $"Falha criando arquivo de cobrança de retorno.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoFabricaModeloBoleto(Exception e)
	{
		return new ExcecaoGenerica(4001, $"Falha criando fábrica de modelo de boleto.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoModeloBoleto(string modelo, Exception e)
	{
		return new ExcecaoGenerica(4002, $"Falha obtendo modelo de boleto [{modelo}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoCamposModeloBoleto(Exception e)
	{
		return new ExcecaoGenerica(4003, $"Falha obtendo campos do modelo do boleto.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoValorParaCampoModeloBoleto(string campo, Exception e)
	{
		return new ExcecaoGenerica(4004, $"Falha obtendo valor para o campo [{campo}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoCamposModeloEstruturalBoleto(Exception e)
	{
		return new ExcecaoGenerica(4005, $"Falha obtendo campos do modelo estrutural do boleto.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoCodigoBarrasI25(Exception e)
	{
		return new ExcecaoGenerica(4006, $"Falha criando código de barras padrão I25.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoModeloBoleto(Exception e)
	{
		return new ExcecaoGenerica(4007, $"Falha inicializando modelo de boleto.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaMontandoModeloBoleto(Exception e)
	{
		return new ExcecaoGenerica(4008, $"Falha montando modelo do boleto.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoBoletoParaDocumentoCobranca(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(4009, $"Falha gerando boleto para documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarHeaderArquivoRetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4010, $"Falha executando comando para carregar Header de arquivo de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarHeaderLoteRetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4011, $"Falha executando comando para carregar Header de arquivo de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarSegmentoTRetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4012, $"Falha executando comando para carregar Segmento de Detalhe T de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarSegmentoURetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4013, $"Falha executando comando para carregar Segmento de Detalhe U de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarTraillerArquivoRetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4014, $"Falha executando comando para carregar Trailler de arquivo de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarTraillerLoteRetornoFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4015, $"Falha executando comando para carregar Trailler de lote de arquivo de retorno Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4016, $"Falha executando comando para gerar Header de Arquivo de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4017, $"Falha executando comando para gerar Header de Lote de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4018, $"Falha executando comando para gerar Segmento de Detalhe P de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarSegmentoQRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4019, $"Falha executando comando para gerar Segmento de Detalhe Q de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarSegmentoRRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4020, $"Falha executando comando para gerar Segmento de Detalhe R de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarTraillerArquivoRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4021, $"Falha executando comando para gerar Trailler de arquivo de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarTraillerLoteRemessaFebraban240(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4022, $"Falha executando comando para gerar Trailler de Lote de remessa Febraban240 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica TipoModeloBoletoNaoEspecificadoOuNulo()
	{
		return new ExcecaoGenerica(4023, $"Tipo de modelo especificado vazio ou nulo.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4024, $"Falha executando comando para gerar Header de Arquivo de remessa Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4025, $"Falha executando comando para gerar Trailler de Arquivo de remessa Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4026, $"Falha executando comando para gerar Detalhe de Arquivo de remessa Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoGerarMensagemArquivoRemessaCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4027, $"Falha executando comando para gerar Mensagem de Arquivo de remessa Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarHeaderArquivoRetornoCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4028, $"Falha executando comando para carregar Header de arquivo de retorno Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4029, $"Falha executando comando para carregar Trailler de arquivo de retorno Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarSegmentoDetalheRetornoCNAB400(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4030, $"Falha executando comando para carregar Segmento de Detalhe de retorno Cnab400 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarHeaderArquivoRetornoFebraban150(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4031, $"Falha executando comando para carregar Header de arquivo de retorno Febraban150 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarSegmentoGRetornoFebraban150(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4032, $"Falha executando comando para carregar Segmento de Detalhe G de retorno Febraban150 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExecutandoComandoCarregarTraillerArquivoRetornoFebraban150(EnumCodigoBanco banco, Exception e)
	{
		return new ExcecaoGenerica(4033, $"Falha executando comando para carregar Trailler de arquivo de retorno Febraban150 do [{banco}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}
}
