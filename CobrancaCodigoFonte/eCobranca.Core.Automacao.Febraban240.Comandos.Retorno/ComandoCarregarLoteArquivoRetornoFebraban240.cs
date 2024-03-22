using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;

public abstract class ComandoCarregarLoteArquivoRetornoFebraban240<C, D, E, F> : MacroCommand where C : ComandoCarregarSegmentoLoteRetornoFebraban240 where D : ComandoCarregarSegmentoDetalheRetornoFebraban240 where E : ComandoCarregarSegmentoDetalheRetornoFebraban240 where F : ComandoCarregarSegmentoLoteRetornoFebraban240
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRetornoFebraban240 lote;

	public ComandoCarregarLoteArquivoRetornoFebraban240(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para carregar o lote do arquivo de retorno do layout FEBRABAN240...");
		this.carteira = carteira;
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
			base.Comandos.Clear();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.FalhaGerandoComandosDaMacroBaseCarregarLoteArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRetornoFebraban240 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
		base.Comandos.Clear();
		foreach (string item in lote.LinhasLote)
		{
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo())
			{
				C val = (C)Activator.CreateInstance(typeof(C));
				val.Preparar(carteira, lote, item);
				base.Comandos.Add(val);
			}
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.DETALHE.Codigo())
			{
				if (item.Substring(13, 1) == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_T.Codigo())
				{
					SegmentoDetalheFebraban240 segmento = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_T, 0L, 0L, segmentoDeRemessa: false) as SegmentoDetalheFebraban240;
					segmento = lote.AdicionarSegmento(segmento);
					D val2 = (D)Activator.CreateInstance(typeof(D));
					val2.Preparar(carteira, segmento, item);
					base.Comandos.Add(val2);
				}
				if (item.Substring(13, 1) == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo())
				{
					SegmentoDetalheFebraban240 segmento2 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_U, 0L, 0L, segmentoDeRemessa: false) as SegmentoDetalheFebraban240;
					segmento2 = lote.AdicionarSegmento(segmento2);
					E val3 = (E)Activator.CreateInstance(typeof(E));
					val3.Preparar(carteira, segmento2, item);
					base.Comandos.Add(val3);
				}
			}
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo())
			{
				F val4 = (F)Activator.CreateInstance(typeof(F));
				val4.Preparar(carteira, lote, item);
				base.Comandos.Add(val4);
			}
		}
	}
}
