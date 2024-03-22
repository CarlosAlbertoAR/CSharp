using System.Diagnostics;
using System.IO;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

internal class JpegFileSource
{
	private string _fileName = string.Empty;

	private long _width;

	private long _height;

	private long _length;

	private byte[] _fileData;

	private long _pdfObjPage;

	private long _pdfObjImage;

	private long _pdfObjContent;

	private long _pdfObjResource;

	public long PdfObjPage
	{
		get
		{
			return _pdfObjPage;
		}
		set
		{
			_pdfObjPage = value;
		}
	}

	public long PdfObjImage
	{
		get
		{
			return _pdfObjImage;
		}
		set
		{
			_pdfObjImage = value;
		}
	}

	public long PdfObjContent
	{
		get
		{
			return _pdfObjContent;
		}
		set
		{
			_pdfObjContent = value;
		}
	}

	public long PdfObjResource
	{
		get
		{
			return _pdfObjResource;
		}
		set
		{
			_pdfObjResource = value;
		}
	}

	public long Width
	{
		get
		{
			return _width;
		}
		set
		{
			_width = value;
		}
	}

	public long Height
	{
		get
		{
			return _height;
		}
		set
		{
			_height = value;
		}
	}

	public long Length
	{
		get
		{
			return _length;
		}
		set
		{
			_length = value;
		}
	}

	public byte[] FileData
	{
		get
		{
			return _fileData;
		}
		set
		{
			_fileData = value;
		}
	}

	public string FileName
	{
		get
		{
			return _fileName;
		}
		set
		{
			_fileName = value;
		}
	}

	public void LoadFile(string fileName)
	{
		_fileName = fileName;
		FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		long length = fileStream.Length;
		long num = 0L;
		long num2 = 0L;
		_fileData = new byte[length];
		fileStream.Read(_fileData, 0, (int)length);
		if (_fileData[0] != byte.MaxValue || _fileData[1] != 216)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoDeImagemJPGInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		if (_fileData[2] != byte.MaxValue || _fileData[3] != 224)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoDeImagemJPGInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		num = (_fileData[4] << 8) | _fileData[5];
		if (_fileData[6] != 74 || _fileData[7] != 70 || _fileData[8] != 73)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoDeImagemJPGInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		for (num2 = num + 4; num2 < length; num2 += num)
		{
			int num3 = (_fileData[num2] << 8) | _fileData[num2 + 1];
			num2 += 2;
			num = (_fileData[num2] << 8) | _fileData[num2 + 1];
			if (num3 == 65472)
			{
				_width = (_fileData[num2 + 5] << 8) | _fileData[num2 + 6];
				_height = (_fileData[num2 + 3] << 8) | _fileData[num2 + 4];
				break;
			}
		}
		if (_width == 0L || _height == 0L)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoDeImagemJPGInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		_length = length;
	}
}
