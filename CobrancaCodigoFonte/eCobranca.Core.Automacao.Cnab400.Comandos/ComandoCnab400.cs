using System;
using eCobranca.Core.Automacao.Converter;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Comandos;

public abstract class ComandoCnab400 : ICommand
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

	public ComandoCnab400()
	{
		Logger.Debug("Criando comando base para o layout CNAB400.");
		dateConverter = new ConverterDateToString(guid, EnumTipoData.DDMMAA);
		doubleConverter = new ConverterDoubleToString(guid);
		timeConverter = new ConverterTimeToString(guid);
		intConverter = new ConverterIntToString(guid);
	}

	public ComandoCnab400(Guid guid)
		: this()
	{
		this.guid = guid;
	}

	public abstract void Execute();
}
