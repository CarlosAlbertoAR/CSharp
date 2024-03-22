using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil : HeaderLoteFebraban240, IHeaderLoteFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca Filler3 => campos[5];

	public CampoLayoutArquivoCobranca CodigoCooperativaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca CodigoCobranca => campos[7];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[8];

	public CampoLayoutArquivoCobranca Filler4 => campos[9];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca Filler5 => campos[11];

	public CampoLayoutArquivoCobranca NumeroRemessa => campos[12];

	public CampoLayoutArquivoCobranca DataGravacao => campos[13];

	public CampoLayoutArquivoCobranca Filler6 => campos[14];

	public CampoLayoutArquivoCobranca Filler7 => campos[15];

	public HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil()
	{
		try
		{
			campos.Clear();
			Logger.Debug("Criando campos do HEADER DE LOTE do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Código do banco na Compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. Domínio: '0' = Header de Arquivo '1' = Header de Lote '2' = Registros Iniciais do Lote '3' = Detalhe '4' = Registros Finais do Lote '5' = Trailler de Lote '9' = Trailler de Arquivo ", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo(), EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Tipo de operação", "Tipo da operação: R - remessa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 9, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 10, 16, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 17, 18, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Código da cooperativa do beneficiário", "Número da cooperativa do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 22, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Código de cobrança", "Código de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 29, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Número da conta corrente", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 40, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 41, 70, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Nome do beneficiário", "Razão social ou nome fantasia do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 71, 100, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 180, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Número da remessa", "Número sequencial da remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 181, 188, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Data da gravação do arquivo", "Data no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 196, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 197, 207, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 208, 240, 33, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoHeaderLoteFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
