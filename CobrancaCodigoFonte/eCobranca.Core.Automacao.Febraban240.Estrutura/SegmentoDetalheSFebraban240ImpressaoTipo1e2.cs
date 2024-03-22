using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheSFebraban240ImpressaoTipo1e2 : SegmentoDetalheSFebraban240ImpressaoPadrao
{
	public SegmentoDetalheSFebraban240ImpressaoTipo1e2(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO S IMPRESSAO TIPO 1 e 2 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3S", "Número da linha a ser impressa", "Número seqüencial adotado pela FEBRABAN, para identificação do local de impressão da mensagem no título de cobrança. Frente de Bloqueto: de '01' a '36'", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 20, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3S", "Mensagem a ser impressa", "Texto de mensagem do Cedente destinada ao Sacado para impressão no título de cobrança. Esta linha deverá ser enviada no formato imagem de impressão (tamanho máximo de 140 posições).", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 21, 160, 140, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3S", "Tipo do caracter a ser impresso", "Código adotado pela FEBRABAN para identificação do tipo de fonte a ser utilizada na impressão de mensagens no título de cobrança. DominioTipoCaracterImpressao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 162, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3S", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 163, 240, 78, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoSFebraban240ImpressaoTipo1e2(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
