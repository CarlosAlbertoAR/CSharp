using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public static class StringUtil
{
	public static string RemoverMascara(string valorMascarado)
	{
		try
		{
			Logger.Debug($"Removendo máscara do valor [{valorMascarado}]");
			string text = "().,/\\- ";
			string text2 = "";
			text2 = valorMascarado;
			for (int i = 0; i < text.Length; i++)
			{
				text2 = text2.Replace(text[i].ToString(), "");
			}
			return text2;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaRemovendoMascaramento(valorMascarado, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public static string AplicarMascara(string valorSemMascara, string mascara)
	{
		string result = "";
		try
		{
			if (valorSemMascara.Length >= RemoverMascara(mascara).Length)
			{
				valorSemMascara = valorSemMascara.Substring(valorSemMascara.Length - RemoverMascara(mascara).Length, RemoverMascara(mascara).Length);
				string text = valorSemMascara;
				for (int i = 0; i < mascara.Length; i++)
				{
					if (mascara[i] != '0' && mascara[i] != 'A')
					{
						text = text.Insert(i, mascara[i].ToString());
					}
				}
				result = text;
				return result;
			}
			throw ExcecaoECobranca.Infra.MascaraInvalidaParaValorInformado(valorSemMascara, mascara);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaAplicandoMascaramento(valorSemMascara, mascara, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string IncrementString(string strToIncrement, string initValue, string maxValue, string mask)
	{
		return IncrementString(strToIncrement, Convert.ToInt64(initValue), Convert.ToInt64(maxValue), mask);
	}

	public static string IncrementString(string strToIncrement, long initValue, long maxValue, string mask)
	{
		try
		{
			Logger.Debug($"Incrementando string [{strToIncrement}] obedecendo máscara...");
			string result = string.Empty;
			long num = 0L;
			if (!string.IsNullOrEmpty(strToIncrement))
			{
				num = Convert.ToInt64(strToIncrement);
			}
			num++;
			if (num <= maxValue)
			{
				result = ZerosLeft(Convert.ToString(num), mask.Length);
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaIncrementandoString(strToIncrement, initValue, maxValue, mask, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public static string ZerosLeft(string strOrigem, int tamanho)
	{
		try
		{
			string text = "";
			if (tamanho <= strOrigem.Length)
			{
				text = strOrigem.Substring(0, tamanho);
			}
			else
			{
				text = strOrigem;
				while (text.Length < tamanho)
				{
					text = "0" + text;
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaAdicionandoZerosAEsquerda(strOrigem, tamanho, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public static string ObterStringComBrancos(int tamanho)
	{
		try
		{
			Logger.Debug($"Formatando string com [{tamanho}] caracteres em branco...");
			string text = "";
			for (int i = 0; i < tamanho; i++)
			{
				text += " ";
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoStringComBrancos(tamanho, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public static string ObterValorDeCampoMascarado(string valorMascarado, int nivelMascara)
	{
		string text = "";
		try
		{
			Logger.Debug($"Obtendo valor de campo mascarado [{valorMascarado}] no nível [{nivelMascara}]");
			string text2 = " .-/\\";
			int num = 1;
			int num2 = 0;
			bool flag = false;
			for (int i = 0; i < text2.Length; i++)
			{
				flag = valorMascarado.Contains(text2[i]);
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				return valorMascarado;
			}
			while (num < nivelMascara)
			{
				for (int j = num2; j < valorMascarado.Length; j++)
				{
					num2++;
					if (text2.Contains(valorMascarado[j]))
					{
						num++;
						break;
					}
				}
			}
			do
			{
				if (num == nivelMascara)
				{
					for (int k = num2; k < valorMascarado.Length; k++)
					{
						num2++;
						if (text2.Contains(valorMascarado[k]))
						{
							num++;
							break;
						}
						text += valorMascarado[k];
					}
					continue;
				}
				return text;
			}
			while (num2 < valorMascarado.Length);
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoValorDeStringMascarada(valorMascarado, nivelMascara, ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public static string FormatValueToSizedString(double value, int strSize)
	{
		string text = "";
		try
		{
			Logger.Debug($"Formatando o valor sem separadores [{value}] para uma string de tamanho [{strSize}]...");
			text = value.ToString("F2");
			text = text.Replace(",", "");
			text = text.Replace(".", "");
			text = ZerosLeft(text, strSize);
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaFormatandoValorNumericoParaStringDeTamanhoDefinido(value, strSize, ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public static string[] GetStringsFromStream(Stream stream)
	{
		string[] result = null;
		try
		{
			Logger.Debug($"Convertendo um stream em um array de string...");
			ArrayList arrayList = new ArrayList();
			using (StreamReader streamReader = new StreamReader(stream, Encoding.Default))
			{
				string value;
				while ((value = streamReader.ReadLine()) != null)
				{
					arrayList.Add(value);
				}
				streamReader.Close();
			}
			result = (string[])arrayList.ToArray(typeof(string));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoStreamParaString(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string[] GetStringsFromStreams(Stream[] streams)
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo um array de string a partir de um array de stream...");
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < streams.Length; i++)
			{
				using StreamReader streamReader = new StreamReader(streams[i], Encoding.Default);
				string value;
				while ((value = streamReader.ReadLine()) != null)
				{
					arrayList.Add(value);
				}
				streamReader.Close();
			}
			result = (string[])arrayList.ToArray(typeof(string));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoStreamParaString(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static byte[] GetBytes(string str)
	{
		byte[] array = new byte[str.Length * 2];
		Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	public static string GetString(byte[] bytes)
	{
		char[] array = new char[bytes.Length / 2];
		Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
		return new string(array);
	}

	public static string RemoverAcentuacao(this string text)
	{
		text = Regex.Replace(text, "['^~\u00b4\u00a8`\"]", " ");
		return new string((from ch in text.Normalize(NormalizationForm.FormD)
			where char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark
			select ch).ToArray());
	}

	public static string RemoverCaracteresEspeciais(this string text)
	{
		return Regex.Replace(text, "[^\\u0000-\\u007F^\\u00C0-\\u00FF]", string.Empty);
	}

	public static bool CampoPossuiMascara(string campo)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < campo.Length; i++)
			{
				if (!char.IsLetterOrDigit(campo[i]))
				{
					result = true;
					return result;
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaVerificandoExistenciaDeMascaramento(campo, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string FormatStringToSizedString(string str, int size)
	{
		string text = string.Empty;
		try
		{
			text = TruncateString(str, size);
			if (text.Length < size)
			{
				text += ObterStringComBrancos(size - text.Length);
				return text;
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaFormatandoStringParaStringDeTamanhoDefinido(str, size, ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public static string TruncateString(string str, int size)
	{
		if (str.Length > size)
		{
			return str.Substring(0, size);
		}
		return str;
	}

	public static string ReplaceLineBreakToHtmlFormat(string str)
	{
		return Regex.Replace(str, "\\r\\n?|\\n", "<br>");
	}

	public static string RemoverQuebrasLinha(this string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		string oldValue = '\u2028'.ToString();
		string oldValue2 = '\u2029'.ToString();
		return value.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty)
			.Replace(oldValue, string.Empty)
			.Replace(oldValue2, string.Empty);
	}

	public static bool IsStringNumerica(this string str)
	{
		return str.All(char.IsDigit);
	}
}
