using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class AESEncryptionUtil
{
	private static Rijndael CriarInstanciaRijndael(string chave, string vetorInicializacao)
	{
		if (chave == null || (chave.Length != 16 && chave.Length != 24 && chave.Length != 32))
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ChaveDeCriptografiaComTamanhoInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		if (vetorInicializacao == null || vetorInicializacao.Length != 16)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.VetorDeInicializacaoComTamanhoInvalido(), new StackTrace().GetFrame(1).GetMethod());
		}
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Encoding.ASCII.GetBytes(chave);
		rijndael.IV = Encoding.ASCII.GetBytes(vetorInicializacao);
		return rijndael;
	}

	public static string Encriptar(string chave, string vetorInicializacao, string textoNormal)
	{
		if (string.IsNullOrWhiteSpace(textoNormal))
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.StringVaziaParaCriptografar(), new StackTrace().GetFrame(1).GetMethod());
		}
		using Rijndael rijndael = CriarInstanciaRijndael(chave, vetorInicializacao);
		ICryptoTransform transform = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(textoNormal);
		}
		return ArrayBytesToHexString(memoryStream.ToArray());
	}

	private static string ArrayBytesToHexString(byte[] conteudo)
	{
		return string.Concat(Array.ConvertAll(conteudo, (byte b) => b.ToString("X2")));
	}

	public static string Decriptar(string chave, string vetorInicializacao, string textoEncriptado)
	{
		if (string.IsNullOrWhiteSpace(textoEncriptado))
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.StringVaziaParaCriptografar(), new StackTrace().GetFrame(1).GetMethod());
		}
		if (textoEncriptado.Length % 2 != 0)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ConteudoInvalidoParaCriptografar(), new StackTrace().GetFrame(1).GetMethod());
		}
		using Rijndael rijndael = CriarInstanciaRijndael(chave, vetorInicializacao);
		ICryptoTransform transform = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);
		string result = null;
		using (MemoryStream stream = new MemoryStream(HexStringToArrayBytes(textoEncriptado)))
		{
			using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream2);
			result = streamReader.ReadToEnd();
		}
		return result;
	}

	private static byte[] HexStringToArrayBytes(string conteudo)
	{
		int num = conteudo.Length / 2;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Convert.ToByte(conteudo.Substring(i * 2, 2), 16);
		}
		return array;
	}
}
