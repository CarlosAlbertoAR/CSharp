using System.ComponentModel;

namespace eCobranca.Enumerator;

public enum EnumLayoutBoletoImpressoFields
{
	[Description("Imagem do logotipo do banco")]
	LOGOTIPOBANCO,
	[Description("Número do banco com o DV")]
	NUMEROBANCO,
	[Description("Vencimento do boleto")]
	VENCIMENTO,
	[Description("Agência / Conta Beneficiário")]
	AGENCIACODIGOCEDENTE,
	[Description("Moeda")]
	MOEDA,
	[Description("Quantidade utilizada para conversão de moeda estrangeira")]
	QUANTIDADE,
	[Description("Valor do documento")]
	VALORDOCUMENTOEXIBICAO,
	[Description("Desconto / Abatimento")]
	VALORDESCONTOEXIBICAO,
	[Description("Mora / Multa / Juros")]
	VALORJUROS,
	[Description("Nosso número com máscara")]
	NOSSONUMEROEXIBICAO,
	[Description("Numero do documento")]
	NUMERODOCUMENTO,
	[Description("Nome do beneficiário")]
	NOMECEDENTE,
	[Description("Identificação completa do beneficiário")]
	IDENTIFICACAOCEDENTE,
	[Description("Local de pagamento")]
	LOCALPAGAMENTO,
	[Description("Data de emissão do título de cobrança que gerou o boleto")]
	DATADOCUMENTO,
	[Description("Espécie do documento / Tipo")]
	ESPECIEDOCUMENTO,
	[Description("Aceite")]
	ACEITE,
	[Description("Data de emissão do boleto")]
	DATAPROCESSAMENTO,
	[Description("Uso do banco")]
	CODIGOUSOBANCO,
	[Description("Código da carteira de cobrança")]
	CARTEIRA,
	[Description("Campo de instruções do boleto")]
	INSTRUCOESCAIXA,
	[Description("Nome do pagador")]
	NOMESACADO,
	[Description("CNPJ com máscara do pagador")]
	CNPJSACADO,
	[Description("CPF com máscara do pagador")]
	CPFSACADO,
	[Description("Endereço com número do pagador")]
	ENDERECOSACADO,
	[Description("Nome do bairro do pagador")]
	BAIRROSACADO,
	[Description("Nome da cidade do pagador")]
	CIDADESACADO,
	[Description("Sigla da UF do pagador")]
	ESTADOSACADO,
	[Description("CEP do pagador")]
	CEPSACADO,
	[Description("Pagador / Avalista")]
	SACADORAVALISTA,
	[Description("Pagador / Avalista")]
	IDENTIFICACAOSACADORAVALISTA,
	[Description("Linha digitável completa")]
	LINHADIGITAVEL,
	[Description("Código de barras do boleto")]
	CODIGOBARRAS,
	[Description("Informações de contato com o SAC do banco")]
	CONTATOSAC,
	[Description("Logotipo do cedente")]
	LOGOTIPOCEDENTE,
	[Description("Valor dos outros acréscimos")]
	VALOROUTROSACRESCIMOSEXIBICAO,
	[Description("Campo demonstrativo para exibição de informações diversas")]
	DEMONSTRATIVO,
	[Description("Url origem")]
	URLORIGEM,
	[Description("Campo reservado para exibição de alguma imagem para divulgação ou mesmo texto")]
	PROPAGANDA,
	[Description("Campo que exibe uma cópia informativa da linha digitável do código de barras")]
	LINHADIGITAVELESPELHO,
	[Description("Número do banco com dígito exibido no recibo do sacado e entrega")]
	NUMEROBANCORECIBO,
	[Description("Imagem do local para autenticação mecânica")]
	IMAGEMAUTENTICACAOMECANICA,
	[Description("Define a altura do campo demonstrativo do recibo de entrega dos modelos de boleto que o possuírem")]
	ALTURACAMPODEMONSTRATIVORECIBOENTREGA,
	[Description("Define a altura do campo demonstrativo do recibo do pagador dos modelos de boleto que o possuírem")]
	ALTURACAMPODEMONSTRATIVORECIBOPAGADOR,
	[Description("Define o estilo que será utilizado para renderizar a logotipo do banco")]
	ESTILOLOGOTIPOBANCO,
	[Description("Define o estilo que será utilizado para renderizar a código do banco")]
	ESTILOCODIGOBANCO,
	[Description("Define o estilo que será utilizado para renderizar a linha digitável do boleto")]
	ESTILOLINHADIGITAVEL,
	[Description("Define que será utilizado um estilo dinâmico para os cabeçalhos dos campos na ficha de compensação")]
	ESTILOCABECALHOCAMPOFICHACOMPENSACAO,
	[Description("Define que será utilizado um estilo dinâmico para o conteúdo dos campos na ficha de compensação")]
	ESTILOCONTEUDOCAMPOFICHACOMPENSACAO,
	[Description("Define que será utilizado um estilo dinâmico para os valores monetários dos campos na ficha de compensação")]
	ESTILOCONTEUDOCAMPOVALORFICHACOMPENSACAO,
	[Description("Define que será utilizado um estilo dinâmico para o campo instruções na ficha de compensação")]
	ESTILOINSTRUCOESFICHACOMPENSACAO,
	[Description("Define que será utilizado um estilo dinâmico para exibição dos dados do pagador no boleto")]
	ESTILODADOSPAGADOR,
	[Description("Define que será utilizado um estilo dinâmico para exibição dos dados do avalista no boleto")]
	ESTILODADOSAVALISTA,
	[Description("Define que será utilizado um estilo dinâmico para formatação do local da autenticação mecânica")]
	ESTILOAUTENTICACAOMECANICA
}
