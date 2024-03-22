using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Retorno;

public class ComandoCarregarLoteArquivoRetornoCnab400Ban399 : ComandoCarregarLoteArquivoRetornoCnab400
{
	public ComandoCarregarLoteArquivoRetornoCnab400Ban399()
	{
		Logger.Debug($"Criando macro comando para carregar LOTE DE ARQUIVO de retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
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
			if (item.Substring(0, 1).Equals(EnumTipoSegmentoDetalheCnab400Ban399.REGISTRO_TIPO_1.Codigo()))
			{
				DetalheRetornoCnab400 segmento = new DetalheRetornoCnab400Ban399();
				base.Lote.AdicionarSegmento(segmento);
				ComandoCarregarRegistroDetalheTipo1RemessaCnab400Ban399 comandoCarregarRegistroDetalheTipo1RemessaCnab400Ban = new ComandoCarregarRegistroDetalheTipo1RemessaCnab400Ban399();
				comandoCarregarRegistroDetalheTipo1RemessaCnab400Ban.Preparar(carteira, segmento, item);
				base.Comandos.Add(comandoCarregarRegistroDetalheTipo1RemessaCnab400Ban);
			}
		}
	}
}
