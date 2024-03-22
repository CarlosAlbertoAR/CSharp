using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban748;

public class RegistroTipo1RetornoCnab400Ban748 : DetalheRetornoCnab400, IRegistroTipo1RetornoCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca TipoCobranca => campos[2];

	public CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca CodigoPagadorNoAssociado => campos[4];

	public CampoLayoutArquivoCobranca BoletoDDA => campos[5];

	public CampoLayoutArquivoCobranca Filler2 => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca Filler3 => campos[8];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[9];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[10];

	public CampoLayoutArquivoCobranca SeuNumero => campos[11];

	public CampoLayoutArquivoCobranca Filler4 => campos[12];

	public CampoLayoutArquivoCobranca DataVencimento => campos[13];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[14];

	public CampoLayoutArquivoCobranca Filler5 => campos[15];

	public CampoLayoutArquivoCobranca EspecieDocumento => campos[16];

	public CampoLayoutArquivoCobranca ValorDespesasCobranca => campos[17];

	public CampoLayoutArquivoCobranca ValorDespesasCustasProtesto => campos[18];

	public CampoLayoutArquivoCobranca Filler6 => campos[19];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[20];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[21];

	public CampoLayoutArquivoCobranca ValorPago => campos[22];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[23];

	public CampoLayoutArquivoCobranca ValorMulta => campos[24];

	public CampoLayoutArquivoCobranca Filler7 => campos[25];

	public CampoLayoutArquivoCobranca ResultadoOcorrencia19 => campos[26];

	public CampoLayoutArquivoCobranca Filler8 => campos[27];

	public CampoLayoutArquivoCobranca MotivosOcorrencia => campos[28];

	public CampoLayoutArquivoCobranca DataPrevistaCredito => campos[29];

	public CampoLayoutArquivoCobranca Filler9 => campos[30];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[31];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Filler", "Brancos - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 13, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Tipo de cobrança", "A - cobrança com registro", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código do pagador na cooperativa do beneficiário", "Código do pagador na cooperativa do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 15, 19, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Código do pagador junto ao associado", "Enviar sempre zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 20, 24, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Boleto DDA", "1 - Boleto enviado a CIP/DDA, 2 - Boleto normal", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 25, 25, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 26, 47, 22, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número sicredi sem edição", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 48, 62, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 108, 46, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Ocorrência", "Identificação da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Data ocorrência", "Data ocorrência no banco no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Seu número", "Número do documento sob responsabilidade do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Data de vencimento", "Data de vencimento do título no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 166, 174, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Espécie de documento", "Código da espécie de documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 175, 175, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Despesas de cobrança", "Valor das despesas de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Despesas de custas de protesto", "Valor das despesas de custas com o protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Filler", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 227, 26, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Valor do abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Valor do desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor pago", "Valor efetivamente pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Valor de juros de mora", "Valor de juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor da multa", "Valor da multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 294, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Somente para ocorrência 19", "Somente para ocorrência 19", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 295, 295, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 296, 318, 23, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Motivo da ocorrência", "Motivo do código de ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 319, 328, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Data prevista do crédito", "Data prevista do crédito no formato: AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 329, 336, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 337, 394, 58, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
