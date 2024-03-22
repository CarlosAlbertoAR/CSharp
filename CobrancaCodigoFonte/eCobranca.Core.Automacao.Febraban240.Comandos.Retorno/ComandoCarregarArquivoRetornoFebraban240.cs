using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;

public abstract class ComandoCarregarArquivoRetornoFebraban240<A, B, C, D, E, F, G> : MacroCommand where A : ComandoCarregarSegmentoArquivoRetornoFebraban240 where B : ComandoCarregarLoteArquivoRetornoFebraban240<C, D, E, F> where C : ComandoCarregarSegmentoLoteRetornoFebraban240 where D : ComandoCarregarSegmentoDetalheRetornoFebraban240 where E : ComandoCarregarSegmentoDetalheRetornoFebraban240 where F : ComandoCarregarSegmentoLoteRetornoFebraban240 where G : ComandoCarregarSegmentoArquivoRetornoFebraban240
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoFebraban240 arquivo;

	public ComandoCarregarArquivoRetornoFebraban240(CarteiraCobranca carteira)
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
			if (text.Substring(7, 1) == EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo())
			{
				A val = (A)Activator.CreateInstance(typeof(A));
				val.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val);
			}
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
				B val2 = (B)Activator.CreateInstance(typeof(B), this.carteira);
				val2.Preparar(carteira, lote);
				base.Comandos.Add(val2);
			}
			if (text.Substring(7, 1) == EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo())
			{
				G val3 = (G)Activator.CreateInstance(typeof(G));
				val3.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val3);
			}
		}
	}
}
