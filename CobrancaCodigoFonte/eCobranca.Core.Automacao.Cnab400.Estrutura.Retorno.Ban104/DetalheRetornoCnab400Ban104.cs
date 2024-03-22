using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban104;

public class DetalheRetornoCnab400Ban104 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban104
{
	public CampoLayoutArquivoCobranca IdentificadorRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca IdentificacaoEmissaoBloqueto => campos[5];

	public CampoLayoutArquivoCobranca IdentificacaoDistribuicaoBloqueto => campos[6];

	public CampoLayoutArquivoCobranca Filler1 => campos[7];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca Modalidade => campos[9];

	public CampoLayoutArquivoCobranca NossoNumero => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public CampoLayoutArquivoCobranca CodigoMotivoRejeicao => campos[12];

	public CampoLayoutArquivoCobranca Filler3 => campos[13];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[14];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[16];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[17];

	public CampoLayoutArquivoCobranca Filler4 => campos[18];

	public CampoLayoutArquivoCobranca DataVencimento => campos[19];

	public CampoLayoutArquivoCobranca ValorNominal => campos[20];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[21];

	public CampoLayoutArquivoCobranca CodigoAgenciaCobradora => campos[22];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[23];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[24];

	public CampoLayoutArquivoCobranca CodigoLiquidacaoBaixa => campos[25];

	public CampoLayoutArquivoCobranca CodigoFormaPagamento => campos[26];

	public CampoLayoutArquivoCobranca InformacaoFloatNegociado => campos[27];

	public CampoLayoutArquivoCobranca DataDebitoTarifa => campos[28];

	public CampoLayoutArquivoCobranca Filler5 => campos[29];

	public CampoLayoutArquivoCobranca ValorIOF => campos[30];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[31];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[32];

	public CampoLayoutArquivoCobranca ValorPrincipalPago => campos[33];

	public CampoLayoutArquivoCobranca ValorJuros => campos[34];

	public CampoLayoutArquivoCobranca ValorMulta => campos[35];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[36];

	public CampoLayoutArquivoCobranca DataCredito => campos[37];

	public CampoLayoutArquivoCobranca Filler6 => campos[38];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[39];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban104.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo inscrição cedente", "Identificação do tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número inscrição do cedente", "Número de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência", "Agência mantenedora da conta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Código do beneficiário", "Conta corrente do beneficiário na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 27, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "ID emissão", "Identificação da emissão do bloqueto ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 28, 28, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "ID postagem", "Identificação da entrega/distribuição do bloqueto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 29, 29, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Uso exclusivo da CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 31, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Identificação do título do beneficiário", "Identificação do título no cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 56, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Modalidade de cobrança", "Modalidade de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 57, 58, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Nosso número", "Identificação do título na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 73, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Uso exclusivo da CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 79, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Código de rejeição", "Código do motivo de rejeição", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 82, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Uso exclusivo da CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 106, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Código da ocorrência", "Identificação do tipo de ocorrência do arquivo retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Data da ocorrência", "Data da ocorrência na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Número do documento", "Número do documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Uso exclusivo da CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Vencimento", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Código do banco", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo(), "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Agência cobradora", "Agência encarregada da cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Espécie do título", "Espécie do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor tarifa", "Valor da tarifa/despesa de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Código do canal de liquidação", "Código do canal de liquidação ou da baixa do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 191, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Código da forma de pagamento", "Código que identifica a forma de pagamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 192, 192, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Informação do float negociado", "Informação do float negociado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 194, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Data do débito da tarifa", "Data do débito da tarifa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 195, 200, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Uso exclusivo CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 201, 214, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Valor do IOF", "Valor do IOF a ser recolhido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor do abatimento", "Valor do abatimento a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Valor do desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Valor principal", "Valor principal pago pelo pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Valor dos juros", "Valor dos juros pago pelo pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Valor da multa", "Valor da multa paga pelo pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 293, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Data de crédito", "Data de crédito dessa liquidação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 294, 299, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Uso exclusivo CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 300, 394, 95, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Número sequencial", "Número sequencial do registro no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
