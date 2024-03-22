using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;

public abstract class ComandoGerarLoteArquivoRemessaCnab400 : MacroCommand
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRemessaCnab400 lote;

	public LoteCobrancaRemessaCnab400 Lote => lote;

	public CarteiraCobranca Carteira => carteira;

	public ComandoGerarLoteArquivoRemessaCnab400()
	{
		Logger.Debug("Criando macro comando para gerar lote de arquivo de remessa no layout CNAB400...");
		GerarComandos();
	}

	protected abstract void GerarComandos();

	public virtual void Preparar(CarteiraCobranca carteira, LoteCobrancaRemessaCnab400 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
	}

	public override void Execute()
	{
		base.Execute();
		if (this is IObservable)
		{
			(this as IObservable).RefreshNotifyEventHandler();
			Launcher.GetInstance().Executar(delegate
			{
				(this as IObservable).TriggerNotifyEvent(this, new NotifyEvent(Carteira.GetGuid(), EnumTipoNotificacao.ATUALIZAR_SEQUENCIA_TRAILLER_CNAB400, Lote.Segmentos.Count + 2));
			});
		}
	}
}
