using System.IO;
using System.Text;

namespace eCobranca.Util;

public sealed class StringWriterWithEncoding : StringWriter
{
	private readonly Encoding encoding;

	public override Encoding Encoding => encoding;

	public StringWriterWithEncoding(StringBuilder sb)
		: base(sb)
	{
		encoding = Encoding.Unicode;
	}

	public StringWriterWithEncoding(Encoding encoding)
	{
		this.encoding = encoding;
	}

	public StringWriterWithEncoding(StringBuilder sb, Encoding encoding)
		: base(sb)
	{
		this.encoding = encoding;
	}
}
