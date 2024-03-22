using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;

public class HeaderRemessaCnab400Ban004 : HeaderRemessaCnab400, IHeaderRemessaCnab400Ban004
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoTipoOperacao => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoTipoOperacaoExtenso => campos[2];

	public CampoLayoutArquivoCobranca IdentificacaoTipoServico => campos[3];

	public CampoLayoutArquivoCobranca IdentificacaoTipoServicoExtenso => campos[4];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca Filler1 => campos[6];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca DigitoContaCorrenteBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca Filler2 => campos[9];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[11];

	public CampoLayoutArquivoCobranca NomeBanco => campos[12];

	public CampoLayoutArquivoCobranca DataGravacao => campos[13];

	public CampoLayoutArquivoCobranca CodigoUsuario => campos[14];

	public CampoLayoutArquivoCobranca Filler3 => campos[15];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[16];

	public HeaderRemessaCnab400Ban004(long sequeciaSegmento)
		: base(sequeciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO HEADER de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
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
			campoLayoutArquivoCobranca.Preparar("06.0", "Agência do beneficiário", "Código da agência do beneficiário.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 30, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Filler 1", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 31, 32, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Conta do beneficiário", "Conta corrente de cobrança do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 39, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Dígito da conta corrente do beneficiário", "Dígito da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 40, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Filler 2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 41, 46, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Nome do beneficiário", "Nome do cliente beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 47, 76, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Número do banco", "Informar 004", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL.Codigo(), "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Nome do banco", "Informar B. DO NORDESTE", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL.Sigla(), "", 80, 94, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data de gravação", "Data da geração do arquivo de remessa: Informe no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 100, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Código do usuário", "Código da caixa postal no sistema EDI (Fornecido pelo banco)", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 103, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 104, 394, 291, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Número sequencial do registro", "Informar 000001 - Incrementar os próximos regitros em 1 até o trailler", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
