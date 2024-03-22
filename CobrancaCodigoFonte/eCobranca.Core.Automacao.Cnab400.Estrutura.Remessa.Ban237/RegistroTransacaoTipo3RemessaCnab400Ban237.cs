using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;

public class RegistroTransacaoTipo3RemessaCnab400Ban237 : SegmentoCnab400, IRegistroTransacaoTipo3RemessaCnab400Ban237
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NossoNumero => campos[2];

	public CampoLayoutArquivoCobranca CodigoCalculoRateio => campos[3];

	public CampoLayoutArquivoCobranca TipoValorInformado => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario1 => campos[6];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario1 => campos[7];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario1 => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario1 => campos[9];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario1 => campos[10];

	public CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario1 => campos[11];

	public CampoLayoutArquivoCobranca NomeBeneficiario1 => campos[12];

	public CampoLayoutArquivoCobranca Filler2 => campos[13];

	public CampoLayoutArquivoCobranca Parcela1 => campos[14];

	public CampoLayoutArquivoCobranca FloatingBeneficiario1 => campos[15];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario2 => campos[16];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario2 => campos[17];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario2 => campos[18];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario2 => campos[19];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario2 => campos[20];

	public CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario2 => campos[21];

	public CampoLayoutArquivoCobranca NomeBeneficiario2 => campos[22];

	public CampoLayoutArquivoCobranca Filler3 => campos[23];

	public CampoLayoutArquivoCobranca Parcela2 => campos[24];

	public CampoLayoutArquivoCobranca FloatingBeneficiario2 => campos[25];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario3 => campos[26];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario3 => campos[27];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario3 => campos[28];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario3 => campos[29];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario3 => campos[30];

	public CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario3 => campos[31];

	public CampoLayoutArquivoCobranca NomeBeneficiario3 => campos[32];

	public CampoLayoutArquivoCobranca Filler4 => campos[33];

	public CampoLayoutArquivoCobranca Parcela3 => campos[34];

	public CampoLayoutArquivoCobranca FloatingBeneficiario3 => campos[35];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[36];

	public RegistroTransacaoTipo3RemessaCnab400Ban237(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSACAO TIPO 3 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3", "Tipo de registro", "Informar 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_3.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3", "Identificação da empresa no banco", "Carteira, agência e conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 17, 16, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 29, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3", "Código para cálculo de rateio", "Informar um dos códigos do DominioCodigoCalculoRateioBan237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3", "Tipo de valor informado", "Informar um dos códigos do DominioTipoValorInformadoBan237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3", "Filler", "Informar Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 43, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3", "Código do banco para crédito do primeiro beneficiário", "Informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 44, 46, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3", "Código da agência para crédito do primeiro beneficiário", "Código da agência do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 51, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3", "Dígito da agência do primeiro beneficiário", "Digito da agência do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 52, 52, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3", "Conta corrente do primeiro beneficiário", "Número da conta corrente para crédito do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 64, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3", "Dígito da conta corrente do primeiro beneficiário", "Dígito da conta corrente para crédito do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 65, 65, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3", "Valor ou percentual de rateio do primeiro benficiário", "Valor ou percentual de rateio do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 80, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3", "Nome do primeiro beneficiário", "Nome do primeiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 81, 120, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 121, 151, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 157, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3", "Quantidade de dias para crédito do primeiro beneficiário", "Quantidade de dias para crédito do primeiro benficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 160, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3", "Código do banco para crédito do segundo beneficiário", "Informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 163, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3", "Código da agência para crédito do segundo beneficiário", "Código da agência do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 168, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3", "Dígito da agência do segundo beneficiário", "Digito da agência do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 169, 169, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3", "Conta corrente do segundo beneficiário", "Número da conta corrente para crédito do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 170, 181, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3", "Dígito da conta corrente do segundo beneficiário", "Dígito da conta corrente para crédito do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 182, 182, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3", "Valor ou percentual de rateio do segundo benficiário", "Valor ou percentual de rateio do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 183, 197, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3", "Nome do segundo beneficiário", "Nome do segundo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 237, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 238, 268, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 269, 274, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3", "Quantidade de dias para crédito do segundo beneficiário", "Quantidade de dias para crédito do segundo benficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 275, 277, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3", "Código do banco para crédito do terceiro beneficiário", "Informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 278, 280, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3", "Código da agência para crédito do terceiro beneficiário", "Código da agência do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 281, 285, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3", "Dígito da agência do terceiro beneficiário", "Digito da agência do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 286, 286, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3", "Conta corrente do terceiro beneficiário", "Número da conta corrente para crédito do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 287, 298, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.3", "Dígito da conta corrente do terceiro beneficiário", "Dígito da conta corrente para crédito do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 299, 299, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.3", "Valor ou percentual de rateio do terceiro benficiário", "Valor ou percentual de rateio do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 300, 314, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.3", "Nome do terceiro beneficiário", "Nome do terceiro beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 354, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.3", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 385, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.3", "Parcela", "Identificação da parcela", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 386, 391, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.3", "Quantidade de dias para crédito do terceiro beneficiário", "Quantidade de dias para crédito do terceiro benficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
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
