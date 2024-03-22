using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban133;

public class RegistroDetalheRetornoCnab400Ban133 : DetalheRetornoCnab400, IRegistroDetalheCnab400Ban133
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco => campos[4];

	public CampoLayoutArquivoCobranca NumeroControleBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca Filler2 => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca Filler3 => campos[8];

	public CampoLayoutArquivoCobranca Filler4 => campos[9];

	public CampoLayoutArquivoCobranca IndicadorRateioCredito => campos[10];

	public CampoLayoutArquivoCobranca Filler5 => campos[11];

	public CampoLayoutArquivoCobranca Carteira => campos[12];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[13];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[14];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[15];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[16];

	public CampoLayoutArquivoCobranca DataVencimento => campos[17];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[18];

	public CampoLayoutArquivoCobranca CodigoBancoCobrador => campos[19];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[20];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[21];

	public CampoLayoutArquivoCobranca ValorDespesa => campos[22];

	public CampoLayoutArquivoCobranca OutrasDespesas => campos[23];

	public CampoLayoutArquivoCobranca JurosOperacaoEmAtraso => campos[24];

	public CampoLayoutArquivoCobranca IOFDevido => campos[25];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[26];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[27];

	public CampoLayoutArquivoCobranca ValorPago => campos[28];

	public CampoLayoutArquivoCobranca JurosDeMora => campos[29];

	public CampoLayoutArquivoCobranca OutrosCreditos => campos[30];

	public CampoLayoutArquivoCobranca Filler6 => campos[31];

	public CampoLayoutArquivoCobranca MotivoOcorrencia => campos[32];

	public CampoLayoutArquivoCobranca DataCredito => campos[33];

	public CampoLayoutArquivoCobranca OrigemPagamento => campos[34];

	public CampoLayoutArquivoCobranca Filler7 => campos[35];

	public CampoLayoutArquivoCobranca CodigoBanco2 => campos[36];

	public CampoLayoutArquivoCobranca MotivoRejeicao => campos[37];

	public CampoLayoutArquivoCobranca Filler8 => campos[38];

	public CampoLayoutArquivoCobranca NumeroCartorio => campos[39];

	public CampoLayoutArquivoCobranca NumeroProtocolo => campos[40];

	public CampoLayoutArquivoCobranca Filler9 => campos[41];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[42];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de retorno CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban099.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição", "Tipo de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição", "Número de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 20, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Identificação da empresa beneficiária", "Zero, carteira, agência e conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 21, 37, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número controle do participante", "Uso da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 82, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Uso do banco", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 92, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Uso do banco", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 104, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Indicador de rateio de crédito", "Informar R", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 105, 105, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Uso do banco", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 107, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Carteira", "Carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Ocorrência", "Identificação da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Data ocorrência", "Data ocorrência no banco no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Número do documento", "Número do documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data de vencimento", "Data de vencimento do título no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Banco cobrador", "Código do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Agência cobradora", "Código da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Espécie do título", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Tarifa", "Despesas de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Outras despesas", "Outras despesas custas de protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Juros operação em atraso", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 214, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "IOF", "IOF devido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Abatimento", "Abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Desconto", "Desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Juros de mora", "Juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Outros créditos", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 294, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Motivo da ocorrência", "Motivo do código de ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 295, 295, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Data do crédito", "Data do crédito no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 296, 301, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Origem do pagamento", "Origem do pagamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 302, 304, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 305, 314, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Código do banco", "Quando cheque do bradesco informar 0237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 315, 318, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Motivos de rejeição", "Código dos motivo de rejeição da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 319, 328, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 329, 368, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Número do cartório", "Número do cartório", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 369, 370, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Número do protocolo", "Número do protocolo", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 371, 380, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 381, 394, 14, 0);
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
