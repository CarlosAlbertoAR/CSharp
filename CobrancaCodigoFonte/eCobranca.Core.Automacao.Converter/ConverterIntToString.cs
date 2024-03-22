using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using eCobranca.Core.Excecao;

namespace eCobranca.Core.Automacao.Converter;

public class ConverterIntToString : IValueConverter
{
	private Guid guid;

	public ConverterIntToString()
	{
	}

	public ConverterIntToString(Guid guid)
		: this()
	{
		this.guid = guid;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string text = "";
		try
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				text = result.ToString();
				text = text.Replace(culture.NumberFormat.NumberDecimalSeparator, "");
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.InteiroInvalidoParaConversao(), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoInteiroParaCampoRemessa(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int result = 0;
		try
		{
			if (int.TryParse(value.ToString(), out result))
			{
				return result;
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoCampoRetornoParaInteiro(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return result;
	}
}
