using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public class RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041 : DetalheRemessaCnab400, IRegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[1];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => base.Campos[2];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[3];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => base.Campos[4];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[5];

	public CampoLayoutArquivoCobranca Mensagem => base.Campos[6];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[7];

	public CampoLayoutArquivoCobranca TipoCarteira => base.Campos[8];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => base.Campos[9];

	public CampoLayoutArquivoCobranca SeuNumero => base.Campos[10];

	public CampoLayoutArquivoCobranca DataVencimento => base.Campos[11];

	public CampoLayoutArquivoCobranca ValorTitulo => base.Campos[12];

	public CampoLayoutArquivoCobranca BancoCobrador => base.Campos[13];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[14];

	public CampoLayoutArquivoCobranca TipoDocumento => base.Campos[15];

	public CampoLayoutArquivoCobranca CodigoAceite => base.Campos[16];

	public CampoLayoutArquivoCobranca DataEmissao => base.Campos[17];

	public CampoLayoutArquivoCobranca CodigoInstrucao1 => base.Campos[18];

	public CampoLayoutArquivoCobranca CodigoInstrucao2 => base.Campos[19];

	public CampoLayoutArquivoCobranca CodigoJurosDeMora => base.Campos[20];

	public CampoLayoutArquivoCobranca ValorPercentualJurosAoDia => base.Campos[21];

	public CampoLayoutArquivoCobranca DataDesconto => base.Campos[22];

	public CampoLayoutArquivoCobranca ValorDesconto => base.Campos[23];

	public CampoLayoutArquivoCobranca ValorIOF => base.Campos[24];

	public CampoLayoutArquivoCobranca ValorAbatimento => base.Campos[25];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => base.Campos[26];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => base.Campos[27];

	public CampoLayoutArquivoCobranca NomePagador => base.Campos[28];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[29];

	public CampoLayoutArquivoCobranca EnderecoPagador => base.Campos[30];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[31];

	public CampoLayoutArquivoCobranca TaxaMulta => base.Campos[32];

	public CampoLayoutArquivoCobranca NumeroDiasMultaAposVencimento => base.Campos[33];

	public CampoLayoutArquivoCobranca CepPagador => base.Campos[34];

	public CampoLayoutArquivoCobranca CidadePagador => base.Campos[35];

	public CampoLayoutArquivoCobranca UFPagador => base.Campos[36];

	public CampoLayoutArquivoCobranca TaxaAoDiaPagamentoAntecipado => base.Campos[37];

	public CampoLayoutArquivoCobranca Filler7 => base.Campos[38];

	public CampoLayoutArquivoCobranca ValorParaCalculoDesconto => base.Campos[39];

	public CampoLayoutArquivoCobranca NumeroDiasProtestoOuDevolucaoAutomatica => base.Campos[40];

	public CampoLayoutArquivoCobranca Filler8 => base.Campos[41];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[42];

	public RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

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
			campoLayoutArquivoCobranca.Preparar("02.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 17, 16, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Código do beneficiário", "Informe AAAACCCCCCC, onde: AAAA = agência, e CCCCCCCCC", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 30, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 37, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Identificação do título no beneficiário", "Identificação do título no beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 72, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Mensagem no bloqueto", "Campo alfanúmerico opcional. Será impresso no campo instruções.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 104, 32, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 105, 107, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Tipo de carteira", "Código do tipo da carteira", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código de ocorrência", "Código da ocorrência do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Seu número", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Data de vencimento", "Data do vencimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Banco cobrador", "Código do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 143, 147, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Tipo de documento", "Para todos os documentos será considerado Duplicata Mercantil. Para carteiras N, R, S e X deixe o campo em branco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Código de aceite", "Código de aceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Data de emissão do título", "Data de emissão do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Código da primeira instrução", "Código da primeira instrução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Código da segunda instrução", "Código da segunda instrução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Código de juros de mora", "Para carteiras N, R, S e X deixar o campo em branco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 161, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "valor ao dia ou taxa mensal de juros", "Para carteiras N, R, S e X deixar o campo em branco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 162, 173, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data de desconto", "Formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Valor do desconto", "Valor do desconto a ser concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Valor IOF", "Valor do IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Número da inscrição do pagador", "Número da inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 269, 35, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 270, 274, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Endereço do pagador", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 321, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Taxa para multa após vencimento", "Infomar o valor apenas com uma casa decimal", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 322, 324, 2, 1);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Número de dias para multa após vencimento", "Número de dias para multa após vencimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 325, 326, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Cep do pagador", "Cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Taxa ao dia para pagamento antecipado", "Para carteiras N, R, S e X informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 352, 355, 2, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Filler7", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 356, 356, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Valor para cálculo do desconto", "Carteiras N, R, S e X informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 357, 369, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.1", "Número de dias para protesto ou devolução automática", "Para carteiras N, R, S e X informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 370, 371, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.1", "Filler8", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 372, 394, 23, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
