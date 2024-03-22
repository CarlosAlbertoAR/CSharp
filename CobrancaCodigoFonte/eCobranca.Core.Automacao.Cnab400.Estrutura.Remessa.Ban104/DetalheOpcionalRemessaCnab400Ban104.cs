using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;

public class DetalheOpcionalRemessaCnab400Ban104 : DetalheRemessaCnab400, IDetalheOpcionalRemessaCnab400Ban104
{
	public CampoLayoutArquivoCobranca IdentificadorRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca Filler2 => campos[6];

	public CampoLayoutArquivoCobranca Modalidade => campos[7];

	public CampoLayoutArquivoCobranca NossoNumero => campos[8];

	public CampoLayoutArquivoCobranca Filler3 => campos[9];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[10];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[11];

	public CampoLayoutArquivoCobranca Filler4 => campos[12];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[13];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[14];

	public CampoLayoutArquivoCobranca Mensagem2 => campos[15];

	public CampoLayoutArquivoCobranca Mensagem3 => campos[16];

	public CampoLayoutArquivoCobranca Mensagem4 => campos[17];

	public CampoLayoutArquivoCobranca Mensagem5 => campos[18];

	public CampoLayoutArquivoCobranca Mensagem6 => campos[19];

	public CampoLayoutArquivoCobranca Filler5 => campos[20];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[21];

	public DetalheOpcionalRemessaCnab400Ban104(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE OPCIONAL de remessa CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.2", "Identificação do registro Detalhe opcional", "Identificação do registro Detalhe opcional do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban104.DETALHE_OPCIONAL.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.2", "Tipo de inscrição", "Tipo de inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.2", "Número da inscrição", "Número da inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.2", "Código da agência", "Código da agência de vinculação do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.2", "Código do beneficiário", "Conta corrente do beneficiário na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 27, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.2", "Uso exclusivo da CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 28, 31, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.2", "Uso exclusivo CNAB400", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 32, 56, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.2", "Modalidade de cobrança", "Código da modalidade de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 57, 58, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.2", "Nosso número", "Identificação do título na CAIXA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 73, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.2", "Uso exclusivo CNAB400", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 106, 33, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.2", "Carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Código da ocorrência", "Identificação do tipo de ocorrência no arquivo de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.2", "Uso exclusivo CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 139, 29, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.2", "Código do banco", "Código do banco na compensação - 104", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo(), "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.2", "Mensagem 1", "Mensagem 1 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 143, 182, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.2", "Mensagem 2", "Mensagem 2 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 183, 222, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.2", "Mensagem 3", "Mensagem 3 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 223, 262, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.2", "Mensagem 4", "Mensagem 4 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 263, 302, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.2", "Mensagem 5", "Mensagem 5 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 303, 342, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.2", "Mensagem 6", "Mensagem 6 a ser impressa no boleto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 343, 382, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.2", "Uso exclusivo CAIXA", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 383, 394, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.2", "Número sequencial", "Número sequencial do registro no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
