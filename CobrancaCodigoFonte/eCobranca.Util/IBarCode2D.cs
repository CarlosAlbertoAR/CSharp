namespace eCobranca.Util;

public interface IBarCode2D
{
	string EncodeValue(string value);

	string GetRenderedHtmlString(string encodedValue, bool modoFastReports);
}
