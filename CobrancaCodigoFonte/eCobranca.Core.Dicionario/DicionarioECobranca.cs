using System;
using System.Collections.Generic;
using System.Linq;

namespace eCobranca.Core.Dicionario;

public abstract class DicionarioECobranca<K, T>
{
	protected Dictionary<K, T> dicionario = new Dictionary<K, T>();

	protected K chavePadrao;

	protected DicionarioECobranca()
	{
		CriarDicionario();
		DefinirValorPadrao();
	}

	public bool PossuiChave(K chave)
	{
		return dicionario.ContainsKey(chave);
	}

	public bool PossuiValor(T valor)
	{
		return dicionario.ContainsValue(valor);
	}

	public T GetValor(K obj)
	{
		T value;
		if (dicionario.ContainsKey(obj))
		{
			dicionario.TryGetValue(obj, out value);
		}
		else
		{
			dicionario.TryGetValue(chavePadrao, out value);
		}
		return value;
	}

	public T GetValor(string str)
	{
		if (Enum.IsDefined(typeof(K), str))
		{
			K obj = (K)Enum.Parse(typeof(K), str);
			return GetValor(obj);
		}
		return GetValor(chavePadrao);
	}

	public K GetChave(T valor)
	{
		if (PossuiValor(valor))
		{
			return dicionario.FirstOrDefault((KeyValuePair<K, T> x) => x.Value.Equals(valor)).Key;
		}
		return chavePadrao;
	}

	protected abstract void CriarDicionario();

	protected abstract void DefinirValorPadrao();
}
