using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public abstract class SegmentoDetalheFebraban150 : SegmentoFebraban150, ISegmentoDetalheFebraban150
{
	private long sequenciaLote;

	private long sequenciaSegmento;

	public long SequenciaLote
	{
		get
		{
			return sequenciaLote;
		}
		set
		{
			sequenciaLote = value;
		}
	}

	public long SequenciaSegmento
	{
		get
		{
			return sequenciaSegmento;
		}
		set
		{
			sequenciaSegmento = value;
		}
	}

	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public SegmentoDetalheFebraban150()
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN150.");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Código do registro", "Informar o código do registro", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoBaseDetalheFebraban150(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(long sequenciaLote, long sequenciaSegmento)
	{
		this.sequenciaLote = sequenciaLote;
		this.sequenciaSegmento = sequenciaSegmento;
	}
}
