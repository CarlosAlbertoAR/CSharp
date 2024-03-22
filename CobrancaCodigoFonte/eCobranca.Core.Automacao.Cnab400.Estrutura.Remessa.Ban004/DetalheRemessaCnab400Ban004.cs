using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;

public class DetalheRemessaCnab400Ban004 : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban004
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca Filler2 => campos[3];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca DigitoContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca TaxaMulta => campos[6];

	public CampoLayoutArquivoCobranca Filler3 => campos[7];

	public CampoLayoutArquivoCobranca NumeroControle => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca DigitoNossoNumero => campos[10];

	public CampoLayoutArquivoCobranca NumeroContrato => campos[11];

	public CampoLayoutArquivoCobranca DataSegundoDesconto => campos[12];

	public CampoLayoutArquivoCobranca ValorSegundoDesconto => campos[13];

	public CampoLayoutArquivoCobranca Filler4 => campos[14];

	public CampoLayoutArquivoCobranca Carteira => campos[15];

	public CampoLayoutArquivoCobranca CodigoServico => campos[16];

	public CampoLayoutArquivoCobranca SeuNumero => campos[17];

	public CampoLayoutArquivoCobranca DataVencimento => campos[18];

	public CampoLayoutArquivoCobranca ValorNominal => campos[19];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[20];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[21];

	public CampoLayoutArquivoCobranca Filler5 => campos[22];

	public CampoLayoutArquivoCobranca Especie => campos[23];

	public CampoLayoutArquivoCobranca Aceite => campos[24];

	public CampoLayoutArquivoCobranca DataEmissao => campos[25];

	public CampoLayoutArquivoCobranca CodigoInstrucao => campos[26];

	public CampoLayoutArquivoCobranca JurosDia => campos[27];

	public CampoLayoutArquivoCobranca DataDesconto => campos[28];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[29];

	public CampoLayoutArquivoCobranca ValorIOC => campos[30];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[31];

	public CampoLayoutArquivoCobranca CodigoInscricaoPagador => campos[32];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[33];

	public CampoLayoutArquivoCobranca NomePagador => campos[34];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[35];

	public CampoLayoutArquivoCobranca ComplementoEnderecoPagador => campos[36];

	public CampoLayoutArquivoCobranca CepPagador => campos[37];

	public CampoLayoutArquivoCobranca CidadePagador => campos[38];

	public CampoLayoutArquivoCobranca UfPagador => campos[39];

	public CampoLayoutArquivoCobranca MensageOuNomeSacadorAvalista => campos[40];

	public CampoLayoutArquivoCobranca PrazoProtesto => campos[41];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[42];

	public CampoLayoutArquivoCobranca SequencialRegistro => campos[43];

	public DetalheRemessaCnab400Ban004(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban004.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Filler 1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoSegmentoDetalheCnab400Ban004.DETALHE.Codigo(), "", 2, 17, 16, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Filler 2", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 23, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta corrente do beneficiário", "Conta corrente de cobrança do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 30, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Dígito da conta corrente", "Dígito da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Taxa de multa", "Percentual de multa por atraso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 33, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Filler 3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 34, 37, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Número de controle", "Número de controle do título do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Nosso número", "Nosso número quando o boleto for emitido pelo cliente. Caso contrário, informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 69, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Dígito nosso número", "DV do nosso número calculado pelo módulo 11", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 70, 70, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Número do contrato", "Número do contrato para cobrança caucionada/vinculada. Informar zeros para cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 80, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Data do segundo desconto", "Data do segundo desconto no formato DDMMAA se houver. Caso contrário informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 81, 86, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Valor do segundo desconto", "Valor do segundo desconto se houver. Caso contrário, informar zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 87, 99, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Filler 4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 100, 107, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Carteira", "Carteira a ser utilizada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código de movimento remessa", "Informar o código do movimento de remessa a ser utilizado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Seu número", "Informar o número do documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Data de vencimento", "Informar a data de vencimento no formato ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Número do banco cobrador", "Informar zeros (Banco cobrador será definido conforme cobradora) ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Agência cobradora", "Agência cobradora será definida pelo BNB com base no CEP do Sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 146, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Filler 5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 147, 147, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Espécie", "Informar a espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Aceite", "Informar A se aceito e N se não aceito", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Data de emissão", "Informar a data de emissão no formato ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Código de instrução", "Informar o código da instrução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 160, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Juros ao dia", "Informar juros de um dia desejado. Para cobrar a comissão de permanência vigente no BANCO DO NORDESTE, preencha com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Data de desconto", "Informar a data do desconto no formato ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor do desconto", "Valor do desconto, se não houver informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor do IOC", "Imposto a ser recolhido pelo banco quando se tratar de operações de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor do abatimento", "Valor do abtimento, se não houver informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "código de inscrição do pagador", "Informar 01 para CPF e 02 para CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Número de inscrição do pagador", "Informar o CNPJ ou CPF do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Endereço do pagador", "Endereço d pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Complemento do endereço do pagador", "Complemento do endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "CEP do pagador", "CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Mensagem ou Nome do sacador avalista", "Campo de livre preenchimento que pode ser usado pelo cedente para qualquer informação ou mensagem", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 391, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Prazo de protesto", "Informar o número de dias em atraso para envio do título para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Código da moeda", "Informar o código da moeda do título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Número sequencial do regitro", "Adicionar 1 ao sequencial do registro aterior", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
