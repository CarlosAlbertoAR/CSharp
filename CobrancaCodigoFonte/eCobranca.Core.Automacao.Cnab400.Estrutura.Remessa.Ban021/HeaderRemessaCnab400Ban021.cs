using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;

public class HeaderRemessaCnab400Ban021 : HeaderRemessaCnab400, IHeaderRemessaCnab400Ban021
{
	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.IdentificacaoRegistro => campos[0];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.IdentificacaoRemessa => campos[1];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.IdentificacaoRemessaLiteral => campos[2];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.CodigoServico => campos[3];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.LiteralServico => campos[4];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.CodigoBeneficiario => campos[5];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.Filler1 => campos[6];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.NomeBeneficiario => campos[7];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.CodigoBanco => campos[8];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.NomeBanco => campos[9];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.DataGravacao => campos[10];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.Filler2 => campos[11];

	CampoLayoutArquivoCobranca IHeaderRemessaCnab400Ban021.NumeroSequencialRegistro => campos[12];

	public HeaderRemessaCnab400Ban021(long sequeciaSegmento)
		: base(sequeciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
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
			campoLayoutArquivoCobranca.Preparar("06.0", "Código do beneficiário", "Identificação da empresa no Banestes - Conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 37, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 46, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Nome do beneficiário", "Nome por extenso da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Código do banco", "Número do bradesco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Codigo(), "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Nome do banco por extenso", "Nome do banco por extenso", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Sigla(), "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Data de gravação do arquivo", "Data de gravação do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 394, 294, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
