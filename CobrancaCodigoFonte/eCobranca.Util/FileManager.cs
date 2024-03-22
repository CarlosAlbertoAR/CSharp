using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public static class FileManager
{
	public static void WriteBytesToFile(string absoluteFileName, byte[] dataFile)
	{
		try
		{
			Logger.Debug("Criando arquivo a partir de uma array de bytes...");
			string path = Path.GetFileName(absoluteFileName).Replace(".cart", "_antiga.cart");
			if (File.Exists(absoluteFileName))
			{
				File.Move(absoluteFileName, Path.Combine(Path.GetDirectoryName(absoluteFileName), path));
			}
			if (dataFile != null || dataFile.Length != 0)
			{
				using FileStream fileStream = new FileStream(absoluteFileName, FileMode.Create);
				fileStream.Write(dataFile, 0, dataFile.Length);
			}
			if (File.Exists(Path.Combine(Path.GetDirectoryName(absoluteFileName), path)))
			{
				File.Delete(Path.Combine(Path.GetDirectoryName(absoluteFileName), path));
			}
		}
		catch (Exception ex)
		{
			if (File.Exists(Path.Combine(Path.GetDirectoryName(absoluteFileName), Path.GetFileName(absoluteFileName).Replace(".cart", "_antiga.cart"))))
			{
				File.Move(Path.GetFileName(absoluteFileName).Replace(".cart", "_antiga.cart"), absoluteFileName);
			}
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ImpossivelEscreverArquivoEmDisco(absoluteFileName, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public static void WriteStringToFile(string absoluteFileName, string dataFile)
	{
		try
		{
			Logger.Debug("Criando arquivo a partir de uma string...");
			WriteBytesToFile(absoluteFileName, Encoding.UTF8.GetBytes(dataFile));
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaEscrevendoStringEmArquivo(absoluteFileName, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public static byte[] ReadBytesFromFile(string absoluteFileName)
	{
		byte[] array = null;
		try
		{
			Logger.Debug($"Lendo array de bytes do arquivo [{absoluteFileName}]...");
			FileInfo fileInfo = null;
			try
			{
				fileInfo = new FileInfo(absoluteFileName);
				if (fileInfo.Exists)
				{
					using FileStream fileStream = new FileStream(absoluteFileName, FileMode.Open);
					array = new byte[fileStream.Length];
					fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
				}
			}
			finally
			{
				if (fileInfo != null)
				{
					fileInfo = null;
				}
			}
			return array;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return array;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ImpossivelLerBytesDeArquivo(absoluteFileName, ex), new StackTrace().GetFrame(1).GetMethod());
			return array;
		}
	}

	public static string ReadStringFromFile(string absoluteFileName)
	{
		string result = "";
		try
		{
			Logger.Debug($"Lendo string do arquivo [{absoluteFileName}]");
			byte[] bytes = ReadBytesFromFile(absoluteFileName);
			result = Encoding.UTF8.GetString(bytes);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaLendoStringEmArquivo(absoluteFileName, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static void SaveFileStream(string nomeArquivoAbsoluto, Stream stream)
	{
		if (!Directory.Exists(Path.GetDirectoryName(nomeArquivoAbsoluto)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivoAbsoluto));
		}
		using FileStream fileStream = new FileStream(nomeArquivoAbsoluto, FileMode.Create, FileAccess.Write);
		stream.CopyTo(fileStream);
		fileStream.Flush();
	}

	private static void ExcluirArquivosTemporarios()
	{
		ArrayList allFilesFromDirectory = GetAllFilesFromDirectory(AppDomain.CurrentDomain.BaseDirectory ?? "", "BoletoTemp*.pdf");
		foreach (string item in allFilesFromDirectory)
		{
			if (!IsFileInUse(AppDomain.CurrentDomain.BaseDirectory + item))
			{
				File.Delete(AppDomain.CurrentDomain.BaseDirectory + item);
			}
		}
		allFilesFromDirectory.Clear();
		allFilesFromDirectory = GetAllFilesFromDirectory(AppDomain.CurrentDomain.BaseDirectory ?? "", "BoletoTemp*.htm");
		foreach (string item2 in allFilesFromDirectory)
		{
			if (!IsFileInUse(AppDomain.CurrentDomain.BaseDirectory + item2))
			{
				File.Delete(AppDomain.CurrentDomain.BaseDirectory + item2);
			}
		}
		allFilesFromDirectory.Clear();
	}

	public static byte[] Combine(params byte[][] arrays)
	{
		byte[] array = null;
		try
		{
			array = new byte[arrays.Sum((byte[] a) => a.Length)];
			int num = 0;
			foreach (byte[] array2 in arrays)
			{
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return array;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaCombinandoArrayDeBytes(ex), new StackTrace().GetFrame(1).GetMethod());
			return array;
		}
	}

	public static ArrayList GetAllFilesFromDirectory(string directory, string fileFilter)
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			FileInfo[] files = new DirectoryInfo(directory).GetFiles(fileFilter);
			foreach (FileInfo fileInfo in files)
			{
				arrayList.Add(fileInfo.Name);
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return arrayList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoTodosOsArquivosDoDiretorio(directory, ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}

	public static bool IsFileInUse(string path)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	public static void LimparDiretorio(string diretorio)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(diretorio);
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo obj in files)
		{
			obj.IsReadOnly = false;
			obj.Delete();
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo obj2 in directories)
		{
			LimparDiretorio(obj2.FullName);
			obj2.Delete();
		}
	}

	public static bool LimparDiretorioESubPastas(string pathName)
	{
		bool flag = false;
		DirectoryInfo directoryInfo = new DirectoryInfo(pathName);
		flag = RemoverApenasArquivosDoDiretorio(directoryInfo);
		foreach (DirectoryInfo item in directoryInfo.EnumerateDirectories())
		{
			try
			{
				LimparDiretorioESubPastas(item.FullName);
				item.Delete();
				while (item.Exists)
				{
					Thread.Sleep(10);
					item.Refresh();
				}
			}
			catch (IOException)
			{
				flag = true;
			}
		}
		return !flag;
	}

	public static bool RemoverApenasArquivosDoDiretorio(DirectoryInfo dir)
	{
		bool flag = false;
		foreach (FileInfo item in dir.EnumerateFiles())
		{
			try
			{
				if (!(item.LastAccessTime == DateTime.Today))
				{
					item.IsReadOnly = false;
					item.Delete();
					while (item.Exists)
					{
						Thread.Sleep(10);
						item.Refresh();
					}
				}
			}
			catch (IOException ex)
			{
				Logger.Warn("Falha excluindo arquivo: " + ex.Message);
				flag = true;
			}
		}
		return !flag;
	}

	public static bool RemoverApenasArquivosDoDiretorio(DirectoryInfo dir, string fileFilter)
	{
		bool flag = false;
		foreach (FileInfo item in dir.EnumerateFiles())
		{
			try
			{
				if (!(item.LastAccessTime.ToString("ddMMyyyy") == DateTime.Today.ToString("ddMMyyyy")))
				{
					string[] array = fileFilter.Split('.');
					string empty = string.Empty;
					_ = string.Empty;
					if (array.Length == 0)
					{
						goto IL_0090;
					}
					empty = array[0];
					if (item.Name.ToLower().Contains(empty.ToLower()))
					{
						goto IL_0090;
					}
				}
				goto end_IL_001a;
				IL_0090:
				item.IsReadOnly = false;
				item.Delete();
				while (item.Exists)
				{
					Thread.Sleep(10);
					item.Refresh();
				}
				end_IL_001a:;
			}
			catch (UnauthorizedAccessException ex)
			{
				Logger.Warn("Falha excluindo arquivo: " + ex.Message);
				flag = true;
			}
			catch (IOException ex2)
			{
				Logger.Warn("Falha excluindo arquivo: " + ex2.Message);
				flag = true;
			}
		}
		return !flag;
	}
}
