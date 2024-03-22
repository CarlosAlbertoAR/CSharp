using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class TraillerLoteRetornoFebraban240Ban033 : TraillerLoteFebraban240, ITraillerLoteRetornoFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosLote => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalTituloCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada => campos[7];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada => campos[11];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada => campos[12];

	public CampoLayoutArquivoCobranca NumeroAvisoLancamento => campos[13];

	public CampoLayoutArquivoCobranca Filler2 => campos[14];

	public TraillerLoteRetornoFebraban240Ban033()
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.5", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.5", "Lote de serviço", "Lote de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.5", "Tipo de registro", "Tipo de registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.5", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 17, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.5", "Quantidade de registros no lote", "Quantidade de registros no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.5", "Quantidade de títulos de cobrança simples", "Quantidade de títulos de sobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 29, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.5", "Valor total dos títulos de cobrança simples", "Valor total dos títulos de cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 46, 15, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.5", "Quantidade de títulos de cobrança vinculada", "Quantidade de títulos de sobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 52, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.5", "Valor total dos títulos de cobrança vinculada", "Valor total dos títulos de cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 69, 15, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.5", "Quantidade de títulos de cobrança caucionada", "Quantidade de títulos de sobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 70, 75, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.5", "Valor total dos títulos de cobrança caucionada", "Valor total dos títulos de cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 76, 92, 15, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.5", "Quantidade de títulos de cobrança descontada", "Quantidade de títulos de sobrança descontada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 98, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.5", "Valor total dos títulos de cobrança descontada", "Valor total dos títulos de cobrança descontada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 99, 115, 15, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.5", "Número do aviso do lançamento", "Número do aviso do lançamento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 116, 123, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.5", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 124, 240, 117, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
