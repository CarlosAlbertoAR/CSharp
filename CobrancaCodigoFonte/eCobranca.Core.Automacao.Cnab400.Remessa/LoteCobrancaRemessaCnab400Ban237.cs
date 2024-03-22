using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban237;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban237 : LoteCobrancaRemessaCnab400
{
	private bool geraRegistroTransacaoTipo1;

	private bool geraRegistroTransacaoTipo2;

	private bool geraRegistroTransacaoTipo3;

	private bool geraRegistroTransacaoTipo7;

	public bool GeraRegistroTransacaoTipo1 => geraRegistroTransacaoTipo1;

	public bool GeraRegistroTransacaoTipo2 => geraRegistroTransacaoTipo2;

	public bool GeraRegistroTransacaoTipo3 => geraRegistroTransacaoTipo3;

	public bool GeraRegistroTransacaoTipo7 => geraRegistroTransacaoTipo7;

	public LoteCobrancaRemessaCnab400Ban237()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
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
			foreach (SegmentoLoteCnab400 segmento in segmentos)
			{
				if (segmento is RegistroTransacaoTipo1RemessaCnab400Ban237)
				{
					if (GeraRegistroTransacaoTipo1)
					{
						arrayList.Add(segmento.GerarRegistro());
					}
				}
				else if (segmento is RegistroTransacaoTipo2RemessaCnab400Ban237 && GeraRegistroTransacaoTipo2)
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
			geraRegistroTransacaoTipo1 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_1_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan237).GeraRegistroTransacaoTipo1RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTransacaoTipo2 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_2_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan237).GeraRegistroTransacaoTipo2RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTransacaoTipo3 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_3_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan237).GeraRegistroTransacaoTipo3RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTransacaoTipo7 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_TIPO_7_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan237).GeraRegistroTransacaoTipo7RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
