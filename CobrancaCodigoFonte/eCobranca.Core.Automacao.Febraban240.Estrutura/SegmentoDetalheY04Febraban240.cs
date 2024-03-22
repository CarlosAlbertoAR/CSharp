using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheY04Febraban240 : SegmentoDetalheOpcionalFebraban240
{
	public SegmentoDetalheY04Febraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumIdentificacaoRegistroOpcionalYFebraban.INFORMACAO_DE_DADOS_DO_SACADO.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO Y04 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Y", "E-mail do sacado para envio de informação", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 69, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Y", "Código de ddd do celular do sacado", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 70, 71, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Y", "Número de celular do sacado", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 72, 79, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Y", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 80, 240, 161, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoY04Febraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
