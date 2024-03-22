using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban237Unicred : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban237Unicred()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
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
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban237).GeraRegistroTransacaoTipo1)
			{
				SegmentoCnab400 segmento = new RegistroTransacaoTipo1RemessaCnab400Ban237(0L);
				segmento = base.Lote.AdicionarSegmento(segmento);
				ComandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred comandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred = new ComandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred();
				comandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban237).GeraRegistroTransacaoTipo2)
			{
				SegmentoCnab400 segmento2 = new RegistroTransacaoTipo2RemessaCnab400Ban237(0L);
				segmento2 = base.Lote.AdicionarSegmento(segmento2);
				ComandoGerarTransacaoTipo2RemessaCnab400Ban237Unicred comandoGerarTransacaoTipo2RemessaCnab400Ban237Unicred = new ComandoGerarTransacaoTipo2RemessaCnab400Ban237Unicred();
				comandoGerarTransacaoTipo2RemessaCnab400Ban237Unicred.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarTransacaoTipo2RemessaCnab400Ban237Unicred);
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
