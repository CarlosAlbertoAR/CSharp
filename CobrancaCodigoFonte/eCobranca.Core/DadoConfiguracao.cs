using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using eCobranca.Core.Excecao;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Util;

namespace eCobranca.Core;

[Serializable]
public class DadoConfiguracao : IObservable, ISerializable
{
	private string ajuda;

	private string cabecalho;

	private string mascara;

	private string nome;

	private string valor;

	private bool validaPreenchimentoMascara;

	private bool valorDefinido;

	private ArrayList valoresDefinidos;

	public bool ValorDefinido => valorDefinido;

	public string Ajuda
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = ajuda;
			});
			return result;
		}
	}

	public string Cabecalho
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = cabecalho;
			});
			return result;
		}
	}

	public string Mascara
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = mascara;
			});
			return result;
		}
	}

	public string Nome
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = nome;
			});
			return result;
		}
	}

	public string Valor
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = valor;
			});
			return result;
		}
		set
		{
			bool result = false;
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = ValorValido(value);
				});
				if (result)
				{
					if (value.IsStringNumerica() && Mascara.IsStringNumerica() && Mascara.Length > value.Length)
					{
						Launcher.GetInstance().Executar(delegate
						{
							valor = StringUtil.ZerosLeft(value, Mascara.Length);
						});
					}
					else
					{
						Launcher.GetInstance().Executar(delegate
						{
							valor = value;
						});
					}
				}
				else
				{
					valor = "";
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInformadoNaoObedeceMascara(Nome, Mascara, value), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade(Nome, new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ArrayList ValoresDefinidos => valoresDefinidos;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public DadoConfiguracao(string nome, string ajuda, string cabecalho, string mascara)
	{
		this.ajuda = ajuda;
		this.cabecalho = cabecalho;
		validaPreenchimentoMascara = !mascara.Contains("*");
		this.mascara = mascara.Replace("*", string.Empty);
		this.nome = nome;
		valor = "";
		valorDefinido = false;
		valoresDefinidos = new ArrayList();
	}

	public DadoConfiguracao(string nome, string ajuda, string cabecalho, string mascara, ArrayList valoresDefinidos)
		: this(nome, ajuda, cabecalho, mascara)
	{
		valorDefinido = true;
		this.valoresDefinidos = valoresDefinidos;
		validaPreenchimentoMascara = false;
	}

	public DadoConfiguracao(SerializationInfo serobj, StreamingContext scontext)
	{
		ajuda = (string)serobj.GetValue("Ajuda", typeof(string));
		cabecalho = (string)serobj.GetValue("Cabecalho", typeof(string));
		mascara = (string)serobj.GetValue("Mascara", typeof(string));
		nome = (string)serobj.GetValue("Nome", typeof(string));
		valor = (string)serobj.GetValue("Valor", typeof(string));
		validaPreenchimentoMascara = (bool)serobj.GetValue("ValidaPreenchimentoMascara", typeof(bool));
		valorDefinido = (bool)serobj.GetValue("ValorDefinido", typeof(bool));
		valoresDefinidos = (ArrayList)serobj.GetValue("ValoresDefinidos", typeof(ArrayList));
	}

	private bool ValorValido(string valor)
	{
		string text = "";
		try
		{
			if (!validaPreenchimentoMascara)
			{
				return true;
			}
			if (valor.IsStringNumerica() && Mascara.IsStringNumerica() && Mascara.Length > valor.Length)
			{
				return true;
			}
			if (valor.Length != Mascara.Length)
			{
				return false;
			}
			for (int i = 0; i < Mascara.Length; i++)
			{
				text = Mascara.Substring(i, 1);
				char c = valor.Substring(i, 1).ToCharArray().First();
				switch (text)
				{
				case "0":
					if (!char.IsNumber(c))
					{
						return false;
					}
					break;
				case "A":
					if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
					{
						return false;
					}
					break;
				case "T":
					if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
					{
						return false;
					}
					break;
				case "C":
					if (!char.IsLetter(c))
					{
						return false;
					}
					break;
				case "x":
					if (!char.IsLetter(c))
					{
						return false;
					}
					if (!char.IsLower(c))
					{
						return false;
					}
					break;
				case "X":
					if (!char.IsLetter(c))
					{
						return false;
					}
					if (!char.IsUpper(c))
					{
						return false;
					}
					break;
				default:
					if (text != c.ToString())
					{
						return false;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaValidandoValorDadoConfiguracao(Nome, Mascara, valor, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return true;
	}

	public void TriggerNotifyEvent(object sender, NotifyEvent notifyEvent)
	{
		if (this.onNotifyEvent == null)
		{
			onNotifyEvent += NotifyEventInterceptor.GetInstance().OnNotifyEvent;
		}
		this.onNotifyEvent(sender, notifyEvent);
	}

	public void RefreshNotifyEventHandler()
	{
		this.onNotifyEvent = null;
		onNotifyEvent += NotifyEventInterceptor.GetInstance().OnNotifyEvent;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Ajuda", ajuda);
		info.AddValue("Cabecalho", cabecalho);
		info.AddValue("Mascara", mascara);
		info.AddValue("Nome", nome);
		info.AddValue("Valor", valor);
		info.AddValue("ValidaPreenchimentoMascara", validaPreenchimentoMascara);
		info.AddValue("ValorDefinido", valorDefinido);
		info.AddValue("ValoresDefinidos", valoresDefinidos);
	}
}
