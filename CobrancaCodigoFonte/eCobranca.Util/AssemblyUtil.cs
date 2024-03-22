using System;
using System.Diagnostics;
using System.Reflection;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class AssemblyUtil
{
	public static Assembly GetAssembly(string pAssemblyName)
	{
		Assembly result = null;
		if (string.IsNullOrEmpty(pAssemblyName))
		{
			return result;
		}
		result = GetAssemblyEmbedded(pAssemblyName);
		if (result == null)
		{
			GetAssemblyDLL(pAssemblyName);
		}
		return result;
	}

	public static Assembly GetAssemblyEmbedded(string assemblyDisplayName)
	{
		Assembly result = null;
		if (string.IsNullOrEmpty(assemblyDisplayName))
		{
			return result;
		}
		try
		{
			result = Assembly.Load(assemblyDisplayName);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoAssemblyInterno(assemblyDisplayName, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static Assembly GetAssemblyDLL(string assemblyNameDLL)
	{
		Assembly result = null;
		if (string.IsNullOrEmpty(assemblyNameDLL))
		{
			return result;
		}
		try
		{
			if (!assemblyNameDLL.ToLower().EndsWith(".dll"))
			{
				assemblyNameDLL += ".dll";
			}
			result = Assembly.LoadFrom(assemblyNameDLL);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDLLAssembly(assemblyNameDLL, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string GetVersionStringFromAssembly(string assemblyDisplayName)
	{
		string result = "Unknown";
		Assembly assembly = null;
		assembly = GetAssembly(assemblyDisplayName);
		if (assembly == null)
		{
			return result;
		}
		return GetVersionString(assembly.GetName().Version.ToString());
	}

	public static string GetVersionString(Version version)
	{
		string result = "Unknown";
		if (version == null)
		{
			return result;
		}
		return GetVersionString(version.ToString());
	}

	public static string GetVersionString(string versionString)
	{
		string text = "Unknown";
		if (string.IsNullOrEmpty(versionString))
		{
			return text;
		}
		string[] array = versionString.Split('.');
		if (array.Length != 0)
		{
			text = array[0];
		}
		if (array.Length > 1)
		{
			text = text + "." + array[1];
		}
		if (array.Length > 2)
		{
			text = text + "." + array[2].PadLeft(4, '0');
		}
		if (array.Length > 3)
		{
			text = text + "." + array[3].PadLeft(4, '0');
		}
		return text;
	}

	public static string GetVersionStringFromAssemblyEmbedded(string assemblyDisplayName)
	{
		string result = "Unknown";
		Assembly assembly = null;
		assembly = GetAssemblyEmbedded(assemblyDisplayName);
		if (assembly == null)
		{
			return result;
		}
		return GetVersionString(assembly.GetName().Version.ToString());
	}

	public static string GetVersionStringFromAssemblyDLL(string assemblyDisplayName)
	{
		string result = "Unknown";
		Assembly assembly = null;
		assembly = GetAssemblyDLL(assemblyDisplayName);
		if (assembly == null)
		{
			return result;
		}
		return GetVersionString(assembly.GetName().Version.ToString());
	}
}
