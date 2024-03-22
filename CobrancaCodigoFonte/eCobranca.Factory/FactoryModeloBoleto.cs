using System;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactoryModeloBoleto
{
	private static object syncRoot = new object();

	private static FactoryModeloBoleto uniqueInstance;

	private FactoryModeloBoleto()
	{
	}

	public static FactoryModeloBoleto GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de Modelos de Boletos...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new FactoryModeloBoleto();
					}
				}
			}
			return uniqueInstance;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaCriandoFabricaModeloBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return null;
		}
	}

	public ModeloBoleto GetModelo(EnumTipoModeloBoleto tipoModelo, CarteiraCobranca carteira)
	{
		ModeloBoleto result = null;
		try
		{
			Logger.Debug($"Obtendo instância de modelo de boleto [{tipoModelo.ToString()}]");
			switch (tipoModelo)
			{
			case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA:
				result = new ModeloBoletoPadraoSacadoPaginaInteira(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA:
				result = new ModeloBoletoPadraoSacadoEntregaPaginaInteira(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_MEIA_PAGINA:
				result = new ModeloBoletoTopoSacadoMeiaPagina(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA:
				result = new ModeloBoletoTopoSacadoEntregaMeiaPagina(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO:
				result = new ModeloBoletoCarnetSacado(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA:
				result = new ModeloBoletoCarnetSacadoEntrega(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA:
				result = new ModeloBoletoCarnetSacadoEntregaZebra(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_FITA:
				result = new ModeloBoletoCarnetSacadoEntregaFita(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS:
				result = new ModeloBoletoPadraoSacadoPaginaInteiraExtra(carteira);
				return result;
			case EnumTipoModeloBoleto.BOLETO_PERSONALIZADO:
				if (carteira.ConfiguracaoBoleto != null)
				{
					if (File.Exists(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + carteira.ConfiguracaoBoleto.ModeloBoletoPersonalizado))
					{
						result = new ModeloBoletoPersonalizado(carteira);
						return result;
					}
					return result;
				}
				return result;
			default:
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto(tipoModelo.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
