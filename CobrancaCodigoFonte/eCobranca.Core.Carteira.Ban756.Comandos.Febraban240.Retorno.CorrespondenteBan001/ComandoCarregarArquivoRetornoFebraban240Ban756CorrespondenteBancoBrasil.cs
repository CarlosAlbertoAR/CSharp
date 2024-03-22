using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno.CorrespondenteBan001;

public class ComandoCarregarArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil : MacroCommand
{
	[NonSerialized]
	private CarteiraCobranca carteira;

	[NonSerialized]
	private ArquivoCobrancaRetornoFebraban240 arquivo;

	public ComandoCarregarArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para carregar arquivo de retorno do layout FEBRABAN240...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.FalhaGerandoComandosDaMacroBaseCarregarLoteArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoFebraban240 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		base.Comandos.Clear();
		ArrayList arrayList = new ArrayList();
		using StreamReader streamReader = new StreamReader(arquivo.Diretorio + arquivo.NomeArquivoRetorno);
		string text;
		while (!string.IsNullOrEmpty(text = streamReader.ReadLine()))
		{
			if (text.Substring(7, 1) == EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo())
			{
				arrayList.Clear();
				arrayList.Add(text);
			}
			if (text.Substring(7, 1) == EnumTipoRegistroFebraban240.DETALHE.Codigo())
			{
				arrayList.Add(text);
			}
			if (text.Substring(7, 1) == EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo())
			{
				arrayList.Add(text);
				LoteCobrancaRetornoFebraban240 lote = arquivo.NovoLote(arrayList);
				ComandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil comandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil = new ComandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil(carteira);
				comandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, lote);
				base.Comandos.Add(comandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil);
			}
		}
	}
}
