using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Retorno;

public class ComandoCarregarLoteArquivoRetornoCnab400Ban041 : ComandoCarregarLoteArquivoRetornoCnab400
{
	public ComandoCarregarLoteArquivoRetornoCnab400Ban041()
	{
		Logger.Debug($"Criando macro comando para carregar LOTE DE ARQUIVO de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
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
			if (item.Substring(0, 1).Equals(EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_1_DADOS_TITULO.Codigo()))
			{
				DetalheRetornoCnab400 segmento = new RegistroTransacaoTipo1DadosTituloRetornoCnab400Ban041();
				base.Lote.AdicionarSegmento(segmento);
				ComandoCarregarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041 comandoCarregarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban = new ComandoCarregarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041();
				comandoCarregarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban.Preparar(carteira, segmento, item);
				base.Comandos.Add(comandoCarregarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban);
			}
		}
	}
}
