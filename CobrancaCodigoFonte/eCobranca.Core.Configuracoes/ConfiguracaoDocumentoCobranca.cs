using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoDocumentoCobranca : ConfiguracaoECobranca
{
	private string codigoJuros;

	private double valorJurosAoDia;

	private double percentualJurosAoDia;

	private string codigoDesconto;

	private double valorDesconto;

	private double percentualDesconto;

	private string codigoProtesto;

	private int diasProtesto;

	private string codigoAceite;

	private string codigoBaixaDevolucao;

	private int diasBaixa;

	private string tipoDocumentoCobranca;

	private string codigoMoeda;

	private string codigoMulta;

	private double valorMulta;

	private double percentualMulta;

	private bool geraInstrucaoAutomaticaJuros;

	private bool geraInstrucaoAutomaticaMulta;

	private bool geraInstrucaoAutomaticaDesconto;

	private bool geraInstrucaoAutomaticaProtesto;

	protected ArrayList tiposDocumentosCobrancaFebraban240;

	protected ArrayList tiposDocumentosCobrancaCnab400;

	protected ArrayList codigosAceiteFebraban240;

	protected ArrayList codigosAceiteCnab400;

	protected ArrayList codigosDescontoFebraban240;

	protected ArrayList codigosDescontoCnab400;

	protected ArrayList codigosJurosFebraban240;

	protected ArrayList codigosJurosCnab400;

	protected ArrayList codigosProtestoFebraban240;

	protected ArrayList codigosProtestoCnab400;

	protected ArrayList codigosMoedaFebraban240;

	protected ArrayList codigosMoedaCnab400;

	protected ArrayList codigosBaixaDevolucaoFebraban240;

	protected ArrayList codigosBaixaDevolucaoCnab400;

	protected ArrayList codigosMultaFebraban240;

	protected ArrayList codigosMultaCnab400;

	protected ArrayList codigosInstrucaoCobrancaCnab400;

	protected ArrayList codigosInstrucaoCobrancaFebraban240;

	protected ArrayList modalidadesCobranca;

	public string CodigoMulta
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoMulta;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoMulta), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoMulta = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoMulta", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoMulta", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualMulta
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = percentualMulta;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					percentualMulta = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualMulta", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorMulta
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = valorMulta;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					valorMulta = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorMulta", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoMoeda
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoMoeda;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoMoeda), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoMoeda = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoMoeda", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoMoeda", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoBaixaDevolucao
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoBaixaDevolucao;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoBaixaDevolucao), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoBaixaDevolucao = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoBaixaDevolucao", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoBaixaDevolucao", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int DiasBaixa
	{
		get
		{
			int result = 0;
			Launcher.GetInstance().Executar(delegate
			{
				result = diasBaixa;
			});
			return result;
		}
		set
		{
			int result = 0;
			if (int.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					diasBaixa = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DiasBaixa", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string TipoDocumentoCobranca
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoDocumentoCobranca;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumTipoDocumentoCobranca), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						tipoDocumentoCobranca = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TipoDocumentoCobranca", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("TipoDocumentoCobranca", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoAceite
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoAceite;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumTipoAceite), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoAceite = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoAceite", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoAceite", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoProtesto
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoProtesto;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoProtesto), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoProtesto = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoProtesto", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoProtesto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int DiasProtesto
	{
		get
		{
			int result = 0;
			Launcher.GetInstance().Executar(delegate
			{
				result = diasProtesto;
			});
			return result;
		}
		set
		{
			int result = 0;
			if (int.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					diasProtesto = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DiasProtesto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoDesconto
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoDesconto;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoDesconto), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoDesconto = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoDesconto", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoDesconto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorDesconto
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = valorDesconto;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					valorDesconto = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorDesconto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualDesconto
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = percentualDesconto;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					percentualDesconto = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualDesconto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoJuros
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoJuros;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoJuros), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoJuros = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoJuros", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoJuros", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorJurosAoDia
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = valorJurosAoDia;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					valorJurosAoDia = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorJurosAoDia", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualJurosAoDia
	{
		get
		{
			double result = 0.0;
			Launcher.GetInstance().Executar(delegate
			{
				result = percentualJurosAoDia;
			});
			return result;
		}
		set
		{
			double result = 0.0;
			if (double.TryParse(value.ToString(), out result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					percentualJurosAoDia = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualJurosAoDia", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ArrayList ModalidadesCobranca => modalidadesCobranca;

	public ArrayList CodigosMulta
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMultaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMultaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMultaFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosMoeda
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMoedaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMoedaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosMoedaFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosBaixaDevolucao
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosBaixaDevolucaoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosBaixaDevolucaoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosBaixaDevolucaoFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosJuros
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosJurosCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosJurosCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosJurosFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosAceite
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosAceiteCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosAceiteCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosAceiteFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList TiposDocumentosCobranca
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = tiposDocumentosCobrancaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = tiposDocumentosCobrancaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = tiposDocumentosCobrancaFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosProtesto
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosProtestoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosProtestoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosProtestoFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosDesconto
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosDescontoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosDescontoCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosDescontoFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public ArrayList CodigosInstrucaoCobranca
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_LAYOUT_REMESSA));
			});
			Enum @enum = carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToEnum<EnumLayoutArquivoRemessa>();
			if (@enum is EnumLayoutArquivoRemessa)
			{
				switch ((EnumLayoutArquivoRemessa)(object)@enum)
				{
				case EnumLayoutArquivoRemessa.CBR641:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosInstrucaoCobrancaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.CNAB400:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosInstrucaoCobrancaCnab400;
					});
					break;
				case EnumLayoutArquivoRemessa.FEBRABAN240:
					Launcher.GetInstance().Executar(delegate
					{
						result = codigosInstrucaoCobrancaFebraban240;
					});
					break;
				}
			}
			return result;
		}
	}

	public bool GeraInstrucaoAutomaticaJuros
	{
		get
		{
			return geraInstrucaoAutomaticaJuros;
		}
		set
		{
			geraInstrucaoAutomaticaJuros = value;
		}
	}

	public bool GeraInstrucaoAutomaticaMulta
	{
		get
		{
			return geraInstrucaoAutomaticaMulta;
		}
		set
		{
			geraInstrucaoAutomaticaMulta = value;
		}
	}

	public bool GeraInstrucaoAutomaticaDesconto
	{
		get
		{
			return geraInstrucaoAutomaticaDesconto;
		}
		set
		{
			geraInstrucaoAutomaticaDesconto = value;
		}
	}

	public bool GeraInstrucaoAutomaticaProtesto
	{
		get
		{
			return geraInstrucaoAutomaticaProtesto;
		}
		set
		{
			geraInstrucaoAutomaticaProtesto = value;
		}
	}

	public ConfiguracaoDocumentoCobranca(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(guid, banco, modoUso, carteira)
	{
		try
		{
			Logger.Debug("Criando configuração de documento de cobrança...");
			RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>(), tipoCarteira);
			CarregarListas(repositorio);
			codigoJuros = "";
			valorJurosAoDia = 0.0;
			percentualJurosAoDia = 0.0;
			codigoDesconto = "";
			valorDesconto = 0.0;
			percentualDesconto = 0.0;
			codigoProtesto = "";
			diasProtesto = 0;
			codigoAceite = "";
			codigoBaixaDevolucao = "";
			diasBaixa = 0;
			tipoDocumentoCobranca = "";
			codigoMoeda = "";
			codigoMulta = "";
			valorMulta = 0.0;
			percentualMulta = 0.0;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ConfiguracaoDocumentoCobranca(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		geraInstrucaoAutomaticaJuros = (bool)serobj.GetValue("GeraInstrucaoAutomaticaJuros", typeof(bool));
		geraInstrucaoAutomaticaMulta = (bool)serobj.GetValue("GeraInstrucaoAutomaticaMulta", typeof(bool));
		geraInstrucaoAutomaticaDesconto = (bool)serobj.GetValue("GeraInstrucaoAutomaticaDesconto", typeof(bool));
		codigoJuros = (string)serobj.GetValue("CodigoJuros", typeof(string));
		valorJurosAoDia = (double)serobj.GetValue("ValorJurosAoDia", typeof(double));
		percentualJurosAoDia = (double)serobj.GetValue("PercentualJurosAoDia", typeof(double));
		codigoDesconto = (string)serobj.GetValue("CodigoDesconto", typeof(string));
		valorDesconto = (double)serobj.GetValue("ValorDesconto", typeof(double));
		percentualDesconto = (double)serobj.GetValue("PercentualDesconto", typeof(double));
		codigoProtesto = (string)serobj.GetValue("CodigoProtesto", typeof(string));
		diasProtesto = (int)serobj.GetValue("DiasProtesto", typeof(int));
		codigoAceite = (string)serobj.GetValue("CodigoAceite", typeof(string));
		codigoBaixaDevolucao = (string)serobj.GetValue("CodigoBaixaDevolucao", typeof(string));
		diasBaixa = (int)serobj.GetValue("DiasBaixa", typeof(int));
		tipoDocumentoCobranca = (string)serobj.GetValue("TipoDocumentoCobranca", typeof(string));
		codigoMoeda = (string)serobj.GetValue("CodigoMoeda", typeof(string));
		codigoMulta = (string)serobj.GetValue("CodigoMulta", typeof(string));
		valorMulta = (double)serobj.GetValue("ValorMulta", typeof(double));
		percentualMulta = (double)serobj.GetValue("PercentualMulta", typeof(double));
		tiposDocumentosCobrancaFebraban240 = (ArrayList)serobj.GetValue("TiposDocumentosCobrancaFebraban240", typeof(ArrayList));
		tiposDocumentosCobrancaCnab400 = (ArrayList)serobj.GetValue("TiposDocumentosCobrancaCnab400", typeof(ArrayList));
		codigosAceiteFebraban240 = (ArrayList)serobj.GetValue("CodigosAceiteFebraban240", typeof(ArrayList));
		codigosAceiteCnab400 = (ArrayList)serobj.GetValue("CodigosAceiteCnab400", typeof(ArrayList));
		codigosDescontoFebraban240 = (ArrayList)serobj.GetValue("CodigosDescontoFebraban240", typeof(ArrayList));
		codigosDescontoCnab400 = (ArrayList)serobj.GetValue("CodigosDescontoCnab400", typeof(ArrayList));
		codigosJurosFebraban240 = (ArrayList)serobj.GetValue("CodigosJurosFebraban240", typeof(ArrayList));
		codigosJurosCnab400 = (ArrayList)serobj.GetValue("CodigosJurosCnab400", typeof(ArrayList));
		codigosProtestoFebraban240 = (ArrayList)serobj.GetValue("CodigosProtestoFebraban240", typeof(ArrayList));
		codigosProtestoCnab400 = (ArrayList)serobj.GetValue("CodigosProtestoCnab400", typeof(ArrayList));
		codigosMoedaFebraban240 = (ArrayList)serobj.GetValue("CodigosMoedaFebraban240", typeof(ArrayList));
		codigosMoedaCnab400 = (ArrayList)serobj.GetValue("CodigosMoedaCnab400", typeof(ArrayList));
		codigosBaixaDevolucaoFebraban240 = (ArrayList)serobj.GetValue("CodigosBaixaDevolucaoFebraban240", typeof(ArrayList));
		codigosBaixaDevolucaoCnab400 = (ArrayList)serobj.GetValue("CodigosBaixaDevolucaoCnab400", typeof(ArrayList));
		codigosMultaFebraban240 = (ArrayList)serobj.GetValue("CodigosMultaFebraban240", typeof(ArrayList));
		codigosMultaCnab400 = (ArrayList)serobj.GetValue("CodigosMultaCnab400", typeof(ArrayList));
		codigosInstrucaoCobrancaCnab400 = (ArrayList)serobj.GetValue("CodigosInstrucaoCobrancaCnab400", typeof(ArrayList));
		codigosInstrucaoCobrancaFebraban240 = (ArrayList)serobj.GetValue("CodigosInstrucaoCobrancaFebraban240", typeof(ArrayList));
		modalidadesCobranca = (ArrayList)serobj.GetValue("ModalidadesCobranca", typeof(ArrayList));
	}

	protected virtual ArrayList CarregarModalidades()
	{
		ArrayList enumByAttributeToItemLista = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(banco));
		if (enumByAttributeToItemLista.Count == 0)
		{
			enumByAttributeToItemLista = EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumChaveContexto.GERAL));
		}
		return enumByAttributeToItemLista;
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		modalidadesCobranca = CarregarModalidades();
		tiposDocumentosCobrancaFebraban240 = repositorio.TiposDocumentosCobrancaFebraban240;
		tiposDocumentosCobrancaCnab400 = repositorio.TiposDocumentosCobrancaCnab400;
		codigosAceiteFebraban240 = repositorio.CodigosAceiteFebraban240;
		codigosAceiteCnab400 = repositorio.CodigosAceiteCnab400;
		codigosDescontoFebraban240 = repositorio.CodigosDescontoFebraban240;
		codigosDescontoCnab400 = repositorio.CodigosDescontoCnab400;
		codigosJurosFebraban240 = repositorio.CodigosJurosFebraban240;
		codigosJurosCnab400 = repositorio.CodigosJurosCnab400;
		codigosProtestoFebraban240 = repositorio.CodigosProtestoFebraban240;
		codigosProtestoCnab400 = repositorio.CodigosProtestoCnab400;
		codigosMoedaFebraban240 = repositorio.CodigosMoedaFebraban240;
		codigosMoedaCnab400 = repositorio.CodigosMoedaCnab400;
		codigosBaixaDevolucaoFebraban240 = repositorio.CodigosBaixaDevolucaoFebraban240;
		codigosBaixaDevolucaoCnab400 = repositorio.CodigosBaixaDevolucaoCnab400;
		codigosMultaFebraban240 = repositorio.CodigosMultaFebraban240;
		codigosMultaCnab400 = repositorio.CodigosMultaCnab400;
		codigosInstrucaoCobrancaFebraban240 = repositorio.CodigosInstrucaoCobrancaFebraban240;
		codigosInstrucaoCobrancaCnab400 = repositorio.CodigosInstrucaoCobrancaCnab400;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("GeraInstrucaoAutomaticaJuros", geraInstrucaoAutomaticaJuros);
		info.AddValue("GeraInstrucaoAutomaticaMulta", geraInstrucaoAutomaticaMulta);
		info.AddValue("GeraInstrucaoAutomaticaDesconto", geraInstrucaoAutomaticaDesconto);
		info.AddValue("CodigoJuros", codigoJuros);
		info.AddValue("ValorJurosAoDia", valorJurosAoDia);
		info.AddValue("PercentualJurosAoDia", percentualJurosAoDia);
		info.AddValue("CodigoDesconto", codigoDesconto);
		info.AddValue("ValorDesconto", valorDesconto);
		info.AddValue("PercentualDesconto", percentualDesconto);
		info.AddValue("CodigoProtesto", codigoProtesto);
		info.AddValue("DiasProtesto", diasProtesto);
		info.AddValue("CodigoAceite", codigoAceite);
		info.AddValue("CodigoBaixaDevolucao", codigoBaixaDevolucao);
		info.AddValue("DiasBaixa", diasBaixa);
		info.AddValue("TipoDocumentoCobranca", tipoDocumentoCobranca);
		info.AddValue("CodigoMoeda", codigoMoeda);
		info.AddValue("CodigoMulta", codigoMulta);
		info.AddValue("ValorMulta", valorMulta);
		info.AddValue("PercentualMulta", percentualMulta);
		info.AddValue("TiposDocumentosCobrancaFebraban240", tiposDocumentosCobrancaFebraban240);
		info.AddValue("TiposDocumentosCobrancaCnab400", tiposDocumentosCobrancaCnab400);
		info.AddValue("CodigosAceiteFebraban240", codigosAceiteFebraban240);
		info.AddValue("CodigosAceiteCnab400", codigosAceiteCnab400);
		info.AddValue("CodigosDescontoFebraban240", codigosDescontoFebraban240);
		info.AddValue("CodigosDescontoCnab400", codigosDescontoCnab400);
		info.AddValue("CodigosJurosFebraban240", codigosJurosFebraban240);
		info.AddValue("CodigosJurosCnab400", codigosJurosCnab400);
		info.AddValue("CodigosProtestoFebraban240", codigosProtestoFebraban240);
		info.AddValue("CodigosProtestoCnab400", codigosProtestoCnab400);
		info.AddValue("CodigosMoedaFebraban240", codigosMoedaFebraban240);
		info.AddValue("CodigosMoedaCnab400", codigosMoedaCnab400);
		info.AddValue("CodigosBaixaDevolucaoFebraban240", codigosBaixaDevolucaoFebraban240);
		info.AddValue("CodigosBaixaDevolucaoCnab400", codigosBaixaDevolucaoCnab400);
		info.AddValue("CodigosMultaFebraban240", codigosMultaFebraban240);
		info.AddValue("CodigosMultaCnab400", codigosMultaCnab400);
		info.AddValue("CodigosInstrucaoCobrancaCnab400", codigosInstrucaoCobrancaCnab400);
		info.AddValue("CodigosInstrucaoCobrancaFebraban240", codigosInstrucaoCobrancaFebraban240);
		info.AddValue("ModalidadesCobranca", modalidadesCobranca);
	}
}
