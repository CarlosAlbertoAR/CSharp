using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public abstract class HeaderArquivoFebraban150 : SegmentoFebraban150
{
	public HeaderArquivoFebraban150()
	{
		try
		{
			Logger.Debug("Criando campos do HEADER DE ARQUIVO do layout FEBRABAN150...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Código do registro", "Informar o código do registro: A", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Código da operação", "Informar o código da operação: 1 - Remessa, 2 - Retorno ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Código do convênio", "Informar o código do convênio informado pelo banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 3, 22, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Nome do beneficiário", "Nome da empresa do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 23, 42, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Código do banco", "Código do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 43, 45, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Nome do banco", "Nome do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 46, 65, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Data da geração  do arquivo", "Data da geração do arquivo no formato AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 73, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Número sequêncial do arquivo", "Número sequêncial do arquivo NSA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 79, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Versão do layout", "Versão do layout", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 81, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Uso do banco", "Uso do banco informar CODBAR", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 82, 149, 68, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Uso exclusivo FEBRABAN", "Informar ZERO", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 150, 150, 1, 0);
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
