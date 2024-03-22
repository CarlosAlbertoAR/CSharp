using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;

public class DetalheRetornoCnab400Ban399 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban399
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca SubContaBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca OrigemPagamento => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[9];

	public CampoLayoutArquivoCobranca NossoNumero => campos[10];

	public CampoLayoutArquivoCobranca DataDesconto2 => campos[11];

	public CampoLayoutArquivoCobranca ValorDesconto2 => campos[12];

	public CampoLayoutArquivoCobranca DataDesconto3 => campos[13];

	public CampoLayoutArquivoCobranca ValorDesconto3 => campos[14];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[15];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[16];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[17];

	public CampoLayoutArquivoCobranca SeuNumero => campos[18];

	public CampoLayoutArquivoCobranca NossoNumeroBanco => campos[19];

	public CampoLayoutArquivoCobranca Filler3 => campos[20];

	public CampoLayoutArquivoCobranca DataVencimento => campos[21];

	public CampoLayoutArquivoCobranca ValorNominal => campos[22];

	public CampoLayoutArquivoCobranca BancoCobrador => campos[23];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[24];

	public CampoLayoutArquivoCobranca EspecieDocumento => campos[25];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[26];

	public CampoLayoutArquivoCobranca Filler4 => campos[27];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[28];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[29];

	public CampoLayoutArquivoCobranca ValorPago => campos[30];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[31];

	public CampoLayoutArquivoCobranca Filler5 => campos[32];

	public CampoLayoutArquivoCobranca ComplementoOcorrencia => campos[33];

	public CampoLayoutArquivoCobranca IndicativoDeCredito => campos[34];

	public CampoLayoutArquivoCobranca Filler6 => campos[35];

	public CampoLayoutArquivoCobranca NumeroAviso => campos[36];

	public CampoLayoutArquivoCobranca TipoMoeda => campos[37];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[38];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Código da inscrição do beneficiário", "Código da inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número da inscrição do beneficiário", "Número da inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Filler1", "Informar 0", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 22, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Sub-conta do beneficiário", "Número da sub-conta da conta do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 24, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Conta corrente do beneficiário", "Número da conta corrente do beneficiário.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 25, 35, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Origem do pagamento", "Origem do pagamento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 36, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 37, 37, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Número do controle participante", "Número do controle participante", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Nosso número", "Nosso número.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 73, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Data do desconto 2", "Data para concessão do desconto 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 79, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Valor desconto 2", "Valor concedido do desconto 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 90, 9, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Data desconto 3", "Data limite para concessão do desconto 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 91, 96, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Valor desconto 3", "Valor concedido do desconto 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 97, 107, 9, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código da ocorrência", "Código da ocorrência.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data da ocorrência", "Data da ocorrência no formato: DDMMAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Nosso número atribuído pelo banco", "Nosso número atribuído pelo banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 137, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 138, 146, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Data de vencimento", "Data de vencimento no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor nominal do documento de cobrança", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Banco cobrador", "Código do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Agência cobradora", "Código da agência cobradora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Espécie de documento", "Espécie do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor da tarifa", "Valor da tarifa ou custas.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 189, 227, 39, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor dos juros de mora", "Valor dos juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 280, 301, 22, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Complemento da ocorrência", "Complemento da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 302, 303, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Indicativo de crédito", "Indicativo de crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 304, 304, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 305, 388, 84, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Número do aviso", "Número sequencial do aviso de movimentação de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 389, 393, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Tipo de moeda", "Tipo de moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Sequência do registro", "Sequência do registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
