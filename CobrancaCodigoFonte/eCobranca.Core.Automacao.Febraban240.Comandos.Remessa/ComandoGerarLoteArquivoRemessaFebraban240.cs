using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;

public abstract class ComandoGerarLoteArquivoRemessaFebraban240<C, D, E, F, G> : MacroCommand where C : ComandoGerarSegmentoLoteRemessaFebraban240 where D : ComandoGerarSegmentoDetalheRemessaFebraban240 where E : ComandoGerarSegmentoDetalheRemessaFebraban240 where F : ComandoGerarSegmentoDetalheRemessaFebraban240 where G : ComandoGerarSegmentoLoteRemessaFebraban240
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRemessaFebraban240 lote;

	public ComandoGerarLoteArquivoRemessaFebraban240(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para gerar lote de arquivo de remessa no layout FEBRABAN240...");
		this.carteira = carteira;
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Criando comandos integrantes...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroBaseGerarLoteArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public virtual void PrepararComando(CarteiraCobranca carteira, LoteCobrancaRemessaFebraban240 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
		C val = (C)Activator.CreateInstance(typeof(C));
		val.Preparar(carteira, lote);
		base.Comandos.Add(val);
		foreach (DocumentoCobranca documento in lote.Documentos)
		{
			string value = ((!string.IsNullOrEmpty(documento.CodigoMovimentoRemessa)) ? documento.CodigoMovimentoRemessa : carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao);
			if (string.IsNullOrEmpty(value) || (EnumCodigoMovimentoRemessa)(object)value.ToEnum<EnumCodigoMovimentoRemessa>() == EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS)
			{
				if (lote.GeraSegmentoDetalheP)
				{
					SegmentoDetalheFebraban240 segmento = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_P, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento = lote.AdicionarSegmento(segmento);
					D val2 = (D)Activator.CreateInstance(typeof(D));
					val2.Preparar(carteira, segmento, documento);
					base.Comandos.Add(val2);
				}
				if (lote.GeraSegmentoDetalheQ)
				{
					SegmentoDetalheFebraban240 segmento2 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_Q, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento2 = lote.AdicionarSegmento(segmento2);
					E val3 = (E)Activator.CreateInstance(typeof(E));
					val3.Preparar(carteira, segmento2, documento);
					base.Comandos.Add(val3);
				}
				if (lote.GeraSegmentoDetalheR)
				{
					SegmentoDetalheFebraban240 segmento3 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_R, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento3 = lote.AdicionarSegmento(segmento3);
					F val4 = (F)Activator.CreateInstance(typeof(F));
					val4.Preparar(carteira, segmento3, documento);
					base.Comandos.Add(val4);
				}
			}
			else
			{
				if (lote.GeraSegmentoDetalheP)
				{
					SegmentoDetalheFebraban240 segmento4 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_P, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento4 = lote.AdicionarSegmento(segmento4);
					D val5 = (D)Activator.CreateInstance(typeof(D));
					val5.Preparar(carteira, segmento4, documento);
					base.Comandos.Add(val5);
				}
				if (lote.GeraSegmentoDetalheQ && lote.EnviaSegmentosAdicionaisOutrasInstrucoesRemessa)
				{
					SegmentoDetalheFebraban240 segmento5 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_Q, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento5 = lote.AdicionarSegmento(segmento5);
					E val6 = (E)Activator.CreateInstance(typeof(E));
					val6.Preparar(carteira, segmento5, documento);
					base.Comandos.Add(val6);
				}
				if (lote.GeraSegmentoDetalheR && lote.EnviaSegmentosAdicionaisOutrasInstrucoesRemessa)
				{
					SegmentoDetalheFebraban240 segmento6 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_R, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
					segmento6 = lote.AdicionarSegmento(segmento6);
					F val7 = (F)Activator.CreateInstance(typeof(F));
					val7.Preparar(carteira, segmento6, documento);
					base.Comandos.Add(val7);
				}
			}
		}
		G val8 = (G)Activator.CreateInstance(typeof(G));
		val8.Preparar(carteira, lote);
		base.Comandos.Add(val8);
	}
}
