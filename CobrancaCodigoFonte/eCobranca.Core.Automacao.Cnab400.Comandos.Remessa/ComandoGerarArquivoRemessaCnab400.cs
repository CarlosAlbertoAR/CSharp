using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Patterns.Observer;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;

public abstract class ComandoGerarArquivoRemessaCnab400<A, B, C> : MacroCommand where A : ComandoGerarSegmentoArquivoRemessaCnab400 where B : ComandoGerarLoteArquivoRemessaCnab400 where C : ComandoGerarSegmentoArquivoRemessaCnab400
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRemessaCnab400 arquivo;

	public ComandoGerarArquivoRemessaCnab400()
	{
		Logger.Debug("Criando macro comando para gerar arquivo de remessa no layout CNAB400...");
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
			A item = (A)Activator.CreateInstance(typeof(A));
			base.Comandos.Add(item);
			B item2 = (B)Activator.CreateInstance(typeof(B));
			base.Comandos.Add(item2);
			C item3 = (C)Activator.CreateInstance(typeof(C));
			base.Comandos.Add(item3);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroBaseGerarArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRemessaCnab400 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		foreach (ICommand comando in base.Comandos)
		{
			if (comando is ComandoGerarSegmentoArquivoRemessaCnab400)
			{
				(comando as ComandoGerarSegmentoArquivoRemessaCnab400).Preparar(carteira, arquivo);
			}
			else if (comando is ComandoGerarLoteArquivoRemessaCnab400)
			{
				(comando as ComandoGerarLoteArquivoRemessaCnab400).Preparar(carteira, arquivo.Lote);
			}
		}
	}

	public override void Execute()
	{
		if (arquivo.Trailler != null)
		{
			NotifyEventInterceptor.GetInstance().RemoveObserver(arquivo.Trailler);
			NotifyEventInterceptor.GetInstance().AddObserver(arquivo.Trailler);
		}
		base.Execute();
	}
}
