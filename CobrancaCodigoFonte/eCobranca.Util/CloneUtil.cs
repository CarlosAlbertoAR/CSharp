using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class CloneUtil
{
	public static T DeepClone<T>(this T a)
	{
		T result = default(T);
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, a);
			memoryStream.Position = 0L;
			result = (T)binaryFormatter.Deserialize(memoryStream);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaClonandoObjeto(a.GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
