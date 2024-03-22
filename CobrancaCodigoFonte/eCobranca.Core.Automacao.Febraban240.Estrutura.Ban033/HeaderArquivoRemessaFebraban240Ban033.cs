using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class HeaderArquivoRemessaFebraban240Ban033 : HeaderArquivoFebraban240, IHeaderArquivoRemessaFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[3];

	public CampoLayoutArquivoCobranca TipoInscricaoEmpresa => campos[4];

	public CampoLayoutArquivoCobranca NumeroInscricaoEmpresa => campos[5];

	public CampoLayoutArquivoCobranca CodigoTransmissao => campos[6];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[7];

	public CampoLayoutArquivoCobranca NomeEmpresa => campos[8];

	public CampoLayoutArquivoCobranca NomeBanco => campos[9];

	public CampoLayoutArquivoCobranca UsoReservadoBanco3 => campos[10];

	public CampoLayoutArquivoCobranca CodigoRemessa => campos[11];

	public CampoLayoutArquivoCobranca DataGeracaoArquivo => campos[12];

	public CampoLayoutArquivoCobranca UsoReservadoBanco4 => campos[13];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivo => campos[14];

	public CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo => campos[15];

	public CampoLayoutArquivoCobranca UsoReservadoBanco5 => campos[16];

	public HeaderArquivoRemessaFebraban240Ban033()
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.0", "Código do banco na compensação", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.0", "Lote de serviço", "Lote de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.0", "Tipo de registro", "Tipo de registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.0", "Uso reservado Febraban240", "Filler - preencher com brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 16, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.0", "Tipo de inscrição da empresa", "1 = CPF, 2 = CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 17, 17, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.0", "Número da inscrição da empresa", "Número da inscrição da empresa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 32, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.0", "Código de transmissão", "Código de transmissão", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 47, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.0", "Uso reservado Febraban240", "Filler - preencher com brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 72, 25, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.0", "Nome da empresa", "Nome da empresa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 102, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.0", "Nome do banco", "Nome do banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 103, 132, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.0", "Reservado ao banco", "Reservado ao banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 133, 142, 10, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.0", "Código de remessa", "Código de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 143, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.0", "Data de geração do arquivo", "Data de geração do arquivo no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 144, 151, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.0", "Reservado uso do banco", "Reservado uso do banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 157, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.0", "Número sequencial do arquivo", "Número sequencial do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 163, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.0", "Número da versão do layout", "Número da versão do layout", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 166, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.0", "Uso reservado Febraban240", "Filler - preencher com brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 167, 240, 74, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[14].Valor.Trim());
	}
}
