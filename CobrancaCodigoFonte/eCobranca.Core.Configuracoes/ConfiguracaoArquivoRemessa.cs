using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
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
public class ConfiguracaoArquivoRemessa : ConfiguracaoECobranca
{
	protected string layoutArquivoRemessa;

	private string diretorioArquivoRemessa;

	private string codigoMovimentoRemessaPadrao;

	private long sequenciaRemessa;

	private int sequenciaLote;

	protected ArrayList layoutsArquivoRemessa;

	protected ArrayList codigosMovimentoRemessaFebraban240;

	protected ArrayList codigosMovimentoRemessaCnab400;

	private DateTime dataUltimaRemessa;

	private int sequenciaRemessaDiaria;

	private int limiteRemessasDiaria;

	private bool cobrancaRegistrada;

	public EnumCodigoBanco Banco => banco;

	public ArrayList LayoutsArquivoRemessa
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = layoutsArquivoRemessa;
			});
			return result;
		}
	}

	public ArrayList CodigosMovimentoRemessa
	{
		get
		{
			ArrayList result = new ArrayList();
			try
			{
				if (Enum.IsDefined(typeof(EnumLayoutArquivoRemessa), layoutArquivoRemessa.ToString().ToUpper()))
				{
					switch ((EnumLayoutArquivoRemessa)Enum.Parse(typeof(EnumLayoutArquivoRemessa), layoutArquivoRemessa.ToString().ToUpper()))
					{
					case EnumLayoutArquivoRemessa.CBR641:
						result = codigosMovimentoRemessaCnab400;
						return result;
					case EnumLayoutArquivoRemessa.CNAB400:
						result = codigosMovimentoRemessaCnab400;
						return result;
					case EnumLayoutArquivoRemessa.FEBRABAN240:
						result = codigosMovimentoRemessaFebraban240;
						return result;
					default:
						return result;
					}
				}
				return result;
			}
			catch (Exception ex)
			{
				if (ex is ExcecaoECobranca)
				{
					Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
					return result;
				}
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
		}
	}

	public bool CobrancaRegistrada => cobrancaRegistrada;

	public string CodigoMovimentoRemessaPadrao
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoMovimentoRemessaPadrao;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumCodigoMovimentoRemessa), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						codigoMovimentoRemessaPadrao = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoMovimentoRemessaPadrao", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoMovimentoRemessaPadrao", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int SequenciaLote
	{
		get
		{
			int result = 1;
			Launcher.GetInstance().Executar(delegate
			{
				result = sequenciaLote;
			});
			return result;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					sequenciaLote = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("SequenciaLote", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public long SequenciaRemessa
	{
		get
		{
			long result = 1L;
			Launcher.GetInstance().Executar(delegate
			{
				result = sequenciaRemessa;
			});
			return result;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var _))
			{
				Launcher.GetInstance().Executar(delegate
				{
					sequenciaRemessa = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("SequenciaRemessa", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public DateTime DataUltimaRemessa
	{
		get
		{
			return dataUltimaRemessa;
		}
		set
		{
			dataUltimaRemessa = value;
		}
	}

	public int SequenciaRemessaDiaria
	{
		get
		{
			return sequenciaRemessaDiaria;
		}
		set
		{
			sequenciaRemessaDiaria = value;
		}
	}

	public int LimiteRemessasDiaria => limiteRemessasDiaria;

	public string DiretorioArquivoRemessa
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioArquivoRemessa;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					diretorioArquivoRemessa = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioArquivoRemessa", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string LayoutArquivoRemessa
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = layoutArquivoRemessa;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (cobrancaRegistrada)
				{
					if (Enum.IsDefined(typeof(EnumLayoutArquivoRemessa), value.ToString().ToUpper()))
					{
						Launcher.GetInstance().Executar(delegate
						{
							layoutArquivoRemessa = value;
						});
					}
					else
					{
						Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("LayoutArquivoRemessa", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
					}
				}
				else if (value == "")
				{
					Launcher.GetInstance().Executar(delegate
					{
						layoutArquivoRemessa = value;
					});
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LayoutArquivoRemessa", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ConfiguracaoArquivoRemessa(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, int limiteRemessasDiaria, bool cobrancaRegistrada, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(guid, banco, modoUso, carteira)
	{
		try
		{
			Logger.Debug("Criando configuração de arquivo de remessa...");
			RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>(), tipoCarteira);
			CarregarListas(repositorio);
			if (layoutsArquivoRemessa.Count > 0)
			{
				layoutArquivoRemessa = ((ItemLista)layoutsArquivoRemessa[0]).Valor;
			}
			this.limiteRemessasDiaria = limiteRemessasDiaria;
			this.cobrancaRegistrada = cobrancaRegistrada;
			observableNotifyTypes.Add(EnumTipoNotificacao.GET_LAYOUT_REMESSA);
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

	public ConfiguracaoArquivoRemessa(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		layoutArquivoRemessa = (string)serobj.GetValue("LayoutArquivoRemessa", typeof(string));
		diretorioArquivoRemessa = (string)serobj.GetValue("DiretorioArquivoRemessa", typeof(string));
		codigoMovimentoRemessaPadrao = (string)serobj.GetValue("CodigoMovimentoRemessaPadrao", typeof(string));
		sequenciaRemessa = (long)serobj.GetValue("SequenciaRemessa", typeof(long));
		sequenciaLote = (int)serobj.GetValue("SequenciaLote", typeof(int));
		dataUltimaRemessa = (DateTime)serobj.GetValue("DataUltimaRemessa", typeof(DateTime));
		sequenciaRemessaDiaria = (int)serobj.GetValue("SequenciaRemessaDiaria", typeof(int));
		limiteRemessasDiaria = (int)serobj.GetValue("LimiteRemessasDiaria", typeof(int));
		cobrancaRegistrada = (bool)serobj.GetValue("CobrancaRegistrada", typeof(bool));
		layoutsArquivoRemessa = (ArrayList)serobj.GetValue("LayoutsArquivoRemessa", typeof(ArrayList));
		codigosMovimentoRemessaFebraban240 = (ArrayList)serobj.GetValue("CodigosMovimentoRemessaFebraban240", typeof(ArrayList));
		codigosMovimentoRemessaCnab400 = (ArrayList)serobj.GetValue("CodigosMovimentoRemessaCnab400", typeof(ArrayList));
		observableNotifyTypes.Add(EnumTipoNotificacao.GET_LAYOUT_REMESSA);
	}

	public override void Update(NotifyEvent ne)
	{
		base.Update(ne);
		if (ne.Type == EnumTipoNotificacao.GET_LAYOUT_REMESSA)
		{
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_LAYOUT_REMESSA, layoutArquivoRemessa));
			});
		}
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		layoutsArquivoRemessa = repositorio.LayoutsArquivoRemessa;
		codigosMovimentoRemessaCnab400 = repositorio.CodigosMovimentoRemessaCnab400;
		codigosMovimentoRemessaFebraban240 = repositorio.CodigosMovimentoRemessaFebraban240;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("LayoutArquivoRemessa", layoutArquivoRemessa);
		info.AddValue("DiretorioArquivoRemessa", diretorioArquivoRemessa);
		info.AddValue("CodigoMovimentoRemessaPadrao", codigoMovimentoRemessaPadrao);
		info.AddValue("SequenciaRemessa", sequenciaRemessa);
		info.AddValue("SequenciaLote", sequenciaLote);
		info.AddValue("DataUltimaRemessa", dataUltimaRemessa);
		info.AddValue("SequenciaRemessaDiaria", sequenciaRemessaDiaria);
		info.AddValue("LimiteRemessasDiaria", limiteRemessasDiaria);
		info.AddValue("CobrancaRegistrada", cobrancaRegistrada);
		info.AddValue("LayoutsArquivoRemessa", layoutsArquivoRemessa);
		info.AddValue("CodigosMovimentoRemessaFebraban240", codigosMovimentoRemessaFebraban240);
		info.AddValue("CodigosMovimentoRemessaCnab400", codigosMovimentoRemessaCnab400);
	}
}
