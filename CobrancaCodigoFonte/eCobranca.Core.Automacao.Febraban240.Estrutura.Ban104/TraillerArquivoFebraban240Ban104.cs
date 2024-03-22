using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;

public class TraillerArquivoFebraban240Ban104 : TraillerArquivoFebraban240, ITraillerArquivoFebraban240Ban104
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeLotesArquivo => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosArquivo => campos[5];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[6];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban3 => campos[7];

	public TraillerArquivoFebraban240Ban104()
	{
		try
		{
			Logger.Debug("Criando campos do TRAILLER DE ARQUIVO do layout FEBRABAN240...");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Código do banco na compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Lote de Serviço", "Número seqüencial para identificar univocamente um lote de serviço. Criado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo. Preencher com '0001' para o primeiro lote do arquivo. Para os demais: número do lote anterior acrescido de 1. O número não poderá ser repetido dentro do arquivo.Se registro for Header do Arquivo preencher com '0000'. Se registro for Trailler do Arquivo preencher com '9999' ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "9999", "9999", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. DominioTipoRegistro", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo(), EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 9, 17, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Quantidade de lotes do Arquivo", "Número obtido pela contagem dos lotes enviados no arquivo. Somatória dos registros de tipo 1.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de Registro do Arquivo", "Número obtido pela contagem dos registros enviados no arquivo. Somatória dos registros de tipo 0, 1, 3, 5 e 9.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 29, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Uso exclusivo FEBRABAN", "Informar brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 35, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 36, 240, 205, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoTraillerArquivoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
