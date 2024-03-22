using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheY05Febraban240 : SegmentoDetalheOpcionalFebraban240
{
	public SegmentoDetalheY05Febraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumIdentificacaoRegistroOpcionalYFebraban.INFORMACAO_DE_DADOS_DE_CHEQUES_UTILIZADOS.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE Y05 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Y", "CMC7 de identificacao do cheque 1", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 53, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Y", "CMC7 de identificacao do cheque 2", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 54, 87, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Y", "CMC7 de identificacao do cheque 3", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 121, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Y", "CMC7 de identificacao do cheque 4", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 122, 155, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Y", "CMC7 de identificacao do cheque 5", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 156, 189, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Y", "CMC7 de identificacao do cheque 6", "Código CMC7 do cheque", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 190, 223, 34, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Y", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 224, 240, 17, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoY05Febraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
