using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban133;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban133 : LoteCobrancaRemessaCnab400
{
	private bool geraRegistroDetalhe;

	public bool GeraRegistroDetalhe => geraRegistroDetalhe;

	public LoteCobrancaRemessaCnab400Ban133()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
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
				if (segmento is RegistroDetalheRemessaCnab400Ban133 && GeraRegistroDetalhe)
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
			geraRegistroDetalhe = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400_BAN133, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan133).GeraRegistroDetalheRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
