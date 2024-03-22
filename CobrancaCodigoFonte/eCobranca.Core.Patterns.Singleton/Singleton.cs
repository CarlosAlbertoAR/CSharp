namespace eCobranca.Core.Patterns.Singleton;

public abstract class Singleton<T> where T : class, new()
{
	private static volatile T _instance;

	private object _lockObj = new object();

	public T Instance => GetInstance();

	protected T GetInstance()
	{
		if (_instance == null)
		{
			lock (_lockObj)
			{
				if (_instance == null)
				{
					_instance = new T();
				}
			}
		}
		return _instance;
	}
}
