using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Util;

public class ImageUtil
{
	private static ImageUtil uniqueInstance;

	private static object syncRoot = new object();

	private ImageUtil()
	{
	}

	public static ImageUtil GetInstance()
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
						uniqueInstance = new ImageUtil();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(typeof(ImageUtil).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public string MergeImages(List<Bitmap> arquivos, string outputDirectory, string radicalNomeArquivo, EnumOrientacaoConcatenacao orientacao, EnumFormatoImagem formato = EnumFormatoImagem.JPG)
	{
		if (string.IsNullOrEmpty(radicalNomeArquivo))
		{
			radicalNomeArquivo = "codigoBarrasCompleto";
		}
		string text = "";
		Bitmap bitmap = null;
		try
		{
			int num = 0;
			int num2 = 0;
			foreach (Bitmap arquivo in arquivos)
			{
				if (orientacao == EnumOrientacaoConcatenacao.HORIZONTAL)
				{
					num += arquivo.Width;
					num2 = ((arquivo.Height > num2) ? arquivo.Height : num2);
				}
				else
				{
					num = ((arquivo.Width > num) ? arquivo.Width : num);
					num2 += arquivo.Height;
				}
			}
			bitmap = new Bitmap(num, num2);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.White);
				int num3 = 0;
				foreach (Bitmap arquivo2 in arquivos)
				{
					if (orientacao == EnumOrientacaoConcatenacao.HORIZONTAL)
					{
						graphics.DrawImage(arquivo2, new Rectangle(num3, 0, arquivo2.Width, arquivo2.Height));
						num3 += arquivo2.Width;
					}
					else
					{
						graphics.DrawImage(arquivo2, new Rectangle(0, num3, arquivo2.Width, arquivo2.Height));
						num3 += arquivo2.Height;
					}
				}
			}
			if (!Directory.Exists(outputDirectory ?? ""))
			{
				Directory.CreateDirectory(outputDirectory ?? "");
			}
			switch (formato)
			{
			case EnumFormatoImagem.PNG:
				text = outputDirectory + radicalNomeArquivo + Guid.NewGuid().ToString() + ".png";
				bitmap.Save(text, ImageFormat.Png);
				return text;
			case EnumFormatoImagem.BMP:
				text = outputDirectory + radicalNomeArquivo + Guid.NewGuid().ToString() + ".bmp";
				bitmap.Save(text, ImageFormat.Bmp);
				return text;
			case EnumFormatoImagem.GIF:
				text = outputDirectory + radicalNomeArquivo + Guid.NewGuid().ToString() + ".gif";
				bitmap.Save(text, ImageFormat.Gif);
				return text;
			case EnumFormatoImagem.JPG:
				text = outputDirectory + radicalNomeArquivo + Guid.NewGuid().ToString() + ".jpg";
				bitmap.Save(text, ImageFormat.Jpeg);
				return text;
			case EnumFormatoImagem.TIF:
				text = outputDirectory + radicalNomeArquivo + Guid.NewGuid().ToString() + ".tif";
				bitmap.Save(text, ImageFormat.Tiff);
				return text;
			default:
				return text;
			}
		}
		catch (Exception ex)
		{
			bitmap?.Dispose();
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConcatenandoImagens(ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		finally
		{
			foreach (Bitmap arquivo3 in arquivos)
			{
				arquivo3.Dispose();
			}
		}
	}

	public string ExtrairImagemDosRecursos(string diretorioOrigem, string nomeImagem, string diretorioDestino)
	{
		string text = string.Empty;
		try
		{
			Stream resourceStream = ResourceUtil.GetResourceStream(Path.Combine(diretorioOrigem, nomeImagem));
			if (resourceStream != null)
			{
				text = Path.Combine(diretorioDestino, nomeImagem);
				SaveFileStream(text, resourceStream);
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoRecurso(null), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaExtraindoImagemDosRecursos(ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	private void SaveFileStream(string nomeArquivoAbsoluto, Stream stream)
	{
		if (!Directory.Exists(Path.GetDirectoryName(nomeArquivoAbsoluto)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivoAbsoluto));
		}
		using FileStream fileStream = new FileStream(nomeArquivoAbsoluto, FileMode.Create, FileAccess.Write);
		stream.CopyTo(fileStream);
		fileStream.Flush();
	}

	public Bitmap RotateImage(string imagePath, float angle)
	{
		if (File.Exists(imagePath))
		{
			Image image = Image.FromFile(imagePath);
			return RotateImage(image, angle);
		}
		return null;
	}

	public Bitmap RotateImage(Stream imageStream, float angle)
	{
		if (imageStream != null)
		{
			return RotateImage(Image.FromStream(imageStream), angle, upsizeOk: true, clipOk: true, Color.Transparent);
		}
		return null;
	}

	public static Bitmap RotateImage(Image inputImage, float angleDegrees, bool upsizeOk, bool clipOk, Color backgroundColor)
	{
		if (angleDegrees == 0f)
		{
			return (Bitmap)inputImage.Clone();
		}
		int width = inputImage.Width;
		int height = inputImage.Height;
		int num = width;
		int num2 = height;
		float num3 = 1f;
		if (upsizeOk || !clipOk)
		{
			double num4 = (double)angleDegrees * Math.PI / 180.0;
			double num5 = Math.Abs(Math.Cos(num4));
			double num6 = Math.Abs(Math.Sin(num4));
			num = (int)Math.Round((double)width * num5 + (double)height * num6);
			num2 = (int)Math.Round((double)width * num6 + (double)height * num5);
		}
		if (!upsizeOk && !clipOk)
		{
			num3 = Math.Min((float)width / (float)num, (float)height / (float)num2);
			num = width;
			num2 = height;
		}
		Bitmap bitmap = new Bitmap(num, num2, (backgroundColor == Color.Transparent) ? PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
		bitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		if (backgroundColor != Color.Transparent)
		{
			graphics.Clear(backgroundColor);
		}
		graphics.TranslateTransform((float)num / 2f, (float)num2 / 2f);
		if (num3 != 1f)
		{
			graphics.ScaleTransform(num3, num3);
		}
		graphics.RotateTransform(angleDegrees);
		graphics.TranslateTransform((float)(-width) / 2f, (float)(-height) / 2f);
		graphics.DrawImage(inputImage, 0, 0);
		return bitmap;
	}

	private Bitmap RotateImage(Image image, float angle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		PointF pointF = new PointF((float)image.Width / 2f, (float)image.Height / 2f);
		Bitmap bitmap = new Bitmap(image.Width, image.Height);
		bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.TranslateTransform(pointF.X, pointF.Y);
		graphics.RotateTransform(angle);
		graphics.TranslateTransform(0f - pointF.X, 0f - pointF.Y);
		graphics.DrawImage(image, new PointF(0f, 0f));
		return bitmap;
	}
}
