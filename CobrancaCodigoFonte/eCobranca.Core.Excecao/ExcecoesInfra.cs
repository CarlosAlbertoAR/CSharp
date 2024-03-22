using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesInfra
{
	public ExcecaoGenerica ImpossivelEscreverArquivoEmDisco(string nomeAbsolutoArquivo, Exception e)
	{
		return new ExcecaoGenerica(1000, $"Impossível escrever o arquivo [{nomeAbsolutoArquivo}] em disco.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpossivelLerBytesDeArquivo(string nomeAbsolutoArquivo, Exception e)
	{
		return new ExcecaoGenerica(1001, $"Impossível ler os bytes do arquivo [{nomeAbsolutoArquivo}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpossivelCriarPdfAPartirDeArquivoHtml(Exception e)
	{
		return new ExcecaoGenerica(1002, $"Impossível criar arquivo pdf a partir de arquivo html informado.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaRemovendoMascaramento(string valorMascarado, Exception e)
	{
		return new ExcecaoGenerica(1003, $"Falha ao remover máscara da string [{valorMascarado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaIncrementandoString(string str, long valorInicial, long valorFinal, string mascara, Exception e)
	{
		return new ExcecaoGenerica(1004, $"Falha ao incrementar string [{str}] com valor inicial [{valorInicial}], valor final [{valorFinal}] e máscara [{mascara}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaAdicionandoZerosAEsquerda(string str, int tamanho, Exception e)
	{
		return new ExcecaoGenerica(1005, $"Falha ao adicionar zeros à esquerda para a string [{str}] de tamanho [{tamanho}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoStringComBrancos(int tamanho, Exception e)
	{
		return new ExcecaoGenerica(1006, $"Falha ao criar string com brancos de tamanho [{tamanho}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoValorDeStringMascarada(string strMascarada, int nivel, Exception e)
	{
		return new ExcecaoGenerica(1007, $"Falha ao obter valor da string mascarada [{strMascarada}] no nível [{nivel}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaFormatandoValorNumericoParaStringDeTamanhoDefinido(double valor, int tamanho, Exception e)
	{
		return new ExcecaoGenerica(1008, $"Falha formatando valor [{valor}] para uma string de tamanho [{tamanho}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoStreamParaString(Exception e)
	{
		return new ExcecaoGenerica(1009, $"Falha convertendo Stream para String.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInstanciandoClasse(string nomeClasse, Exception e)
	{
		return new ExcecaoGenerica(1010, $"Falha instanciando objeto da classe [{nomeClasse}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCodificandoCodigoBarras(string valor, Exception e)
	{
		return new ExcecaoGenerica(1011, $"Falha codificando valor [{valor}] para o padrão Intervaled2of5.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoRepresentacaoHtmlCodigoBarras(string valor, Exception e)
	{
		return new ExcecaoGenerica(1012, $"Falha ao obter representação html do código de barras [{valor}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoDescricaoDeValorEnumerado(string valorEnumerado, Exception e)
	{
		return new ExcecaoGenerica(1013, $"Falha ao obter descrição do enumerado [{valorEnumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoNomesDeEnumerado(string enumerado, Exception e)
	{
		return new ExcecaoGenerica(1014, $"Falha ao obter lista de nomes do enumerado [{enumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoNomeDeEnumeradoPeloValor(string enumerado, string valor, Exception e)
	{
		return new ExcecaoGenerica(1015, $"Falha ao obter nome para o valor [{valor}] do enumerado [{enumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoEnumeradoPeloValor(string enumerado, string valor, Exception e)
	{
		return new ExcecaoGenerica(1016, $"Falha ao obter enumerado [{enumerado}] pelo valor [{valor}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaDescriptografandoString(Exception e)
	{
		return new ExcecaoGenerica(1017, $"Falha ao descriptografar string.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriptografandoString(Exception e)
	{
		return new ExcecaoGenerica(1018, $"Falha ao criptografar string.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSerializandoObjetoParaArrayBytes(string className, Exception e)
	{
		return new ExcecaoGenerica(1019, $"Falha ao serializar o objeto do tipo [{className}] para um array de bytes.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaDeserializandoArrayBytesParaObjeto(string className, Exception e)
	{
		return new ExcecaoGenerica(1020, $"Falha ao deserializar array de bytes para objeto do tipo [{className}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSerializandoObjetoParaString(string className, Exception e)
	{
		return new ExcecaoGenerica(1021, $"Falha ao serializar objeto do tipo [{className}] para uma string.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaDeserializandoStringParaObjeto(Exception e)
	{
		return new ExcecaoGenerica(1022, $"Falha ao deserializar string para objeto.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSerializandoObjetoParaStringCriptografada(string className, Exception e)
	{
		return new ExcecaoGenerica(1023, $"Falha serializando objeto do tipo [{className}] para string criptografada.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaDeserializandoStringCriptografadaParaObjeto(Exception e)
	{
		return new ExcecaoGenerica(1024, $"Falha deserializando string criptografada para objeto.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoDataParaCampoRemessa(string valor, Exception e)
	{
		return new ExcecaoGenerica(1025, $"Falha convertendo data [{valor}] para string no formato utilizado na remessa.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoCampoRetornoParaData(string valor, Exception e)
	{
		return new ExcecaoGenerica(1026, $"Falha convertendo campo de arquivo retorno [{valor}] para Data.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica DataInvalidaParaConversao()
	{
		return new ExcecaoGenerica(1027, $"Data inválida para conversão.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoValorMonetarioParaCampoRemessa(string valor, Exception e)
	{
		return new ExcecaoGenerica(1028, $"Falha convertendo valor monetário [{valor}] para string no formato utilizado na remessa.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoCampoRetornoParaValorMonetario(string valor, Exception e)
	{
		return new ExcecaoGenerica(1029, $"Falha convertendo campo de arquivo retorno [{valor}] para valor monetário.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorMonetarioInvalidoParaConversao()
	{
		return new ExcecaoGenerica(1030, $"Valor monetário inválido para conversão.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoInteiroParaCampoRemessa(string valor, Exception e)
	{
		return new ExcecaoGenerica(1031, $"Falha convertendo valor inteiro [{valor}] para string no formato utilizado na remessa.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoCampoRetornoParaInteiro(string valor, Exception e)
	{
		return new ExcecaoGenerica(1032, $"Falha convertendo campo de arquivo retorno [{valor}] para inteiro.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica InteiroInvalidoParaConversao()
	{
		return new ExcecaoGenerica(1033, $"Inteiro inválido para conversão.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoHoraParaCampoRemessa(string valor, Exception e)
	{
		return new ExcecaoGenerica(1034, $"Falha convertendo hora [{valor}] para string no formato utilizado na remessa.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoCampoRetornoParaHora(string valor, Exception e)
	{
		return new ExcecaoGenerica(1035, $"Falha convertendo campo de arquivo retorno [{valor}] para hora.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica HoraInvalidaParaConversao()
	{
		return new ExcecaoGenerica(1036, $"Hora inválida para conversão.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoValorFormatadoCampoDocumentoCobranca(string campo, string tipo, Exception e)
	{
		return new ExcecaoGenerica(1037, $"Falha obtendo valor formatado para o campo [{campo}] do tipo [{tipo}].", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoDicionarioDados(string nomeDicionario, Exception e)
	{
		return new ExcecaoGenerica(1038, $"Falha criando dicionário de dados [{nomeDicionario}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorInvalidoInformadoParaPropriedade(string nomePropriedade, Exception e)
	{
		return new ExcecaoGenerica(1039, $"Valor inválido informado para a propriedade [{nomePropriedade}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGenericaDetectada(Exception e)
	{
		return new ExcecaoGenerica(1040, $"Falha genérica detectada.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.ERROR);
	}

	public ExcecaoGenerica ValorNuloInformadoParaPropriedade(string nomePropriedade, Exception e)
	{
		return new ExcecaoGenerica(1041, $"Valor nulo informado para a propriedade [{nomePropriedade}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica DiretorioInformadoNaoExiste(string diretorio)
	{
		return new ExcecaoGenerica(1042, $"Diretório [{diretorio}] não existe.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ArquivoInformadoNaoExiste(string arquivo)
	{
		return new ExcecaoGenerica(1043, $"Arquivo [{arquivo}] não existe.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FuncionalidadeNaoImplementadaAinda(string funcionalidade)
	{
		return new ExcecaoGenerica(1044, $"Funcionalidade [{funcionalidade}] ainda não implementada.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaEscrevendoStringEmArquivo(string arquivo, Exception e)
	{
		return new ExcecaoGenerica(1045, $"Falha escrevendo string no arquivo [{arquivo}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaLendoStringEmArquivo(string arquivo, Exception e)
	{
		return new ExcecaoGenerica(1046, $"Falha lendo string no arquivo [{arquivo}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorInformadoNaoEEnumeradoValido(string nomeEnumerado)
	{
		return new ExcecaoGenerica(1047, $"Valor informado [{nomeEnumerado}] não é um enumerado válido.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorInformadoNaoObedeceMascara(string nomePropriedade, string mascara, string valorMascarado)
	{
		return new ExcecaoGenerica(1048, $"Valor informado [{valorMascarado}] não obedece máscara [{mascara}] da propriedade [{nomePropriedade}].", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaValidandoValorDadoConfiguracao(string nomePropriedade, string mascara, string valorMascarado, Exception e)
	{
		return new ExcecaoGenerica(1049, $"Falha validando valor informado [{valorMascarado}] da propriedade [{nomePropriedade}] com a máscara definida [{mascara}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaRegistrandoObservador(string nomeObservador, Exception e)
	{
		return new ExcecaoGenerica(1050, $"Falha registrando observador [{nomeObservador}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaRemovendoObservador(string nomeObservador, Exception e)
	{
		return new ExcecaoGenerica(1051, $"Falha removendo observador [{nomeObservador}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ObservadorNaoAtendeANenhumTipoDeNotificacao(string nomeObservador)
	{
		return new ExcecaoGenerica(1052, $"Observador [{nomeObservador}] não atende a nenhum tipo de notificação.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ObservadorJaRegistrado(string nomeObservador)
	{
		return new ExcecaoGenerica(1053, $"Observador [{nomeObservador}] já está registrado.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica EventoDeNotificacaoNulo(string nomeObservavel)
	{
		return new ExcecaoGenerica(1054, $"Evento de notificação está nulo no observável [{nomeObservavel}].", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoListaDeImpressorasInstaladas(Exception e)
	{
		return new ExcecaoGenerica(1055, $"Falha obtendo lista de impressoras instaladas.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ImpressoraSelecionadaInvalidaOuIndisponivel(string nomeImpressora)
	{
		return new ExcecaoGenerica(1056, $"A impressora selecionada [{nomeImpressora}] não é válida ou está indisponível no momento.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCombinandoArrayDeBytes(Exception e)
	{
		return new ExcecaoGenerica(1057, $"Falha combinando arrays de bytes.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ProgramaLeitorPdfInvalido(string programa)
	{
		return new ExcecaoGenerica(1058, $"O programa informado para leitura de arquivos pdf [{programa}] é inválido.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaEnviandoDocumentoPdsParaImpressao(string nomeDocumento, Exception e)
	{
		return new ExcecaoGenerica(1059, $"Falha enviando documento [{nomeDocumento}] para impressão.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaLocalizandoArquivo(string arquivo, Exception e)
	{
		return new ExcecaoGenerica(1060, $"Falha localizando arquivo [{arquivo}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaAcessandoDiretorio(Exception e)
	{
		return new ExcecaoGenerica(1061, $"Falha acessando diretório. Acesso negado.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConcatenandoImagens(Exception e)
	{
		return new ExcecaoGenerica(1062, $"Falha concatenando imagens.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaVerificandoExistenciaDeMascaramento(string campo, Exception e)
	{
		return new ExcecaoGenerica(1063, $"Falha verificando existência de mascaramento para o valor [{campo}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica NumeroInscricaoCnpjInvalido(string cnpj)
	{
		return new ExcecaoGenerica(1064, $"Número de cnpj inválido [{cnpj}] por não obedecer o padrão de 14 dígitos.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica NumeroInscricaoCpfInvalido(string cpf)
	{
		return new ExcecaoGenerica(1065, $"Número de cpf inválido [{cpf}] por não obedecer o padrão de 11 dígitos.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica CepInvalido(string cep)
	{
		return new ExcecaoGenerica(1066, $"Número do cep informado [{cep}] é inválido por não obedecer o padrão de 8 dígitos.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorDeParametroAdicionalInvalido(string valor, string nome)
	{
		return new ExcecaoGenerica(1067, $"O valor informado [{valor}] para o parâmetro adicional de configuração [{nome}] é inválido.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ValorInformadoDeEnumeradoInvalido(string valor, string enumerado)
	{
		return new ExcecaoGenerica(1068, $"O valor informado [{valor}] não pertence ao enumerado [{enumerado}].", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaValidandoAtributoDeEnumerado(string classeAtributo, Exception e)
	{
		return new ExcecaoGenerica(1069, $"Falha validando atributo [{classeAtributo}] de enumerado.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(string codigoDominio, string tipoEnumerado, Exception e)
	{
		return new ExcecaoGenerica(1070, $"Falha ao obter descrição do enumerado [{tipoEnumerado}] para o código de domínio [{codigoDominio}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaLendoPropriedade(string nomePropriedade, Exception e)
	{
		return new ExcecaoGenerica(1071, $"Falha lendo propriedade [{nomePropriedade}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConfigurandoPropriedade(string nomePropriedade, Exception e)
	{
		return new ExcecaoGenerica(1072, $"Falha configurando propriedade [{nomePropriedade}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoAtributoDeValorEnumerado(string valorEnumerado, string enumerado, Exception e)
	{
		return new ExcecaoGenerica(1073, $"Falha obtendo atributo do valor [{valorEnumerado}] do enumerado [{enumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoStringParaValorEnumerado(string str, string enumerado, Exception e)
	{
		return new ExcecaoGenerica(1074, $"Falha convertendo string [{str}] para valor válido do enumerado [{enumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaVerificandoDefinicaoEmEnumerado(string str, string enumerado, Exception e)
	{
		return new ExcecaoGenerica(1075, $"Falha verificando existência do valor [{str}] no enumerado [{enumerado}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaConvertendoTaxaDeJurosDiariaParaMensal(Exception e)
	{
		return new ExcecaoGenerica(1076, $"Falha convertendo taxa de juros diária para mensal.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaAplicandoMascaramento(string valorSemMascara, string mascara, Exception e)
	{
		return new ExcecaoGenerica(1077, $"Falha aplicando máscara [{mascara}] no valor [{valorSemMascara}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica MascaraInvalidaParaValorInformado(string valor, string mascara)
	{
		return new ExcecaoGenerica(1078, $"Máscara inválida [{mascara}] para valor informado [{valor}].", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaValidandoEmail(string email, Exception e)
	{
		return new ExcecaoGenerica(1079, $"Falha validando email [{email}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaEnviandoEmail(Exception e)
	{
		return new ExcecaoGenerica(1080, $"Falha enviando email.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica EmailInvalido(string email)
	{
		return new ExcecaoGenerica(1081, $"Email inválido [{email}]", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoAssemblyInterno(string assemblyName, Exception e)
	{
		return new ExcecaoGenerica(1082, $"Falha obtendo assembly interno [{assemblyName}]", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoDLLAssembly(string assemblyName, Exception e)
	{
		return new ExcecaoGenerica(1083, $"Falha obtendo dll assembly [{assemblyName}]", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoTodosOsArquivosDoDiretorio(string diretorio, Exception e)
	{
		return new ExcecaoGenerica(1084, $"Falha obtendo obtendo arquivos do diretório [{diretorio}]", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaVerificandoSeOArquivoEstaSendoUtilizado(string nomeAbsoluto, Exception e)
	{
		return new ExcecaoGenerica(1085, $"Falha verificando se o arquivo [{nomeAbsoluto}] está sendo utilizado", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaClonandoObjeto(string className, Exception e)
	{
		return new ExcecaoGenerica(1086, $"Falha clonando instância do tipo [{className}]", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaFormatandoStringParaStringDeTamanhoDefinido(string str, int tamanho, Exception e)
	{
		return new ExcecaoGenerica(1087, $"Falha formatando string [{str}] para uma string de tamanho [{tamanho}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSerializandoObjetoParaXml(Type tipoObjeto, Exception e)
	{
		return new ExcecaoGenerica(1088, string.Format("Falha serializando " + tipoObjeto.Name + " para formato Xml."), e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSalvandoBoletoFastReportNoFormatoPdf(string name, Exception e)
	{
		return new ExcecaoGenerica(1089, string.Format("Falha salvando boleto " + name + " do FastReport no formato de Pdf."), e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaImprimindoDocumentoViaFastReport(Exception e)
	{
		return new ExcecaoGenerica(1090, $"Falha imprimindo documento via FastReport.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaObtendoRecurso(Exception e)
	{
		return new ExcecaoGenerica(1091, $"Falha obtendo recurso.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExtraindoImagemDosRecursos(Exception e)
	{
		return new ExcecaoGenerica(1092, $"Falha extraindo imagem do repositório de recursos disponíveis na dll.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCriandoFabricaRepositorioCodigosCobranca(Exception e)
	{
		return new ExcecaoGenerica(1093, $"Falha criando dicionário de repositório de códigos de cobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExtraindoFonteDosRecursos(Exception e)
	{
		return new ExcecaoGenerica(1094, $"Falha extraindo fonte do repositório de recursos disponíveis na dll.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaInstalandoFontesDoECobranca(Exception e)
	{
		return new ExcecaoGenerica(1095, $"Falha instalando as fonts do eCobrança.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaSalvandoBoletoFastReportNoFormatoImage(string name, Exception e)
	{
		return new ExcecaoGenerica(1096, string.Format("Falha salvando boleto " + name + " do FastReport no formato de Image."), e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaExcluindoArquivosTemporarios(Exception e)
	{
		return new ExcecaoGenerica(1097, $"Falha excluindo arquivos temporários.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ArquivoDeImagemJPGInvalido()
	{
		return new ExcecaoGenerica(1098, $"O arquivo de imagem não é uma arquivo JPG válido.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ChaveDeCriptografiaComTamanhoInvalido()
	{
		return new ExcecaoGenerica(1099, $"A chave de criptografia informada deve possuir 16, 24 ou 32 caracteres.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica VetorDeInicializacaoComTamanhoInvalido()
	{
		return new ExcecaoGenerica(1100, $"O vetor de inicialização deve possuir 16 caracteres.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica StringVaziaParaCriptografar()
	{
		return new ExcecaoGenerica(1101, $"O conteúdo para ser criptografado deve ser uma string não vazia.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ConteudoInvalidoParaCriptografar()
	{
		return new ExcecaoGenerica(1101, $"O conteúdo para ser criptografado deve ser uma string não vazia.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica ChaveCarteiraCobrancaInvalida()
	{
		return new ExcecaoGenerica(1102, $"A chave da carteira de cobrança informada para instanciar o eCobrança é inválida.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.FATAL);
	}
}
