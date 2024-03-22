using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public class DetalheOpcionalRemessaCnab400Ban341 : DetalheRemessaCnab400, IDetalheOpcionalRemessaCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[2];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[3];

	public CampoLayoutArquivoCobranca EnderecoSacadorAvalista => campos[4];

	public CampoLayoutArquivoCobranca BairroSacadorAvalista => campos[5];

	public CampoLayoutArquivoCobranca CepSacadorAvalista => campos[6];

	public CampoLayoutArquivoCobranca CidadeSacadorAvalista => campos[7];

	public CampoLayoutArquivoCobranca UFSacadorAvalista => campos[8];

	public CampoLayoutArquivoCobranca Filler2 => campos[9];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[10];

	public DetalheOpcionalRemessaCnab400Ban341(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE OPCIONAL de remessa CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.5", "Identificação do registro Detalhe opcional", "Identificação do registro Detalhe opcional do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban341.DETALHE_OPCIONAL.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.5", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 121, 120, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.5", "Código de inscrição", "Identificação do tipo de inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 122, 123, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.5", "Número da inscrição", "Número da inscrição do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 124, 137, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.5", "Endereço do sacador avalista", "Rua, número e complemento do endereço do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 138, 177, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.5", "Bairro do sacador avalista", "Bairro do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 178, 189, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.5", "CEP do sacador avalista", "CEP do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 190, 197, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.5", "Cidade do sacador avalista", "Cidade do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 212, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.5", "UF do sacador avalista", "UF do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 213, 214, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.5", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 215, 394, 180, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.5", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
