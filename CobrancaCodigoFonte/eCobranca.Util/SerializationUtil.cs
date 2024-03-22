using System;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class SerializationUtil
{
	public static string SerializarParaXml<T>(this T value)
	{
		if (value == null)
		{
			return string.Empty;
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			using XmlWriter xmlWriter = XmlWriter.Create(new StringWriterWithEncoding(stringBuilder, Encoding.UTF8));
			xmlSerializer.Serialize(xmlWriter, value);
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSerializandoObjetoParaXml(typeof(T), ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return string.Empty;
		}
	}

	public static string RemoverCaracteresInvalidosXml(this string inString)
	{
		if (inString == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in inString)
		{
			if (XmlConvert.IsXmlChar(c))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}
}
