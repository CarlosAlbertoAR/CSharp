using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;

public abstract class ComandoCarregarArquivoRetornoFebraban150<A, B, C, D> : MacroCommand where A : ComandoCarregarSegmentoArquivoRetornoFebraban150 where B : ComandoCarregarLoteArquivoRetornoFebraban150<C> where C : ComandoCarregarSegmentoDetalheRetornoFebraban150 where D : ComandoCarregarSegmentoArquivoRetornoFebraban150
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoFebraban150 arquivo;

	public ComandoCarregarArquivoRetornoFebraban150()
	{
		Logger.Debug("Criando macro comando para carregar arquivo de retorno do layout FEBRABAN150...");
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
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

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoFebraban150 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		ArrayList arrayList = new ArrayList();
		string text;
		while (!string.IsNullOrEmpty(text = arquivo.Retorno.ReadLine()))
		{
			if (text.Substring(1, 1) == EnumTipoSegmentoFebraban150.HEADER_ARQUIVO.Codigo())
			{
				A val = (A)Activator.CreateInstance(typeof(A));
				val.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val);
			}
			if (text.Substring(1, 1) == EnumTipoSegmentoFebraban150.SEGMENTO_DETALHE_G.Codigo())
			{
				arrayList.Add(text);
			}
			if (text.Substring(1, 1) == EnumTipoSegmentoFebraban150.TRAILLER_ARQUIVO.Codigo())
			{
				arquivo.NovoLote(arrayList);
				B val2 = (B)Activator.CreateInstance(typeof(B));
				val2.Preparar(carteira, arquivo.Lotes[0]);
				base.Comandos.Add(val2);
				D val3 = (D)Activator.CreateInstance(typeof(D));
				val3.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val3);
			}
		}
		arquivo.Retorno.Close();
		arquivo.Retorno.Dispose();
	}
}
