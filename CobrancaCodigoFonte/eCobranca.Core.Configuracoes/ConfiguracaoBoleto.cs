using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoBoleto : ConfiguracaoECobranca
{
	private string diretorioImagens;

	private string logotipoBeneficiario;

	private string propaganda;

	private string tipoPropaganda;

	private string diretorioModeloBoletoPersonalizado;

	private string modeloBoletoPersonalizado;

	private string formatoBoletoPersonalizado;

	private string tipoModeloBoletoUtilizado;

	private string dadosSAC;

	private string diretorioGeracaoBoleto;

	private string codigoBancoImpressao;

	private string codigoCarteiraImpressao;

	private string localPagamento;

	private string prefixoNomenclatura;

	private string tipoNomenclatura;

	private int numeroMaximoBoletosPorPagina;

	private int numeroBoletosPorPagina;

	private int alturaCampoDemonstrativoReciboEntrega;

	private int alturaCampoDemonstrativoReciboPagador;

	private bool exibeEspelhoLinhaDigitavel;

	private bool exibeCodigoBancoCompensacaoRecibo;

	private bool exibeSAC;

	private bool exibeLogotipoBeneficiario;

	private bool exibePropaganda;

	private ArrayList tiposModeloBoleto;

	[NonSerialized]
	private ArrayList modelosBoleto;

	private ArrayList formatosBoleto;

	private ArrayList tiposPropaganda;

	private ArrayList tiposNomenclaturaBoleto;

	public ArrayList TiposNomenclaturaBoleto => tiposNomenclaturaBoleto;

	public ArrayList TiposPropaganda => tiposPropaganda;

	public ArrayList TiposModeloBoleto
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = tiposModeloBoleto;
			});
			return result;
		}
	}

	public ArrayList FormatosBoleto => formatosBoleto;

	public string CodigoCarteiraImpressao
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoCarteiraImpressao;
			});
			return result;
		}
	}

	public string CodigoBancoImpressao
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoBancoImpressao;
			});
			return result;
		}
	}

	public ArrayList ModelosBoleto
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = modelosBoleto;
			});
			return modelosBoleto;
		}
	}

	public string DadosSAC
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = dadosSAC;
			});
			return result;
		}
	}

	public int NumeroMaximoBoletosPorPagina
	{
		get
		{
			if (Enum.IsDefined(typeof(EnumTipoModeloBoleto), TipoModeloBoletoUtilizado.ToUpper()))
			{
				switch ((EnumTipoModeloBoleto)Enum.Parse(typeof(EnumTipoModeloBoleto), TipoModeloBoletoUtilizado.ToUpper()))
				{
				case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 1;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 1;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_MEIA_PAGINA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 2;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 2;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 3;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 2;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 1;
					});
					break;
				case EnumTipoModeloBoleto.BOLETO_PERSONALIZADO:
					Launcher.GetInstance().Executar(delegate
					{
						numeroMaximoBoletosPorPagina = 3;
					});
					break;
				}
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					numeroMaximoBoletosPorPagina = 1;
				});
			}
			return numeroMaximoBoletosPorPagina;
		}
	}

	public int QuantidadeLinhasDemonstrativo
	{
		get
		{
			if (string.IsNullOrEmpty(tipoModeloBoletoUtilizado))
			{
				return 0;
			}
			return (EnumTipoModeloBoleto)(object)tipoModeloBoletoUtilizado.ToEnum<EnumTipoModeloBoleto>() switch
			{
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA => 0, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA => 0, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS => 25, 
				_ => 0, 
			};
		}
	}

	public int QuantidadeCharsLinhaDemonstrativo
	{
		get
		{
			if (string.IsNullOrEmpty(tipoModeloBoletoUtilizado))
			{
				return 0;
			}
			return (EnumTipoModeloBoleto)(object)tipoModeloBoletoUtilizado.ToEnum<EnumTipoModeloBoleto>() switch
			{
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA => 0, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA => 0, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS => 95, 
				_ => 0, 
			};
		}
	}

	public int QuantidadeLinhasInformacoesExtras
	{
		get
		{
			if (string.IsNullOrEmpty(tipoModeloBoletoUtilizado))
			{
				return 0;
			}
			return (EnumTipoModeloBoleto)(object)tipoModeloBoletoUtilizado.ToEnum<EnumTipoModeloBoleto>() switch
			{
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA => 33, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA => 18, 
				EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS => 6, 
				_ => 0, 
			};
		}
	}

	public int QuantidadeCharsLinhaInformacoesExtras
	{
		get
		{
			if (string.IsNullOrEmpty(tipoModeloBoletoUtilizado))
			{
				return 0;
			}
			EnumTipoModeloBoleto enumTipoModeloBoleto = (EnumTipoModeloBoleto)(object)tipoModeloBoletoUtilizado.ToEnum<EnumTipoModeloBoleto>();
			if ((uint)enumTipoModeloBoleto <= 1u || enumTipoModeloBoleto == EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS)
			{
				return 95;
			}
			return 0;
		}
	}

	public int AlturaCampoDemonstrativoReciboPagador
	{
		get
		{
			int result = 0;
			Launcher.GetInstance().Executar(delegate
			{
				result = alturaCampoDemonstrativoReciboPagador;
			});
			return result;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					alturaCampoDemonstrativoReciboPagador = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("AlturaCampoDemonstrativoReciboPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int AlturaCampoDemonstrativoReciboEntrega
	{
		get
		{
			int result = 0;
			Launcher.GetInstance().Executar(delegate
			{
				result = alturaCampoDemonstrativoReciboEntrega;
			});
			return result;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					alturaCampoDemonstrativoReciboEntrega = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("AlturaCampoDemonstrativoReciboEntrega", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string DiretorioGeracaoBoleto
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioGeracaoBoleto;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					diretorioGeracaoBoleto = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioGeracaoBoleto", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string LocalPagamento
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = localPagamento;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					localPagamento = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LocalPagamento", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string PrefixoNomenclatura
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = prefixoNomenclatura;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					prefixoNomenclatura = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("PrefixoNomenclatura", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string TipoModeloBoletoUtilizado
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoModeloBoletoUtilizado;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumTipoModeloBoleto), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						tipoModeloBoletoUtilizado = value.ToString().ToUpper();
					});
					Launcher.GetInstance().Executar(delegate
					{
						numeroBoletosPorPagina = NumeroMaximoBoletosPorPagina;
					});
					switch ((EnumTipoModeloBoleto)(object)value.ToEnum<EnumTipoModeloBoleto>())
					{
					case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA:
						alturaCampoDemonstrativoReciboEntrega = 350;
						alturaCampoDemonstrativoReciboPagador = 350;
						break;
					case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA:
						alturaCampoDemonstrativoReciboEntrega = 250;
						alturaCampoDemonstrativoReciboPagador = 250;
						break;
					case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_MEIA_PAGINA:
					case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA:
					case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO:
					case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA:
					case EnumTipoModeloBoleto.BOLETO_PERSONALIZADO:
						alturaCampoDemonstrativoReciboEntrega = 0;
						alturaCampoDemonstrativoReciboPagador = 0;
						break;
					}
					_ = (EnumTipoModeloBoleto)(object)value.ToEnum<EnumTipoModeloBoleto>();
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TipoModeloBoletoUtilizado", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("TipoModeloBoletoUtilizado", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int NumeroBoletosPorPagina
	{
		get
		{
			int result = 1;
			Launcher.GetInstance().Executar(delegate
			{
				result = numeroBoletosPorPagina;
			});
			return result;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				if (result <= NumeroMaximoBoletosPorPagina && result > 0)
				{
					Launcher.GetInstance().Executar(delegate
					{
						numeroBoletosPorPagina = result;
					});
				}
				else
				{
					Launcher.GetInstance().Executar(delegate
					{
						numeroBoletosPorPagina = NumeroMaximoBoletosPorPagina;
					});
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("NumeroBoletosPorPagina", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ExibePropaganda
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibePropaganda;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibePropaganda = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibePropaganda", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade ExibeLogotipoCedente está em desuso, favor utilizar ExibeLogotipoBeneficiario.")]
	public bool ExibeLogotipoCedente
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibeLogotipoBeneficiario;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibeLogotipoBeneficiario = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibeLogotipoCedente", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ExibeLogotipoBeneficiario
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibeLogotipoBeneficiario;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibeLogotipoBeneficiario = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibeLogotipoCedente", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ExibeSAC
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibeSAC;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibeSAC = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibeSAC", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ExibeCodigoBancoCompensacaoRecibo
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibeCodigoBancoCompensacaoRecibo;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibeCodigoBancoCompensacaoRecibo = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibeCodigoBancoCompensacaoRecibo", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ExibeEspelhoLinhaDigitavel
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = exibeEspelhoLinhaDigitavel;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					exibeEspelhoLinhaDigitavel = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ExibeEspelhoLinhaDigitavel", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ModeloBoletoPersonalizado
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = modeloBoletoPersonalizado;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					modeloBoletoPersonalizado = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ModeloBoletoPersonalizado", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string FormatoBoletoPersonalizado
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = formatoBoletoPersonalizado;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumFormatoModeloBoleto>())
				{
					Launcher.GetInstance().Executar(delegate
					{
						formatoBoletoPersonalizado = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("FormatoBoletoPersonalizado", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("FormatoBoletoPersonalizado", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string Propaganda
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = propaganda;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					propaganda = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("Propaganda", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string TipoPropaganda
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoPropaganda;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumTipoPropaganda>())
				{
					Launcher.GetInstance().Executar(delegate
					{
						tipoPropaganda = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TipoPropaganda", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("TipoPropaganda", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string TipoNomenclatura
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoNomenclatura;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumTipoNomenclaturaBoleto>())
				{
					Launcher.GetInstance().Executar(delegate
					{
						tipoNomenclatura = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TipoNomenclatura", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("TipoNomenclatura", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string DiretorioModeloBoletoPersonalizado
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioModeloBoletoPersonalizado;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					diretorioModeloBoletoPersonalizado = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioModeloBoletoPersonalizado", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade LogotipoCedente está em desuso, favor utilizar LogotipoBeneficiario.")]
	public string LogotipoCedente
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = logotipoBeneficiario;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value == string.Empty)
				{
					Launcher.GetInstance().Executar(delegate
					{
						logotipoBeneficiario = value;
					});
				}
				else if (File.Exists(value))
				{
					Launcher.GetInstance().Executar(delegate
					{
						logotipoBeneficiario = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoInformadoNaoExiste(value), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LogotipoCedente", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string LogotipoBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = logotipoBeneficiario;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value == string.Empty)
				{
					Launcher.GetInstance().Executar(delegate
					{
						logotipoBeneficiario = value;
					});
				}
				else if (File.Exists(value))
				{
					Launcher.GetInstance().Executar(delegate
					{
						logotipoBeneficiario = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoInformadoNaoExiste(value), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LogotipoBeneficiario", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string DiretorioImagens
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioImagens;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					diretorioImagens = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioImagens", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ConfiguracaoBoleto(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, string dadosSAC, string codigoBancoImpressao, string codigoCarteiraImpressao)
		: base(guid, banco, modoUso, carteira)
	{
		try
		{
			Logger.Debug("Criando configuração de boleto...");
			RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>());
			CarregarListas(repositorio);
			CarregarModelosBoletos();
			this.dadosSAC = dadosSAC;
			this.codigoBancoImpressao = codigoBancoImpressao;
			this.codigoCarteiraImpressao = codigoCarteiraImpressao;
			prefixoNomenclatura = "";
			exibeCodigoBancoCompensacaoRecibo = false;
			exibeEspelhoLinhaDigitavel = false;
			exibeLogotipoBeneficiario = false;
			exibeSAC = false;
			exibePropaganda = false;
			tipoModeloBoletoUtilizado = ((ItemLista)tiposModeloBoleto[0]).Valor;
			numeroMaximoBoletosPorPagina = 1;
			numeroBoletosPorPagina = 1;
			tipoNomenclatura = (tiposNomenclaturaBoleto[0] as ItemLista).Valor;
			diretorioImagens = "C:\\eCobranca\\Imagens\\";
			diretorioGeracaoBoleto = "C:\\eCobranca\\Boletos\\";
			alturaCampoDemonstrativoReciboEntrega = 0;
			alturaCampoDemonstrativoReciboPagador = 0;
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

	public ConfiguracaoBoleto(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		diretorioImagens = (string)serobj.GetValue("DiretorioImagens", typeof(string));
		logotipoBeneficiario = (string)serobj.GetValue("LogotipoBeneficiario", typeof(string));
		propaganda = (string)serobj.GetValue("Propaganda", typeof(string));
		tipoPropaganda = (string)serobj.GetValue("TipoPropaganda", typeof(string));
		diretorioModeloBoletoPersonalizado = (string)serobj.GetValue("DiretorioModeloBoletoPersonalizado", typeof(string));
		modeloBoletoPersonalizado = (string)serobj.GetValue("ModeloBoletoPersonalizado", typeof(string));
		formatoBoletoPersonalizado = (string)serobj.GetValue("FormatoBoletoPersonalizado", typeof(string));
		tipoModeloBoletoUtilizado = (string)serobj.GetValue("TipoModeloBoletoUtilizado", typeof(string));
		dadosSAC = (string)serobj.GetValue("DadosSAC", typeof(string));
		diretorioGeracaoBoleto = (string)serobj.GetValue("DiretorioGeracaoBoleto", typeof(string));
		codigoBancoImpressao = (string)serobj.GetValue("CodigoBancoImpressao", typeof(string));
		codigoCarteiraImpressao = (string)serobj.GetValue("CodigoCarteiraImpressao", typeof(string));
		localPagamento = (string)serobj.GetValue("LocalPagamento", typeof(string));
		prefixoNomenclatura = (string)serobj.GetValue("PrefixoNomenclatura", typeof(string));
		tipoNomenclatura = (string)serobj.GetValue("TipoNomenclatura", typeof(string));
		numeroMaximoBoletosPorPagina = (int)serobj.GetValue("NumeroMaximoBoletosPorPagina", typeof(int));
		numeroBoletosPorPagina = (int)serobj.GetValue("NumeroBoletosPorPagina", typeof(int));
		alturaCampoDemonstrativoReciboEntrega = (int)serobj.GetValue("AlturaCampoDemonstrativoReciboEntrega", typeof(int));
		alturaCampoDemonstrativoReciboPagador = (int)serobj.GetValue("AlturaCampoDemonstrativoReciboPagador", typeof(int));
		exibeEspelhoLinhaDigitavel = (bool)serobj.GetValue("ExibeEspelhoLinhaDigitavel", typeof(bool));
		exibeCodigoBancoCompensacaoRecibo = (bool)serobj.GetValue("ExibeCodigoBancoCompensacaoRecibo", typeof(bool));
		exibeSAC = (bool)serobj.GetValue("ExibeSAC", typeof(bool));
		exibeLogotipoBeneficiario = (bool)serobj.GetValue("ExibeLogotipoBeneficiario", typeof(bool));
		exibePropaganda = (bool)serobj.GetValue("ExibePropaganda", typeof(bool));
		tiposModeloBoleto = (ArrayList)serobj.GetValue("TiposModeloBoleto", typeof(ArrayList));
		formatosBoleto = (ArrayList)serobj.GetValue("FormatosBoleto", typeof(ArrayList));
		tiposPropaganda = (ArrayList)serobj.GetValue("TiposPropaganda", typeof(ArrayList));
		tiposNomenclaturaBoleto = (ArrayList)serobj.GetValue("TiposNomenclaturaBoleto", typeof(ArrayList));
		RefreshNotifyEventHandler();
		observableNotifyTypes.Add(EnumTipoNotificacao.CARREGAR_MODELOS_BOLETO);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
	}

	private void CarregarModelosBoletos()
	{
		ArrayList names = EnumUtil.GetNames(typeof(EnumTipoModeloBoleto));
		modelosBoleto = new ArrayList();
		for (int i = 0; i < names.Count; i++)
		{
			EnumTipoModeloBoleto tipoModelo = (EnumTipoModeloBoleto)Enum.Parse(typeof(EnumTipoModeloBoleto), names[i].ToString().ToUpper());
			if (!tipoModelo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO))
			{
				ModeloBoleto modelo = FactoryModeloBoleto.GetInstance().GetModelo(tipoModelo, carteira);
				if (modelo != null)
				{
					modelosBoleto.Add(modelo);
				}
			}
		}
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		tiposModeloBoleto = repositorio.TiposModelosBoleto;
		formatosBoleto = repositorio.FormatosBoleto;
		tiposPropaganda = repositorio.TiposPropaganda;
		tiposNomenclaturaBoleto = repositorio.TiposNomenclaturaBoleto;
	}

	public override void Update(NotifyEvent ne)
	{
		base.Update(ne);
		if (ne.Type == EnumTipoNotificacao.CARREGAR_MODELOS_BOLETO && carteira != null)
		{
			CarregarModelosBoletos();
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("DiretorioImagens", diretorioImagens);
		info.AddValue("LogotipoBeneficiario", logotipoBeneficiario);
		info.AddValue("Propaganda", propaganda);
		info.AddValue("TipoPropaganda", tipoPropaganda);
		info.AddValue("DiretorioModeloBoletoPersonalizado", diretorioModeloBoletoPersonalizado);
		info.AddValue("ModeloBoletoPersonalizado", modeloBoletoPersonalizado);
		info.AddValue("FormatoBoletoPersonalizado", formatoBoletoPersonalizado);
		info.AddValue("TipoModeloBoletoUtilizado", tipoModeloBoletoUtilizado);
		info.AddValue("DadosSAC", dadosSAC);
		info.AddValue("DiretorioGeracaoBoleto", diretorioGeracaoBoleto);
		info.AddValue("CodigoBancoImpressao", codigoBancoImpressao);
		info.AddValue("CodigoCarteiraImpressao", codigoCarteiraImpressao);
		info.AddValue("LocalPagamento", localPagamento);
		info.AddValue("PrefixoNomenclatura", prefixoNomenclatura);
		info.AddValue("TipoNomenclatura", tipoNomenclatura);
		info.AddValue("NumeroMaximoBoletosPorPagina", numeroMaximoBoletosPorPagina);
		info.AddValue("NumeroBoletosPorPagina", numeroBoletosPorPagina);
		info.AddValue("AlturaCampoDemonstrativoReciboEntrega", alturaCampoDemonstrativoReciboEntrega);
		info.AddValue("AlturaCampoDemonstrativoReciboPagador", alturaCampoDemonstrativoReciboPagador);
		info.AddValue("ExibeEspelhoLinhaDigitavel", exibeEspelhoLinhaDigitavel);
		info.AddValue("ExibeCodigoBancoCompensacaoRecibo", exibeCodigoBancoCompensacaoRecibo);
		info.AddValue("ExibeSAC", exibeSAC);
		info.AddValue("ExibeLogotipoBeneficiario", exibeLogotipoBeneficiario);
		info.AddValue("ExibePropaganda", exibePropaganda);
		info.AddValue("TiposModeloBoleto", tiposModeloBoleto);
		info.AddValue("FormatosBoleto", formatosBoleto);
		info.AddValue("TiposPropaganda", tiposPropaganda);
		info.AddValue("TiposNomenclaturaBoleto", tiposNomenclaturaBoleto);
	}
}
