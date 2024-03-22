using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheUFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalheUFebraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE U do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3U", "Acréscimos de juros, multa e encargos", "Valor dos acréscimos efetuados no título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 32, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3U", "Valor do desconto concedido", "Valor dos descontos efetuados no título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 47, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3U", "Valor do abatimento concedido/cancelado", "Valor dos abatimentos efetuados ou cancelados no título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 48, 62, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3U", "Valor do IOF recolhido", "Valor do IOF - Imposto sobre Operações Financeiras - recolhido sobre o Título, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 77, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3U", "Valor pago pelo sacado", "Valor do pagamento efetuado pelo Sacado referente ao título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 92, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3U", "Valor líquido a ser creditado", "Valor efetivo a ser creditado referente ao Título, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 107, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3U", "Valor de outras despesas", "Valor efetivo de despesas referente ao título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 122, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3U", "Valor de outros créditos", "Valor efetivo de créditos referente ao título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 123, 137, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3U", "Data da ocorrência", "Data do evento que afeta o estado do título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 145, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3U", "Data da efetivação do crédito", "Data de disponibilização do crédito referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 153, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3U", "Código da ocorrência do sacado", "Código adotado pela FEBRABAN para identificar o tipo de ocorrência do sacado.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 154, 157, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3U", "Data da ocorrência do sacado", "Data do evento, alegado pelo Sacado, que afeta o estado do título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 165, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3U", "Valor da ocorrência do sacado", "Valor constante da ocorrência, alegada pelo Sacado, referente ao título de cobrança, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 180, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3U", "Complemento da ocorrência do sacado", "Texto descritivo para complementar a ocorrência do sacado. Para código padrão = '01' - Formato Livre Para código padrão = '02' - Mesmo formato do campo “Ocorrência” do segmento U: Data Ocorrência: 8 posições (DDMMAAAA) Valor Ocorrência: 13 inteiras e 2 decimais Complemento: 30 posições ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 181, 210, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3U", "Código do banco correspondente compensação", "Código fornecido pelo Banco Central para identificação na Câmara de Compensação, do Banco ao qual será repassada a Cobrança do Título. Somente para troca de arquivos entre Bancos.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 211, 213, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3U", "Nosso número no banco correspondente", "Código fornecido pelo Banco Correspondente para identificação do Título de Cobrança. Somente para troca de arquivos entre Bancos.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 214, 233, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3U", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 234, 240, 7, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoUFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
