using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban237;

public class RegistroTransacaoTipo3RetornoCnab400Ban237 : DetalheRetornoCnab400, IRegistroTransacaoTipo3RetornoCnab400Ban237
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco => campos[1];

	public CampoLayoutArquivoCobranca NossoNumero => campos[2];

	public CampoLayoutArquivoCobranca CodigoCalculoRateioCredito => campos[3];

	public CampoLayoutArquivoCobranca TipoValorInformado => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario1 => campos[6];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario1 => campos[7];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario1 => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario1 => campos[9];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario1 => campos[10];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario1 => campos[11];

	public CampoLayoutArquivoCobranca NomeBeneficiario1 => campos[12];

	public CampoLayoutArquivoCobranca Filler2 => campos[13];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario1 => campos[14];

	public CampoLayoutArquivoCobranca FloatingBeneficiario1 => campos[15];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario1 => campos[16];

	public CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario1 => campos[17];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario2 => campos[18];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario2 => campos[19];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario2 => campos[20];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario2 => campos[21];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario2 => campos[22];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario2 => campos[23];

	public CampoLayoutArquivoCobranca NomeBeneficiario2 => campos[24];

	public CampoLayoutArquivoCobranca Filler3 => campos[25];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario2 => campos[26];

	public CampoLayoutArquivoCobranca FloatingBeneficiario2 => campos[27];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario2 => campos[28];

	public CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario2 => campos[29];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario3 => campos[30];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario3 => campos[31];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario3 => campos[32];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario3 => campos[33];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario3 => campos[34];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario3 => campos[35];

	public CampoLayoutArquivoCobranca NomeBeneficiario3 => campos[36];

	public CampoLayoutArquivoCobranca Filler4 => campos[37];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario3 => campos[38];

	public CampoLayoutArquivoCobranca FloatingBeneficiario3 => campos[39];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario3 => campos[40];

	public CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario3 => campos[41];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[42];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 3 de retorno CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_3.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3", "Identificação da empresa", "Identificação da empresa no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 17, 16, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 29, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3", "Código de rateio", "Código de cálculo de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3", "Tipo de valor informado", "1=Percentual, 2=Valor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 43, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3", "Código do banco para crédito", "Fixo 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 44, 46, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3", "Código agência primeiro beneficiário", "Código agência primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 51, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3", "Dígito agência primeiro beneficiário", "Dígito agência primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 52, 52, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3", "Conta corrente primeiro beneficiário", "Conta corrente primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 64, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3", "Dígito conta corrente primeiro beneficiário", "Dígito conta corrente primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 65, 65, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3", "Valor efetivo do rateio primeiro beneficiário", "Valor efetivo do rateio primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 80, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3", "Nome do primeiro beneficiário", "Nome do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 81, 120, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 121, 141, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 142, 147, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3", "Floating para o primeiro beneficiário", "Quantidade de dias para crédito do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 150, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3", "Data do crédito para o primeiro beneficiário", "Data do crédito para o primeiro beneficiário: DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 158, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3", "Status / Motivo ocorrência de rateio", "Status / Motivo ocorrência de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3", "Código do banco para crédito", "Fixo 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 163, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3", "Código agência segundo beneficiário", "Código agência segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 168, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3", "Dígito agência segundo beneficiário", "Dígito agência segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 169, 169, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3", "Conta corrente segundo beneficiário", "Conta corrente segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 170, 181, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3", "Dígito conta corrente segundo beneficiário", "Dígito conta corrente segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 182, 182, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3", "Valor efetivo do rateio segundo beneficiário", "Valor efetivo do rateio segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 183, 194, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3", "Nome do segundo beneficiário", "Nome do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 237, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 238, 258, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 259, 264, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3", "Floating para o segundo beneficiário", "Quantidade de dias para crédito do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 265, 267, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3", "Data do crédito para o segundo beneficiário", "Data do crédito para o segundo beneficiário: DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 268, 275, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3", "Status / Motivo ocorrência de rateio", "Status / Motivo ocorrência de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 276, 277, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.3", "Código do banco para crédito", "Fixo 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 278, 280, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.3", "Código agência terceiro beneficiário", "Código agência terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 281, 285, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.3", "Dígito agência terceiro beneficiário", "Dígito agência terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 286, 286, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.3", "Conta corrente terceiro beneficiário", "Conta corrente terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 287, 298, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.3", "Dígito conta corrente terceiro beneficiário", "Dígito conta corrente terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 299, 299, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.3", "Valor efetivo do rateio terceiro beneficiário", "Valor efetivo do rateio terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 300, 314, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.3", "Nome do terceiro beneficiário", "Nome do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 354, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.3", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 375, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 375, 381, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.3", "Floating para o terceiro beneficiário", "Quantidade de dias para crédito do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 382, 384, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.3", "Data do crédito para o terceiro beneficiário", "Data do crédito para o terceiro beneficiário: DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 385, 392, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.3", "Status / Motivo ocorrência de rateio", "Status / Motivo ocorrência de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
