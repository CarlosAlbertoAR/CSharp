using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban150.Estrutura;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;

public abstract class ComandoCarregarLoteArquivoRetornoFebraban150<C> : MacroCommand where C : ComandoCarregarSegmentoDetalheRetornoFebraban150
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRetornoFebraban150 lote;

	public ComandoCarregarLoteArquivoRetornoFebraban150()
	{
		Logger.Debug("Criando macro comando para carregar o lote do arquivo de retorno do layout FEBRABAN150...");
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
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

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRetornoFebraban150 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
		foreach (string item in lote.LinhasLote)
		{
			if (item.Substring(0, 1) == EnumTipoSegmentoFebraban150.SEGMENTO_DETALHE_G.Codigo())
			{
				SegmentoDetalheFebraban150 segmento = new SegmentoDetalheGFebraban150Padrao();
				segmento = lote.AdicionarSegmentoDetalhe(segmento);
				C val = (C)Activator.CreateInstance(typeof(C));
				val.Preparar(carteira, segmento, item);
				base.Comandos.Add(val);
			}
		}
	}
}
