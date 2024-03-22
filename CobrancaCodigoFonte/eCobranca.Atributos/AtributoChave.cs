using System;
using System.Runtime.Serialization;

namespace eCobranca.Atributos;

[Serializable]
public class AtributoChave : Attribute
{
	private Enum[] _chaves;

	public Enum[] Chaves
	{
		get
		{
			return _chaves;
		}
		set
		{
			_chaves = value;
		}
	}

	public AtributoChave()
	{
	}

	public AtributoChave(params object[] chaves)
		: this()
	{
		_chaves = new Enum[chaves.Length];
		for (int i = 0; i < chaves.Length; i++)
		{
			_chaves[i] = (Enum)Enum.Parse(chaves[i].GetType(), chaves[i].ToString());
		}
	}

	public AtributoChave(SerializationInfo serobj)
	{
		_chaves = (Enum[])serobj.GetValue("Chaves", typeof(Enum[]));
	}

	public void GetObjectData(SerializationInfo info)
	{
		info.AddValue("Chaves", _chaves);
	}
}
