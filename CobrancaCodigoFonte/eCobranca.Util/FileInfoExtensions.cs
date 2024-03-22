using System.Diagnostics;
using System.IO;

namespace eCobranca.Util;

public static class FileInfoExtensions
{
	public static void Print(this FileInfo value)
	{
		Process process = new Process();
		process.StartInfo.FileName = value.FullName;
		process.StartInfo.Verb = "Print";
		process.Start();
	}
}
