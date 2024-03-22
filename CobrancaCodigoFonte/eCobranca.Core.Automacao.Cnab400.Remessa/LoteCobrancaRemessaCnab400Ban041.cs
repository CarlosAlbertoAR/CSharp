using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban041;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban041 : LoteCobrancaRemessaCnab400
{
	private bool geraRegistroTransacaoTipo1DetalheTitulo;

	private bool geraRegistroTransacaoTipo2Mensagem;

	public bool GeraRegistroTransacaoTipo1DetalheTitulo => geraRegistroTransacaoTipo1DetalheTitulo;

	public bool GeraRegistroTransacaoTipo2Mensagem => geraRegistroTransacaoTipo2Mensagem;

	public LoteCobrancaRemessaCnab400Ban041()
	{
		try
		{
			Logger.Info($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
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
				if (segmento.GetType() == typeof(RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041) && geraRegistroTransacaoTipo1DetalheTitulo)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(RegistroTransacaoTipo2MensagemRemessaCnab400Ban041) && geraRegistroTransacaoTipo2Mensagem)
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
			geraRegistroTransacaoTipo1DetalheTitulo = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_1_DETALHE_TITULO_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan041).GeraRegistroTransacaoTipo1DetalheTituloRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTransacaoTipo2Mensagem = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_2_MENSAGEM_TITULO_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan041).GeraRegistroTransacaoTipo2MensagemRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
