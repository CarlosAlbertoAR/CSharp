using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil : SegmentoDetalheUFebraban240, ISegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca Filler1 => campos[0];

	public CampoLayoutArquivoCobranca TipoDoRegistro => campos[1];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistroLote => campos[2];

	public CampoLayoutArquivoCobranca CodigoSegmentoDoRegistroDetalhe => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[5];

	public CampoLayoutArquivoCobranca ValorJurosMultaEncargos => campos[6];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[7];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[8];

	public CampoLayoutArquivoCobranca ValorPago => campos[9];

	public CampoLayoutArquivoCobranca Filler3 => campos[10];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[11];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[12];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[13];

	public CampoLayoutArquivoCobranca DataCredito => campos[14];

	public CampoLayoutArquivoCobranca Filler4 => campos[15];

	public CampoLayoutArquivoCobranca NossoNumero => campos[16];

	public CampoLayoutArquivoCobranca Filler5 => campos[17];

	public SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN240.");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3U", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 7, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3U", "Registro detalhe", "Tipo do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3U", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3U", "Código do segmento do registro detalhe", "Código do segmento do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo(), EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo(), 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3U", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3U", "Código da instrução", "Código da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3U", "Valor dos juros/multa/encargos", "Valor dos juros/multa/encargos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 32, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3U", "Valor de desconto", "Valor de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 47, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3U", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 48, 62, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3U", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 77, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3U", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 107, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3U", "Valor de outras despesas", "Valor de outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 122, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3U", "Valor de outros créditos", "Valor de outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 123, 137, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3U", "Data da ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 145, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3U", "Data de efetivação do crédito", "Data de efetivação do crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 153, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3U", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 154, 213, 60, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3U", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 214, 233, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3U", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 234, 240, 7, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoBaseDetalheFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
