using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban748 : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban748()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
		GerarComandos();
	}

	protected override void GerarComandos()
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroEspecificaGerarLoteArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public override void Preparar(CarteiraCobranca carteira, LoteCobrancaRemessaCnab400 lote)
	{
		base.Preparar(carteira, lote);
		base.Comandos.Clear();
		foreach (DocumentoCobranca documento in base.Lote.Documentos)
		{
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban748).GeraRegistroTipo1)
			{
				SegmentoCnab400 segmento = new RegistroTipo1RemessaCnab400Ban748(0L);
				segmento = base.Lote.AdicionarSegmento(segmento);
				ComandoGerarRegistroTipo1RemessaCnab400Ban748 comandoGerarRegistroTipo1RemessaCnab400Ban = new ComandoGerarRegistroTipo1RemessaCnab400Ban748();
				comandoGerarRegistroTipo1RemessaCnab400Ban.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarRegistroTipo1RemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban748).GeraRegistroTipo2)
			{
				SegmentoCnab400 segmento2 = new RegistroTipo2RemessaCnab400Ban748(0L);
				segmento2 = base.Lote.AdicionarSegmento(segmento2);
				ComandoGerarRegistroTipo2RemessaCnab400Ban748 comandoGerarRegistroTipo2RemessaCnab400Ban = new ComandoGerarRegistroTipo2RemessaCnab400Ban748();
				comandoGerarRegistroTipo2RemessaCnab400Ban.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarRegistroTipo2RemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban748).GeraRegistroTipo6)
			{
				SegmentoCnab400 segmento3 = new RegistroTipo6RemessaCnab400Ban748(0L);
				segmento3 = base.Lote.AdicionarSegmento(segmento3);
				ComandoGerarRegistroTipo6RemessaCnab400Ban748 comandoGerarRegistroTipo6RemessaCnab400Ban = new ComandoGerarRegistroTipo6RemessaCnab400Ban748();
				comandoGerarRegistroTipo6RemessaCnab400Ban.PrepararComando(carteira, segmento3, documento);
				base.Comandos.Add(comandoGerarRegistroTipo6RemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban748).GeraRegistroTipo7)
			{
				SegmentoCnab400 segmento4 = new RegistroTipo7RemessaCnab400Ban748(0L);
				segmento4 = base.Lote.AdicionarSegmento(segmento4);
				ComandoGerarRegistroTipo7RemessaCnab400Ban748 comandoGerarRegistroTipo7RemessaCnab400Ban = new ComandoGerarRegistroTipo7RemessaCnab400Ban748();
				comandoGerarRegistroTipo7RemessaCnab400Ban.PrepararComando(carteira, segmento4, documento);
				base.Comandos.Add(comandoGerarRegistroTipo7RemessaCnab400Ban);
			}
		}
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
}
