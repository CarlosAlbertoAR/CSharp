using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public class PdfUtil
{
	private static PdfUtil uniqueInstance;

	private static object syncRoot = new object();

	private List<JpegFileSource> _jpegFiles = new List<JpegFileSource>();

	private MemoryStream _msDestino;

	private byte[] _lineBreak;

	private byte[] _lineBreak2;

	private PdfUtil()
	{
	}

	public static PdfUtil GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de carteiras de cobrança...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new PdfUtil();
					}
				}
			}
			return uniqueInstance;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(typeof(PdfUtil).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public MemoryStream ImageToPdf(List<FileInfo> arquivos)
	{
		if (arquivos.Count == 0)
		{
			return new MemoryStream();
		}
		Reset();
		arquivos.ForEach(delegate(FileInfo x)
		{
			AddPage(x.FullName);
		});
		BuildPdf();
		return _msDestino;
	}

	private void BuildPdf()
	{
		long[] array = new long[_jpegFiles.Count * 4 + 4];
		_msDestino = new MemoryStream();
		NewPdfStreamWriteLine("%PDF-1.7");
		NewPdfStreamWriteLine("");
		int num = 0;
		int num2 = 4;
		while (num < _jpegFiles.Count)
		{
			JpegFileSource jpegFileSource = _jpegFiles[num++];
			jpegFileSource.PdfObjImage = num2++;
			jpegFileSource.PdfObjPage = num2++;
			jpegFileSource.PdfObjContent = num2++;
			jpegFileSource.PdfObjResource = num2++;
			array[jpegFileSource.PdfObjImage] = _msDestino.Position;
			NewPdfStreamWriteLine(jpegFileSource.PdfObjImage + " 0 obj");
			NewPdfStreamWriteLine("<<");
			NewPdfStreamWriteLine("/BitsPerComponent 8");
			NewPdfStreamWriteLine("/ColorSpace /DeviceRGB");
			NewPdfStreamWriteLine("/Filter /DCTDecode");
			NewPdfStreamWriteLine("/Height " + jpegFileSource.Height);
			NewPdfStreamWriteLine("/Length " + jpegFileSource.Length);
			NewPdfStreamWriteLine("/Subtype /Image");
			NewPdfStreamWriteLine("/Type /XObject");
			NewPdfStreamWriteLine("/Width " + jpegFileSource.Width);
			NewPdfStreamWriteLine(">>");
			NewPdfStreamWriteLine("stream");
			_msDestino.Write(jpegFileSource.FileData, 0, jpegFileSource.FileData.Length);
			_msDestino.Write(_lineBreak, 0, _lineBreak.Length);
			NewPdfStreamWriteLine("endstream");
			NewPdfStreamWriteLine("endobj");
			array[jpegFileSource.PdfObjPage] = _msDestino.Position;
			NewPdfStreamWriteLine(jpegFileSource.PdfObjPage + " 0 obj");
			NewPdfStreamWriteLine("<<");
			NewPdfStreamWriteLine("/Contents [ " + jpegFileSource.PdfObjContent + " 0 R ]");
			NewPdfStreamWriteLine("/CropBox [ 0.0 0.0 595.27576 841.89001 ]");
			NewPdfStreamWriteLine("/MediaBox [ 0.0 0.0 595.27576 841.89001 ]");
			NewPdfStreamWriteLine("/Parent 2 0 R");
			NewPdfStreamWriteLine("/Resources " + jpegFileSource.PdfObjResource + " 0 R");
			NewPdfStreamWriteLine("/Rotate 0");
			NewPdfStreamWriteLine("/Type /Page");
			NewPdfStreamWriteLine(">>");
			NewPdfStreamWriteLine("endobj");
			array[jpegFileSource.PdfObjContent] = _msDestino.Position;
			NewPdfStreamWriteLine(jpegFileSource.PdfObjContent + " 0 obj");
			NewPdfStreamWriteLine("<<");
			NewPdfStreamWriteLine("/Filter /FlateDecode");
			NewPdfStreamWriteLine("/Length 176");
			NewPdfStreamWriteLine(">>");
			NewPdfStreamWriteLine("stream");
			byte[] array2 = new byte[177]
			{
				120, 156, 181, 146, 189, 14, 194, 48, 12, 132,
				247, 60, 69, 102, 164, 154, 179, 211, 144, 100,
				103, 97, 236, 196, 140, 16, 148, 129, 130, 224,
				253, 7, 92, 134, 254, 200, 85, 23, 68, 188,
				88, 119, 177, 253, 201, 9, 40, 69, 232, 241,
				32, 96, 158, 84, 214, 203, 53, 83, 46, 0,
				71, 127, 238, 220, 75, 131, 77, 217, 144, 172,
				88, 90, 204, 230, 218, 144, 188, 91, 103, 75,
				58, 151, 74, 160, 4, 148, 92, 70, 245, 62,
				85, 153, 69, 40, 10, 32, 189, 49, 114, 204,
				228, 155, 187, 110, 92, 163, 228, 255, 27, 97,
				59, 247, 99, 143, 27, 255, 248, 101, 97, 203,
				188, 53, 133, 154, 75, 198, 156, 119, 80, 21,
				44, 140, 198, 148, 55, 24, 54, 80, 68, 220,
				73, 94, 24, 191, 98, 125, 255, 1, 199, 180,
				2, 95, 137, 136, 181, 167, 162, 54, 217, 30,
				186, 83, 123, 97, 191, 127, 234, 235, 244, 209,
				184, 15, 54, 229, 128, 18, 10
			};
			_msDestino.Write(array2, 0, array2.Length);
			NewPdfStreamWriteLine("endstream");
			NewPdfStreamWriteLine("endobj");
			array[jpegFileSource.PdfObjResource] = _msDestino.Position;
			NewPdfStreamWriteLine(jpegFileSource.PdfObjResource + " 0 obj");
			NewPdfStreamWriteLine("<<");
			NewPdfStreamWriteLine("/XObject <<");
			NewPdfStreamWriteLine("/Image1 " + jpegFileSource.PdfObjImage + " 0 R");
			NewPdfStreamWriteLine(">>");
			NewPdfStreamWriteLine(">>");
			NewPdfStreamWriteLine("endobj");
		}
		array[3] = _msDestino.Position;
		NewPdfStreamWriteLine("3 0 obj");
		NewPdfStreamWriteLine("<<");
		NewPdfStreamWriteLine("/Author (desconhecido e-cobranca)");
		string text = "(D:" + DateTime.UtcNow.ToString("yyyyMMddhhmmss") + "+00'00')";
		NewPdfStreamWriteLine("/CreationDate " + text);
		NewPdfStreamWriteLine("/ModDate " + text);
		NewPdfStreamWriteLine("/Producer (desconhecido: e-cobranca)");
		NewPdfStreamWriteLine("/Title (boleto)");
		NewPdfStreamWriteLine(">>");
		NewPdfStreamWriteLine("endobj");
		array[2] = _msDestino.Position;
		NewPdfStreamWriteLine("2 0 obj");
		NewPdfStreamWriteLine("<<");
		NewPdfStreamWriteLine("/Count " + _jpegFiles.Count);
		string text2 = "";
		num = 0;
		while (num < _jpegFiles.Count)
		{
			JpegFileSource jpegFileSource2 = _jpegFiles[num++];
			text2 = text2 + " " + jpegFileSource2.PdfObjPage + " 0 R";
		}
		NewPdfStreamWriteLine("/Kids [" + text2 + " ]");
		NewPdfStreamWriteLine("/Type /Pages");
		NewPdfStreamWriteLine(">>");
		NewPdfStreamWriteLine("endobj");
		array[1] = _msDestino.Position;
		NewPdfStreamWriteLine("1 0 obj");
		NewPdfStreamWriteLine("<<");
		NewPdfStreamWriteLine("/Pages 2 0 R");
		NewPdfStreamWriteLine("/Type /Catalog");
		NewPdfStreamWriteLine(">>");
		NewPdfStreamWriteLine("endobj");
		int num3 = _jpegFiles.Count * 4 + 4;
		long position = _msDestino.Position;
		NewPdfStreamWriteLine("xref");
		NewPdfStreamWriteLine2(num3 + " 0");
		NewPdfStreamWriteLine2("0000000000 65535 f");
		long num4 = 1L;
		while (num4 < num3)
		{
			NewPdfStreamWriteLine2(array[num4++].ToString("D10") + " 00000 n");
		}
		NewPdfStreamWriteLine("trailer");
		NewPdfStreamWriteLine("<<");
		NewPdfStreamWriteLine("/Info 3 0 R");
		NewPdfStreamWriteLine("/Root 1 0 R");
		NewPdfStreamWriteLine("/Size " + position);
		NewPdfStreamWriteLine(">>");
		NewPdfStreamWriteLine("startxref");
		NewPdfStreamWriteLine(position.ToString());
		NewPdfStreamWriteLine("%%EOF");
	}

	private void AddPage(string fileName)
	{
		JpegFileSource jpegFileSource = new JpegFileSource();
		jpegFileSource.LoadFile(fileName);
		_jpegFiles.Add(jpegFileSource);
	}

	private void NewPdfStreamWriteLine(string line)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(line);
		_msDestino.Write(bytes, 0, bytes.Length);
		_msDestino.Write(_lineBreak, 0, _lineBreak.Length);
	}

	private void NewPdfStreamWriteLine2(string line)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(line);
		_msDestino.Write(bytes, 0, bytes.Length);
		_msDestino.Write(_lineBreak2, 0, _lineBreak2.Length);
	}

	private void Reset()
	{
		_jpegFiles = new List<JpegFileSource>();
		_lineBreak = new byte[1];
		_lineBreak[0] = 10;
		_lineBreak2 = new byte[2];
		_lineBreak2[0] = 13;
		_lineBreak2[1] = 10;
	}
}
