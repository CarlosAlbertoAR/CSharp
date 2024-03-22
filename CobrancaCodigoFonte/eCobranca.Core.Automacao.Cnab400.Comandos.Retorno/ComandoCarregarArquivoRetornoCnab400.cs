using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;

public abstract class ComandoCarregarArquivoRetornoCnab400<A, B, C> : MacroCommand where A : ComandoCarregarSegmentoArquivoRetornoCnab400 where B : ComandoCarregarLoteArquivoRetornoCnab400 where C : ComandoCarregarSegmentoArquivoRetornoCnab400
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoCnab400 arquivo;

	public ComandoCarregarArquivoRetornoCnab400()
	{
		Logger.Debug("Criando macro comando para carregar arquivo de retorno no layout CNAB400...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroBaseGerarArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoCnab400 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		base.Comandos.Clear();
		List<string> list = new List<string>();
		using StreamReader streamReader = new StreamReader(arquivo.Diretorio + arquivo.NomeArquivoRetorno);
		string text;
		while (!string.IsNullOrEmpty(text = streamReader.ReadLine()))
		{
			if (text.Substring(0, 1) == EnumTipoRegistroCnab400.HEADER.Codigo())
			{
				A val = (A)Activator.CreateInstance(typeof(A));
				val.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val);
			}
			else if (text.Substring(0, 1) == EnumTipoRegistroCnab400.TRAILLER.Codigo())
			{
				arquivo.NovoLote(list);
				B val2 = (B)Activator.CreateInstance(typeof(B));
				val2.PrepararComando(carteira, arquivo.Lote);
				base.Comandos.Add(val2);
				C val3 = (C)Activator.CreateInstance(typeof(C));
				val3.Preparar(carteira, arquivo, text);
				base.Comandos.Add(val3);
			}
			else
			{
				list.Add(text);
			}
		}
		streamReader.Close();
	}
}
