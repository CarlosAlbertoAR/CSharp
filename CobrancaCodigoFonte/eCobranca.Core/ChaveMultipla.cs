using System.Collections.Generic;

namespace eCobranca.Core;

public class ChaveMultipla
{
	private IList<object> chaves;

	public IList<object> Chaves => chaves;

	public ChaveMultipla(params object[] chaves)
	{
		this.chaves = new List<object>();
		foreach (object item in chaves)
		{
			this.chaves.Add(item);
		}
	}
}
