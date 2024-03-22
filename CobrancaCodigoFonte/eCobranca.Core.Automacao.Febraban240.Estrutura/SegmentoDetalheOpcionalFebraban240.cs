using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheOpcionalFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalheOpcionalFebraban240(string identificacaoRegistroOpcional, long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Y.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos de SEGMENTO OPCIONAL do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3Y", "Identificação do registro opcional", "Código adotado pela FEBRABAN para identificação de registros opcionais. DominioIdentificacaoRegistroOpcional", EnumFormatoCampoLayoutArquivoCobranca.NUM, identificacaoRegistroOpcional, identificacaoRegistroOpcional, 18, 19, 2, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoBaseDetalheOpcionalFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
