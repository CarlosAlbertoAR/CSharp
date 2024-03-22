using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public class TraillerRetornoCnab400Ban097 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban097
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoServico => campos[1];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[2];

	public CampoLayoutArquivoCobranca Agencia => campos[3];

	public CampoLayoutArquivoCobranca SiglaAgencia => campos[4];

	public CampoLayoutArquivoCobranca EnderecoAgencia => campos[5];

	public CampoLayoutArquivoCobranca BairroAgencia => campos[6];

	public CampoLayoutArquivoCobranca CepAgencia => campos[7];

	public CampoLayoutArquivoCobranca CidadeAgencia => campos[8];

	public CampoLayoutArquivoCobranca EstadoAgencia => campos[9];

	public CampoLayoutArquivoCobranca DataMovimento => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeRegistros => campos[11];

	public CampoLayoutArquivoCobranca Filler1 => campos[12];

	public CampoLayoutArquivoCobranca Filler2 => campos[13];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[14];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Identificação do serviço", "Informar 02", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Número do banco", "Informar 097", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 6, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Agência", "Código da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 7, 10, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Sigla da agência", "Sigla da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 11, 35, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Endereço da agência", "Endereço da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 85, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Bairro da agência", "Bairro da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 86, 115, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Cep da agência", "Cep da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 116, 123, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Cidade de agência", "Cidade da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 124, 153, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Estado da agência", "Estado da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 154, 155, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Data do movimento", "Data do movimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 156, 163, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Quantidade de registros", "Quantidade de registros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 171, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 172, 182, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 183, 394, 212, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
