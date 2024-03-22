namespace eCobranca.Core.Patterns.Observer;

public interface IInterceptor
{
	void AddObserver(IObserver observer);

	void RemoveObserver(IObserver observer);

	void NotifyObservers(NotifyEvent ne);
}
