using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;

public class RegistroTransacaoTipo1DadosTituloRetornoCnab400Ban041 : DetalheRetornoCnab400, IRegistroTransacaoTipo1DadosTituloRetornoCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => base.Campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => base.Campos[2];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => base.Campos[3];

	public CampoLayoutArquivoCobranca TipoCobranca => base.Campos[4];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[5];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => base.Campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[7];

	public CampoLayoutArquivoCobranca NossoNumeroOpcional => base.Campos[8];

	public CampoLayoutArquivoCobranca NumeroContratoBlu => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[10];

	public CampoLayoutArquivoCobranca TipoCarteira => base.Campos[11];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => base.Campos[12];

	public CampoLayoutArquivoCobranca DataOcorrencia => base.Campos[13];

	public CampoLayoutArquivoCobranca SeuNumero => base.Campos[14];

	public CampoLayoutArquivoCobranca NossoNumero2 => base.Campos[15];

	public CampoLayoutArquivoCobranca DataVencimento => base.Campos[16];

	public CampoLayoutArquivoCobranca ValorTitulo => base.Campos[17];

	public CampoLayoutArquivoCobranca CodigoBancoCobrador => base.Campos[18];

	public CampoLayoutArquivoCobranca CodigoAgenciaCobradora => base.Campos[19];

	public CampoLayoutArquivoCobranca TipoDocumento => base.Campos[20];

	public CampoLayoutArquivoCobranca ValorDespesaCobranca => base.Campos[21];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => base.Campos[22];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[23];

	public CampoLayoutArquivoCobranca ValorAbatimento => base.Campos[24];

	public CampoLayoutArquivoCobranca ValorDesconto => base.Campos[25];

	public CampoLayoutArquivoCobranca ValorPago => base.Campos[26];

	public CampoLayoutArquivoCobranca ValorJuros => base.Campos[27];

	public CampoLayoutArquivoCobranca ValorOutrosRecebimentos => base.Campos[28];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[29];

	public CampoLayoutArquivoCobranca DataCredito => base.Campos[30];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[31];

	public CampoLayoutArquivoCobranca FormaPagamento => base.Campos[32];

	public CampoLayoutArquivoCobranca CanalPagamento => base.Campos[33];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[34];

	public CampoLayoutArquivoCobranca MotivosOcorrencia => base.Campos[35];

	public CampoLayoutArquivoCobranca Filler7 => base.Campos[36];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[37];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_1_DADOS_TITULO.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do beneficiário", "Tipo de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código do beneficiário", "Código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 30, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Tipo de cobrança", "Tipo de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 36, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 37, 37, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Identificação do título no beneficiário", "Identificação do título no beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 72, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Nosso número opcional", "Nosso número opcional", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 73, 82, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Número do contrato blu", "Número do contrato blu", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 104, 22, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 105, 107, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Tipo de carteira", "Tipo de carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Código da ocorrência", "Código da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Data da ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 116, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Nosso número 2", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 146, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Data de vencimento", "Data de vencimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 147, 152, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 153, 165, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Código do banco cobrador", "Código do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 168, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Código da agência cobradora", "Código da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 169, 173, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Tipo de documento", "Tipo de documento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Valor das despesas de cobranca", "Valor das despesas de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 188, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Valor outras despesas", "Valor das outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 201, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 227, 26, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 240, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 241, 253, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 254, 266, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Valor dos juros cobrados", "Valor dos juros cobrados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 267, 279, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Valor de outros recebimentos", "Valor de outros recebimentos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 280, 292, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 293, 295, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Data do crédito", "Data do crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 296, 301, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 302, 342, 41, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Forma de pagamento", "Forma de pagamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 343, 343, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Canal de pagamento", "Canal de pagamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 344, 344, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 345, 382, 38, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Motivos da ocorrência", "Motivos da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 383, 392, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Filler7", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 393, 394, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
