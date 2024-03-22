using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheY50Febraban240 : SegmentoDetalheOpcionalFebraban240
{
	public SegmentoDetalheY50Febraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumIdentificacaoRegistroOpcionalYFebraban.INFORMACAO_DE_DADOS_DE_RATEIO_DE_CREDITO.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE Y05 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Y", "Agência mantenedora da conta", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 20, 24, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Y", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 25, 25, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Y", "Número da conta corrente", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 37, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Y", "Dígito verificador da conta corrente", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 38, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Y", "Dígito verificador da Agência/Conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 39, 39, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Y", "Identificacao do título no banco (Nosso Número)", "Número adotado pelo Banco Cedente para identificar o Título. Para código de movimento igual a '01' (Entrada de Títulos), caso esteja preenchido com zeros, a numeração será feita pelo Banco.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 40, 59, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Y", "Código de cálculo de rateio p/ beneficiário", "Código adotado pela FEBRABAN para identificar a maneira de cálculo da divisão do valor do crédito entre os beneficiários do Título. DominioCodigoCalculoRateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 60, 60, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3Y", "Tipo de valor informado para rateio", "Código adotado pela FEBRABAN para identificar qual o valor informado para rateio de crédito. DominioTipoValorRateio", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 61, 61, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3Y", "Valor/quantidade ou percentual de rateio", "Valor ou percentual do título para Rateio de Crédito. Quando o valor for expresso em percentual, deve ser informado com 3 decimais ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 62, 76, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3Y", "Código do banco para crédito do beneficiário", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 79, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3Y", "Código da agência do beneficiário", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 84, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3Y", "Dígito verificador da agência do beneficiário", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 85, 85, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3Y", "Número da conta corrente do beneficiário", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 97, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3Y", "Dígito verificador da conta corrente do beneficiário", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 98, 98, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3Y", "Dígito verificador da agência conta do beneficiário", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 99, 99, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3Y", "Nome do beneficiário", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 100, 139, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3Y", "Parcela do rateio", "Número seqüencial para identificação da parcela de rateio do título de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 140, 145, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3Y", "Número de dias para crédito do beneficiário", "Número de dias decorrentes após a disponibilização do crédito do título de cobrança para efetivação do crédito ao beneficiário. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 148, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3Y", "Data crédito beneficiário", "Data de efetivação do crédito referente ao rateio do título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 149, 156, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3Y", "Motivo ocorrido", "Código adotado pela FEBRABAN para identificar o motivo ocorrido para rejeição de registro de rateio de crédito. DominioIdentificacaoRejeicao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 166, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3Y", "ISPB do banco destinatário", "Código Adotado pelo Banco Central para identificação das instituições financeiras no Sistema de Pagamentos Brasileiro. A informação do Código ISPB é obrigatória quando for necessário o envio de TED para instituição financeira que não possui código COMPE.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 167, 174, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3Y", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 175, 240, 66, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoY50Febraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
