using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban748;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Retorno;

public class ComandoCarregarLoteArquivoRetornoCnab400Ban748 : ComandoCarregarLoteArquivoRetornoCnab400
{
	public ComandoCarregarLoteArquivoRetornoCnab400Ban748()
	{
		Logger.Debug($"Criando macro comando para carregar LOTE DE ARQUIVO de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
		GerarComandos();
	}

	protected override void GerarComandos()
	{
		try
		{
			Logger.Info("Criando comandos integrantes...");
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
			if (item.Substring(0, 1).Equals(EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_1.Codigo()) && item.Substring(13, 1).Equals(EnumTipoCarteiraCobranca.BAN748_A.Sigla()))
			{
				DetalheRetornoCnab400 segmento = new RegistroTipo1RetornoCnab400Ban748();
				base.Lote.AdicionarSegmento(segmento);
				ComandoCarregarRegistroTipo1RetornoCnab400Ban748 comandoCarregarRegistroTipo1RetornoCnab400Ban = new ComandoCarregarRegistroTipo1RetornoCnab400Ban748();
				comandoCarregarRegistroTipo1RetornoCnab400Ban.Preparar(carteira, segmento, item);
				base.Comandos.Add(comandoCarregarRegistroTipo1RetornoCnab400Ban);
			}
			else if (item.Substring(0, 1).Equals(EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_1.Codigo()) && item.Substring(13, 1).Equals(EnumTipoCarteiraCobranca.BAN748_C.Sigla()))
			{
				DetalheRetornoCnab400 segmento2 = new RegistroTipo1SemRegistroRetornoCnab400Ban748();
				base.Lote.AdicionarSegmento(segmento2);
				ComandoCarregarRegistroTipo1SemRegistroRetornoCnab400Ban748 comandoCarregarRegistroTipo1SemRegistroRetornoCnab400Ban = new ComandoCarregarRegistroTipo1SemRegistroRetornoCnab400Ban748();
				comandoCarregarRegistroTipo1SemRegistroRetornoCnab400Ban.Preparar(carteira, segmento2, item);
				base.Comandos.Add(comandoCarregarRegistroTipo1SemRegistroRetornoCnab400Ban);
			}
		}
	}
}
