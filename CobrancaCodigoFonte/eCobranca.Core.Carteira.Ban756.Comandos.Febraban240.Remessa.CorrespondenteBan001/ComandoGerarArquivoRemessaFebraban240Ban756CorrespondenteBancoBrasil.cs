using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarArquivoRemessaFebraban240Ban756CorrespondenteBancoBrasil : MacroCommand
{
	[NonSerialized]
	private CarteiraCobranca carteira;

	[NonSerialized]
	private ArquivoCobrancaRemessaFebraban240 arquivo;

	public ComandoGerarArquivoRemessaFebraban240Ban756CorrespondenteBancoBrasil(CarteiraCobranca carteira)
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
		foreach (LoteCobrancaRemessaFebraban240 lote in arquivo.Lotes)
		{
			ComandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil comandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil = new ComandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil(carteira);
			comandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil.Preparar(lote);
			base.Comandos.Add(comandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil);
		}
	}
}
