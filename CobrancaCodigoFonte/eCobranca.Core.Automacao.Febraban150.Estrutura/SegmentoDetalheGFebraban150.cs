using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public abstract class SegmentoDetalheGFebraban150 : SegmentoDetalheFebraban150
{
	public SegmentoDetalheGFebraban150()
	{
		try
		{
			Logger.Debug("Criando campos do HEADER DE ARQUIVO do layout FEBRABAN150...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Identificação da empresa no banco", "Preenchido com código da agência sem dv (3 posições) e conta corrente com DV (7 posições)", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 21, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Data do pagamento", "Data do pagamento no formato: AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 29, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Data do crédito", "Data do crédito no formato: AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 37, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Código de barras", "Informacoes do código de barras", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 38, 81, 44, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Valor recebido", "Valor recebido com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 82, 93, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Valor da tarifa", "Valor da tarifa com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 94, 100, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Número sequencial de registro", "Número sequêncial de registro NSR", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 108, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Código da agência arrecadadora", "Código da agência arrecadadora", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 109, 116, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Forma de arrecadação", "Forma de arrecadação: 1 - Boca de caixa, 2 - Arrecadação eletrônica", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 117, 117, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Uso exclusivo FEBRABAN", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 118, 149, 32, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Uso exclusivo FEBRABAN", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 150, 150, 1, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoHeaderArquivoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public abstract int GetNumeroSequencialArquivo();
}
