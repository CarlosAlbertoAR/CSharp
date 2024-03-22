using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban136;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Retorno;

public class ComandoCarregarLoteArquivoRetornoCnab400Ban136 : ComandoCarregarLoteArquivoRetornoCnab400
{
	public ComandoCarregarLoteArquivoRetornoCnab400Ban136()
	{
		Logger.Debug($"Criando macro comando para carregar LOTE DE ARQUIVO de retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.FalhaGerandoComandosDaMacroBaseCarregarLoteArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public override void PrepararComando(CarteiraCobranca carteira, LoteCobrancaRetornoCnab400 lote)
	{
		base.PrepararComando(carteira, lote);
		base.Comandos.Clear();
		foreach (string item in base.Lote.LinhasLote)
		{
			if (item.Substring(0, 1).Equals(EnumTipoSegmentoDetalheCnab400Ban136.REGISTRO_TIPO1.Codigo()))
			{
				DetalheRetornoCnab400 segmento = new RegistroTipo1RetornoCnab400Ban136();
				base.Lote.AdicionarSegmento(segmento);
				ComandoCarregarRegistroTipo1RetornoCnab400Ban136 comandoCarregarRegistroTipo1RetornoCnab400Ban = new ComandoCarregarRegistroTipo1RetornoCnab400Ban136();
				comandoCarregarRegistroTipo1RetornoCnab400Ban.Preparar(carteira, segmento, item);
				base.Comandos.Add(comandoCarregarRegistroTipo1RetornoCnab400Ban);
			}
		}
	}
}
