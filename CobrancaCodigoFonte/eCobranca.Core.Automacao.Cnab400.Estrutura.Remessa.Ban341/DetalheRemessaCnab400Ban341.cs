using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public class DetalheRemessaCnab400Ban341 : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVAgenciaContaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca CondigoInstrucaoOuAlegacaoASerCancelada => campos[8];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[9];

	public CampoLayoutArquivoCobranca NossoNumero => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeMoedaVariavel => campos[11];

	public CampoLayoutArquivoCobranca NumeroCarteiraNoBanco => campos[12];

	public CampoLayoutArquivoCobranca IdentificacaoOperacaoNoBanco => campos[13];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[14];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[16];

	public CampoLayoutArquivoCobranca DataVencimento => campos[17];

	public CampoLayoutArquivoCobranca ValorNominalTitulo => campos[18];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[19];

	public CampoLayoutArquivoCobranca CodigoAgenciaCobradora => campos[20];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[21];

	public CampoLayoutArquivoCobranca TipoAceite => campos[22];

	public CampoLayoutArquivoCobranca DataEmissao => campos[23];

	public CampoLayoutArquivoCobranca InstrucaoCobranca1 => campos[24];

	public CampoLayoutArquivoCobranca InstrucaoCobranca2 => campos[25];

	public CampoLayoutArquivoCobranca ValorJurosAoDia => campos[26];

	public CampoLayoutArquivoCobranca DataDesconto => campos[27];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[28];

	public CampoLayoutArquivoCobranca ValorIOF => campos[29];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[30];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[31];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[32];

	public CampoLayoutArquivoCobranca NomePagador => campos[33];

	public CampoLayoutArquivoCobranca Filler3 => campos[34];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[35];

	public CampoLayoutArquivoCobranca BairroPagador => campos[36];

	public CampoLayoutArquivoCobranca CepPagador => campos[37];

	public CampoLayoutArquivoCobranca CidadePagador => campos[38];

	public CampoLayoutArquivoCobranca UFPagador => campos[39];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[40];

	public CampoLayoutArquivoCobranca Filler4 => campos[41];

	public CampoLayoutArquivoCobranca DataJuros => campos[42];

	public CampoLayoutArquivoCobranca QuantidadeDias => campos[43];

	public CampoLayoutArquivoCobranca Filler5 => campos[44];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[45];

	public DetalheRemessaCnab400Ban341(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban341.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do cedente", "Tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do cedente", "Número do CPF/CNPJ do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência", "Agência mantenedora da conta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Complemento de registro", "Complemento de registro - Informar ZEROS", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 23, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número da conta corrente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 28, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Dígito verificador da agência/conta corrente", "Dígito de auto conferência agência/conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 29, 29, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 33, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código da instrução/alegação", "Código da instrução/alegação a ser cancelada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 34, 37, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Identificação do título no cedente ", "Identificação do título no cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Identificação do título no banco", "Identificação do título na banco - nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Quantidade de moeda", "Quantidade de moeda variável", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 83, 8, 5);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Número da carteira", "Número da carteira no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 84, 86, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Uso do banco", "Identificação da operação no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 87, 107, 21, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Código da carteira", "Código da carteira de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Código da ocorrência", "Identificação da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Número do documento", "Número do documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data de vencimento do título", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Valor do título", "Valor nominal do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Código do banco", "Código do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Agência cobradora", "Agência onde o título será cobrado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Espécie do título", "Tipo do documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Aceite", "Identificação de título aceito ou não aceito", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Data de emissão", "Data de emissão do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Instrução 1", "1ª instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Instrução 2", "2ª instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Juros ao dia", "Valor de juros de mora por dia de atraso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Data desconto", "Data  limite para concessão de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor do desconto", "Valor do desconto a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor do IOF", "Valor do IOF recolhido para notas de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor do abatimento", "Valor do abatimento a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Tipo inscrição do sacado", "Identificação do tipo de inscrição do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Número da inscrição do sacado", "Número da inscrição do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Nome do sacado", "Nome do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 264, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 265, 274, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Endereço do sacado", "Rua, número e complemento do endereço do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Bairro do sacado", "Bairro do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Cep do sacado", "Cep do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Cidade do sacado", "Cidade do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "UF do sacado", "UF do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Sacador/Avalista", "Nome do sacador ou avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 381, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 385, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Data de mora", "Data de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 386, 391, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Prazo", "Quantidade de dias", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Sequencial do registro", "Número sequencial do registro na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
