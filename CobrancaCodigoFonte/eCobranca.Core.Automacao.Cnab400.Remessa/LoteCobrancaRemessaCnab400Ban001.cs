using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban001;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban001 : LoteCobrancaRemessaCnab400
{
	private bool geraSegmentoDetalhe;

	private bool geraSegmentoMensagem;

	public bool GeraSegmentoDetalhe => geraSegmentoDetalhe;

	public bool GeraSegmentoMensagem => geraSegmentoMensagem;

	public LoteCobrancaRemessaCnab400Ban001()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoLoteRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public override ArrayList CarregarRegistrosLote()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			foreach (SegmentoLoteCnab400 segmento in base.Segmentos)
			{
				if (segmento.GetType() == typeof(DetalheRemessaCnab400Ban001) && geraSegmentoDetalhe)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(MensagemRemessaCnab400Ban001Multa) && geraSegmentoMensagem)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return arrayList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoRegistrosDoLoteRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}

	public override void Preparar(ConfiguracaoArquivoRemessa configuracaoRemessa, ArrayList documentos, params bool[] parametros)
	{
		base.Preparar(configuracaoRemessa, documentos, parametros);
		if (parametros != null)
		{
			geraSegmentoDetalhe = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001).GeraDetalheRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoMensagem = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_MENSAGEM_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001).GeraMensagemRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
