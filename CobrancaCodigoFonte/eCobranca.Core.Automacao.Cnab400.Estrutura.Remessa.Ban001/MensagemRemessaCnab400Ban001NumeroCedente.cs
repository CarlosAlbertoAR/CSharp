using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;

public class MensagemRemessaCnab400Ban001NumeroCedente : MensagemRemessaCnab400Ban001, IMensagemRemessaCnab400Ban001NumeroCedente
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoServico => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[4];

	public MensagemRemessaCnab400Ban001NumeroCedente(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE OPCIONAL NÚMERO CEDENTE de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.5", "Identificação do registro transação", "Identificação do registro transação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_NUMERO_CEDENTE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.5", "Tipo de serviço", "Tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.ENVIO_NUMERO_CEDENTE.Codigo(), "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.5", "Identificação do título cedente", "Identificação do título cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 4, 18, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.5", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 19, 394, 376, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.5", "Número sequencial do registro", "Número sequencial do registro no arquivo de remessa.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
