using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using eCobranca.Core.Excecao;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Converter;

public class ConverterTimeToString : IValueConverter
{
	private Guid guid;

	public ConverterTimeToString()
	{
	}

	public ConverterTimeToString(Guid guid)
		: this()
	{
		this.guid = guid;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string text = "";
		try
		{
			if (DateTime.TryParse(value.ToString(), out var result))
			{
				text = StringUtil.ZerosLeft(result.Hour.ToString(), 2);
				text += StringUtil.ZerosLeft(result.Minute.ToString(), 2);
				text += StringUtil.ZerosLeft(result.Second.ToString(), 2);
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.HoraInvalidaParaConversao(), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoHoraParaCampoRemessa(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		DateTime dateTime = default(DateTime);
		try
		{
			string text = "";
			if (!string.IsNullOrEmpty(value.ToString()))
			{
				text = value.ToString().Trim();
				dateTime = new DateTime(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year, int.Parse(text.Substring(0, 2)), int.Parse(text.Substring(2, 2)), int.Parse(text.Substring(4, 2)));
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoCampoRetornoParaHora(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return dateTime;
	}
}
