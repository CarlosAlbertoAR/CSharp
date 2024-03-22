using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;

public class RegistroTransacaoTipo2RemessaCnab400Ban422 : DetalheRemessaCnab400, IRegistroTransacaoTipo2RemessaCnab400Ban422
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca EnderecoEmailPagador => campos[1];

	public CampoLayoutArquivoCobranca Filler1 => campos[2];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca TipoPessoaBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca EnderecoBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca BairroBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca CidadeBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca CepBeneficiario => campos[9];

	public CampoLayoutArquivoCobranca UfBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivoRemessa => campos[12];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[13];

	public RegistroTransacaoTipo2RemessaCnab400Ban422(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSAÇÃO TIPO 1 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.2", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban422.TRANSACAO_TIPO_2.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.2", "Email", "Endereço de e-mail do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 51, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.2", "Filler 1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 52, 151, 100, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.2", "Nome do beneficiário", "Nome do beneficiário do título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 191, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.2", "Tipo de pessoa", "Tipo de pessoa do beneficiário PF=1 PJ=2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 192, 192, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.2", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário, CPF ou CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 206, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.2", "Endereço do beneficiário", "Endereço do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 207, 246, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.2", "Bairro do beneficiário", "Bairro do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 247, 261, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.2", "Cidade do beneficiário", "Cidade do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 262, 281, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.2", "CEP", "CEP do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 282, 289, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.2", "UF", "UF do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 290, 291, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.2", "Filler 2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 292, 391, 100, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.2", "Número da remessa", "Número sequencial da remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.2", "Número sequencial do registro", "Número sequencial do registro no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
