using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;

public class RegistroTransacaoTipo7RemessaCnab400Ban237 : SegmentoCnab400, IRegistroTransacaoTipo7RemessaCnab400Ban237
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca EnderecoSacadorAvalista => campos[1];

	public CampoLayoutArquivoCobranca PrefixoCepSacadorAvalista => campos[2];

	public CampoLayoutArquivoCobranca SufixoCepSacadorAvalista => campos[3];

	public CampoLayoutArquivoCobranca CidadeSacadorAvalista => campos[4];

	public CampoLayoutArquivoCobranca UFSacadorAvalista => campos[5];

	public CampoLayoutArquivoCobranca Filler1 => campos[6];

	public CampoLayoutArquivoCobranca Carteira => campos[7];

	public CampoLayoutArquivoCobranca Agencia => campos[8];

	public CampoLayoutArquivoCobranca ContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca NossoNumero => campos[11];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[12];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[13];

	public RegistroTransacaoTipo7RemessaCnab400Ban237(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSACAO TIPO 7 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Tipo de registro", "Informar 7", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_7.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Endereço do sacador/avalista", "Endereço do sacador/avalista ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 46, 45, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "CEP", "CEP", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 51, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Sufixo do CEP", "Sufixo do CEP", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 52, 54, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "Cidade", "Cidade", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 55, 74, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "UF", "UF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 76, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 77, 366, 290, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Carteira", "Número da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 367, 369, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Agência", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 370, 374, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Conta corrente", "Número da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 375, 381, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.7", "Dígito da conta corrente", "Dígito verificador da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 382, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.7", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 383, 393, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.7", "Dígito verificador do nosso número", "Dígito verificador do nosso número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.7", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
