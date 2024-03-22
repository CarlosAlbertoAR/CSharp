using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheSFebraban240Impressao : SegmentoDetalheFebraban240
{
	public SegmentoDetalheSFebraban240Impressao(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_S.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO S IMPRESSÃO do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3S", "Identificação da impressão", "Código adotado pela FEBRABAN para identificação do tipo de impressão da mensagem do título de cobrança. DominioTipoImpressao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoSFebraban240Impressao(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
