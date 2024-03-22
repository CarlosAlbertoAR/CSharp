using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using eCobranca.Core.Excecao;

namespace eCobranca.Core.Automacao.Converter;

public class ConverterDoubleToString : IValueConverter
{
	private Guid guid;

	public ConverterDoubleToString()
	{
	}

	public ConverterDoubleToString(Guid guid)
		: this()
	{
		this.guid = guid;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string text = "";
		try
		{
			if (parameter == null)
			{
				parameter = "";
			}
			if (double.TryParse(value.ToString(), out var result))
			{
				text = result.ToString(parameter.ToString());
				text = text.Replace(culture.NumberFormat.NumberDecimalSeparator, "");
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorMonetarioInvalidoParaConversao(), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoValorMonetarioParaCampoRemessa(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double result = 0.0;
		try
		{
			if (double.TryParse(value.ToString(), out result))
			{
				result /= 100.0;
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoCampoRetornoParaValorMonetario(value.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return result;
	}
}
