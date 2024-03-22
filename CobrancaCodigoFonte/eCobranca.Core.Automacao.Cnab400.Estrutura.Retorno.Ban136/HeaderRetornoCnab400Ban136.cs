using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban136;

public class HeaderRetornoCnab400Ban136 : HeaderRetornoCnab400, IHeaderRetornoCnab400Ban136
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoArquivoRetorno => campos[1];

	public CampoLayoutArquivoCobranca LiteralRetorno => campos[2];

	public CampoLayoutArquivoCobranca CodigoServico => campos[3];

	public CampoLayoutArquivoCobranca LiteralServico => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[6];

	public CampoLayoutArquivoCobranca DigitoAgencia => campos[7];

	public CampoLayoutArquivoCobranca ContaCorrente => campos[8];

	public CampoLayoutArquivoCobranca DigitoContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca Filler2 => campos[10];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoBanco => campos[12];

	public CampoLayoutArquivoCobranca DataGeracao => campos[13];

	public CampoLayoutArquivoCobranca SequencialRetorno => campos[14];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[15];

	public CampoLayoutArquivoCobranca Filler3 => campos[16];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[17];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Identificação do registro Header", "Identificação do registro Header do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.HEADER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Identificação do arquivo retorno", "Informar 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoOperacao.RETORNO.Codigo(), "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Descrição tipo de operação", "Identificação por extenso do tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoOperacao.RETORNO.Sigla(), "", 3, 9, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Tipo de serviço", "Identificação do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.COBRANCA.Codigo(), "", 10, 11, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Descrição tipo de serviço", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoServico.COBRANCA.Sigla(), "", 12, 19, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 26, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Número da agência", "Número da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 30, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Dígito da agência", "Dígito da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Conta corrente do beneficiário", "Conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 39, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Dígito da conta corrente", "Dígito da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 40, 40, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Filler", "Informar fico 000000", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 46, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Nome do beneficiário", "Nome do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Identificação do banco", "Informar fixo 136UNICREDDOBRASIL", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 94, 18, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data da geração do arquivo", "Data no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Sequencial do retorno", "Incremental por arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 107, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Código do beneficiário", "Código do beneficiário com zeros à esquerda", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 121, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 122, 394, 273, 0);
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
