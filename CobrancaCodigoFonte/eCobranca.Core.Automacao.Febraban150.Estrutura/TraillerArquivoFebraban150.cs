using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public abstract class TraillerArquivoFebraban150 : SegmentoFebraban150
{
	public TraillerArquivoFebraban150()
	{
		try
		{
			Logger.Debug("Criando campos do HEADER DE ARQUIVO do layout FEBRABAN150...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Código do registro", "Informar o código do registro: Z", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Quantidade total de registros no arquivo", "Quantidade total de registros incluindo o header e trailler", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 7, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Valor total dos registros no arquivo", "Valor total dos registros do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 24, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 25, 149, 125, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Filler2", "Informar ZERO", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 150, 150, 1, 0);
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
