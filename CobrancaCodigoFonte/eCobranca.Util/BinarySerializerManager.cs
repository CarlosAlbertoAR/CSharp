using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Util;

public static class BinarySerializerManager<T>
{
	public static byte[] SerializeToBytes(T data)
	{
		byte[] result = null;
		try
		{
			Logger.Debug($"Serializando para um array de bytes um objeto do tipo [{typeof(T).ToString()}]...");
			if (data != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				new BinaryFormatter().Serialize(memoryStream, data);
				result = memoryStream.GetBuffer();
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSerializandoObjetoParaArrayBytes(typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T DeserializeFromBytes(byte[] binData)
	{
		T result = default(T);
		try
		{
			Logger.Debug($"Deserializando para um objeto do tipo [{typeof(T).ToString()}] um array de bytes...");
			if (binData != null || binData.Length != 0)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream serializationStream = new MemoryStream(binData);
				result = (T)binaryFormatter.Deserialize(serializationStream);
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaDeserializandoArrayBytesParaObjeto(typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string SerializeToString(T data)
	{
		string result = "";
		try
		{
			Logger.Debug($"Serializando para uma string base 64 os dados de um objeto do tipo [{typeof(T).ToString()}]");
			if (data != null)
			{
				result = Convert.ToBase64String(SerializeToBytes(data));
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSerializandoObjetoParaString(typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T DeserializeFromString(string binString)
	{
		T result = default(T);
		try
		{
			Logger.Debug($"Deserializando uma string base 64 para um objeto do tipo [{binString}]");
			if (binString != null && binString.Length != 0)
			{
				result = DeserializeFromBytes(Convert.FromBase64String(binString));
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaDeserializandoStringParaObjeto(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string SerializeToEncryptedString(T data)
	{
		string result = "";
		try
		{
			Logger.Debug($"Criptografando a string resultado da serialização de um objeto do tipo [{typeof(T).ToString()}]");
			result = EncryptionUtil.Instance().Encrypt(SerializeToString(data));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSerializandoObjetoParaStringCriptografada(typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T DeserializeFromEncryptedString(string binStringEncrypted)
	{
		try
		{
			Logger.Debug("Descriptografando uma string serializada e criptografada...");
			return DeserializeFromString(EncryptionUtil.Instance().Decrypt(binStringEncrypted));
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaDeserializandoStringCriptografadaParaObjeto(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return DeserializeFromString("");
	}
}
