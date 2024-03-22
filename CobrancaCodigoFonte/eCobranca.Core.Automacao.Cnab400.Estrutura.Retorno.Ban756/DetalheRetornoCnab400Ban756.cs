using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban756;

public class DetalheRetornoCnab400Ban756 : DetalheRetornoCnab400, IDetalheRetornoCnab400Ban756
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca NumeroConvenio => campos[7];

	public CampoLayoutArquivoCobranca NumeroControleParticipante => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[10];

	public CampoLayoutArquivoCobranca NumeroParcela => campos[11];

	public CampoLayoutArquivoCobranca GrupoValor => campos[12];

	public CampoLayoutArquivoCobranca CodigoBaixaRecusa => campos[13];

	public CampoLayoutArquivoCobranca PrefixoTitulo => campos[14];

	public CampoLayoutArquivoCobranca VariacaoCarteira => campos[15];

	public CampoLayoutArquivoCobranca ContaCaucao => campos[16];

	public CampoLayoutArquivoCobranca CodigoResponsabilidade => campos[17];

	public CampoLayoutArquivoCobranca DVCodigoResponsabilidade => campos[18];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[19];

	public CampoLayoutArquivoCobranca ValorIOF => campos[20];

	public CampoLayoutArquivoCobranca Filler1 => campos[21];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[22];

	public CampoLayoutArquivoCobranca Ocorrencia => campos[23];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[24];

	public CampoLayoutArquivoCobranca SeuNumero => campos[25];

	public CampoLayoutArquivoCobranca Filler2 => campos[26];

	public CampoLayoutArquivoCobranca DataVencimento => campos[27];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[28];

	public CampoLayoutArquivoCobranca CodigoBancoRecebedor => campos[29];

	public CampoLayoutArquivoCobranca CodigoAgenciaRecebedora => campos[30];

	public CampoLayoutArquivoCobranca DVAgenciaRecebedora => campos[31];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[32];

	public CampoLayoutArquivoCobranca DataCredito => campos[33];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[34];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[35];

	public CampoLayoutArquivoCobranca ValorJurosDoDesconto => campos[36];

	public CampoLayoutArquivoCobranca ValorIOFDoDesconto => campos[37];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[38];

	public CampoLayoutArquivoCobranca DescontoConcedido => campos[39];

	public CampoLayoutArquivoCobranca ValorRecebido => campos[40];

	public CampoLayoutArquivoCobranca ValorJuros => campos[41];

	public CampoLayoutArquivoCobranca ValorOutrosRecebimentos => campos[42];

	public CampoLayoutArquivoCobranca ValorAbatimentoNaoAproveitadoPeloPagador => campos[43];

	public CampoLayoutArquivoCobranca ValorLancamento => campos[44];

	public CampoLayoutArquivoCobranca IndicativoDebitoCredito => campos[45];

	public CampoLayoutArquivoCobranca IndicativoValor => campos[46];

	public CampoLayoutArquivoCobranca ValorAjuste => campos[47];

	public CampoLayoutArquivoCobranca Filler3 => campos[48];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[49];

	public CampoLayoutArquivoCobranca Filler4 => campos[50];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[51];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número da inscrição do pagador", "Número da inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Prefixo da agência", "Código do prefixo da agência do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "DV do Prefixo da agência", "Dígito verificador do prefixo da agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 22, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número da conta corrente do cedente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 30, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "DV da conta corrente", "Dígito verificador do número da conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Número do convênio", "Número do convênio de cobrança do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 37, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Número do controle participante", "Número do controle participante", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 73, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Dígito verificador do nosso número", "DV do nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 74, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Número da parcela", "Número da parcela", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 76, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Grupo de valor", "Grupo de valor: informar 00", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 80, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Código de baixa/recusa", "Código de baixa/recusa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 81, 82, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 83, 85, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Variacao da carteira", "Variação da carteira.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 88, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Conta caução", "Conta caução.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 89, 89, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Código de responsabilidade", "Código de responsabilidade.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 90, 94, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Dígito verificador do código de responsabilidade", "DV código de responsabilidade.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 95, 95, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Percentual de taxa de desconto", "Percentual de taxa de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 96, 100, 3, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Taxa de IOF", "Taxa de IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 105, 1, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Código da carteira", "Código da carteira.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Código da ocorrência", "Código da ocorrência de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Data ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "0", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Data de vencimento", "Data de vencimento do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor título", "Valor nominal do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Codigo do banco recebedor", "Código do banco recebedor.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Código da agência recebedora", "Código da agência recebedora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 172, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Dígito verificador da agência recebedora", "DV agência recebedora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 173, 173, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Data do crédito", "Data do crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 181, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Valor da tarifa", "Valor da tarifa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 182, 188, 5, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Valor outras despesas", "Valor de outras despesas.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Valor juros do desconto", "Valor juros do desconto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 214, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "IOF do desconto", "IOF do desconto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 215, 227, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Valor do abatimento", "Valor do abatimento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Valor desconto", "Valor do desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Valor recebido", "Valor recebido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Juros de mora", "Valor juros de mora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Valor outros recebimentos", "Valor de outros recebimentos.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.1", "Valor do abatimento não aproveitado", "Valor do abatimento não aproveitado pelo pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 305, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.1", "Valor do lançamento", "Valor do lançamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 306, 318, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.1", "Indicativo de débito/crédito", "Indicativo de débito/crédito.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 319, 319, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.1", "Indicativo de valor", "Indicativo de valor", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 320, 320, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.1", "Valor do ajuste", "Valor do ajuste", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 321, 332, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 333, 342, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.1", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 343, 357, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("51.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 358, 394, 37, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("52.1", "Sequência do registro", "Sequência do registro.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
