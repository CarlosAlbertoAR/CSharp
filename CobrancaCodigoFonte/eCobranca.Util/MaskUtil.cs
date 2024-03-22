using System.Globalization;

namespace eCobranca.Util;

public static class MaskUtil
{
	public static string AplicarMascaraValorMonetario(double valor)
	{
		return string.Format(new CultureInfo("pt-BR"), "{0:n}", new object[1] { valor });
	}
}
