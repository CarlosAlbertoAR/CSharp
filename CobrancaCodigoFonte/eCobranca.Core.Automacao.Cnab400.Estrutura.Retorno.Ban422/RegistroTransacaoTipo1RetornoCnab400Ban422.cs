using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban422;

public class RegistroTransacaoTipo1RetornoCnab400Ban422 : DetalheRetornoCnab400, IRegistroTransacaoTipo1RetornoCnab400Ban422
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca UsoExclusivoBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NossoNumero => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca CodigoOcorrenciaRemessa => campos[8];

	public CampoLayoutArquivoCobranca CodigoRejeicao => campos[9];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[10];

	public CampoLayoutArquivoCobranca CodigoOcorrenciaRetorno => campos[11];

	public CampoLayoutArquivoCobranca DataOcorrenciaNoBanco => campos[12];

	public CampoLayoutArquivoCobranca SeuNumero => campos[13];

	public CampoLayoutArquivoCobranca ConfirmacaoNossoNumero => campos[14];

	public CampoLayoutArquivoCobranca Filler3 => campos[15];

	public CampoLayoutArquivoCobranca DataVencimento => campos[16];

	public CampoLayoutArquivoCobranca ValorNominal => campos[17];

	public CampoLayoutArquivoCobranca BancoCobrador => campos[18];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[19];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[20];

	public CampoLayoutArquivoCobranca TarifaCobranca => campos[21];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[22];

	public CampoLayoutArquivoCobranca Filler4 => campos[23];

	public CampoLayoutArquivoCobranca ValorIof => campos[24];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[25];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[26];

	public CampoLayoutArquivoCobranca ValorPago => campos[27];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[28];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[29];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[30];

	public CampoLayoutArquivoCobranca DataCredito => campos[31];

	public CampoLayoutArquivoCobranca Filler5 => campos[32];

	public CampoLayoutArquivoCobranca CodigoBeneficiarioTransferido => campos[33];

	public CampoLayoutArquivoCobranca IndicadorEntradaDDA => campos[34];

	public CampoLayoutArquivoCobranca MeioDeLiquidacao => campos[35];

	public CampoLayoutArquivoCobranca Filler6 => campos[36];

	public CampoLayoutArquivoCobranca SeuNumeroExtra => campos[37];

	public CampoLayoutArquivoCobranca NumeroSequencialGeracaoArquivo => campos[38];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[39];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban422.TRANSACAO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Código da inscrição", "Tipo de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição da empresa", "Número da inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Identificação da empresa no banco", "Identificação da empresa do beneficiário no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 31, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 37, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Uso exclusivo da empresa", "Uso exclusivo da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 71, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 72, 102, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código da ocorrência remessa", "Código da ocorrência recebida no arquivo de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 103, 104, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código de motivo de rejeição", "Código do motivo de rejeição", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 105, 107, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Código da carteira", "Identificação do tipo da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Código da ocorrência de retorno", "Identificação da ocorrência de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Data da ocorrência", "Data da ocorrência ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Seu número", "Identificação do título no beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Nosso número", "Confirmação do nosso número atribuído ao título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 135, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Filler 3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 136, 146, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Data de vencimento", "Data de vencimento do título ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Banco cobrador", "Código do banco encarregado da cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Agência cobradora", "Código da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Tarifa", "Tarifa de cobran;a", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor de outras despesas", "Valor de outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Filler 4", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 202, 214, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Iof", "Valor de Iof", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor do abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Juros de mora", "Valor dos juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Outros créditos", "Valor de outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Código da moeda", "Código de moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 295, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Data do crédito", "Data do crédito no formato ddmmaa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 296, 301, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Filler 5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 302, 307, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Ced. Transferido", "Código do beneficiário transferido - ocorrência 21", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 308, 321, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Indicador de entrada DDA", "Indicador de entrada DDA", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 322, 322, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Meio de liquidação", "Meio de liquidação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 323, 324, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Filler 6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 325, 376, 52, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 377, 391, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Número sequencial arquivo", "Número sequencial do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
