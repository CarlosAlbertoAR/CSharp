using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public class RegistroTransacaoTipo3RateioCreditoRemessaCnab400Ban041 : DetalheRemessaCnab400, IRegistroTransacaoTipo3RateioCreditoRemessaCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca CodigoBeneficiarioPrincipal => base.Campos[1];

	public CampoLayoutArquivoCobranca TipoEmissorBoletoCobranca => base.Campos[2];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[3];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[4];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[5];

	public CampoLayoutArquivoCobranca CodigoCalculoRateio => base.Campos[6];

	public CampoLayoutArquivoCobranca TipoValorInformado => base.Campos[7];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[8];

	public CampoLayoutArquivoCobranca CodigoBeneficiario1 => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[10];

	public CampoLayoutArquivoCobranca ValorPercentualBeneficiario1 => base.Campos[11];

	public CampoLayoutArquivoCobranca NomeBeneficiario1 => base.Campos[12];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[13];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario1 => base.Campos[14];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[15];

	public CampoLayoutArquivoCobranca CodigoBeneficiario2 => base.Campos[16];

	public CampoLayoutArquivoCobranca Filler7 => base.Campos[17];

	public CampoLayoutArquivoCobranca ValorPercentualBeneficiario2 => base.Campos[18];

	public CampoLayoutArquivoCobranca NomeBeneficiario2 => base.Campos[19];

	public CampoLayoutArquivoCobranca Filler8 => base.Campos[20];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario2 => base.Campos[21];

	public CampoLayoutArquivoCobranca CodigoBeneficiario3 => base.Campos[22];

	public CampoLayoutArquivoCobranca Filler9 => base.Campos[23];

	public CampoLayoutArquivoCobranca ValorPercentualBeneficiario3 => base.Campos[24];

	public CampoLayoutArquivoCobranca NomeBeneficiario3 => base.Campos[25];

	public CampoLayoutArquivoCobranca Filler10 => base.Campos[26];

	public CampoLayoutArquivoCobranca ParcelaBeneficiario3 => base.Campos[27];

	public CampoLayoutArquivoCobranca Filler11 => base.Campos[28];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[29];

	public RegistroTransacaoTipo3RateioCreditoRemessaCnab400Ban041(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_3_RATEIO_CREDITO.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Código do beneficiário principal", "Informar AAAACCCCCCCCC,  onde AAAA = código da agência, CCCCCCCCC = código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 14, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Tipo emissor do bloqueto de cobrança", "Tipo emissor do bloqueto de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Filler 1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 27, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Filler 2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 28, 29, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Código do cálculo de rateio", "Código do cálculo de rateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Tipo de valor informado", "Tipo de valor informado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Filler 3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 43, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código do primeiro beneficiário", "Código do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 44, 56, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Filler 4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 57, 65, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Valor ou percentual do beneficiário 1", "Valor ou percentual do beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 66, 80, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Nome do primeiro beneficiário 1", "Nome do primeiro beneficiário 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 81, 120, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Filler 5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 121, 151, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Parcela do primeiro beneficiário", "Parcela do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 152, 157, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Filler 6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 158, 160, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código do segundo beneficiário", "Código do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Filler 7", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 182, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Valor ou percentual do beneficiário 2", "Valor ou percentual do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 183, 197, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Nome do beneficiário 2", "Nome do beneficiário 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 237, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Filler 8", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 238, 268, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Parcela do segundo beneficiário", "Parcela do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 269, 274, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Código do terceiro beneficiário", "Código do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 275, 287, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Filler 9", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 288, 299, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor ou percentual do beneficiário 3", "Valor ou percentual do beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 300, 314, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Nome do beneficiário 3", "Nome do beneficiário 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 354, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Filler 10", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 385, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Parcela do terceiro beneficiário", "Parcela do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 386, 391, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Filler 11", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
