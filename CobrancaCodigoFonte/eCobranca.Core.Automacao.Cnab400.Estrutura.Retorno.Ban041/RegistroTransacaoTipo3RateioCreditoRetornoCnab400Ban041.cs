using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;

public class RegistroTransacaoTipo3RateioCreditoRetornoCnab400Ban041 : DetalheRetornoCnab400, IRegistroTransacaoTipo3RateioCreditoRetornoCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => base.Campos[1];

	public CampoLayoutArquivoCobranca EmissorBoletoCobranca => base.Campos[2];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[3];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[4];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[5];

	public CampoLayoutArquivoCobranca CodigoCalculoRateio => base.Campos[6];

	public CampoLayoutArquivoCobranca TipoValorInformado => base.Campos[7];

	public CampoLayoutArquivoCobranca Fillers3 => base.Campos[8];

	public CampoLayoutArquivoCobranca CodigoBeneficiario1 => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[10];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario1 => base.Campos[11];

	public CampoLayoutArquivoCobranca NomeBeneficiario1 => base.Campos[12];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[13];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario1 => base.Campos[14];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[15];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario1 => base.Campos[16];

	public CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario1 => base.Campos[17];

	public CampoLayoutArquivoCobranca CodigoBeneficiario2 => base.Campos[18];

	public CampoLayoutArquivoCobranca Filler7 => base.Campos[19];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario2 => base.Campos[20];

	public CampoLayoutArquivoCobranca NomeBeneficiario2 => base.Campos[21];

	public CampoLayoutArquivoCobranca Filler8 => base.Campos[22];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario2 => base.Campos[23];

	public CampoLayoutArquivoCobranca Filler9 => base.Campos[24];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario2 => base.Campos[25];

	public CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario2 => base.Campos[26];

	public CampoLayoutArquivoCobranca CodigoBeneficiario3 => base.Campos[27];

	public CampoLayoutArquivoCobranca Filler10 => base.Campos[28];

	public CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario3 => base.Campos[29];

	public CampoLayoutArquivoCobranca NomeBeneficiario3 => base.Campos[30];

	public CampoLayoutArquivoCobranca Filler11 => base.Campos[31];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario3 => base.Campos[32];

	public CampoLayoutArquivoCobranca Filler12 => base.Campos[33];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario3 => base.Campos[34];

	public CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario3 => base.Campos[35];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[36];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSACAO TIPO 3 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3", "Tipo de registro", "Informar 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_3.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3", "Código do beneficiário", "Código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 14, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3", "Emissor do boleto de cobrança", "Emissor do boleto de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 27, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 28, 29, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3", "Código do cálculo de rateio", "Código do cálculo de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3", "Tipo do valor informado", "Tipo do valor informado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 32, 43, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3", "Código do beneficiário 1", "Código do beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 44, 56, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 57, 65, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3", "Valor efetivo rateio beneficiário 1", "Valor efetivo rateio beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 80, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3", "Nome do beneficiário 1", "Nome do beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 81, 120, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 121, 141, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3", "Parcela do beneficiário 1", "Parcela do beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 142, 147, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 148, 150, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3", "Data de crédito do beneficiário 1", "Data de crédito do beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 158, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3", "Motivo ocorrência beneficiário 1", "Motivo ocorrência beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3", "Código do beneficiário 2", "Código do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3", "Filler7", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 182, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3", "Valor efetivo rateio beneficiário 2", "Valor efetivo rateio beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 183, 197, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3", "Nome do beneficiário 2", "Nome do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 237, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3", "Filler8", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 238, 258, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3", "Parcela do beneficiário 2", "Parcela do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 259, 264, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3", "Filler9", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 265, 267, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3", "Data de crédito do beneficiário 2", "Data de crédito do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 268, 275, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3", "Motivo ocorrência do beneficiário 2", "Motivo ocorrência do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 276, 277, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3", "Código do beneficiário 3", "Código do beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 278, 290, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3", "Filler10", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 291, 299, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3", "Valor efetivo rateio beneficiário 3", "Valor efetivo rateio beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 300, 314, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.3", "Nome do beneficiário 3", "Nome do beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 354, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.3", "Filler11", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 375, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.3", "Parcela do beneficiário 3", "Parcela do beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 376, 381, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.3", "Filler12", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 384, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.3", "Data crédito beneficiário 3", "Data crédito beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 385, 392, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.3", "Motivo ocorrência beneficiário 3", "Motivo ocorrência beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.3", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
