using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban033;

public class RegistroTipo1RetornoCnab400Ban033 : DetalheRetornoCnab400, IRegistroTipo1RetornoCnab400Ban033
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca ContaMovimentoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca ContaCobrancaBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca Filler1 => campos[8];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[9];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[10];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[11];

	public CampoLayoutArquivoCobranca SeuNumero => campos[12];

	public CampoLayoutArquivoCobranca NossoNumero2 => campos[13];

	public CampoLayoutArquivoCobranca CodigoOriginalRemessa => campos[14];

	public CampoLayoutArquivoCobranca CodigoErroPrimeiraOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca CodigoErroSegundaOcorrencia => campos[16];

	public CampoLayoutArquivoCobranca CodigoErroTerceiraOcorrencia => campos[17];

	public CampoLayoutArquivoCobranca Filler2 => campos[18];

	public CampoLayoutArquivoCobranca DataVencimento => campos[19];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[20];

	public CampoLayoutArquivoCobranca NumeroBancoCobrador => campos[21];

	public CampoLayoutArquivoCobranca AgenciaRecebedora => campos[22];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[23];

	public CampoLayoutArquivoCobranca ValorTarifaCobrada => campos[24];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[25];

	public CampoLayoutArquivoCobranca ValorJuros => campos[26];

	public CampoLayoutArquivoCobranca ValorIOF => campos[27];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[28];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[29];

	public CampoLayoutArquivoCobranca ValorTotalRecebido => campos[30];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[31];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[32];

	public CampoLayoutArquivoCobranca Filler3 => campos[33];

	public CampoLayoutArquivoCobranca CodigoAceite => campos[34];

	public CampoLayoutArquivoCobranca Filler4 => campos[35];

	public CampoLayoutArquivoCobranca DataCredito => campos[36];

	public CampoLayoutArquivoCobranca NomePagador => campos[37];

	public CampoLayoutArquivoCobranca IdentificadorComplemento => campos[38];

	public CampoLayoutArquivoCobranca UnidadeValorMoeda => campos[39];

	public CampoLayoutArquivoCobranca ValorTituloOutraUnidade => campos[40];

	public CampoLayoutArquivoCobranca ValorIOFOutraUnidade => campos[41];

	public CampoLayoutArquivoCobranca ValorDebitoCredito => campos[42];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[43];

	public CampoLayoutArquivoCobranca Filler5 => campos[44];

	public CampoLayoutArquivoCobranca Complemento => campos[45];

	public CampoLayoutArquivoCobranca SiglaEmpresaNoSistema => campos[46];

	public CampoLayoutArquivoCobranca Filler6 => campos[47];

	public CampoLayoutArquivoCobranca NumeroVersao => campos[48];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[49];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban033.REGISTRO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição", "Tipo de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição", "Número de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta do movimento do beneficiário", "Conta do movimento do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 29, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Conta de cobrança do beneficiário", "Conta de cobrança do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 37, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Número de controle do participante", "Número de controle de responsabilidade do cliente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 107, 37, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Código da ocorrência", "Código da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Data da ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 134, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Código original da remessa", "Código original da remessa - apenas caso ocorra erro no processamento da remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 135, 136, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Código do erro da 1ª ocorrência", "Código do erro da 1ª ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 137, 139, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código do erro da 2ª ocorrência", "Código do erro da 2ª ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Código do erro da 3ª ocorrência", "Código do erro da 3ª ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 143, 145, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 146, 146, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Data de vencimento", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Valor nominal do título", "Valor do título em moeda corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Número do banco cobrador", "Número do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Código da agência recebedora do título", "Código da agência recebedora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Espécie de documento", "Espécie de documento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor da tarifa", "Valor da tarifa cobrada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor de outras despesas", "Valor de outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor dos juros", "Valor dos juros de atraso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 214, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Valor do IOF", "Valor do IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor do abatimento concedido", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor do desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor total recebido", "Valor total recebido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor dos juros de mora", "Valor dos juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Valor de outros créditos", "Valor de outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 293, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Código de aceite", "Código de aceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 294, 294, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 295, 295, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Data do crédito", "Data do crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 296, 301, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Nome do sacado", "Nome do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 302, 337, 36, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Identificador do complemento", "Identificador do complemento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 338, 338, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Unidade de valor moeda corrente", "Undiade de valor de moeda corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 339, 340, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Valor do título em outra unidade de valor", "Valor do título em outra unidade de valor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 341, 353, 8, 5);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Valor do IOF em outra unidade de valor", "Valor do IOF em outra unidade de valor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 354, 366, 8, 5);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Valor do débito ou crédito", "Valor do débito ou crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 367, 379, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Tipo operação", "Tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 380, 380, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Filler", "Informar em brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 381, 383, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Complemento", "Complemento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 384, 385, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Sigla da empresa no sistema", "Silga da empresa no sistema", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 386, 389, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 390, 391, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.1", "Número da versão", "Número da versão", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.1", "Número sequencial do registro no arquivo", "Número sequencial do registro no arquivo de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
