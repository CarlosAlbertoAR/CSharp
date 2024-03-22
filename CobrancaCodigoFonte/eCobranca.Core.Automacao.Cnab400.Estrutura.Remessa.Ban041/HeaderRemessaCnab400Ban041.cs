using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public class HeaderRemessaCnab400Ban041 : HeaderRemessaCnab400, IHeaderRemessaCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoRemessa => base.Campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoRemessaLiteral => base.Campos[2];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[3];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => base.Campos[4];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[5];

	public CampoLayoutArquivoCobranca NomeBeneficiario => base.Campos[6];

	public CampoLayoutArquivoCobranca IdentificacaoBanco => base.Campos[7];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[8];

	public CampoLayoutArquivoCobranca DataGravacao => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[10];

	public CampoLayoutArquivoCobranca CodigoServico => base.Campos[11];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[12];

	public CampoLayoutArquivoCobranca TipoProcessamento => base.Campos[13];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[14];

	public CampoLayoutArquivoCobranca CodigoClienteOfficeBanking => base.Campos[15];

	public CampoLayoutArquivoCobranca Filler7 => base.Campos[16];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[17];

	public HeaderRemessaCnab400Ban041(long sequeciaSegmento)
		: base(sequeciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
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
			campoLayoutArquivoCobranca.Preparar("04.0", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 10, 26, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Código do cedente", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "", "", 27, 39, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 40, 46, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Nome da empresa", "Razão social / Nome fantasia", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Identificação do banco", "Código do banco e nome do banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 87, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 94, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Data de gravação do arquivo", "Data de gravação do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 109, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Código do serviço", "Apenas utilizado para as carteiras R, S e X. Para demais carteiras informar brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 110, 113, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Filler5", "Filler5", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 114, 114, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Tipo de processamento", "Somente para as carteiras  R, S e X, para as demais, este campo deve ficar em branco.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 115, 115, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Filler6", "Filler6", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 116, 116, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Código do cliente no office banking", "Somente para carteiras R, S e X, para as demais deixar em branco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 117, 126, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Filler7", "Filler7", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 127, 394, 268, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.0", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
