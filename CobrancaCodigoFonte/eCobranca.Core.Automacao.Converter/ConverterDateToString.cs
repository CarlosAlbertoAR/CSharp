using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using eCobranca.Core.Excecao;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Converter;

public class ConverterDateToString : IValueConverter
{
	private EnumTipoData tipo;

	private Guid guid;

	public ConverterDateToString(EnumTipoData tipo)
	{
		this.tipo = tipo;
	}

	public ConverterDateToString(Guid guid, EnumTipoData tipo)
		: this(tipo)
	{
		this.guid = guid;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			if (parameter == null)
			{
				parameter = tipo;
			}
			if (DateTime.TryParse(value.ToString(), out var result))
			{
				if (Enum.IsDefined(typeof(EnumTipoData), parameter.ToString()))
				{
					switch ((EnumTipoData)Enum.Parse(typeof(EnumTipoData), parameter.ToString()))
					{
					case EnumTipoData.DDMMAA:
						stringBuilder.Append(StringUtil.ZerosLeft(result.Day.ToString(), 2));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Month.ToString(), 2));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Year.ToString().Substring(2, 2), 2));
						break;
					case EnumTipoData.DDMMAAAA:
						stringBuilder.Append(StringUtil.ZerosLeft(result.Day.ToString(), 2));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Month.ToString(), 2));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Year.ToString(), 4));
						break;
					case EnumTipoData.AAAAMMDD:
						stringBuilder.Append(StringUtil.ZerosLeft(result.Year.ToString(), 4));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Month.ToString(), 2));
						stringBuilder.Append(StringUtil.ZerosLeft(result.Day.ToString(), 2));
						break;
					}
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.DataInvalidaParaConversao(), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoDataParaCampoRemessa(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return stringBuilder.ToString();
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		DateTime? dateTime = null;
		try
		{
			string text = "";
			DateTime result = default(DateTime);
			if (parameter == null)
			{
				parameter = tipo;
			}
			if (string.IsNullOrEmpty(value.ToString()))
			{
				return null;
			}
			text = value.ToString().Trim();
			string s = "";
			if (Enum.IsDefined(typeof(EnumTipoData), parameter.ToString()))
			{
				switch ((EnumTipoData)Enum.Parse(typeof(EnumTipoData), parameter.ToString()))
				{
				case EnumTipoData.DDMMAA:
					if (text.Length < 6)
					{
						return null;
					}
					s = text.Substring(0, 2) + "/" + text.Substring(2, 2) + "/" + text.Substring(4, 2);
					break;
				case EnumTipoData.DDMMAAAA:
					if (text.Length < 8)
					{
						return null;
					}
					s = text.Substring(0, 2) + "/" + text.Substring(2, 2) + "/" + text.Substring(4, 4);
					break;
				case EnumTipoData.AAAAMMDD:
					if (text.Length < 8)
					{
						return null;
					}
					s = text.Substring(6, 2) + "/" + text.Substring(4, 2) + "/" + text.Substring(0, 4);
					break;
				}
			}
			if (!DateTime.TryParse(s, out result))
			{
				return null;
			}
			dateTime = result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoCampoRetornoParaData(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return dateTime;
	}
}
