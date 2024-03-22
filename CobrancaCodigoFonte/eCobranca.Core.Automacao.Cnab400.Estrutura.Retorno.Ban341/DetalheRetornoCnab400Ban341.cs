using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;

public class DetalheRetornoCnab400Ban341 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVAgenciaContaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca Filler3 => campos[10];

	public CampoLayoutArquivoCobranca NumeroCarteira => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[12];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[13];

	public CampoLayoutArquivoCobranca Filler4 => campos[14];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[15];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[16];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[17];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[18];

	public CampoLayoutArquivoCobranca ConfirmacaoNossoNumero => campos[19];

	public CampoLayoutArquivoCobranca Filler5 => campos[20];

	public CampoLayoutArquivoCobranca DataVencimento => campos[21];

	public CampoLayoutArquivoCobranca ValorNominal => campos[22];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[23];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[24];

	public CampoLayoutArquivoCobranca DVAgenciaCobradora => campos[25];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[26];

	public CampoLayoutArquivoCobranca ValorDespesaCobranca => campos[27];

	public CampoLayoutArquivoCobranca Filler6 => campos[28];

	public CampoLayoutArquivoCobranca ValorIOF => campos[29];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[30];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[31];

	public CampoLayoutArquivoCobranca ValorLancamento => campos[32];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[33];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[34];

	public CampoLayoutArquivoCobranca IndicadorBoletoDDA => campos[35];

	public CampoLayoutArquivoCobranca Filler7 => campos[36];

	public CampoLayoutArquivoCobranca DataCredito => campos[37];

	public CampoLayoutArquivoCobranca CodigoInstrucaoCancelada => campos[38];

	public CampoLayoutArquivoCobranca Filler8 => campos[39];

	public CampoLayoutArquivoCobranca Filler9 => campos[40];

	public CampoLayoutArquivoCobranca NomePagador => campos[41];

	public CampoLayoutArquivoCobranca Filler10 => campos[42];

	public CampoLayoutArquivoCobranca RegistrosRejeitados => campos[43];

	public CampoLayoutArquivoCobranca Filler11 => campos[44];

	public CampoLayoutArquivoCobranca CodigoLiquidacao => campos[45];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[46];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban341.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo inscrição cedente", "Identificação do tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número inscrição do cedente", "Número de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Prefixo da agência", "Agência mantenedora da conta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Complemento de registro", "Complemento de registro - Informar ZEROS", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 23, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número da conta corrente do cedente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 28, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Dígito verificador da agência/conta corrente", "Dígito de auto conferência da agência/conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 29, 29, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 37, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código de controle da empresa", "Identificação do título no cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Identificação do título no banco", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 71, 82, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Carteira", "Número da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 85, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 93, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Dígito verificador do nosso número", "Dígito verificador do nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 94, 94, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 107, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código do movimento de retorno", "Identificação da ocorrência de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data da ocorrência", "Data da ocorrência no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Número do documento", "Número do documento de cobrnaça", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Nosso número", "Confirmação do nosso número do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 134, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 135, 146, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Vencimento", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Código do banco", "Número do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Agência cobradora", "Agência cobradora, de liquidação ou baixa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 172, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Dígito verificador da agência cobradora", "Dígito verificador da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 173, 173, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Espécie do título", "Tipo de documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Tarifa de cobrança", "Valor da despesa de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 189, 214, 26, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor IOF", "Valor do IOF a ser recolhido para notas de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor do abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor do desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Valor principal", "Valor lançado em conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Valor juros de mora/multa", "Valor de juros de mora e multa pagos pelo sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Outros créditos", "Valor de outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Boleto DDA", "Indicador de boleto DDA", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 293, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 294, 295, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Data de crédito", "Data de crédito dessa liquidação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 296, 301, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Instrução cancelada", "Código da instrução cancelada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 302, 305, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 306, 311, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Complemento de registro", "Complemento de registro - Informar ZEROS", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 312, 324, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Nome do sacado", "Nome do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 325, 354, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 377, 23, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Erros/mensagem informativa", "Registros rejeitados ou alegação do sacado ou registro de mensagem informativa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 378, 385, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 386, 392, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Código de liquidação", "Meio pelo qual o título foi liquidado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Sequência do registro", "Sequência do registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
