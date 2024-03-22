using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public class RegistroTipo2RemessaCnab400Ban748 : DetalheRemessaCnab400, IRegistroTipo2RemessaCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Filler1 => campos[1];

	public CampoLayoutArquivoCobranca NossoNumero => campos[2];

	public CampoLayoutArquivoCobranca InstrucaoImpressao1 => campos[3];

	public CampoLayoutArquivoCobranca InstrucaoImpressao2 => campos[4];

	public CampoLayoutArquivoCobranca InstrucaoImpressao3 => campos[5];

	public CampoLayoutArquivoCobranca InstrucaoImpressao4 => campos[6];

	public CampoLayoutArquivoCobranca SeuNumero => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[9];

	public RegistroTipo2RemessaCnab400Ban748(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE OPCIONAL EMAIL de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.2", "Identificação do registro transação", "Identificação do registro transação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_2.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.2", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 12, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.2", "Nosso número", "Deixar em branco quando a impressão for feita pelo banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 13, 21, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.2", "1ª instrução para impressão no boleto", "Texto completo. Informar sem acentuação ou caracteres especiais..", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 101, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.2", "2ª instrução para impressão no boleto", "Texto completo. Informar sem acentuação ou caracteres especiais.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 102, 181, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.2", "3ª instrução para impressão no boleto", "Texto completo. Informar sem acentuação ou caracteres especiais.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 182, 261, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.2", "4ª instrução para impressão no boleto", "Texto completo. Informar sem acentuação ou caracteres especiais.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 262, 341, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.2", "Seu número", "Campo de responsabillidade do beneficiário. Não pode se repetir.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 342, 351, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.2", "Filler", "Deixar em branco - sem preenchimento.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 394, 43, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.2", "Número sequencial do registro", "Número sequencial do registro na remessa CNAB400.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
