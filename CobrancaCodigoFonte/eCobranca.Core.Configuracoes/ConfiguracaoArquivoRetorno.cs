using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoArquivoRetorno : ConfiguracaoECobranca
{
	protected string layoutArquivoRetorno;

	private string diretorioArquivoRetorno;

	protected ArrayList layoutsArquivoRetorno;

	public EnumCodigoBanco Banco => banco;

	public ArrayList LayoutsArquivoRetorno
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = layoutsArquivoRetorno;
			});
			return result;
		}
	}

	public string DiretorioArquivoRetorno
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioArquivoRetorno;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				Launcher.GetInstance().Executar(delegate
				{
					diretorioArquivoRetorno = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioArquivoRetorno", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string LayoutArquivoRetorno
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = layoutArquivoRetorno;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumLayoutArquivoRetorno), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						layoutArquivoRetorno = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("LayoutArquivoRemessa", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LayoutArquivoRetorno", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ConfiguracaoArquivoRetorno(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(guid, banco, modoUso, carteira)
	{
		try
		{
			Logger.Debug("Criando configuração de arquivo de retorno...");
			RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>(), tipoCarteira);
			CarregarListas(repositorio);
			layoutArquivoRetorno = (layoutsArquivoRetorno[0] as ItemLista).Valor;
			diretorioArquivoRetorno = "";
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

	public ConfiguracaoArquivoRetorno(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, string diretorioArquivoRetorno, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: this(guid, banco, modoUso, carteira, tipoCarteira)
	{
		try
		{
			this.diretorioArquivoRetorno = diretorioArquivoRetorno;
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

	public ConfiguracaoArquivoRetorno(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		layoutArquivoRetorno = (string)serobj.GetValue("LayoutArquivoRetorno", typeof(string));
		diretorioArquivoRetorno = (string)serobj.GetValue("DiretorioArquivoRetorno", typeof(string));
		layoutsArquivoRetorno = (ArrayList)serobj.GetValue("LayoutsArquivoRetorno", typeof(ArrayList));
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		layoutsArquivoRetorno = repositorio.LayoutsArquivoRetorno;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("LayoutArquivoRetorno", layoutArquivoRetorno);
		info.AddValue("DiretorioArquivoRetorno", diretorioArquivoRetorno);
		info.AddValue("LayoutsArquivoRetorno", layoutsArquivoRetorno);
	}
}
