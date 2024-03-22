using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public class DetalheRetornoCnab400Ban097 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban097
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca Filler3 => campos[7];

	public CampoLayoutArquivoCobranca NumeroControleBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca Filler4 => campos[10];

	public CampoLayoutArquivoCobranca Filler5 => campos[11];

	public CampoLayoutArquivoCobranca Filler6 => campos[12];

	public CampoLayoutArquivoCobranca CodigoTipoLancamento => campos[13];

	public CampoLayoutArquivoCobranca Filler7 => campos[14];

	public CampoLayoutArquivoCobranca Filler8 => campos[15];

	public CampoLayoutArquivoCobranca Filler9 => campos[16];

	public CampoLayoutArquivoCobranca Filler10 => campos[17];

	public CampoLayoutArquivoCobranca Filler11 => campos[18];

	public CampoLayoutArquivoCobranca Filler12 => campos[19];

	public CampoLayoutArquivoCobranca Filler13 => campos[20];

	public CampoLayoutArquivoCobranca Filler14 => campos[21];

	public CampoLayoutArquivoCobranca Filler15 => campos[22];

	public CampoLayoutArquivoCobranca Filler16 => campos[23];

	public CampoLayoutArquivoCobranca DataMovimento => campos[24];

	public CampoLayoutArquivoCobranca Filler17 => campos[25];

	public CampoLayoutArquivoCobranca Filler18 => campos[26];

	public CampoLayoutArquivoCobranca DataVencimento => campos[27];

	public CampoLayoutArquivoCobranca ValorNominal => campos[28];

	public CampoLayoutArquivoCobranca Filler19 => campos[29];

	public CampoLayoutArquivoCobranca Filler20 => campos[30];

	public CampoLayoutArquivoCobranca Filler21 => campos[31];

	public CampoLayoutArquivoCobranca Filler22 => campos[32];

	public CampoLayoutArquivoCobranca DataCredito => campos[33];

	public CampoLayoutArquivoCobranca Filler23 => campos[34];

	public CampoLayoutArquivoCobranca Filler24 => campos[35];

	public CampoLayoutArquivoCobranca Filler25 => campos[36];

	public CampoLayoutArquivoCobranca Filler26 => campos[37];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[38];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[39];

	public CampoLayoutArquivoCobranca ValorRecebido => campos[40];

	public CampoLayoutArquivoCobranca JurosDeMora => campos[41];

	public CampoLayoutArquivoCobranca OutrosRecebimentos => campos[42];

	public CampoLayoutArquivoCobranca AbatimentoNaoAproveitado => campos[43];

	public CampoLayoutArquivoCobranca ValorLancamento => campos[44];

	public CampoLayoutArquivoCobranca IndicativoDebitoCredito => campos[45];

	public CampoLayoutArquivoCobranca Filler27 => campos[46];

	public CampoLayoutArquivoCobranca Filler28 => campos[47];

	public CampoLayoutArquivoCobranca Filler29 => campos[48];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacado => campos[49];

	public CampoLayoutArquivoCobranca Filler30 => campos[50];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[51];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban097.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Prefixo da agência", "Código do prefixo da agência do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 22, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "Número da conta corrente do cedente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 30, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "DV da conta corrente", "Dígito verificador do número da conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 37, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Código de controle da empresa", "Pode conter qualquer informação de interesse da Empresa. Será mantido na base de dados do sistema do Banco sem qualquer tipo de tratamento. A informação contida neste campo sempre retornará com o respectivo título no arquivo-retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 73, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 74, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 75, 76, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 80, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.7", "Codigo movimento retorno", "Código do movimento de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 81, 82, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 85, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 86, 88, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 89, 89, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 90, 94, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 95, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 96, 100, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 105, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.7", "Data de movimentação", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.7", "Data de vencimento", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.7", "Valor nominal do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 169, 172, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 173, 173, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 175, 2, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.7", "Data do crédito", "No formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 181, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 182, 188, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 189, 201, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 202, 214, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 215, 227, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.7", "Valor abatimento", "Valor abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.7", "Desconto concedido", "Valor de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.7", "Valor recebido", "Valor recebido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.7", "Juros de mora", "Juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.7", "Outros recebimentos", "Outros recebimentos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.7", "Abatimento não aproveitado", "Valor do abatimento não aproveitado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 305, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.7", "Valor do lançamento", "Valor do lançamento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 306, 318, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.7", "Indicativo de débito/crédito", "Indicativo de débito/crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 319, 319, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.7", "Filler", "Informar brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 320, 320, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.7", "Filler", "Informar brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 321, 332, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 333, 342, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.7", "Inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 343, 357, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("51.7", "Zeros", "Zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 358, 394, 38, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("52.7", "Sequência do registro", "Sequência do registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
