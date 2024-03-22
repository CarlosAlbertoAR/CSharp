using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban341 : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
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
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban341).GeraSegmentoDetalhe)
			{
				SegmentoCnab400 segmento = new DetalheRemessaCnab400Ban341(0L);
				segmento = base.Lote.AdicionarSegmento(segmento);
				ComandoGerarDetalheRemessaCnab400Ban341 comandoGerarDetalheRemessaCnab400Ban = new ComandoGerarDetalheRemessaCnab400Ban341();
				comandoGerarDetalheRemessaCnab400Ban.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarDetalheRemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban341).GeraSegmentoDetalheOpcionalMulta)
			{
				SegmentoCnab400 segmento2 = new DetalheOpcionalMultaRemessaCnab400Ban341(0L);
				segmento2 = base.Lote.AdicionarSegmento(segmento2);
				ComandoGerarDetalheOpcionalMultaRemessaCnab400Ban341 comandoGerarDetalheOpcionalMultaRemessaCnab400Ban = new ComandoGerarDetalheOpcionalMultaRemessaCnab400Ban341();
				comandoGerarDetalheOpcionalMultaRemessaCnab400Ban.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarDetalheOpcionalMultaRemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban341).GeraSegmentoDetalheOpcionalAvalista)
			{
				SegmentoCnab400 segmento3 = new DetalheOpcionalRemessaCnab400Ban341(0L);
				segmento3 = base.Lote.AdicionarSegmento(segmento3);
				ComandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban341 comandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban = new ComandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban341();
				comandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban.PrepararComando(carteira, segmento3, documento);
				base.Comandos.Add(comandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban);
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
