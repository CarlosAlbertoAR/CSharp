using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;

public class HeaderRemessaCnab400Ban136 : HeaderRemessaCnab400, IHeaderRemessaCnab400Ban136
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoRemessa => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoRemessaLiteral => campos[2];

	public CampoLayoutArquivoCobranca CodigoServico => campos[3];

	public CampoLayoutArquivoCobranca LiteralServico => campos[4];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[7];

	public CampoLayoutArquivoCobranca NomeBanco => campos[8];

	public CampoLayoutArquivoCobranca DataGravacao => campos[9];

	public CampoLayoutArquivoCobranca Filler1 => campos[10];

	public CampoLayoutArquivoCobranca CodigoVariacao => campos[11];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivo => campos[12];

	public CampoLayoutArquivoCobranca Filler2 => campos[13];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[14];

	public HeaderRemessaCnab400Ban136(long sequeciaSegmento)
		: base(sequeciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de remessa CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.HEADER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Tipo de operação", "Tipo de operação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoOperacao.REMESSA.Codigo(), "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Descrição tipo de operação", "Identificação por extenso do tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoOperacao.REMESSA.Sigla(), "", 3, 9, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Tipo de serviço", "Identificação do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.COBRANCA.Codigo(), "", 10, 11, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Descrição tipo de serviço", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoServico.COBRANCA.Sigla(), "", 12, 26, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Código do beneficiário", "Identificação da empresa no Banestes - Conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 46, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Nome do beneficiário", "Nome por extenso da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Código do banco", "Número do bradesco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.UNICRED.Codigo(), "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Nome do banco por extenso", "Nome do banco por extenso", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.UNICRED.Sigla(), "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Data de gravação do arquivo", "Data de gravação do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 107, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Código da variação da carteira da UNICRED", "Preencher com 000", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 110, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Número sequencial do arquivo", "Número sequencial do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 117, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 118, 394, 277, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
