using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;

public class RegistroTipo1RemessaCnab400Ban033 : DetalheRemessaCnab400, IRegistroTipo1RemessaCnab400Ban033
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca ContaMovimentoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca ContaCobrancaBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca DataSegundoDesconto => campos[8];

	public CampoLayoutArquivoCobranca Filler1 => campos[9];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[10];

	public CampoLayoutArquivoCobranca PercentualMulta => campos[11];

	public CampoLayoutArquivoCobranca UnidadeValorMoeda => campos[12];

	public CampoLayoutArquivoCobranca ValorTituloEmOutraUnidade => campos[13];

	public CampoLayoutArquivoCobranca Filler2 => campos[14];

	public CampoLayoutArquivoCobranca DataMulta => campos[15];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[16];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[17];

	public CampoLayoutArquivoCobranca SeuNumero => campos[18];

	public CampoLayoutArquivoCobranca DataVencimento => campos[19];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[20];

	public CampoLayoutArquivoCobranca NumeroBancoCobrador => campos[21];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[22];

	public CampoLayoutArquivoCobranca EspecieDocumento => campos[23];

	public CampoLayoutArquivoCobranca TipoAceite => campos[24];

	public CampoLayoutArquivoCobranca DataEmissaoTitulo => campos[25];

	public CampoLayoutArquivoCobranca PrimeiraInstrucaoCobranca => campos[26];

	public CampoLayoutArquivoCobranca SegundaInstrucaoCobranca => campos[27];

	public CampoLayoutArquivoCobranca ValorJurosAoDia => campos[28];

	public CampoLayoutArquivoCobranca DataLimiteDesconto => campos[29];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[30];

	public CampoLayoutArquivoCobranca ValorIOF => campos[31];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[32];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[33];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[34];

	public CampoLayoutArquivoCobranca NomePagador => campos[35];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[36];

	public CampoLayoutArquivoCobranca BairroPagador => campos[37];

	public CampoLayoutArquivoCobranca PrefixoCEPPagador => campos[38];

	public CampoLayoutArquivoCobranca SufixoCEPPagador => campos[39];

	public CampoLayoutArquivoCobranca MunicipioPagador => campos[40];

	public CampoLayoutArquivoCobranca UFPagador => campos[41];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[42];

	public CampoLayoutArquivoCobranca Filler3 => campos[43];

	public CampoLayoutArquivoCobranca IdentificadorComplemento => campos[44];

	public CampoLayoutArquivoCobranca Complemento => campos[45];

	public CampoLayoutArquivoCobranca Filler4 => campos[46];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[47];

	public CampoLayoutArquivoCobranca Filler5 => campos[48];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[49];

	public RegistroTipo1RemessaCnab400Ban033(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban033.REGISTRO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição cedente", "Tipo de inscrição do cedente. 01-CPF, 02-CNPJ ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do cedente", "Número do CNPJ ou CPF do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta movimento beneficiário", "Conta movimento beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 29, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Conta cobrança beneficiário", "Número da conta de cobrança do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 37, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Número de controle do participante", "Número de controle do participante, para controle por parte do beneficiário ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Data do segundo desconto", "Data do segundo desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 76, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 77, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Código de multa", "Informação de multa = 4, senão houver informar zero", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 78, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Percentual de multa por atraso", "Percentual de multa por atraso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 79, 82, 2, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Unidade de valor de moeda corrente", "Unidade de valor de moeda corrente. Informar 00", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 84, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Valor do título em outra unidade", "Valor do título em outra unidade", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 85, 97, 8, 5);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 98, 101, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Data para cobrança da multa", "Data para cobrança da multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 102, 107, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Código da ocorrência de remessa", "Código da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Seu número", "Número de controle de responsbilidade do cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Data de vencimento", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Número do banco na compensação", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Agência cobradora", "Código da agência cobradora do banco Santander. Informar apenas quando o código da carteira for igual a 5", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Tipo de aceite", "Código do aceite - Informar N", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Data de emissão", "Dta de emissão do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Primeira instrução de cobrança", "Primeira instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Segunda instrução de cobrança", "Segunda instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor de juros de mora", "Valor de juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Data de desconto", "Data limite para concessão de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor de IOF", "Valor de IOF para nota de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 8, 5);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Valor de abatimento", "Valor do abatimento a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador. 01-CPF, 02-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Endereço do pagador", "Logradouro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Bairro do pagador", "Bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Prefixo do CEP do pagador", "Prefixo do CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 331, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Sufixo do CEP do pagador", "Sufixo do CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 332, 334, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Nome do sacador ou coobrigado", "Nome do sacador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 381, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 382, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Identificador do complemento", "Identificador do complemento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 383, 383, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Complemento 2", "Complemento 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 384, 385, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 386, 391, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.1", "Número de dias para protesto", "Número de dias para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
