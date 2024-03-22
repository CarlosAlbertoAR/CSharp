using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public class DetalheRetornoCnab400Ban097CobrancaSimples : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban097CobrancaSimples
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca Filler1 => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca CodigoOperacao => campos[8];

	public CampoLayoutArquivoCobranca DataOperacao => campos[9];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public CampoLayoutArquivoCobranca DataVencimentoTitulo => campos[12];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[13];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[14];

	public CampoLayoutArquivoCobranca DataCredito => campos[15];

	public CampoLayoutArquivoCobranca Filler3 => campos[16];

	public CampoLayoutArquivoCobranca DescontoConcedido => campos[17];

	public CampoLayoutArquivoCobranca ValorRecebidoTitulo => campos[18];

	public CampoLayoutArquivoCobranca ValorAcrescimos => campos[19];

	public CampoLayoutArquivoCobranca Filler4 => campos[20];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[21];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[22];

	public CampoLayoutArquivoCobranca NomePagador => campos[23];

	public CampoLayoutArquivoCobranca Filler5 => campos[24];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[25];

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
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban097.DETALHE_OPCIONAL.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do beneficiário", "01-CPF, 02-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta do beneficiário", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 29, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "DV da conta corrente do beneficiário", "DV do Número da conta corrente do beneficiário.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 56, 26, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Informar o nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 57, 76, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código da operação", "Código da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 78, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Data da operação", "Data da operação no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 79, 84, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Número do documento", "Informar o número do documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 85, 94, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 146, 52, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Data de vencimento do título", "Informar a data de vencimento do título no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Valor do título", "Valor nominal do título com 2 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Valor da tarifa/custas", "Valor da tarifa com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 175, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Data de crédito", "Informar a data de crédito no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 181, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 182, 240, 59, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Desconto concedido", "Valor do desconto com 2 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.7", "Valor do título recebido", "Valor recebido do título com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Juros, multa e encargos", "Valor dos acréscimos com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 280, 337, 58, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Tipo inscrição do pagador", "01-CPF, 02-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 338, 339, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Número de inscrição do pagador", "Informar o CPF ou CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 340, 353, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Nome do pagador", "Informar o nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 354, 393, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
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
