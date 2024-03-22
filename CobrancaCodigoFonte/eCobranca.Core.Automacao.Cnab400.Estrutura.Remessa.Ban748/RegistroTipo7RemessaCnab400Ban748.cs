using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public class RegistroTipo7RemessaCnab400Ban748 : DetalheRemessaCnab400, IRegistroTipo7RemessaCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca NossoNumero => campos[1];

	public CampoLayoutArquivoCobranca SeuNumero => campos[2];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[3];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[4];

	public CampoLayoutArquivoCobranca DataDesconto2 => campos[5];

	public CampoLayoutArquivoCobranca ValorPercentualDesconto2 => campos[6];

	public CampoLayoutArquivoCobranca DataDesconto3 => campos[7];

	public CampoLayoutArquivoCobranca ValorPercentualDesconto3 => campos[8];

	public CampoLayoutArquivoCobranca Filler1 => campos[9];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[10];

	public RegistroTipo7RemessaCnab400Ban748(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSACAO TIPO 7 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Tipo de registro", "Identificação do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_7.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Nosso número sicredi", "Nosso número sicredi", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 16, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "Seu número", "Número de controle utilizado pelo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 17, 26, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Número de inscrição do pagador", "CPF/CNPJ do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 40, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "Número de inscrição do sacador/avalista", "CPF/CNPJ do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 54, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "Data limite para o 2º desconto", "Informar a data no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 55, 60, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "Valor/percentual do 2º desconto", "Valor/percentual do segundo desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 61, 73, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Data limite para o 3º desconto", "Informar a data no formato: DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 79, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Valor/percentual do 3º desconto", "Valor/percentual do terceiro desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 92, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 394, 302, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.7", "Número sequencial do registro", "Número sequencial do registro no arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
