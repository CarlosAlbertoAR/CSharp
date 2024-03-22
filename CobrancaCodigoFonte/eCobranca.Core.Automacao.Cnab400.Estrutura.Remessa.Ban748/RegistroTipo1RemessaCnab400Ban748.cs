using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public class RegistroTipo1RemessaCnab400Ban748 : DetalheRemessaCnab400, IRegistroTipo1RemessaCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoCobranca => campos[1];

	public CampoLayoutArquivoCobranca TipoCarteira => campos[2];

	public CampoLayoutArquivoCobranca TipoImpressao => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca TipoMoeda => campos[5];

	public CampoLayoutArquivoCobranca TipoDesconto => campos[6];

	public CampoLayoutArquivoCobranca TipoJuros => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca Filler3 => campos[10];

	public CampoLayoutArquivoCobranca DataInstrucao => campos[11];

	public CampoLayoutArquivoCobranca CampoAlterado => campos[12];

	public CampoLayoutArquivoCobranca PostagemTitulo => campos[13];

	public CampoLayoutArquivoCobranca Filler4 => campos[14];

	public CampoLayoutArquivoCobranca TipoEmissaoBoleto => campos[15];

	public CampoLayoutArquivoCobranca NumeroParcelaCarne => campos[16];

	public CampoLayoutArquivoCobranca NumeroTotalParcelasCarne => campos[17];

	public CampoLayoutArquivoCobranca Filler5 => campos[18];

	public CampoLayoutArquivoCobranca ValorDescontoPorDiaAntecipacao => campos[19];

	public CampoLayoutArquivoCobranca PercentualMulta => campos[20];

	public CampoLayoutArquivoCobranca Filler6 => campos[21];

	public CampoLayoutArquivoCobranca Instrucao => campos[22];

	public CampoLayoutArquivoCobranca SeuNumero => campos[23];

	public CampoLayoutArquivoCobranca DataVencimento => campos[24];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[25];

	public CampoLayoutArquivoCobranca Filler7 => campos[26];

	public CampoLayoutArquivoCobranca EspecieDocumento => campos[27];

	public CampoLayoutArquivoCobranca TipoAceite => campos[28];

	public CampoLayoutArquivoCobranca DataEmissao => campos[29];

	public CampoLayoutArquivoCobranca InstrucaoProtestoAutomatico => campos[30];

	public CampoLayoutArquivoCobranca NumeroDiasProtestoAutomatico => campos[31];

	public CampoLayoutArquivoCobranca ValorJurosAoDia => campos[32];

	public CampoLayoutArquivoCobranca DataDesconto => campos[33];

	public CampoLayoutArquivoCobranca ValorPercentualDesconto => campos[34];

	public CampoLayoutArquivoCobranca Filler8 => campos[35];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[36];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[37];

	public CampoLayoutArquivoCobranca Filler9 => campos[38];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[39];

	public CampoLayoutArquivoCobranca NomePagador => campos[40];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[41];

	public CampoLayoutArquivoCobranca CodigoPagadorNaCooperativa => campos[42];

	public CampoLayoutArquivoCobranca Filler10 => campos[43];

	public CampoLayoutArquivoCobranca Filler11 => campos[44];

	public CampoLayoutArquivoCobranca CepPagador => campos[45];

	public CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario => campos[46];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[47];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[48];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[49];

	public RegistroTipo1RemessaCnab400Ban748(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de cobrança", "A - Sicredi com registro, C - Sicredi sem registro ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Tipo de carteira", "A - Simples", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 3, 3, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Tipo de impressão", "A - Normal, B - Carnê", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 4, 4, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 5, 16, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Tipo de moeda", "A - Real", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 17, 17, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Tipo de desconto", "A - Valor, B - Percentual", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Tipo de juros", "A - Valor, B - Percentual", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 19, 19, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 47, 28, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Nosso número", "Nosso número sicredi", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 48, 56, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 57, 62, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Data da instrução", "O formato da data de instrudção do arquivo deve estar no padrão: AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 70, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Campo alterado", "Utilizar apenas quando instrução (109-110) for igual a 31", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 71, 71, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Postagem do título", "S - para postar o título diretamente ao pagador N - Não postar e remeter o título para o beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 72, 72, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 73, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Identificação do emissor do boleto", "A - impressão é feita pelo Sicredi B - Impressão é feita pelo Beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 74, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Número da parcela no carnê", "Quando tipo de impressão for B - Carnê", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 76, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Número total de parcelas no carnê", "Quando tipo de impressão for B - Carnê", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 78, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 79, 82, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Valor de desconto por dia de antecipação", "Informar o valor de desconto ou informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 92, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Percentual de multa por pagamento em atraso", "Percnetual de multa ou informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 96, 2, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Filler", "Informar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 97, 108, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Instrução do movimento de remessa", "Informar o código do movimento de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Seu número", "Número de controle do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Data de vencimento", "Data de vencimento no formato: DDMMAA. Deve ser maior do que 7 dias da data de emissão.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 140, 148, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Espécie do título", "Espécie do título. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 149, 149, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Aceite do título", "Aceite do título. DominioTipoAceite ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Data de emissão", "Data de emissão do título no formato DDMMAA. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Instrução de protesto automático", "Tipo de protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Número de dias para protesto automático", "Mínimo de 3 dias. Quando informado 3 ou 4 dias o sistema comandará protesto em dias úteis, caso contrário será em dias corridos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Juros de mora por dia de atraso", "Taxa de juros mora por dia de atraso.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Data desconto / Juros Mora", "Data limite para concessão de desconto, aplicação de juros mora no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Valor do desconto", "Informe o valor de desconto incidente sobre o título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Filler", "Sempre preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Valor do abatimento", "Valor do abatimento concedido ao título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Tipo de inscrição do sacado", "Tipo de inscrição do sacado. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 219, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Filler", "Sempre preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 220, 220, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Número inscrição do sacado", "Número do CPF ou do CNPJ do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Nome do sacado", "Nome do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Endereço do sacado", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Código do pagador na cooperativa do beneficiário", "Enviar sempre zero quando o sistema do beneficiário não utilizar esse campo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 315, 319, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Filler", "Sempre preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 320, 325, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 326, 326, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Cep do pagador", "Cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Código do pagador junto ao beneficiário", "Campo númerico, informar zeros quando inexistente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 335, 339, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.1", "Número de inscrição do sacador/avalista", "Número de inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 340, 353, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.1", "Nome do sacador/avalista", "Nome do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 354, 394, 41, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.1", "Sequencial do registro", "Número sequencial do registro na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
