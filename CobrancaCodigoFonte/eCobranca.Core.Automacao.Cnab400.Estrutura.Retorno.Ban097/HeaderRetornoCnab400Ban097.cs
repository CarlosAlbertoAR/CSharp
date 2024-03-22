using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public class HeaderRetornoCnab400Ban097 : HeaderRetornoCnab400, IHeaderRetornoCnab400Ban097
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[1];

	public CampoLayoutArquivoCobranca TipoOperacaoLiteral => campos[2];

	public CampoLayoutArquivoCobranca TipoServico => campos[3];

	public CampoLayoutArquivoCobranca TipoServicoLiteral => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[9];

	public CampoLayoutArquivoCobranca Filler3 => campos[10];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoBanco => campos[12];

	public CampoLayoutArquivoCobranca DataGravacao => campos[13];

	public CampoLayoutArquivoCobranca SequencialRetorno => campos[14];

	public CampoLayoutArquivoCobranca Filler4 => campos[15];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[16];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
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
			campoLayoutArquivoCobranca.Preparar("05.0", "Descrição tipo de serviço", "Identificação por extenso do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoServico.COBRANCA.Sigla(), "", 12, 19, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 26, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Código da agência", "Prefixo da agência: Número da agência onde está cadastrado o convênio líder do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 30, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Número da conta corrente", "Número da conta corrente onde está cadastrado o Convênio Líder do Cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 39, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Dígito verificador da conta corrente", "Dígito verificador - D.V. - do número da conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 40, 40, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 46, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Nome do beneficiário", "Nome do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Identificação do banco na compensação", "Identificação do banco na câmara de compensação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Codigo() + EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Sigla(), "", 77, 94, 18, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data de gravação", "Data da geração do arquivo de remessa: Informe no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Sequencial da retorno", "Número da retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 107, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 394, 287, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
