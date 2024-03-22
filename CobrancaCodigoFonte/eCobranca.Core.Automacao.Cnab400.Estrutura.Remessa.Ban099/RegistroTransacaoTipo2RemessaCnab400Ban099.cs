using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;

public class RegistroTransacaoTipo2RemessaCnab400Ban099 : SegmentoLoteCnab400, IRegistroTransacaoTipo2RemessaCnab400Ban099
{
	public CampoLayoutArquivoCobranca TipoRegistro => campos[0];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[1];

	public CampoLayoutArquivoCobranca Mensagem2 => campos[2];

	public CampoLayoutArquivoCobranca Mensagem3 => campos[3];

	public CampoLayoutArquivoCobranca Mensagem4 => campos[4];

	public CampoLayoutArquivoCobranca DataDesconto2 => campos[5];

	public CampoLayoutArquivoCobranca ValorDesconto2 => campos[6];

	public CampoLayoutArquivoCobranca DataDesconto3 => campos[7];

	public CampoLayoutArquivoCobranca ValorDesconto3 => campos[8];

	public CampoLayoutArquivoCobranca Filler1 => campos[9];

	public CampoLayoutArquivoCobranca Carteira => campos[10];

	public CampoLayoutArquivoCobranca Agencia => campos[11];

	public CampoLayoutArquivoCobranca ContaCorrente => campos[12];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[13];

	public CampoLayoutArquivoCobranca NossoNumero => campos[14];

	public CampoLayoutArquivoCobranca DVNossoNumero => campos[15];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[16];

	public RegistroTransacaoTipo2RemessaCnab400Ban099(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 2 de remessa CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.2", "Tipo de registro", "Informar 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban099.MENSAGEM.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.2", "Mensagem 1", "Mensagem 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 81, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.2", "Mensagem 2", "Mensagem 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 82, 161, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.2", "Mensagem 3", "Mensagem 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 162, 241, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.2", "Mensagem 4", "Mensagem 4", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 242, 321, 80, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.2", "Data do desconto 2", "Data limite para concessão do desconto 2 no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 322, 327, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.2", "Valor do desconto 2", "Valor do desconto 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 328, 340, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.2", "Data do desconto 3", "Data limite para concessão do desconto 3 no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 341, 346, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.2", "Valor do desconto 3", "Valor do desconto 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 347, 359, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.2", "Reserva", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 360, 366, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.2", "Número da carteira", "Número da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 367, 369, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.2", "Agência", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 370, 374, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.2", "Conta corrente", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 375, 381, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.2", "Dígito verificador da conta corrente", "Dígito verificador da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 382, 382, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.2", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 383, 393, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.2", "Dígito do nosso número", "Dígito do nosso número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.2", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
