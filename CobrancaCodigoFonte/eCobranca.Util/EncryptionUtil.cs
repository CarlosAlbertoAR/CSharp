using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public class EncryptionUtil
{
	private byte[] key = new byte[0];

	private byte[] IV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };

	private const string ENCRYPTION_KEY = "Hnr5sZT8";

	private static EncryptionUtil uniqueInstance;

	private static object syncRoot = new object();

	private EncryptionUtil()
	{
	}

	public static EncryptionUtil Instance()
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
						uniqueInstance = new EncryptionUtil();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(typeof(FileManager).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public string Decrypt(string stringToDecrypt)
	{
		byte[] array = new byte[stringToDecrypt.Length + 1];
		try
		{
			Logger.Debug($"Descriptografando string [{stringToDecrypt}]");
			key = Encoding.UTF8.GetBytes("Hnr5sZT8");
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			array = Convert.FromBase64String(stringToDecrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(key, IV), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			return Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaDescriptografandoString(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return "";
	}

	public string Encrypt(string stringToEncrypt)
	{
		try
		{
			Logger.Debug($"Criptografando string [{stringToEncrypt}]");
			key = Encoding.UTF8.GetBytes("Hnr5sZT8");
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] bytes = Encoding.UTF8.GetBytes(stringToEncrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(key, IV), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaCriptografandoString(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return "";
	}
}
