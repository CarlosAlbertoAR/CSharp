using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban104;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban104 : LoteCobrancaRemessaCnab400
{
	private bool geraSegmentoDetalhe;

	private bool geraSegmentoDetalheOpcional;

	public bool GeraSegmentoDetalhe => geraSegmentoDetalhe;

	public bool GeraSegmentoDetalheOpcional => geraSegmentoDetalheOpcional;

	public LoteCobrancaRemessaCnab400Ban104()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
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
				if (segmento.GetType() == typeof(DetalheRemessaCnab400Ban104) && geraSegmentoDetalhe)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(DetalheOpcionalRemessaCnab400Ban104) && geraSegmentoDetalheOpcional)
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
			geraSegmentoDetalhe = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan104).GeraRegistroDetalheRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheOpcional = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_OPCIONAL_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan104).GeraRegistroDetalheOpcionalRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
