using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;

public class TraillerLoteFebraban240Ban104 : TraillerLoteFebraban240, ITraillerLoteFebraban240Ban104
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosLote => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[7];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada => campos[10];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[11];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban3 => campos[12];

	public TraillerLoteFebraban240Ban104()
	{
		try
		{
			Logger.Debug("Criando campos do TRAILLER DE LOTE do layout FEBRABAN240...");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.5", "Código do banco na Compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.5", "Lote de Serviço", "Número seqüencial para identificar univocamente um lote de serviço. Criado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo. Preencher com '0001' para o primeiro lote do arquivo. Para os demais: número do lote anterior acrescido de 1. O número não poderá ser repetido dentro do arquivo.Se registro for Header do Arquivo preencher com '0000'. Se registro for Trailler do Arquivo preencher com '9999' ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.5", "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. DominioTipoRegistro", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo(), EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.5", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 9, 17, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.5", "Quantidade de registros no lote", "Número obtido pela contagem dos registros enviados no lote do arquivo. Somatória dos registros de tipo 1, 2, 3, 4 e 5. Registros de tipo 2 e 4 são utilizados apenas em alguns produtos (exemplo: Extrato para Gestão de Caixa). ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.5", "Quantidade de títulos de cobrança simples", "Somatória dos registros enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 29, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.5", "Valor total dos títulos de cobrança simples", "Somatória dos valores dos títulos de cobrança enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 46, 15, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.5", "Quantidade de títulos de cobrança caucionada", "Somatória dos registros enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 52, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.5", "Valor total dos títulos de cobrança caucionada", "Somatória dos valores dos títulos de cobrança enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 69, 15, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.5", "Quantidade de títulos de cobrança descontada", "Somatória dos registros enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 70, 75, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.5", "Valor total dos títulos de cobrança descontada", "Somatória dos valores dos títulos de cobrança enviados no lote do arquivo de acordo com o Código da Carteira. Só serão utilizados para informação do arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 76, 92, 15, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.5", "Uso exclusivo FEBRABAN", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 93, 123, 31, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.5", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 124, 240, 117, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoTraillerLoteFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
