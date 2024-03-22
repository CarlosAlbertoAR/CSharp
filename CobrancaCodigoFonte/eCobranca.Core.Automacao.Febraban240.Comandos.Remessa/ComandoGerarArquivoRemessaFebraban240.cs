using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;

public abstract class ComandoGerarArquivoRemessaFebraban240<A, B, C, D, E, F, G, H> : MacroCommand where A : ComandoGerarSegmentoArquivoRemessaFebraban240 where B : ComandoGerarLoteArquivoRemessaFebraban240<C, D, E, F, G> where C : ComandoGerarSegmentoLoteRemessaFebraban240 where D : ComandoGerarSegmentoDetalheRemessaFebraban240 where E : ComandoGerarSegmentoDetalheRemessaFebraban240 where F : ComandoGerarSegmentoDetalheRemessaFebraban240 where G : ComandoGerarSegmentoLoteRemessaFebraban240 where H : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRemessaFebraban240 arquivo;

	public ComandoGerarArquivoRemessaFebraban240(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para gerar arquivo de remessa no layout FEBRABAN240...");
		this.carteira = carteira;
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroBaseGerarArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRemessaFebraban240 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		base.Comandos.Clear();
		A val = (A)Activator.CreateInstance(typeof(A));
		val.Preparar(carteira, arquivo);
		base.Comandos.Add(val);
		foreach (LoteCobrancaRemessaFebraban240 lote in arquivo.Lotes)
		{
			B val2 = (B)Activator.CreateInstance(typeof(B), this.carteira);
			val2.PrepararComando(carteira, lote);
			base.Comandos.Add(val2);
		}
		H val3 = (H)Activator.CreateInstance(typeof(H));
		val3.Preparar(carteira, arquivo);
		base.Comandos.Add(val3);
	}
}
