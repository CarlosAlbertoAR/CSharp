using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban341;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public class LoteCobrancaRemessaCnab400Ban341 : LoteCobrancaRemessaCnab400
{
	private bool geraSegmentoDetalhe;

	private bool geraSegmentoDetalheOpcionalAvalista;

	private bool geraSegmentoDetalheOpcionalMulta;

	private bool geraSegmentoMensagemFrente;

	private bool geraSegmentoMensagemVerso;

	public bool GeraSegmentoDetalhe => geraSegmentoDetalhe;

	public bool GeraSegmentoDetalheOpcionalAvalista => geraSegmentoDetalheOpcionalAvalista;

	public bool GeraSegmentoDetalheOpcionalMulta => geraSegmentoDetalheOpcionalMulta;

	public bool GeraSegmentoMensagemFrente => geraSegmentoMensagemFrente;

	public bool GeraSegmentoMensagemVerso => geraSegmentoMensagemVerso;

	public LoteCobrancaRemessaCnab400Ban341()
	{
		try
		{
			Logger.Debug($"Criando lote de cobrança do arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
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
				if (segmento.GetType() == typeof(DetalheRemessaCnab400Ban341) && geraSegmentoDetalhe)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(DetalheOpcionalMultaRemessaCnab400Ban341) && geraSegmentoDetalheOpcionalMulta)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(DetalheOpcionalRemessaCnab400Ban341) && geraSegmentoDetalheOpcionalAvalista)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(RegistroMensagemFrenteRemessaCnab400Ban341) && geraSegmentoMensagemFrente)
				{
					arrayList.Add(segmento.GerarRegistro());
				}
				if (segmento.GetType() == typeof(RegistroMensagemVersoRemessaCnab400Ban341) && geraSegmentoMensagemVerso)
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
			geraSegmentoDetalhe = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).GeraRegistroDetalheRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheOpcionalMulta = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_OPCIONAL_MULTA_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).GeraRegistroDetalheOpcionalMultaRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheOpcionalAvalista = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_DETALHE_OPCIONAL_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).GeraRegistroDetalheOpcionalAvalistaRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoMensagemFrente = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_MENSAGEM_FRENTE_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).GeraRegistroMensagemFrenteRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoMensagemVerso = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_MENSAGEM_VERSO_REMESSA_CNAB400, (base.Configuracao.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).GeraRegistroMensagemVersoRemessaCnab400(), base.Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
