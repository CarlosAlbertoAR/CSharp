using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheFebraban240 : SegmentoFebraban240, ISegmentoBaseDetalheFebraban240Padrao
{
	private long sequenciaLote;

	private long sequenciaSegmento;

	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote => campos[3];

	public CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe => campos[4];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoMovimento => campos[6];

	public long SequenciaLote
	{
		get
		{
			return sequenciaLote;
		}
		set
		{
			sequenciaLote = value;
		}
	}

	public long SequenciaSegmento
	{
		get
		{
			return sequenciaSegmento;
		}
		set
		{
			sequenciaSegmento = value;
		}
	}

	public SegmentoDetalheFebraban240(string tipoSegmentoDetalhe, long sequenciaLote, long sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN240.");
			this.sequenciaLote = sequenciaLote;
			this.sequenciaSegmento = sequenciaSegmento;
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3" + tipoSegmentoDetalhe, "Código do banco na Compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3" + tipoSegmentoDetalhe, "Lote de Serviço", "Número seqüencial para identificar univocamente um lote de serviço. Criado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo. Preencher com '0001' para o primeiro lote do arquivo. Para os demais: número do lote anterior acrescido de 1. O número não poderá ser repetido dentro do arquivo.Se registro for Header do Arquivo preencher com '0000'. Se registro for Trailler do Arquivo preencher com '9999' ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3" + tipoSegmentoDetalhe, "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. DominioTipoRegistro", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.DETALHE.Codigo(), EnumTipoRegistroFebraban240.DETALHE.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3" + tipoSegmentoDetalhe, "Número sequencial do registro no lote", "Número adotado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo, para identificar a seqüência de registros encaminhados no lote. Deve ser inicializado sempre em '1', em cada novo lote.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3" + tipoSegmentoDetalhe, "Código segmento do registro detalhe", "Código adotado pela FEBRABAN para identificar o segmento do registro.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, tipoSegmentoDetalhe, tipoSegmentoDetalhe, 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3" + tipoSegmentoDetalhe, "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3" + tipoSegmentoDetalhe, "Código de movimento", "Código adotado pela FEBRABAN, para identificar o tipo de movimentação enviado nos registros do arquivo de remessa/retorno. Cada Banco definirá os campos a serem alterados para o código de movimento '31'", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoBaseDetalheFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
