using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban748;

internal class HeaderRetornoCnab400Ban748 : HeaderRetornoCnab400, IHeaderRetornoCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoMovimento => campos[1];

	public CampoLayoutArquivoCobranca TipoMovimentoLiteral => campos[2];

	public CampoLayoutArquivoCobranca TipoServico => campos[3];

	public CampoLayoutArquivoCobranca TipoServicoLiteral => campos[4];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca Filler1 => campos[7];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[8];

	public CampoLayoutArquivoCobranca NomeBanco => campos[9];

	public CampoLayoutArquivoCobranca DataGravacao => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public CampoLayoutArquivoCobranca NumeroSequencialRetorno => campos[12];

	public CampoLayoutArquivoCobranca Filler3 => campos[13];

	public CampoLayoutArquivoCobranca VersaoSistema => campos[14];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[15];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Identificação do registro Header", "Identificação do registro Header do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.HEADER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Identificação do arquivo retorno", "Informar 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoOperacao.RETORNO.Codigo(), "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("03.0", "Descrição tipo de operação", "Identificação por extenso do tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoOperacao.RETORNO.Sigla(), "", 3, 9, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Tipo de serviço", "Identificação do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.COBRANCA.Codigo(), "", 10, 11, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("05.0", "Descrição tipo de serviço", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoServico.COBRANCA.Sigla(), "", 12, 26, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Código da empresa", "Número da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 31, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("07.0", "Número de inscrição do beneficiário", "CPF/CNPJ do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 45, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 46, 76, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("09.0", "Número de compensação do Sicredi", "Informar 748", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Literal BANSicredi", "BANSicredi", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("11.0", "Data de gravação do arquivo", "Informar no formato: AAAAMMDD", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 102, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 103, 110, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("13.0", "Número do retorno", "Número do retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 117, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 118, 389, 272, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca.Preparar("15.0", "Versão do sistema", "Informar no formato: 99.99", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 390, 394, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
