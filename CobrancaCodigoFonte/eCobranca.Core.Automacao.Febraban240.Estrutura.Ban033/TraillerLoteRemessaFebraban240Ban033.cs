using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class TraillerLoteRemessaFebraban240Ban033 : TraillerLoteFebraban240, ITraillerLoteRemessaFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosLote => campos[4];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[5];

	public TraillerLoteRemessaFebraban240Ban033()
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("1.5", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("2.5", "Número do lote remessa", "Número do lote remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("3.5", "Tipo de registro", "Informar 5", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("4.5", "Reservado uso do banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 17, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("5.5", "Quantidade de registros do lote", "Quantidade de registros do lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("6.5", "Uso reservado do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 24, 240, 217, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
