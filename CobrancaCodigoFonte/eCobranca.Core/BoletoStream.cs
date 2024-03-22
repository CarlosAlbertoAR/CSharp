using eCobranca.Enumerator;

namespace eCobranca.Core;

public class BoletoStream
{
	private byte[] allBytes;

	private EnumFormatoSaida formato;

	public byte[] AllBytes => allBytes;

	public EnumFormatoSaida Formato => formato;

	public BoletoStream(byte[] allBytes, EnumFormatoSaida formato)
	{
		this.allBytes = allBytes;
		this.formato = formato;
	}
}
