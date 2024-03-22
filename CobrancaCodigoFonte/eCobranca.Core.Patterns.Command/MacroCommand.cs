using System.Collections.Generic;

namespace eCobranca.Core.Patterns.Command;

public abstract class MacroCommand : ICommand
{
	private IList<ICommand> comandos = new List<ICommand>();

	public IList<ICommand> Comandos
	{
		get
		{
			return comandos;
		}
		set
		{
			comandos = value;
		}
	}

	public virtual void Execute()
	{
		foreach (ICommand comando in comandos)
		{
			comando.Execute();
		}
	}
}
