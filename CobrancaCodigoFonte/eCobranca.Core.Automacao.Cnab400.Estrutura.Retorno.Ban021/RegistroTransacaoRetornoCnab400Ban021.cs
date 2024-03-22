using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban021;

public class RegistroTransacaoRetornoCnab400Ban021 : DetalheRetornoCnab400, IRegistroTransacaoRetornoCnab400Ban021
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca IdentificacaoControleParticipante => campos[5];

	public CampoLayoutArquivoCobranca NossoNumero => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca CodigoLancamento => campos[8];

	public CampoLayoutArquivoCobranca UsoBanestes => campos[9];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[10];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[11];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[12];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[13];

	public CampoLayoutArquivoCobranca Filler3 => campos[14];

	public CampoLayoutArquivoCobranca DataVencimento => campos[15];

	public CampoLayoutArquivoCobranca FatorVencimento => campos[16];

	public CampoLayoutArquivoCobranca ValorNominalTitulo => campos[17];

	public CampoLayoutArquivoCobranca BancoRecebedor => campos[18];

	public CampoLayoutArquivoCobranca AgenciaRecebedora => campos[19];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[20];

	public CampoLayoutArquivoCobranca TarifaBancaria => campos[21];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[22];

	public CampoLayoutArquivoCobranca Filler4 => campos[23];

	public CampoLayoutArquivoCobranca ValorIOC => campos[24];

	public CampoLayoutArquivoCobranca ValorAbatimentoConcedido => campos[25];

	public CampoLayoutArquivoCobranca ValorDescontoConcedido => campos[26];

	public CampoLayoutArquivoCobranca ValorPago => campos[27];

	public CampoLayoutArquivoCobranca ValorJuros => campos[28];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[29];

	public CampoLayoutArquivoCobranca IdentificacaoPagamentoEmCartorio => campos[30];

	public CampoLayoutArquivoCobranca Filler5 => campos[31];

	public CampoLayoutArquivoCobranca MotivoOcorrencia => campos[32];

	public CampoLayoutArquivoCobranca Filler6 => campos[33];

	public CampoLayoutArquivoCobranca NumeroRemessa => campos[34];

	public CampoLayoutArquivoCobranca DataRemessa => campos[35];

	public CampoLayoutArquivoCobranca SequenciaTransmissaoArquivo => campos[36];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[37];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[38];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban021.REGISTRO_TRANSACAO.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição", "Tipo de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição", "Número de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Identificação da empresa beneficiária", "Conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 28, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Filler", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 29, 37, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Identificação da operação na empresa", "Numero controle do participante", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Nosso número", "Nosso número de identificação do título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 72, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 82, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código de lançamento", "Aviso de movimentação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 84, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Uso do banestes", "Uso do banestes", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 85, 107, 23, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Código da carteira", "Código da carteira de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Código da ocorrência", "Código da ocorrência de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Data da ocorrência", "Formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Número do documento", "Número do documento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Data de vencimento", "Data de vencimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Fator de vencimento", "Fator de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 155, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Valor nominal", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 156, 165, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Banco recebedor", "Código do banco recebedor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Agência cobradora", "Código da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Tarifa bancária", "Valor da tarifa bancária", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor outras despesas", "Outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 202, 214, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor do IOC", "No caso de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor de abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor de desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor juros", "Valor dos juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor de outros créditos", "Valor de outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Identificação de pagamento em cartório", "Pago em cartório", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 293, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 294, 318, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Motivo da ocorrência", "Motivo do código de ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 319, 328, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 329, 376, 48, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Número da remessa", "Número da remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 377, 382, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Data da remessa", "Formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 383, 390, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Sequência de transmissão do arquivo", "Sequência de transmissão do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 391, 393, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
