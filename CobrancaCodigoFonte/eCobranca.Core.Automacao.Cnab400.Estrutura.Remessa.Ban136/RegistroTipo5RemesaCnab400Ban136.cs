using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;

public class RegistroTipo5RemesaCnab400Ban136 : DetalheRemessaCnab400, IRegistroTipo5RemesaCnab400Ban136
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca EderecoEmail => campos[1];

	public CampoLayoutArquivoCobranca TipoInscricao => campos[2];

	public CampoLayoutArquivoCobranca NumeroInscricao => campos[3];

	public CampoLayoutArquivoCobranca Logradouro => campos[4];

	public CampoLayoutArquivoCobranca Bairro => campos[5];

	public CampoLayoutArquivoCobranca Cep => campos[6];

	public CampoLayoutArquivoCobranca Cidade => campos[7];

	public CampoLayoutArquivoCobranca Estado => campos[8];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[9];

	public CampoLayoutArquivoCobranca Mensagem2 => campos[10];

	public CampoLayoutArquivoCobranca Filler1 => campos[11];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[12];

	public RegistroTipo5RemesaCnab400Ban136(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 5 de remessa CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.5", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban136.REGISTRO_TIPO5.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.5", "Endereço de email", "Endereço de email do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 121, 120, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.5", "Tipo de inscrição", "Tipo de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 122, 123, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.5", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 124, 137, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.5", "Logradouro", "Logradouro", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 138, 177, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.5", "Bairro", "Bairro", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 178, 189, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.5", "CEP", "CEP", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 190, 197, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.5", "Cidade", "Cidade", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 198, 212, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.5", "Estado", "Estado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 213, 214, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.5", "Mensagem1", "Mensagem1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 215, 274, 60, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.5", "Mensagem2", "Mensagem2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 334, 60, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.5", "Filler", "Filler", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 394, 60, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.5", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
