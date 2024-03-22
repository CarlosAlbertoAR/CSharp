using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;

public class HeaderRetornoCnab400Ban341 : HeaderRetornoCnab400, IHeaderRetornoCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoMovimento => campos[1];

	public CampoLayoutArquivoCobranca TipoMovimentoLiteral => campos[2];

	public CampoLayoutArquivoCobranca TipoServico => campos[3];

	public CampoLayoutArquivoCobranca TipoServicoLiteral => campos[4];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca Filler1 => campos[6];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca DVAgenciaContaBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca Filler2 => campos[9];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[11];

	public CampoLayoutArquivoCobranca NomeBanco => campos[12];

	public CampoLayoutArquivoCobranca DataGeracao => campos[13];

	public CampoLayoutArquivoCobranca UnidadeDensidade => campos[14];

	public CampoLayoutArquivoCobranca DensidadeGravacao => campos[15];

	public CampoLayoutArquivoCobranca NumeroSequencialRetorno => campos[16];

	public CampoLayoutArquivoCobranca DataCreditoLancamentos => campos[17];

	public CampoLayoutArquivoCobranca Filler3 => campos[18];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[19];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.HEADER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Identificação de operação", "Identificação de operação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoOperacao.RETORNO.Codigo(), "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Descrição tipo de operação", "Identificação por extenso do tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoOperacao.RETORNO.Sigla(), "", 3, 9, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Tipo de serviço", "Identificação do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.COBRANCA.Codigo(), "", 10, 11, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Descrição tipo de serviço", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoServico.COBRANCA.Sigla(), "", 12, 26, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Código da agência", "Agência mantenedora da conta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 30, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Complemento de registro", "Complemento de registro - Informar ZEROS", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 32, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Número da conta corrente", "Número da conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 37, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Dígito da agência/conta corrente", "Dígito de auto conferência da agência/conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 38, 38, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 39, 46, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Nome do cedente", "Nome do cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Identificação do banco na compensação", "Identificação do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.BANCO_ITAU.Codigo(), "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Nome do banco", "Nome por extenso do banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.BANCO_ITAU.Sigla(), "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data de geração", "Data de geração do arquivo de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Unidade de densidade", "Unidade da densidade", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 105, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Densidade", "Densidade de gravação do arquivo", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "BPI", "", 106, 108, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Número sequencial arquivo retorno", "Número sequencial do arquivo de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 113, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.0", "Data de crédito", "Data de crédito dos lançamentos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 114, 119, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.0", "Complemento de registro", "Complemento de registro - Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 120, 394, 275, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.0", "Número sequencial do registro no arquivo", "Número sequencial do registro no arquivo de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
