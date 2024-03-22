using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheSFebraban240ImpressaoTipo3 : SegmentoDetalheSFebraban240ImpressaoPadrao
{
	public SegmentoDetalheSFebraban240ImpressaoTipo3(long segmentoLote, long sequenciaSegmento)
		: base(segmentoLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE S IMPRESSAO TIPO 3 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3S", "Mensagem 5", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 19, 58, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3S", "Mensagem 6", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 59, 98, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3S", "Mensagem 7", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 99, 138, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3S", "Mensagem 8", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 139, 178, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3S", "Mensagem 9", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 179, 218, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3S", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 219, 240, 22, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoSFebraban240ImpressaoTipo3(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
