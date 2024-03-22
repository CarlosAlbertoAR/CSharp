using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class HeaderLoteFebraban240 : SegmentoFebraban240
{
	public HeaderLoteFebraban240()
	{
		try
		{
			Logger.Debug("Criando os campos do HEADER DE LOTE do layout FEBRABAN240.");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Código do banco na Compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Lote de Serviço", "Número seqüencial para identificar univocamente um lote de serviço. Criado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo. Preencher com '0001' para o primeiro lote do arquivo. Para os demais: número do lote anterior acrescido de 1. O número não poderá ser repetido dentro do arquivo.Se registro for Header do Arquivo preencher com '0000'. Se registro for Trailler do Arquivo preencher com '9999' ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. DominioTipoRegistro. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo(), EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Tipo de Operação", "Código adotado pela FEBRABAN para identificar a transação que será realizada com os registros detalhe do lote. DominioTipoOperacao.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 9, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Tipo de Serviço", "Código adotado pela FEBRABAN para indicar o tipo de serviço / produto (processo) contido no arquivo / lote.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "01", "01", 10, 11, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 12, 13, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Número da Versão do Layout do Lote", "Código adotado pela FEBRABAN para identificar qual a versão de layout do lote de arquivo encaminhado. O código é composto de: Versão = 2 dígitos, Release = 1 dígito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "046", "046", 14, 16, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 17, 17, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Tipo de inscrição da Empresa", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Número de inscrição da Empresa", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 33, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Código do convênio no Banco", "Código adotado pelo Banco para identificar o Contrato entre este e a Empresa Cliente.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 34, 53, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Agência mantenedora da conta", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "", "", 54, 58, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 59, 59, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Número da conta corrente", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "", "", 60, 71, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Dígito verificador da conta corrente", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 72, 72, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Dígito verificador da Agência/Conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 73, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Nome da Empresa", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 103, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Mensagem 1", "Texto referente a mensagens que serão impressas em todos os bloquetos referentes ao mesmo lote. Estes campos não serão utilizados no arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 104, 143, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Mensagem 2", "Texto referente a mensagens que serão impressas em todos os bloquetos referentes ao mesmo lote. Estes campos não serão utilizados no arquivo retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 144, 183, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Número Remessa/Retorno", "Número adotado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo para identificar a seqüência de envio ou devolução do arquivo entre o Cedente e o Banco Cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 184, 191, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Data de gravação Remessa/Retorno", "Data da gravação do arquivo de remessa ou retorno. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 192, 199, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Data de crédito", "Data de efetivação do crédito referente ao pagamento do título de cobrança. Informação enviada somente no arquivo de retorno. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 200, 207, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 208, 240, 33, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoHeaderLoteFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
