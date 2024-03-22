using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class ResourceUtil
{
	public static Stream GetResourceStream(string nomeRecursoCompleto)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		List<string> source = new List<string>(executingAssembly.GetManifestResourceNames());
		nomeRecursoCompleto = nomeRecursoCompleto.Replace("/", ".");
		string text = source.FirstOrDefault((string r) => r.Contains(nomeRecursoCompleto));
		if (text == null)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoRecurso(null), new StackTrace().GetFrame(1).GetMethod());
		}
		return executingAssembly.GetManifestResourceStream(text);
	}
}
