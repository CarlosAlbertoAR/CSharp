using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using eCobranca.Atributos;
using eCobranca.Core;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Util;

public static class EnumUtil
{
	public static string ObterDescricaoPeloCodigoEChave<T>(string codigoDominio, EnumChaveContexto chave) where T : struct
	{
		string result = "";
		try
		{
			Logger.Debug($"Obtendo descrição do enum [{typeof(T).Name}] para o código de domínio [{codigoDominio}]");
			foreach (object item in GetEnumByAttribute<T, AtributoChave>(new AtributoChave(chave)))
			{
				if (Enum.IsDefined(typeof(T), item.ToString().ToUpper()))
				{
					Enum value = Enum.Parse(typeof(T), item.ToString()) as Enum;
					if (value.Codigo().Equals(codigoDominio))
					{
						return value.Descricao();
					}
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(codigoDominio, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static string ObterDescricaoPeloCodigoEChave<T>(string codigoDominio, AtributoChave chave) where T : struct
	{
		string result = "";
		try
		{
			Logger.Debug($"Obtendo descrição do enum [{typeof(T).Name}] para o código de domínio [{codigoDominio}]");
			foreach (object item in GetEnumByAttribute<T, AtributoChave>(chave))
			{
				if (Enum.IsDefined(typeof(T), item.ToString().ToUpper()))
				{
					Enum value = Enum.Parse(typeof(T), item.ToString()) as Enum;
					if (value.Codigo().Equals(codigoDominio))
					{
						return value.Descricao();
					}
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(codigoDominio, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T ObterValorEnumeradoPeloCodigoEChave<T>(string codigoDominio, AtributoChave chave) where T : struct
	{
		T result = default(T);
		try
		{
			Logger.Debug($"Obtendo descrição do enum [{typeof(T).Name}] para o código de domínio [{codigoDominio}]");
			foreach (object item in GetEnumByAttribute<T, AtributoChave>(chave))
			{
				if (Enum.IsDefined(typeof(T), item.ToString().ToUpper()) && (Enum.Parse(typeof(T), item.ToString()) as Enum).Codigo().Equals(codigoDominio))
				{
					return (T)Enum.Parse(typeof(T), item.ToString().ToUpper());
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(codigoDominio, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T ObterValorEnumeradoPeloSiglaEChave<T>(string siglaDominio, AtributoChave chave) where T : struct
	{
		T result = default(T);
		try
		{
			Logger.Debug($"Obtendo descrição do enum [{typeof(T).Name}] para o código de domínio [{siglaDominio}]");
			foreach (object item in GetEnumByAttribute<T, AtributoChave>(chave))
			{
				if (Enum.IsDefined(typeof(T), item.ToString().ToUpper()) && (Enum.Parse(typeof(T), item.ToString()) as Enum).Sigla().Equals(siglaDominio))
				{
					return (T)Enum.Parse(typeof(T), item.ToString().ToUpper());
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(siglaDominio, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T ObterValorEnumeradoPeloCodigoEChave<T>(string codigoDominio, Enum chave) where T : struct
	{
		T result = default(T);
		try
		{
			Logger.Debug($"Obtendo descrição do enum [{typeof(T).Name}] para o código de domínio [{codigoDominio}]");
			foreach (object item in GetEnumByAttribute<T, AtributoChave>(new AtributoChave(chave)))
			{
				if (Enum.IsDefined(typeof(T), item.ToString().ToUpper()) && (Enum.Parse(typeof(T), item.ToString()) as Enum).Codigo().Equals(codigoDominio))
				{
					return (T)Enum.Parse(typeof(T), item.ToString().ToUpper());
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoDescricaoDeValorEnumeradoPeloCodigoDominio(codigoDominio, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static T GetAttribute<T>(this Enum value) where T : Attribute
	{
		try
		{
			return (T)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(T), inherit: false)[0];
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoAtributoDeValorEnumerado(value.ToString(), value.GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return null;
		}
	}

	public static Enum ToEnum<T>(this string value)
	{
		try
		{
			return Enum.Parse(typeof(T), value) as Enum;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoStringParaValorEnumerado(value, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return null;
		}
	}

	public static bool ExisteNaEnum<T>(this string value)
	{
		try
		{
			return Enum.IsDefined(typeof(T), value);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaVerificandoDefinicaoEmEnumerado(value, typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return false;
		}
	}

	public static string Descricao(this Enum value)
	{
		DescriptionAttribute attribute = value.GetAttribute<DescriptionAttribute>();
		if (attribute != null)
		{
			return attribute.Description;
		}
		return "";
	}

	public static string Codigo(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.Codigo;
		}
		return "";
	}

	public static string Sigla(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.Sigla;
		}
		return "";
	}

	public static string Ajuda(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.Ajuda;
		}
		return "";
	}

	public static string Mascara(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.Mascara;
		}
		return "";
	}

	public static string ValorPadrao(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.ValorPadrao;
		}
		return "";
	}

	public static ArrayList ValoresDefinidos(this Enum value)
	{
		AtributoDominio attribute = value.GetAttribute<AtributoDominio>();
		if (attribute != null)
		{
			return attribute.ValoresDefinidos;
		}
		return new ArrayList();
	}

	public static ArrayList GetNames(Type enumType)
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			Logger.Debug($"Obtendo todos os nomes do enumerado [{enumType.Name}]");
			string[] names = Enum.GetNames(enumType);
			foreach (string value in names)
			{
				arrayList.Add(value);
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoNomesDeEnumerado(enumType.Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return arrayList;
		}
	}

	public static Enum GetEnumByValue(Type enumType, string enumValue)
	{
		try
		{
			Logger.Debug($"Obtendo um enumerado do tipo [{enumType.ToString()}] pelo valor [{enumValue.ToString()}]...");
			int num = 0;
			foreach (Enum value in Enum.GetValues(enumType))
			{
				if (value.ToString() == enumValue)
				{
					return value;
				}
				num++;
			}
			return null;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoEnumeradoPeloValor(enumType.Name, enumValue.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public static ArrayList GetEnumByAttribute<T, A>(A atributo)
	{
		ArrayList arrayList = new ArrayList();
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			if (AtributoValido(GetAttribute<A, T>(value), atributo))
			{
				arrayList.Add(value.ToString());
			}
		}
		return arrayList;
	}

	public static ArrayList GetEnumByAttributeToItemLista<T, A>(A atributo) where T : struct
	{
		ArrayList arrayList = new ArrayList();
		foreach (T value3 in Enum.GetValues(typeof(T)))
		{
			if (AtributoValido(GetAttribute<A, T>(value3), atributo))
			{
				Enum @enum = Enum.Parse(typeof(T), value3.ToString()) as Enum;
				ItemLista value2 = new ItemLista(@enum.Codigo(), @enum.Descricao(), @enum.Sigla(), @enum.Ajuda(), @enum.ToString());
				arrayList.Add(value2);
			}
		}
		return arrayList;
	}

	public static ArrayList GetEnumByAttributeToObject<A, B, C>(B atributo) where C : Attribute
	{
		ArrayList arrayList = new ArrayList();
		foreach (A value3 in Enum.GetValues(typeof(A)))
		{
			if (AtributoValido(GetAttribute<B, A>(value3), atributo))
			{
				Enum value2 = Enum.Parse(typeof(A), value3.ToString()) as Enum;
				arrayList.Add(value2.GetAttribute<C>());
			}
		}
		return arrayList;
	}

	public static ArrayList GetEnumByAttributeToParametroConfiguracao<T, A>(A atributo) where T : struct
	{
		ArrayList arrayList = new ArrayList();
		foreach (T value3 in Enum.GetValues(typeof(T)))
		{
			if (AtributoValido(GetAttribute<A, T>(value3), atributo))
			{
				ParametroConfiguracao value2 = new ParametroConfiguracao(Enum.Parse(typeof(T), value3.ToString()) as Enum);
				arrayList.Add(value2);
			}
		}
		return arrayList;
	}

	private static A GetAttribute<A, T>(T value)
	{
		object[] customAttributes = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(A), inherit: false);
		if (customAttributes.Length == 0)
		{
			return default(A);
		}
		return (A)Convert.ChangeType(customAttributes[0], typeof(A));
	}

	private static bool AtributoValido<T>(T origem, T destino)
	{
		bool result = true;
		try
		{
			PropertyInfo[] properties = typeof(T).GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.PropertyType.IsArray)
				{
					if (origem == null || destino == null)
					{
						return false;
					}
					object value = propertyInfo.GetValue(origem, null);
					object value2 = propertyInfo.GetValue(destino, null);
					bool flag = false;
					if (value == null || value2 == null)
					{
						continue;
					}
					if ((value2 as Array).Length > (value as Array).Length)
					{
						return false;
					}
					foreach (object item in value2 as Array)
					{
						foreach (object item2 in value as Array)
						{
							if (item2.Equals(item))
							{
								flag = true;
								break;
							}
							flag = false;
						}
						if (!flag)
						{
							break;
						}
					}
					if (!flag)
					{
						return false;
					}
				}
				else if (!propertyInfo.GetValue(origem, null).Equals(propertyInfo.GetValue(destino, null)))
				{
					return false;
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaValidandoAtributoDeEnumerado(typeof(T).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
