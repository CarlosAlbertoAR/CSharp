using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;

public class HeaderRetornoCnab400Ban399 : HeaderRetornoCnab400, IHeaderRetornoCnab400Ban399
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoTipoArquivo => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoTipoArquivoExtenso => campos[2];

	public CampoLayoutArquivoCobranca IdentificacaoServico => campos[3];

	public CampoLayoutArquivoCobranca IdentificacaoServicoExtenso => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca SubContaBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca Filler2 => campos[9];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[11];

	public CampoLayoutArquivoCobranca NomeBanco => campos[12];

	public CampoLayoutArquivoCobranca DataGravacao => campos[13];

	public CampoLayoutArquivoCobranca DensidadeGravacao => campos[14];

	public CampoLayoutArquivoCobranca UnidadeDensidadeGravacao => campos[15];

	public CampoLayoutArquivoCobranca Filler3 => campos[16];

	public CampoLayoutArquivoCobranca DataCredito => campos[17];

	public CampoLayoutArquivoCobranca Filler4 => campos[18];

	public CampoLayoutArquivoCobranca NumeroSequencialRetorno => campos[19];

	public CampoLayoutArquivoCobranca Filler5 => campos[20];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[21];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
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
			campoLayoutArquivoCobranca.Preparar("06.0", "Filler1", "Informar zero.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 27, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Código da agência", "Prefixo da agência: Número da agência onde está cadastrado o convênio líder do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 28, 31, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Sub-conta do beneficiário", "Sub-conta da conta do cliente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 33, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Número da conta corrente", "Número da conta corrente onde está cadastrado o Convênio Líder do Cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 34, 44, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 45, 46, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Nome do beneficiário", "Nome do benficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Identificação do banco na compensação", "Identificação do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo(), "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Nome do banco", "Nome do banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.HSBC_BANK_BRASIL.Sigla(), "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data de gravação", "Data da geração do arquivo de remessa: Informe no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Densidade de gravação", "Densidade de gravação do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 105, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Unidade de densidade de gravação", "Unidade de densidade de gravação do arquivo.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 108, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 109, 119, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.0", "Data do crédito em conta corrente", "Data do crédito em conta corrente no formato DDMMAAAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 120, 125, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.0", "Filler4", "Infomar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 126, 388, 263, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.0", "Sequencial do arquivo de retorno", "Sequencial do arquivo de retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 389, 393, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.0", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca("22.0", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
