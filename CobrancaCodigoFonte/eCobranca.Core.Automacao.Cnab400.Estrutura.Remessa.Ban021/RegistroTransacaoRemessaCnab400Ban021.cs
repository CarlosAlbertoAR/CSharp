using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;

public class RegistroTransacaoRemessaCnab400Ban021 : DetalheRemessaCnab400, IRegistroTransacaoRemessaCnab400Ban021
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[5];

	public CampoLayoutArquivoCobranca NossoNumero => campos[6];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[7];

	public CampoLayoutArquivoCobranca ValorMulta => campos[8];

	public CampoLayoutArquivoCobranca IdentificacaoCarne => campos[9];

	public CampoLayoutArquivoCobranca NumeroParcelaCarne => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeParcelasCarne => campos[11];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[12];

	public CampoLayoutArquivoCobranca InscricaoSacadorAvalista => campos[13];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[14];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[16];

	public CampoLayoutArquivoCobranca DataVencimento => campos[17];

	public CampoLayoutArquivoCobranca Filler2 => campos[18];

	public CampoLayoutArquivoCobranca ValorNominal => campos[19];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[20];

	public CampoLayoutArquivoCobranca PracaCobranca => campos[21];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[22];

	public CampoLayoutArquivoCobranca CodigoAceite => campos[23];

	public CampoLayoutArquivoCobranca DataEmissao => campos[24];

	public CampoLayoutArquivoCobranca PrimeiraInstrucaoCobranca => campos[25];

	public CampoLayoutArquivoCobranca SegundaInstrucaoCobranca => campos[26];

	public CampoLayoutArquivoCobranca CodigoJuros => campos[27];

	public CampoLayoutArquivoCobranca ValorJuros => campos[28];

	public CampoLayoutArquivoCobranca DataLimiteDesconto => campos[29];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[30];

	public CampoLayoutArquivoCobranca IOC => campos[31];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[32];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[33];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[34];

	public CampoLayoutArquivoCobranca NomePagador => campos[35];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[36];

	public CampoLayoutArquivoCobranca BairroPagador => campos[37];

	public CampoLayoutArquivoCobranca CepPagador => campos[38];

	public CampoLayoutArquivoCobranca CidadePagador => campos[39];

	public CampoLayoutArquivoCobranca EstadoPagador => campos[40];

	public CampoLayoutArquivoCobranca MensagemCampoInstrucao => campos[41];

	public CampoLayoutArquivoCobranca Filler3 => campos[42];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[43];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[44];

	public RegistroTransacaoRemessaCnab400Ban021(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban021.REGISTRO_TRANSACAO.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do beneficiário", "01 - CPF, 02 - CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do beneficiário", "Informar o número de inscrição do beneficiário sem máscara", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Identificação do beneficiário", "Conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 28, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 29, 37, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número do controle participante", "Código de controle particular do título no beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Nosso número", "Nosso número do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 72, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Código da multa", "Código da instrução de multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 73, 73, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Valor da multa", "Valor ou percentual de multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 82, 7, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Identificação do carnê", "Identificação do carnê", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 88, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Número da parcela do carnê", "Informar o número da parcela do carnê", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 89, 90, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Quantidade de parcelas do carnê", "Quandidade de parcelas do carnê", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 91, 92, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Tipo de inscrição do sacador/avalista", "1-CPF, 2-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 93, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Inscrição do sacador/avalista", "Número de inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 94, 107, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Código da ocorrência", "Código da ocorrência na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Número do documento", "Informar o número do documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data de vencimento", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 129, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Valor nominal do título", "Informar o valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 130, 139, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Código do banco", "Informar o código 021", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Codigo(), "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Praça de cobrança", "Praça de cobrança responsável pela postagem", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Espécie do título", "Informar a espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Identificação do aceite", "Informar o código de aceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Data de emissão do título", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Primeira instrução de cobrança", "Código da primeira instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Segunda instrução de cobrança", "Código da segunda instrução de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Código de juros", "Informar o código de juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 161, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor dos juros", "Informar o valor ou percentual de juros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 162, 173, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Data limite para desconto", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.7", "Valor de desconto", "Valor de desconto a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "IOC", "Em caso de título de seguro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Valor do abatimento", "Valor do abatimento a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Tipo de inscrição do pagador", "01-CPF, 02-CNPJ, 99-Outros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Endereço do pagador", "Informar o endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Bairro do pagador", "Informar o bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "CEP do pagador", "CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Cidade do pagador", "Nome da cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Estado do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Mensagem a ser impressa", "Mensagem para impressão no campo instrução", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 391, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Código da moeda", "Informar o código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
