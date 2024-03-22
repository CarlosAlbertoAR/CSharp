using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;

public class DetalheRemessaCnab400Ban756 : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban756
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca NumeroConvenioBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca NumeroParcela => campos[10];

	public CampoLayoutArquivoCobranca GrupoValor => campos[11];

	public CampoLayoutArquivoCobranca Filler1 => campos[12];

	public CampoLayoutArquivoCobranca IndicativoMensagemSacadorAvalista => campos[13];

	public CampoLayoutArquivoCobranca PrefixoTitulo => campos[14];

	public CampoLayoutArquivoCobranca VariacaoCarteira => campos[15];

	public CampoLayoutArquivoCobranca ContaCaucao => campos[16];

	public CampoLayoutArquivoCobranca NumeroContratoGarantia => campos[17];

	public CampoLayoutArquivoCobranca DVNumeroContratoGarantia => campos[18];

	public CampoLayoutArquivoCobranca NumeroBordero => campos[19];

	public CampoLayoutArquivoCobranca Filler2 => campos[20];

	public CampoLayoutArquivoCobranca TipoEmissao => campos[21];

	public CampoLayoutArquivoCobranca Carteira => campos[22];

	public CampoLayoutArquivoCobranca Comando => campos[23];

	public CampoLayoutArquivoCobranca SeuNumero => campos[24];

	public CampoLayoutArquivoCobranca Vencimento => campos[25];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[26];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[27];

	public CampoLayoutArquivoCobranca PrefixoCooperativa => campos[28];

	public CampoLayoutArquivoCobranca DVPrefixoCooperativa => campos[29];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[30];

	public CampoLayoutArquivoCobranca TipoAceite => campos[31];

	public CampoLayoutArquivoCobranca DataEmissao => campos[32];

	public CampoLayoutArquivoCobranca Instrucao1 => campos[33];

	public CampoLayoutArquivoCobranca Instrucao2 => campos[34];

	public CampoLayoutArquivoCobranca TaxaJurosMes => campos[35];

	public CampoLayoutArquivoCobranca TaxaMulta => campos[36];

	public CampoLayoutArquivoCobranca TipoDistribuicao => campos[37];

	public CampoLayoutArquivoCobranca DataDesconto => campos[38];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[39];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[40];

	public CampoLayoutArquivoCobranca ValorIOF => campos[41];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[42];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[43];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[44];

	public CampoLayoutArquivoCobranca NomePagador => campos[45];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[46];

	public CampoLayoutArquivoCobranca BairroPagador => campos[47];

	public CampoLayoutArquivoCobranca CepPagador => campos[48];

	public CampoLayoutArquivoCobranca CidadePagador => campos[49];

	public CampoLayoutArquivoCobranca UFPagador => campos[50];

	public CampoLayoutArquivoCobranca ObservacoesOuMensagemOuSacadorAvalista => campos[51];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[52];

	public CampoLayoutArquivoCobranca Filler3 => campos[53];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[54];

	public DetalheRemessaCnab400Ban756(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do cedente", "Tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do cedente", "Número do CPF/CNPJ do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência", "Prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Dígito verificador da agência", "Dígito verificador - D.V. - do prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 22, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número da conta corrente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 30, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Dígito verificador da conta corrente", "Dígito verificador - D.V - do número da conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Número do convênio", "Número do convênio de cobrança do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 37, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Número de controle do participante", "Pode conter qualquer informação de interesse da Empresa. Será mantido na base de dados do sistema do Banco sem qualquer tipo de tratamento. A informação contida neste campo sempre retornará com o respectivo título no arquivo-retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 74, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Número da parcela", "Número da parcela. 01 se parcela única.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 76, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Grupo de valor", "Grupo de valor. Preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 78, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 79, 81, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Indicativo de mensagem ao Sacador/Avalista", "Indicativo de mensagem ao Sacador/Avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 82, 82, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Prefixo do título", "Prefixo do título: Preencher com brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 85, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Variação da carteira", "Variação da carteira de cobrança fornecido pelo banco do brasil.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 88, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Conta caução", "Conta caução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 89, 89, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Número contrato garantia", "Para carteira 1 preencher zeros. Para carteira 3 preencher o número do contrato", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 90, 94, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Dígito verificador do contrato de garantia", "Dígito verificador do contrato de garantia", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 95, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Número do borderô", "Número do borderô. Preencher em caso de carteira 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 96, 101, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Uso exclusivo CNAB400", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 102, 105, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Tipo de emissão de boleto", "Tipo de emissor de boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Código da carteira", "Código da carteira de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Comando", "Comando/Movimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Seu número", "Número atribuído pelo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Data de vencimento", "Informar no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor do título", "Valor nominal do título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Número do banco", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Código da cooperativa", "Código da cooperativa com 4 dígitos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 146, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Dígito verificador do código da cooperativa", "Dígito verifcador do código da cooperativa. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 147, 147, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Espécie do título", "Espécie do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Aceite", "Código de aceite do título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Data de emissão", "Data de emissão do título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Primeira instrução codificada", "Primeira instrução codificada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Segunda instrução codificada", "Segunda instrução codificada.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Percentual da taxa de juros mês", "Percentual da taxa de juros de mora mensal", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 166, 2, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Percentual da taxa de multa", "Percentual da taxa de multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 167, 172, 2, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Tipo de distribuição", "Responsável pela distribuição dos boletos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 173, 173, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Data do desconto", "Data do primeiro desconto no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Valor do desconto", "Valor do primeiro desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Código da moeda", "Código da moeda.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 193, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Valor de IOF ou quantidade monetária", "Valor de IOF ou quantidade monetária.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 194, 205, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Valor do abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Endereço do pagador", "Endereço completo do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 311, 37, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.1", "Bairro do pagador", "Bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 312, 326, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.1", "Cep do pagador", "Cep do pagador.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.1", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("51.1", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("52.1", "Mensagem ou Sacador/Avalista", "Mensagem ou nome do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 391, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("53.1", "Número de dias para protesto", "Quantidade de dias para envio a protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("54.1", "Uso exclusivo CNAB400", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("55.1", "Sequencial do registro", "Número sequencial do registro na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
