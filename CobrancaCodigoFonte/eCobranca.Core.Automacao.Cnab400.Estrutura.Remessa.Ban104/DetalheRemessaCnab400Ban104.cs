using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;

public class DetalheRemessaCnab400Ban104 : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban104
{
	public CampoLayoutArquivoCobranca IdentificadorRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca IdentificacaoEmissaoBloqueto => campos[5];

	public CampoLayoutArquivoCobranca IdentificacaoDistribuicaoBloqueto => campos[6];

	public CampoLayoutArquivoCobranca TaxaPermanencia => campos[7];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca ModalidadeIdentificacao => campos[9];

	public CampoLayoutArquivoCobranca NossoNumero => campos[10];

	public CampoLayoutArquivoCobranca Filler1 => campos[11];

	public CampoLayoutArquivoCobranca MensagemBloqueto => campos[12];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[13];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[14];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[15];

	public CampoLayoutArquivoCobranca DataVencimento => campos[16];

	public CampoLayoutArquivoCobranca ValorNominal => campos[17];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[18];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[19];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[20];

	public CampoLayoutArquivoCobranca Aceite => campos[21];

	public CampoLayoutArquivoCobranca DataEmissao => campos[22];

	public CampoLayoutArquivoCobranca Instrucao1 => campos[23];

	public CampoLayoutArquivoCobranca Instrucao2 => campos[24];

	public CampoLayoutArquivoCobranca JurosDeMora => campos[25];

	public CampoLayoutArquivoCobranca DataDesconto => campos[26];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[27];

	public CampoLayoutArquivoCobranca ValorIOF => campos[28];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[29];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[30];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[31];

	public CampoLayoutArquivoCobranca NomePagador => campos[32];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[33];

	public CampoLayoutArquivoCobranca BairroPagador => campos[34];

	public CampoLayoutArquivoCobranca CEPPagador => campos[35];

	public CampoLayoutArquivoCobranca CidadePagador => campos[36];

	public CampoLayoutArquivoCobranca UFPagador => campos[37];

	public CampoLayoutArquivoCobranca DataMulta => campos[38];

	public CampoLayoutArquivoCobranca ValorMulta => campos[39];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[40];

	public CampoLayoutArquivoCobranca Instrucao3 => campos[41];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[42];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[43];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[44];

	public DetalheRemessaCnab400Ban104(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban104.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do cedente", "Tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do cedente", "Número do CPF/CNPJ do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência", "Prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Código do beneficiário", "Número da conta corrente do beneficiário na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 27, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "ID emissão", "Identificação da emissão do boleto de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 28, 28, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "ID Postagem", "Identificação da entrega/distribuição do bloqueto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 29, 29, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Taxa de permanência", "Comissão de permanência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 31, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Uso do beneficiário", "Identificação do título na empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 56, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Modalidade de cobrança", "Modalidade de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 57, 58, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Nosso número", "Identificação do título na caixa.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 73, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Uso exclusivo CNAB400", "Informar brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 76, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Mensagem", "Mensagem a ser impressa no bloqueto.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 106, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Código da ocorrência", "Identificação do tipo de ocorrência no arquivo de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Número do documento", "Número do documento de cobrança (seu número)", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Vencimento", "Data de vencimento do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Código do banco", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo(), "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Agência cobradora", "Agência encarregada da cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Espécie do título", "Espécie do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Aceite", "Identificação de título aceito/não aceito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data de emissão do título", "Data de emissão do título de cobrança no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Instrução 1", "Primeira instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Instrução 2", "Segunda instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor ao dia de juros de mora", "Juros de mora por dia/valor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Data do desconto", "Data limite para concessão de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Valor do desconto", "Valor do desconto a ser concedido.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor do IOF", "Valor do IOF a ser recolhido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Abatimento", "Valor do abatimento a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Tipo de inscrição", "Identificação do tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Endereço do pagador", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Bairro do pagador", "Bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "CEP do pagador", "CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Data da multa", "Definição da data para pagamento da multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 352, 357, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Valor da multa", "Valor nominal da multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 358, 367, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Sacador/avalista", "Nome do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 368, 389, 22, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Instrução 3", "Terceira instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 390, 391, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Prazo protesto", "Número de dias para início do protesto/devolução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Número sequencial", "Número sequencial do registro no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
