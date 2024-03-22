using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban001;

public class DetalheRetornoCnab400Ban001 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban001
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca Filler2 => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[3];

	public CampoLayoutArquivoCobranca DVAgencia => campos[4];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[5];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[6];

	public CampoLayoutArquivoCobranca NumeroConvenio => campos[7];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca TipoCobranca => campos[10];

	public CampoLayoutArquivoCobranca TipoCobrancaComando72 => campos[11];

	public CampoLayoutArquivoCobranca DiasParaCalculo => campos[12];

	public CampoLayoutArquivoCobranca NaturezaRecebimento => campos[13];

	public CampoLayoutArquivoCobranca PrefixoTitulo => campos[14];

	public CampoLayoutArquivoCobranca VariacaoCarteira => campos[15];

	public CampoLayoutArquivoCobranca ContaCaucao => campos[16];

	public CampoLayoutArquivoCobranca TaxaDesconto => campos[17];

	public CampoLayoutArquivoCobranca TaxaIOF => campos[18];

	public CampoLayoutArquivoCobranca Filler3 => campos[19];

	public CampoLayoutArquivoCobranca Carteira => campos[20];

	public CampoLayoutArquivoCobranca Comando => campos[21];

	public CampoLayoutArquivoCobranca DataLiquidacao => campos[22];

	public CampoLayoutArquivoCobranca NumeroTituloBeneficiario => campos[23];

	public CampoLayoutArquivoCobranca Filler4 => campos[24];

	public CampoLayoutArquivoCobranca DataVencimento => campos[25];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[26];

	public CampoLayoutArquivoCobranca CodigoBancoRecebedor => campos[27];

	public CampoLayoutArquivoCobranca CodigoAgenciaRecebedora => campos[28];

	public CampoLayoutArquivoCobranca DVAgenciaRecebedora => campos[29];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[30];

	public CampoLayoutArquivoCobranca DataCredito => campos[31];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[32];

	public CampoLayoutArquivoCobranca OutrasDespesas => campos[33];

	public CampoLayoutArquivoCobranca JurosDoDesconto => campos[34];

	public CampoLayoutArquivoCobranca IOFDoDesconto => campos[35];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[36];

	public CampoLayoutArquivoCobranca DescontoConcedido => campos[37];

	public CampoLayoutArquivoCobranca ValorRecebido => campos[38];

	public CampoLayoutArquivoCobranca JurosDeMora => campos[39];

	public CampoLayoutArquivoCobranca OutrosRecebimentos => campos[40];

	public CampoLayoutArquivoCobranca AbatimentoNaoAproveitadoPeloPagador => campos[41];

	public CampoLayoutArquivoCobranca ValorLancamento => campos[42];

	public CampoLayoutArquivoCobranca IndicativoDebitoOuCredito => campos[43];

	public CampoLayoutArquivoCobranca IndicadorValor => campos[44];

	public CampoLayoutArquivoCobranca ValorAjuste => campos[45];

	public CampoLayoutArquivoCobranca Filler5 => campos[46];

	public CampoLayoutArquivoCobranca Filler6 => campos[47];

	public CampoLayoutArquivoCobranca Filler7 => campos[48];

	public CampoLayoutArquivoCobranca Filler8 => campos[49];

	public CampoLayoutArquivoCobranca Filler9 => campos[50];

	public CampoLayoutArquivoCobranca Filler10 => campos[51];

	public CampoLayoutArquivoCobranca Filler11 => campos[52];

	public CampoLayoutArquivoCobranca Filler12 => campos[53];

	public CampoLayoutArquivoCobranca IdicativoAutorizacaoLiquidacaoParcial => campos[54];

	public CampoLayoutArquivoCobranca Filler13 => campos[55];

	public CampoLayoutArquivoCobranca CanalPagamentoTitulo => campos[56];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[57];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Zeros", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "Zeros", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Prefixo da agência", "Código do prefixo da agência do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "DV do Prefixo da agência", "Dígito verificador do prefixo da agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 22, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "Número da conta corrente do cedente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 30, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "DV da conta corrente", "Dígito verificador do número da conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Número do convênio", "Número do convênio de cobrança do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 38, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Código de controle da empresa", "Pode conter qualquer informação de interesse da Empresa. Será mantido na base de dados do sistema do Banco sem qualquer tipo de tratamento. A informação contida neste campo sempre retornará com o respectivo título no arquivo-retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 39, 63, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 64, 80, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.7", "Tipo de cobrança", "Tipo de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 81, 81, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.7", "Tipo de cobrança específico para o comando 72", "Tipo de cobrança específico para alteração de tipo de cobrança de títulos das carteiras 11 e 17", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 82, 82, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.7", "Dias para cálculo", "Quando o título for liquidado, é preenchido com o número de dias decorridos desde o vencimento até a liquidação.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 86, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.7", "Natureza do recebimento", "Código que define a natureza de recebimento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 87, 88, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.7", "Prefixo do título", "Prefixo do título.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 89, 91, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.7", "Variacao da carteira", "Variação da carteira.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 92, 94, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.7", "Conta caução", "Conta caução.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 95, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.7", "Taxa para desconto", "Taxa para desconto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 96, 100, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.7", "Taxa de IOF", "Taxa de IOF.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 105, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.7", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.7", "Carteira", "Carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.7", "Comando", "Comando.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.7", "Data de liquidação", "Data de liquidação DDMMAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.7", "Número do título dado pelo cedente", "Número do título dado pelo cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.7", "Brancos", "Brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.7", "Data de vencimento", "Data de vencimento DDMMAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.7", "Valor do título", "Valor do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.7", "Código do banco recebedor", "Código do banco recebedor.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.7", "Prefixo da agência recebedora", "Prefixo da agência recebedora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 172, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.7", "DV prefixo da agência recebedora", "DV prefixo da agência recebedora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 173, 173, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.7", "Espécie do título", "Espécie do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.7", "Data do crédito", "Data do crédito DDMMAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 181, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.7", "Valor da tarifa", "Valor da tarifa.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 182, 188, 5, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.7", "Outras despesas", "Outras despesas.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.7", "Juros do desconto", "Juros do desconto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 214, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.7", "IOF do desconto", "IOF do desconto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.7", "Valor do abatimento", "Valor do abatimento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.7", "Desconto concedido", "Desconto concedido.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.7", "Valor recebido", "Valor recebido (valor recebido parcial).", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.7", "Juros de mora", "Juros de mora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.7", "Outros recebimentos", "Outros recebimentos.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.7", "Abatimento não aproveitado pelo sacado", "Abatimento não aproveitado pelo sacado.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 305, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.7", "Valor do lançamento", "Valor do lançamento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 306, 318, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.7", "Indicativo de débito/crédito", "Indicativo de débito/crédito.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 319, 319, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.7", "Indicador de valor", "Indicador de valor.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 320, 320, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.7", "Valor do ajuste", "Valor do ajuste.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 321, 332, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.7", "Brancos", "Brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 333, 333, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.7", "Brancos", "Brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 334, 342, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 343, 349, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 350, 358, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("51.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 359, 365, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("52.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 366, 374, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("53.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 375, 381, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("54.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 382, 390, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("55.7", "Indicativo de autorização de liquidação parcial", "Indicativo de autorização de liquidação parcial.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 391, 391, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("56.7", "Brancos", "Brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 392, 392, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("57.7", "Canal de pagamento do título", "Canal de pagamento do título  utilizado pelo sacado/Meio de apresentação do título ao sacado.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("58.7", "Sequência do registro", "Sequência do registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoRemessaCnab400(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
