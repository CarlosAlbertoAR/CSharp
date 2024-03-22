using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban748;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban748 : LoteCobrancaRemessaCnab400
{
	private bool geraRegistroTipo1;

	private bool geraRegistroTipo2;

	private bool geraRegistroTipo6;

	private bool geraRegistroTipo7;

	public bool GeraRegistroTipo1 => geraRegistroTipo1;

	public bool GeraRegistroTipo2 => geraRegistroTipo2;

	public bool GeraRegistroTipo6 => geraRegistroTipo6;

	public bool GeraRegistroTipo7 => geraRegistroTipo7;

	public LoteCobrancaRemessaCnab400Ban748()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
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
				if (segmento is RegistroTipo1RemessaCnab400Ban748)
				{
					if (GeraRegistroTipo1)
					{
						arrayList.Add(segmento.GerarRegistro());
					}
				}
				else if (segmento is RegistroTipo2RemessaCnab400Ban748)
				{
					if (GeraRegistroTipo2)
					{
						arrayList.Add(segmento.GerarRegistro());
					}
				}
				else if (segmento is RegistroTipo6RemessaCnab400Ban748)
				{
					if (GeraRegistroTipo6)
					{
						arrayList.Add(segmento.GerarRegistro());
					}
				}
				else if (segmento is RegistroTipo7RemessaCnab400Ban748 && GeraRegistroTipo7)
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
			geraRegistroTipo1 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_1_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748).GeraRegistroTipo1RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTipo2 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_2_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748).GeraRegistroTipo2RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTipo6 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_6_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748).GeraRegistroTipo6RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraRegistroTipo7 = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TIPO_7_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan748).GeraRegistroTipo7RemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
