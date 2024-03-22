using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public class RegistroTransacaoTipo1DadosSacadorRemessaCnab400Ban041 : DetalheRemessaCnab400, IRegistroTransacaoTipo1DadosSacadorRemessaCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => base.Campos[1];

	public CampoLayoutArquivoCobranca InscricaoSacadorAvalista => base.Campos[2];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => base.Campos[3];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[4];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => base.Campos[5];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[6];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[7];

	public CampoLayoutArquivoCobranca CodigoCarteira => base.Campos[8];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => base.Campos[9];

	public CampoLayoutArquivoCobranca ControleCanalMensagem1 => base.Campos[10];

	public CampoLayoutArquivoCobranca ConteudoMensagem1 => base.Campos[11];

	public CampoLayoutArquivoCobranca ControleCanalMensagem2 => base.Campos[12];

	public CampoLayoutArquivoCobranca ConteudoMensagem2 => base.Campos[13];

	public CampoLayoutArquivoCobranca ControleCanalMensagem3 => base.Campos[14];

	public CampoLayoutArquivoCobranca ConteudoMensagem3 => base.Campos[15];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[16];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[17];

	public RegistroTransacaoTipo1DadosSacadorRemessaCnab400Ban041(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_1_DADOS_SACADOR.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição", "Tipo de inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número da inscrição do sacador/avalista", "Número da inscrição do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código do beneficiário", "Informar AAAACCCCCCCCC,  onde AAAA = código da agência, CCCCCCCCC = código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 30, 13, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 37, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Identificação do título para o beneficiário", "Identificação do título para o beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 62, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 72, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 107, 35, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código da carteira", "Código do tipo da carteira", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 108, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Código de ocorrência", "Código da ocorrência do título na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "ControleCanalMensagem 1", "ControleCanalMensagem 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 111, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Conteúdo da mensagem 1", "Conteúdo da mensagem 1", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 112, 201, 90, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "ControleCanalMensagem 2", "ControleCanalMensagem 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 202, 1, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Conteúdo da mensagem 2", "Conteúdo da mensagem 2", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 203, 292, 90, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "ControleCanalMensagem 3", "ControleCanalMensagem 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 293, 293, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Conteúdo da mensagem 3", "Conteúdo da mensagem 3", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 294, 383, 90, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 384, 394, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
