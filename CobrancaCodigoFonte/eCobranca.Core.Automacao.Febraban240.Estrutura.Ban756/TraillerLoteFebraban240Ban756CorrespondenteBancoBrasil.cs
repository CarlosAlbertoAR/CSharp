using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil : TraillerLoteFebraban240, ITraillerLoteFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca Filler1 => campos[0];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[1];

	public CampoLayoutArquivoCobranca Filler2 => campos[2];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosLote => campos[3];

	public CampoLayoutArquivoCobranca ValorTitulosLote => campos[4];

	public CampoLayoutArquivoCobranca Filler3 => campos[5];

	public CampoLayoutArquivoCobranca Filler4 => campos[6];

	public TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil()
	{
		try
		{
			campos.Clear();
			Logger.Debug("Criando campos do TRAILLER DE LOTE do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.5", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 7, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.5", "Código do registro", "Informar 5", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo(), EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.5", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 17, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.5", "Quantidade de registros no lote", "Quantidade de registros no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.5", "Valor dos títulos do lote", "Valor dos títulos do lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 40, 15, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.5", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 46, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.5", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 240, 194, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoHeaderLoteFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
