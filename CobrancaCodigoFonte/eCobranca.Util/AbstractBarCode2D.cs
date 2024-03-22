namespace eCobranca.Util;

public abstract class AbstractBarCode2D : IBarCode2D
{
	public abstract string EncodeValue(string value);

	public abstract string GetRenderedHtmlString(string encodedValue, bool modoFastReports);
}
