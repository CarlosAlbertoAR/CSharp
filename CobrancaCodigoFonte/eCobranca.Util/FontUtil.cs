using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using eCobranca.Core.Excecao;
using Microsoft.Win32;

namespace eCobranca.Util;

public static class FontUtil
{
	private static readonly string FONTS_NAMESPACE = "eCobranca/Core/Modelo/Fontes/";

	private static readonly string ARIAL_FONT = "arial.ttf";

	private static readonly string ARIAL_BOLD_FONT = "arialbd.ttf";

	private static readonly string ARIAL_NARROW_FONT = "ARIALN.TTF";

	private static readonly string ARIAL_NARROW_BOLD_FONT = "ARIALNB.TTF";

	private static readonly string ARIAL_BLACK_FONT = "ariblk.ttf";

	[DllImport("gdi32", EntryPoint = "AddFontResource")]
	public static extern int AddFontResourceA(string lpFileName);

	[DllImport("gdi32.dll")]
	private static extern int AddFontResource(string lpszFilename);

	[DllImport("gdi32.dll")]
	private static extern int CreateScalableFontResource(uint fdwHidden, string lpszFontRes, string lpszFontFile, string lpszCurrentPath);

	private static void RegisterFont(string contentFontName)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), contentFontName);
		if (!File.Exists(text))
		{
			string text2 = AppDomain.CurrentDomain.BaseDirectory + "\\Temp\\";
			ExtrairFonteDosRecursos(FONTS_NAMESPACE, contentFontName, text2);
			File.Copy(Path.Combine(text2, contentFontName), text);
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			privateFontCollection.AddFontFile(text);
			string name = privateFontCollection.Families[0].Name;
			AddFontResource(text);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts", name, contentFontName, RegistryValueKind.String);
		}
	}

	public static void InstallAllFonts()
	{
		RegisterFont(ARIAL_FONT);
		RegisterFont(ARIAL_BOLD_FONT);
		RegisterFont(ARIAL_NARROW_FONT);
		RegisterFont(ARIAL_NARROW_BOLD_FONT);
		RegisterFont(ARIAL_BLACK_FONT);
	}

	private static string ExtrairFonteDosRecursos(string diretorioOrigem, string nomeFonte, string diretorioDestino)
	{
		string text = string.Empty;
		try
		{
			Stream resourceStream = ResourceUtil.GetResourceStream(diretorioOrigem + nomeFonte);
			if (resourceStream != null)
			{
				text = diretorioDestino + nomeFonte;
				FileManager.SaveFileStream(text, resourceStream);
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoRecurso(null), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaExtraindoFonteDosRecursos(ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}
}
