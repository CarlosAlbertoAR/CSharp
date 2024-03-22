using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban001 : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban001()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
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
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban001).GeraSegmentoDetalhe)
			{
				SegmentoCnab400 segmento = new DetalheRemessaCnab400Ban001(0L);
				segmento = base.Lote.AdicionarSegmento(segmento);
				ComandoGerarDetalheRemessaCnab400Ban001 comandoGerarDetalheRemessaCnab400Ban = new ComandoGerarDetalheRemessaCnab400Ban001();
				comandoGerarDetalheRemessaCnab400Ban.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarDetalheRemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban001).GeraSegmentoMensagem && (documento.ValorMultaAtraso > 0.0 || documento.PercentualMultaAtraso > 0.0))
			{
				SegmentoCnab400 segmento2 = new MensagemRemessaCnab400Ban001Multa(0L);
				segmento2 = base.Lote.AdicionarSegmento(segmento2);
				ComandoGerarMensagemMultaRemessaCnab400Ban001 comandoGerarMensagemMultaRemessaCnab400Ban = new ComandoGerarMensagemMultaRemessaCnab400Ban001();
				comandoGerarMensagemMultaRemessaCnab400Ban.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarMensagemMultaRemessaCnab400Ban);
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
