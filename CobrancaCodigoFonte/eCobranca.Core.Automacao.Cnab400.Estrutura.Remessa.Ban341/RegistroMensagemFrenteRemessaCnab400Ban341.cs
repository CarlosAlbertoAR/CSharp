using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public class RegistroMensagemFrenteRemessaCnab400Ban341 : DetalheRemessaCnab400, IRegistroMensagemFrenteRemessaCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca CodigoFlash => campos[1];

	public CampoLayoutArquivoCobranca NumeroLinha1 => campos[2];

	public CampoLayoutArquivoCobranca ConteudoLinha1 => campos[3];

	public CampoLayoutArquivoCobranca NumeroLinha2 => campos[4];

	public CampoLayoutArquivoCobranca ConteudoLinha2 => campos[5];

	public CampoLayoutArquivoCobranca NumeroLinha3 => campos[6];

	public CampoLayoutArquivoCobranca ConteudoLinha3 => campos[7];

	public CampoLayoutArquivoCobranca DestinoBoleto => campos[8];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[9];

	public RegistroMensagemFrenteRemessaCnab400Ban341(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Identificação do registro mensagem frente", "Identificação do registro mensagem frente do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban341.MENSAGEM_FRENTE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Código flash", "Código flash", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 4, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "Número da linha 1", "Número da linha 1 a ser impressa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 6, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Texto 1", "Conteúdo da linha 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 7, 134, 128, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "Número da linha 2", "Número da linha 2 a ser impressa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 135, 136, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "Texto 2", "Conteúdo da linha 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 137, 264, 128, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "Número da linha 3", "Número da linha  3 a ser impressa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 265, 266, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Texto 3", "Conteúdo da linha 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 267, 393, 127, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Destino boleto", "Identifica o destino no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoRemessaCnab400(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
