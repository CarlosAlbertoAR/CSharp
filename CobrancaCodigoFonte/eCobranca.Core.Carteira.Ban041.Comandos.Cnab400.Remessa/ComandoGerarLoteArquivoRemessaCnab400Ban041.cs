using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarLoteArquivoRemessaCnab400Ban041 : ComandoGerarLoteArquivoRemessaCnab400, IObservable
{
	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ComandoGerarLoteArquivoRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
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
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban041).GeraRegistroTransacaoTipo1DetalheTitulo)
			{
				SegmentoCnab400 segmento = new RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041(0L);
				segmento = lote.AdicionarSegmento(segmento);
				ComandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041 comandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban = new ComandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041();
				comandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban.PrepararComando(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban);
			}
			if ((base.Lote as LoteCobrancaRemessaCnab400Ban041).GeraRegistroTransacaoTipo2Mensagem)
			{
				SegmentoCnab400 segmento2 = new RegistroTransacaoTipo2MensagemRemessaCnab400Ban041(0L);
				segmento2 = lote.AdicionarSegmento(segmento2);
				ComandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban041 comandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban = new ComandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban041();
				comandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban.PrepararComando(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban);
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
