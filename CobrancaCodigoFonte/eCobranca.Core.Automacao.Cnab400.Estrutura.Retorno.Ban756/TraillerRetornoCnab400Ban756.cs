using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban756;

public class TraillerRetornoCnab400Ban756 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban756
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoServico => campos[1];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgencicaRemetente => campos[3];

	public CampoLayoutArquivoCobranca SiglaCooperativaRemetente => campos[4];

	public CampoLayoutArquivoCobranca EnderecoCooperativaRemetente => campos[5];

	public CampoLayoutArquivoCobranca BairroCooperativaRemetente => campos[6];

	public CampoLayoutArquivoCobranca CepCooperativaRemetente => campos[7];

	public CampoLayoutArquivoCobranca CidadeCooperativaRemetente => campos[8];

	public CampoLayoutArquivoCobranca UFCooperativaRemetente => campos[9];

	public CampoLayoutArquivoCobranca DataMovimento => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeRegistros => campos[11];

	public CampoLayoutArquivoCobranca UltimoNossoNumero => campos[12];

	public CampoLayoutArquivoCobranca Filler1 => campos[13];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[14];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Tipo serviço", "Tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Código do banco", "Código do banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 6, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Código da cooperativa remetente", "Código da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 7, 10, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Sigla da cooperativa remetente", "Sigla da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 11, 35, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Endereço da cooperativa remetente", "Endereço da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 85, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Bairro da cooperativa remetente", "Bairro da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 86, 115, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Cep da cooperativa remetente", "Cep da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 116, 123, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Cidade da cooperativa remetente", "Cidade da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 124, 153, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "UF da cooperativa remetente", "UF da cooperativa remetente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 154, 155, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Data do movimento", "Data do movimento no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 156, 163, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Quantidade de registros", "Quantidade de registros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 171, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Último nosso número do beneficiário", "Último nosso número do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 172, 182, 11, 0);
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
