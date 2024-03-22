using System;
using eCobranca.Core.Carteira;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesCarteiraCobranca
{
	public ExcecaoGenerica CarteiraCobrancaNaoEncontradoOuInexistente(string nomeAbsolutoCarteiraCobranca, Exception e)
	{
		return new ExcecaoGenerica(1, $"Arquivo de carteira de cobrança [{nomeAbsolutoCarteiraCobranca}] não encontrado ou inexistente.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica ImpossivelCarregarCarteiraCobranca(string nomeAbsolutoCarteiraCobranca, Exception e)
	{
		return new ExcecaoGenerica(2, $"Impossível efetuar a leitura do arquivo de carteira de cobrança [{nomeAbsolutoCarteiraCobranca}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica ImpossivelDescriptografarArquivoCarteiraCobranca(Exception e)
	{
		return new ExcecaoGenerica(3, $"Impossível descriptografar o arquivo de carteira de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpossivelDeserializarArquivoCarteiraCobranca(Exception e)
	{
		return new ExcecaoGenerica(4, $"Impossível deserializar o arquivo de carteira de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoCarteiraCobrancaInexistente(Exception e)
	{
		return new ExcecaoGenerica(5, $"Instância de configuração de carteira de cobrança nula.", e, EnumCategoriaExcecao.REGRA_NEGOCIO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoCarteiraCobranca(ConfiguracaoCarteiraCobranca config, Exception e)
	{
		return new ExcecaoGenerica(6, $"Impossível criar objeto de carteira de cobrança para a carteira [{config.TipoCarteiraCobranca}].", e, EnumCategoriaExcecao.REGRA_NEGOCIO, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica ImpossivelSerializarArquivoCarteiraCobranca(Exception e)
	{
		return new ExcecaoGenerica(7, $"Impossível serializar o arquivo de carteira de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpossivelSalvarArquivoCarteiraCobranca(string nomeAbsolutoCarteiraCobranca, Exception e)
	{
		return new ExcecaoGenerica(8, $"Impossível salvar arquivo de cobrança [{nomeAbsolutoCarteiraCobranca}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica CarteiraCobrancaNula(Exception e)
	{
		return new ExcecaoGenerica(9, $"Instância de carteira de cobrança nula.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica FalhaCarregandoCarteiraCobranca(string codigoCarteira, Exception e)
	{
		return new ExcecaoGenerica(10, $"Não foi possível carregar o arquivo de carteira de cobrança [{codigoCarteira}] a partir do arquivo de configuração.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaAoCriarFabricaCarteiraCobranca(Exception e)
	{
		return new ExcecaoGenerica(11, $"Não foi possível criar a fábrica de instâncias de carteira de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica CodigoCarteiraCobrancaNaoDefinidoOuInvalido()
	{
		return new ExcecaoGenerica(12, $"Código da carteira de cobrança não definido ou inválido.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoDadosBoleto(Exception e)
	{
		return new ExcecaoGenerica(13, $"Falha calculando dados do(s) boleto(s).", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoBoletos(Exception e)
	{
		return new ExcecaoGenerica(14, $"Falha gerando boleto(s).", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInicializandoCarteiraCobranca(Exception e)
	{
		return new ExcecaoGenerica(15, $"Falha inicializando carteira de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoArquivoRemessa(Exception e)
	{
		return new ExcecaoGenerica(16, $"Falha carregando configuração de arquivo de remessa.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoArquivoRetorno(Exception e)
	{
		return new ExcecaoGenerica(17, $"Falha carregando configuração de arquivo de retorno.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoDocumentoCobranca(Exception e)
	{
		return new ExcecaoGenerica(18, $"Falha carregando configuração de documento de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoCodigoBarrasDocumentoCobranca(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(19, $"Falha gerando o código de barras do documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoModeloBoleto(string modelo, Exception e)
	{
		return new ExcecaoGenerica(20, $"Falha obtendo modelo de boleto [{modelo}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoDVCodigoBarrasDocumentoCobranca(string codigoBarras, Exception e)
	{
		return new ExcecaoGenerica(21, $"Falha gerando o dígito verificador (DV) do código de barras [{codigoBarras}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoFatorVencimento(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(22, $"Falha gerando fator de vencimento do documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpossivelCalcularFatorVencimento(DocumentoCobranca dc)
	{
		return new ExcecaoGenerica(23, $"Impossível calcular fator de vencimento pois data de vencimento do documento de cobrança [{dc.NumeroDocumento}] está nula.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoNossoNumeroCompletoDocumentoCobranca(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(24, string.Format("Falha gerando nosso número completo para o documento de cobrança [{1}].", dc.NumeroDocumento), e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSalvandoAlteracoesCarteiraCobranca(CarteiraCobranca carteira, Exception e)
	{
		return new ExcecaoGenerica(25, string.Format("Falha salvando alterações na carteira de cobranca [{1}].", carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca), e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ArquivoCarteiraCobrancaNuloOuVazio()
	{
		return new ExcecaoGenerica(26, $"Propriedade ArquivoCarteiraCobranca nula ou em braco.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ArquivoCarteiraCobrancaNaoExiste()
	{
		return new ExcecaoGenerica(27, $"Arquivo de cobrança informado não existe.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoCarteiraCobrancaNula()
	{
		return new ExcecaoGenerica(28, $"Configuração de carteira de cobrança nula.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoBoletoNula()
	{
		return new ExcecaoGenerica(29, $"Configuração de boleto nula.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoArquivoRemessaNula()
	{
		return new ExcecaoGenerica(30, $"Configuração de arquivo de remessa nula.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoArquivoRetornoNula()
	{
		return new ExcecaoGenerica(31, $"Configuração de arquivo de retorno nula.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConfiguracaoDocumentoCobrancaNula()
	{
		return new ExcecaoGenerica(32, $"Configuracao de documento de cobranca nula.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ContratoNulo()
	{
		return new ExcecaoGenerica(33, $"Contrato nulo.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoBoleto(Exception e)
	{
		return new ExcecaoGenerica(34, $"Falha carregando configuração de boleto de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoNossoNumeroSemDV(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(35, $"Falha gerando nosso número sem dígito verificador para o documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoCampoLivre(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(36, $"Falha gerando campo livre para o documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoLinhaDigitavel(DocumentoCobranca dc, Exception e)
	{
		return new ExcecaoGenerica(37, $"Falha gerando linha digitável para o documento de cobrança [{dc.NumeroDocumento}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoDVCampoLinhaDigitavel(string campo, Exception e)
	{
		return new ExcecaoGenerica(38, $"Falha calculando DV do campo [{campo}] da linha digitável.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoArquivoRemessaFebraban240(Exception e)
	{
		return new ExcecaoGenerica(39, $"Falha gerando arquivo de remessa Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoFebraban240(Exception e)
	{
		return new ExcecaoGenerica(40, $"Falha carregando arquivo de retorno Febraban240.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoArquivoRemessaCnab400(Exception e)
	{
		return new ExcecaoGenerica(41, $"Falha gerando arquivo de remessa Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoCnab400(Exception e)
	{
		return new ExcecaoGenerica(42, $"Falha carregando arquivo de retorno Cnab400.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculadoDVNossoNumeroDocumentoCobranca(string nossoNumero, Exception e)
	{
		return new ExcecaoGenerica(43, $"Falha calculando o dígito verificador (DV) do nosso número [{nossoNumero}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoDVModulo10(string campo, Exception e)
	{
		return new ExcecaoGenerica(44, $"Falha calculando o dígito verificador (DV) no módulo10 [{campo}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoDVModulo11(string campo, Exception e)
	{
		return new ExcecaoGenerica(45, $"Falha calculando o dígito verificador (DV) no módulo11 [{campo}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoImpressao(Exception e)
	{
		return new ExcecaoGenerica(46, $"Falha carregando configuração para impressão de documentos de cobranca.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro()
	{
		return new ExcecaoGenerica(47, $"Não é permitida a geração de arquivo de remessa para carteira de cobrança sem registro.", null, EnumCategoriaExcecao.REGRA_NEGOCIO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaEnviandoBoletosParaImpressao(Exception e)
	{
		return new ExcecaoGenerica(48, $"Falha enviando boletos para a impressão.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetornoFebraban150(Exception e)
	{
		return new ExcecaoGenerica(49, $"Falha carregando arquivo de retorno Febraban150.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RetornoFebraban240NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(50, $"Carregamento de arquivo de retorno no layout Febraban240 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RetornoCnab400NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(51, $"Carregamento de arquivo de retorno no layout CNAB400 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RetornoFebraban150NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(52, $"Carregamento de arquivo de retorno no layout Febraban240 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RemesssaFebraban150NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(53, $"Carregamento de arquivo de retorno no layout Febraban150 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RemesssaFebraban240NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(54, $"Carregamento de arquivo de retorno no layout Febraban240 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica RemesssaCnab400NaoImplementadoParaCarteira()
	{
		return new ExcecaoGenerica(55, $"Carregamento de arquivo de retorno no layout Cnab400 não disponível para essa carteira de cobrança.", null, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoNomeArquivoRemessa(Exception e)
	{
		return new ExcecaoGenerica(56, $"Falha gerando o nome do arquivo de remessa.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoPreview(Exception e)
	{
		return new ExcecaoGenerica(57, $"Falha gerando preview.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoConfiguracaoEmail(Exception e)
	{
		return new ExcecaoGenerica(58, $"Falha carregando configuração de email.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica VersaoCarteiraCobrancaIncompativel(string versaoECobranca, string versaoCarteira)
	{
		return new ExcecaoGenerica(59, $"A versão da carteira de cobrança [{versaoCarteira}] é incompatível com a versão utilizada do eCobrança [{versaoECobranca}]. Favor utilizar a carteira de cobrança na versão [{versaoECobranca}]", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica DataVigenciaExpirada(DateTime dataVigencia)
	{
		return new ExcecaoGenerica(60, $"Data limite de vigência [{dataVigencia.ToShortDateString()}] expirada para utilização do eCobrança. Favor renovar a licença de uso do eCobrança para ter acessos as suas funcionalidades.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaValidandoCarteira(Exception e)
	{
		return new ExcecaoGenerica(61, $"Falha validando carteira de cobranca.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica LimiteSequencialNossoNumeroAtingido(string sequencia)
	{
		return new ExcecaoGenerica(62, string.Format("O limite sequencial (" + sequencia + ") para a geração do nosso número foi atingida. Favor rever a configuração"), null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoPrimeiroDVChaveASBACE(string chaveASBACE, Exception e)
	{
		return new ExcecaoGenerica(63, $"Falha calculando o primeiro dígito verificador (DV) da chave ASBACE [{chaveASBACE}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCalculandoSegundoDVChaveASBACE(string chaveASBACE, Exception e)
	{
		return new ExcecaoGenerica(64, $"Falha calculando o segundo dígito verificador (DV) da chave ASBACE [{chaveASBACE}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}
}
