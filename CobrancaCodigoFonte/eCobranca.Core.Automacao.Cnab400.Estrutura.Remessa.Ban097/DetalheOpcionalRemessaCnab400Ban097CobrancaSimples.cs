using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;

public class DetalheOpcionalRemessaCnab400Ban097CobrancaSimples : DetalheRemessaCnab400, IDetalheOpcionalRemessaCnab400Ban097CobrancaSimples
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => base.Campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => base.Campos[2];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => base.Campos[3];

	public CampoLayoutArquivoCobranca LogradouroSacadorAvalista => base.Campos[4];

	public CampoLayoutArquivoCobranca NumeroLogradouroSacadorAvalista => base.Campos[5];

	public CampoLayoutArquivoCobranca ComplementoSacadorAvalista => base.Campos[6];

	public CampoLayoutArquivoCobranca BairroSacadorAvalista => base.Campos[7];

	public CampoLayoutArquivoCobranca CidadeSacadorAvalista => base.Campos[8];

	public CampoLayoutArquivoCobranca UfSacadorAvalista => base.Campos[9];

	public CampoLayoutArquivoCobranca CepSacadorAvalista => base.Campos[10];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[11];

	public CampoLayoutArquivoCobranca InstrucaoTitulo => base.Campos[12];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[13];

	public CampoLayoutArquivoCobranca ValorJuros => base.Campos[14];

	public CampoLayoutArquivoCobranca TipoJuros => base.Campos[15];

	public CampoLayoutArquivoCobranca TipoCarenciaJuros => base.Campos[16];

	public CampoLayoutArquivoCobranca DiasCarenciaJuros => base.Campos[17];

	public CampoLayoutArquivoCobranca ValorMulta => base.Campos[18];

	public CampoLayoutArquivoCobranca TipoMulta => base.Campos[19];

	public CampoLayoutArquivoCobranca TipoCarenciaMulta => base.Campos[20];

	public CampoLayoutArquivoCobranca DiasCarenciaMulta => base.Campos[21];

	public CampoLayoutArquivoCobranca DataPrimeiroDesconto => base.Campos[22];

	public CampoLayoutArquivoCobranca ValorPrimeiroDesconto => base.Campos[23];

	public CampoLayoutArquivoCobranca TipoPrimeiroDesconto => base.Campos[24];

	public CampoLayoutArquivoCobranca DataSegundoDesconto => base.Campos[25];

	public CampoLayoutArquivoCobranca ValorSegundoDesconto => base.Campos[26];

	public CampoLayoutArquivoCobranca TipoSegundoDesconto => base.Campos[27];

	public CampoLayoutArquivoCobranca DataTerceiroDesconto => base.Campos[28];

	public CampoLayoutArquivoCobranca ValorTerceiroDesconto => base.Campos[29];

	public CampoLayoutArquivoCobranca TipoTerceiroDesconto => base.Campos[30];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[31];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[32];

	public DetalheOpcionalRemessaCnab400Ban097CobrancaSimples(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban097.DETALHE_OPCIONAL.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do sacador/avalista", "01-CPF, 02-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do sacador/avalista", "CPF ou CNPJ do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Nome do sacador/avalista", "Nome do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 57, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Logradouro do sacador/avalista", "Logradouro do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 58, 92, 35, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Número do logradouro sacador/avalista", "Número do logradouro do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 98, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Complemento do sacador/avalista", "Complemento do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 99, 123, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Bairro do sacador/avalista", "Bairro do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 124, 148, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Cidade do sacador/avalista", "Cidade do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 149, 173, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "UF do sacador/avalista", "UF do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 175, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "CEP do sacador/avalista", "CEP do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 176, 183, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 184, 184, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Instrução do título", "Texto de responsabilidade do Beneficiário a ser impresso no corpo do boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 185, 283, 99, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 284, 184, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Valor de Juros", "Valor dos juros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 285, 299, 11, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Tipo de juros", "F-Valor Fixo, P-Porcentagem, I-Isento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 300, 300, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Tipo de carência de juros", "1-Úteis, 2-Corridos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 301, 301, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Dias de carência juros", "Quantidade de dias de carência após vencimento para incidência de cobrança de juros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 302, 303, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Valor de multa", "Informar o valor da multa com 4 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 304, 318, 11, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Tipo de multa", "F-Valor Fixo, P-Porcentagem, I-Isento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 319, 319, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Tipo de carência de multa", "1-Úteis, 2_Corridos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 320, 320, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Dias carência da multa", "Quantidade de dias de carência após vencimento para incidência de cobrança de multa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 321, 322, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data primeiro desconto", "Data do primeiro desconto no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 323, 328, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Valor primeiro desconto", "Informar com 4 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 329, 341, 9, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Tipo primeiro desconto", "F-Valor Fixo, P-Porcentagem, I-Isento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 342, 342, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Data segundo desconto", "Data do segundo desconto no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 343, 348, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Valor segundo desconto", "Informar com 4 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 349, 361, 9, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Tipo primeiro desconto", "F-Valor Fixo, P-Porcentagem, I-Isento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 362, 362, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Data terceiro desconto", "Data do terceiro desconto no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 363, 368, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Valor terceiro desconto", "Informar com 4 casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 369, 381, 9, 4);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Tipo terceiro desconto", "F-Valor Fixo, P-Porcentagem, I-Isento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 382, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 383, 394, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
