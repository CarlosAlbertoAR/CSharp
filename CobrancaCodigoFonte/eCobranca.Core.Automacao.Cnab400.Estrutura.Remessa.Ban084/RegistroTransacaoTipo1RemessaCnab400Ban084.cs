using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;

public class RegistroTransacaoTipo1RemessaCnab400Ban084 : DetalheRemessaCnab400, IRegistroTransacaoTipo1RemessaCnab400Ban084
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca AgenciaDebito => campos[1];

	public CampoLayoutArquivoCobranca DVAgenciaDebito => campos[2];

	public CampoLayoutArquivoCobranca RazaoContaCorrente => campos[3];

	public CampoLayoutArquivoCobranca ContaCorrente => campos[4];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[5];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco => campos[6];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[7];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[8];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[9];

	public CampoLayoutArquivoCobranca PercentualMulta => campos[10];

	public CampoLayoutArquivoCobranca NossoNumero => campos[11];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[12];

	public CampoLayoutArquivoCobranca DescontoBonificacaoPorDia => campos[13];

	public CampoLayoutArquivoCobranca CondicaoEmissaoBloqueto => campos[14];

	public CampoLayoutArquivoCobranca IdentificacaoEmissaoBoletoDebitoAutomatico => campos[15];

	public CampoLayoutArquivoCobranca IdentificacaoOperacao => campos[16];

	public CampoLayoutArquivoCobranca IndicadorRateioCredito => campos[17];

	public CampoLayoutArquivoCobranca EnderecamentoParaAvisoDebitoAutomatico => campos[18];

	public CampoLayoutArquivoCobranca Filler1 => campos[19];

	public CampoLayoutArquivoCobranca IdentificacaoOcorrencia => campos[20];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[21];

	public CampoLayoutArquivoCobranca DataVencimento => campos[22];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[23];

	public CampoLayoutArquivoCobranca CodigoBancoCobrador => campos[24];

	public CampoLayoutArquivoCobranca AgenciaDepositaria => campos[25];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[26];

	public CampoLayoutArquivoCobranca Identificacao => campos[27];

	public CampoLayoutArquivoCobranca DataEmissao => campos[28];

	public CampoLayoutArquivoCobranca Instrucao1 => campos[29];

	public CampoLayoutArquivoCobranca Instrucao2 => campos[30];

	public CampoLayoutArquivoCobranca ValorJurosDia => campos[31];

	public CampoLayoutArquivoCobranca DataDesconto => campos[32];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[33];

	public CampoLayoutArquivoCobranca ValorIOF => campos[34];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[35];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[36];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[37];

	public CampoLayoutArquivoCobranca NomePagador => campos[38];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[39];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[40];

	public CampoLayoutArquivoCobranca PrefixoCepPagador => campos[41];

	public CampoLayoutArquivoCobranca SufixoCepPagador => campos[42];

	public CampoLayoutArquivoCobranca BairroPagador => campos[43];

	public CampoLayoutArquivoCobranca CidadePagador => campos[44];

	public CampoLayoutArquivoCobranca UfPagador => campos[45];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[46];

	public RegistroTransacaoTipo1RemessaCnab400Ban084(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_1.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Agência de débito", "Código da agência do pagador. Exclusivo para débito em conta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 6, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Dígito da agência de débito", "Dígito da agêncis do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 7, 7, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Razão da conta corrente", "Razão da conta do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 12, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta corrente", "Número da conta do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 13, 19, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Dígito da conta corrente", "Dígito da conta do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 20, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Identificação da empresa", "Zero, carteira, agência e conta corrente do beneficiário ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 21, 37, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Número controle do participante", "Uso da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código do banco", "Número do banco. Utilizar 237.Segundo o BRADESCO, deverá ser informado 000 quando o cliente não optar pelo débito automático. Caso contrário informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 65, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Campo de multa", "Se igual a 2 considerar percentual de multa. Se igual a 0 sem multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 66, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Percentual de multa", "Percentual de multa a ser considerado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 67, 70, 2, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Identificação do título no banco (nosso número)", "Número bancário para cobrança com e sem registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 81, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Dígito de auto conferência do número (dv do nosso número)", "Dígito do nosso número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 82, 82, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Desconto de bonificação por dia", "Valor do desconto por dia", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 92, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Identificação do emissor do boleto", "1 = Banco emite e processa registro. 2 = Cliente emite e banco processa o registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 93, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Identificacao de débito automático", "N = Não registra na cobrança.Diferente de N = registra e emite boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 94, 94, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Identificação da operação", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 104, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Indicador de rateio de crédito", "R", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 105, 105, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Endereçamento para aviso de débito automático em conta corrente", "Endereçamento para aviso de débito automático em conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Identificação da ocorrência", "Códigos de ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Número do documento", "Documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data do vencimento do título", "Formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Valor do título", "Valor do título. Preencher sem ponto e sem vírgula", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Banco encarregado da cobrança", "Preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Agência depositária", "Preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Espécie do título", "DominioEspecieTitulo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Identificação", "Informar sempre N", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Data de emissão do título", "Formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Primeira instrução", "Primeira instrução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Segunda instrução", "Segunda instrução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Juros de mora", "Valor a ser cobrado por dia de atraso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Data limite para desconto", "Data limite para concessão de desconto no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Valor do IOF", "Valor do IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Valor abatimento", "Valor do abatimento a ser concedido ou cancelado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Tipo inscrição do pagador", "Identificação do tipo de inscrição do pagador. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Número de inscrição do pagador", "CNPJ ou CPF do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 274, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Endereço completo do pagador", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Primeira mensagem", "Primeira mensagem", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "CEP", "CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 331, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Sufixo do CEP", "Sufixo do CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 332, 334, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Bairro do pagador", "Preencher com o bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 354, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Cidade do pagador", "Preencher com a cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 355, 392, 38, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "UF do pagador", "Preencher com a UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
