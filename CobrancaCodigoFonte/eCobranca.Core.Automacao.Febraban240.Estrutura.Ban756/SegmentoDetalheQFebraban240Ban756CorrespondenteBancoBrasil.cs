using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil : SegmentoDetalheQFebraban240, ISegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca Filler1 => campos[0];

	public CampoLayoutArquivoCobranca RegistroDoDetalhe => campos[1];

	public CampoLayoutArquivoCobranca NumeroSequencialDoRegistroLote => campos[2];

	public CampoLayoutArquivoCobranca CodigoSegmentoRegistroDoDetalhe => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca CodigoInstrucao => campos[5];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[6];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[7];

	public CampoLayoutArquivoCobranca NomePagador => campos[8];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[9];

	public CampoLayoutArquivoCobranca BairroPagador => campos[10];

	public CampoLayoutArquivoCobranca CepPagador => campos[11];

	public CampoLayoutArquivoCobranca SufixoCepPagador => campos[12];

	public CampoLayoutArquivoCobranca CidadePagador => campos[13];

	public CampoLayoutArquivoCobranca UFPagador => campos[14];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[15];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[16];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[17];

	public CampoLayoutArquivoCobranca Filler3 => campos[18];

	public SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN240.");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3Q", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 7, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3Q", "Registro detalhe", "Tipo do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3Q", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3Q", "Código do segmento do registro detalhe", "Código do segmento do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo(), EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo(), 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3Q", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3Q", "Código da instrução", "Código da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3Q", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 19, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3Q", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 20, 33, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Q", "Nome do pagador", "Nome ou razão social do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 34, 73, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Q", "Endereço do pagador", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 113, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Q", "Bairro do pagador", "Bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 114, 128, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Q", "Prefixo do cep do pagador", "Primeira parte do cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 129, 133, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Q", "Sufixo do cep do pagador", "Segunda parte do cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 136, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Q", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 137, 151, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Q", "UF do pagador", "UF do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 153, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3Q", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 154, 155, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3Q", "Número de inscrição do sacador/avalista", "Informar inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 156, 169, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3Q", "Nome do sacador/avalista", "Nome do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 170, 209, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3Q", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 210, 240, 31, 0);
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
