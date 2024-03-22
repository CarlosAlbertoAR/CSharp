using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban097CobrancaSimples : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban097CobrancaSimples()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
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
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban097CobrancaSimples).GeraSegmentoDetalhe)
			{
				SegmentoCnab400 segmento = new DetalheRemessaCnab400Ban097CobrancaSimples(0L);
				segmento = base.Lote.AdicionarSegmento(segmento);
				ComandoGerarDetalheRemessaCnab400Ban097CobrancaSimples comandoGerarDetalheRemessaCnab400Ban097CobrancaSimples = new ComandoGerarDetalheRemessaCnab400Ban097CobrancaSimples();
				comandoGerarDetalheRemessaCnab400Ban097CobrancaSimples.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarDetalheRemessaCnab400Ban097CobrancaSimples);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban097CobrancaSimples).GeraSegmentoDetalheOpcional)
			{
				SegmentoCnab400 segmento2 = new DetalheOpcionalRemessaCnab400Ban097CobrancaSimples(0L);
				segmento2 = base.Lote.AdicionarSegmento(segmento2);
				ComandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples comandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples = new ComandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples();
				comandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples);
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
