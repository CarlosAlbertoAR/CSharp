using System;
using System.Diagnostics;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public static class DVGenerator
{
	public static string GetDVModulo11(string campo)
	{
		int num = -1;
		try
		{
			Logger.Debug($"Gerando DV para o código de barras [{campo}]");
			int num2 = 2;
			int num3 = 9;
			int num4 = 2;
			int num5 = 0;
			for (int num6 = campo.Length - 1; num6 >= 0; num6--)
			{
				int num7 = Convert.ToInt32(campo[num6].ToString());
				num5 += num7 * num2;
				num2 = ((num2 != num3) ? (num2 + 1) : num4);
			}
			int num8 = ((num5 <= 11) ? num5 : (num5 % 11));
			int num9 = 11 - num8;
			num = ((num9 <= 9) ? num9 : 0);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVCodigoBarrasDocumentoCobranca(campo, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}

	public static string GetDVModulo11Ban097(string campo)
	{
		int num = -1;
		try
		{
			Logger.Debug($"Gerando DV para o código de barras [{campo}]");
			int num2 = 2;
			int num3 = 9;
			int num4 = 2;
			int num5 = 0;
			if (campo.Length > 11)
			{
				num3 = 8;
			}
			for (int num6 = campo.Length - 1; num6 >= 0; num6--)
			{
				int num7 = Convert.ToInt32(campo[num6].ToString());
				num5 += num7 * num2;
				num2 = ((num2 != num3) ? (num2 + 1) : num4);
			}
			int num8 = num5 * 10 % 11;
			num = ((num8 != 10) ? num8 : 0);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVCodigoBarrasDocumentoCobranca(campo, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}

	public static string GetDVModulo11Ban748(string campo)
	{
		int num = -1;
		try
		{
			Logger.Debug($"Gerando DV para o código de barras [{campo}]");
			int num2 = 2;
			int num3 = 9;
			int num4 = 2;
			int num5 = 0;
			for (int num6 = campo.Length - 1; num6 >= 0; num6--)
			{
				int num7 = Convert.ToInt32(campo[num6].ToString());
				num5 += num7 * num2;
				num2 = ((num2 != num3) ? (num2 + 1) : num4);
			}
			int num8 = ((num5 <= 11) ? num5 : (num5 % 11));
			if (num8 == 0 || num8 == 1)
			{
				num = 0;
			}
			else
			{
				int num9 = 11 - num8;
				num = ((num9 <= 9) ? num9 : 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVCodigoBarrasDocumentoCobranca(campo, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}

	public static string GetDVModulo10(string campo)
	{
		int num = -1;
		try
		{
			Logger.Debug("Calculando DV pelo Módulo10...");
			int num2 = 0;
			int num3 = 2;
			int num4 = 0;
			for (int num5 = campo.Length - 1; num5 >= 0; num5--)
			{
				int num6 = Convert.ToInt32(campo[num5].ToString());
				num4 = 0;
				num4 = num6 * num3;
				while (num4 > 9)
				{
					int num7 = 0;
					for (int i = 0; i < Convert.ToString(num4).Length; i++)
					{
						num7 += Convert.ToInt32(Convert.ToString(num4)[i].ToString());
					}
					num4 = num7;
				}
				num2 += num4;
				num3 = ((num3 == 2) ? 1 : 2);
			}
			int num8 = num2 % 10;
			num = 10 - num8;
			if (num == 10)
			{
				num = 0;
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVModulo10(campo, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}
}
