using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;

public abstract class ComandoCarregarLoteArquivoRetornoCnab400 : MacroCommand
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRetornoCnab400 lote;

	public CarteiraCobranca Carteira => carteira;

	public LoteCobrancaRetornoCnab400 Lote => lote;

	public ComandoCarregarLoteArquivoRetornoCnab400()
	{
		Logger.Debug("Criando macro comando para gerar lote de arquivo de retorno no layout CNAB400...");
		GerarComandos();
	}

	protected abstract void GerarComandos();

	public virtual void PrepararComando(CarteiraCobranca carteira, LoteCobrancaRetornoCnab400 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
	}
}
