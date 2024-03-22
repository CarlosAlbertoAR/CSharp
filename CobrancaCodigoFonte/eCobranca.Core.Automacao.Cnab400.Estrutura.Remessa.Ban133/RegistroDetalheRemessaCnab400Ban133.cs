using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;

public class RegistroDetalheRemessaCnab400Ban133 : DetalheRemessaCnab400, IRegistroDetalheRemessaCnab400Ban133
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[1];

	public CampoLayoutArquivoCobranca DVAgencia => campos[2];

	public CampoLayoutArquivoCobranca RazaoContaCorrente => campos[3];

	public CampoLayoutArquivoCobranca ContaCorrente => campos[4];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[5];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[7];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[8];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[9];

	public CampoLayoutArquivoCobranca PercentualMulta => campos[10];

	public CampoLayoutArquivoCobranca NossoNumero => campos[11];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[12];

	public CampoLayoutArquivoCobranca DescontoBonificacaoPorDia => campos[13];

	public CampoLayoutArquivoCobranca IdentificacaoEmissorBoleto => campos[14];

	public CampoLayoutArquivoCobranca IdentificacaoDebitoAutomatico => campos[15];

	public CampoLayoutArquivoCobranca IdentificacaoOperacaoBanco => campos[16];

	public CampoLayoutArquivoCobranca IndicadorRateioCredito => campos[17];

	public CampoLayoutArquivoCobranca EnderecamentoAvisoDebitoAutomatico => campos[18];

	public CampoLayoutArquivoCobranca QuantidadePossiveisPagamento => campos[19];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[20];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[21];

	public CampoLayoutArquivoCobranca DataVencimento => campos[22];

	public CampoLayoutArquivoCobranca ValorNominal => campos[23];

	public CampoLayoutArquivoCobranca BancoEncarregadoCobranca => campos[24];

	public CampoLayoutArquivoCobranca AgenciaDepositaria => campos[25];

	public CampoLayoutArquivoCobranca Especie => campos[26];

	public CampoLayoutArquivoCobranca Identificacao => campos[27];

	public CampoLayoutArquivoCobranca DataEmissao => campos[28];

	public CampoLayoutArquivoCobranca PrimeiraInstrucao => campos[29];

	public CampoLayoutArquivoCobranca SegundaInstrucao => campos[30];

	public CampoLayoutArquivoCobranca ValorJurosAoDia => campos[31];

	public CampoLayoutArquivoCobranca DataLimiteDesconto => campos[32];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[33];

	public CampoLayoutArquivoCobranca ValorIOF => campos[34];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[35];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[36];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[37];

	public CampoLayoutArquivoCobranca NomePagador => campos[38];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[39];

	public CampoLayoutArquivoCobranca PrimeiraMensagem => campos[40];

	public CampoLayoutArquivoCobranca CepPagador => campos[41];

	public CampoLayoutArquivoCobranca SacadorAvalista => campos[42];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[43];

	public RegistroDetalheRemessaCnab400Ban133(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban133.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Agência de débito", "Agência de débito", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 6, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Dígito verificador da agência de débito", "DV da agência de débito", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 7, 7, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Razão da conta corrente", "Razão da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 12, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta corrente", "Conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 13, 19, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Dígito verificador da conta corrente", "DV da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 20, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Identificação do beneficiário no banco", "Identificação do beneficiário no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 21, 37, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Número controle do participante", "Número controle do participante", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código do banco", "Código do banco a ser debitado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 65, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código de multa", "Código de multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 66, 66, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Percentual de multa", "Percentual de multa a ser considerado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 67, 70, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 71, 81, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "DV do nosso número", "DV do nosso número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 82, 82, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Desconto bonificação por dia", "Desconto bonificação por dia", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 92, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Identificação emissor boleto", "Identificação emissor boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 93, 93, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Identificação débito automático", "Identificação débito automático", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 94, 94, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Identificação operação no banco", "Identificação operação no banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 104, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Indicador de rateio de crédito", "Indicador de rateio de crédito", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 105, 105, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Endereçamento para aviso de débito automático", "Endereçamento para aviso de débito automático", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Quantidade possíveis pagamentos", "Quantidade possíveis pagamentos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Identificação da ocorrência", "Identificação da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Número do documento", "Número do documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data de vencimento do título", "Data de vencimento do título DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Valor do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Banco encarregado da cobrança", "Banco encarregado da cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Agência depositária", "Agência depositária", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Identificação", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Data de emissão do título", "Data de emissão do título no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Primeira instrução", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Segunda instrução", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Valor juros ao dia", "Valor juros ao dia", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Data limite de desconto", "Data limite de desconto no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Valor do IOF", "Valor do IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Tipo inscrição do pagador", "Tipo inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Endereço completo", "Endereço completo", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Primeira mensagem", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Cep do pagador", "Cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "0", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Sacador avalista", "Sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 394, 60, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Número sequencial do regitro", "Adicionar 1 ao sequencial do registro aterior", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
