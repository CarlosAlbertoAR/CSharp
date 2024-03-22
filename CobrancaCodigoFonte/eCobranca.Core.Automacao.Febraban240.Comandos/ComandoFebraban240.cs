using System;
using eCobranca.Core.Automacao.Converter;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Comandos;

public abstract class ComandoFebraban240 : ICommand
{
	private ConverterDateToString dateConverter;

	private ConverterTimeToString timeConverter;

	private ConverterDoubleToString doubleConverter;

	private ConverterIntToString intConverter;

	protected Guid guid;

	public ConverterIntToString IntConverter => intConverter;

	public ConverterTimeToString TimeConverter => timeConverter;

	public ConverterDateToString DateConverter => dateConverter;

	public ConverterDoubleToString DoubleConverter => doubleConverter;

	public ComandoFebraban240()
	{
		Logger.Debug("Criando comando base para o layout FEBRABAN240.");
		dateConverter = new ConverterDateToString(guid, EnumTipoData.DDMMAAAA);
		doubleConverter = new ConverterDoubleToString(guid);
		timeConverter = new ConverterTimeToString(guid);
		intConverter = new ConverterIntToString(guid);
	}

	public ComandoFebraban240(Guid guid)
		: this()
	{
		this.guid = guid;
	}

	public abstract void Execute();
}
