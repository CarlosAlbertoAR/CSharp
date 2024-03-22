using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalhePFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalhePFebraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO P do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3P", "Agência mantenedora da conta", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 22, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3P", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 23, 23, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3P", "Número da conta corrente", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 35, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3P", "Dígito verificador da conta corrente", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 36, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3P", "Dígito verificador da Agência/Conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 37, 37, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3P", "Identificacao do título no banco (Nosso Número)", "Número adotado pelo Banco Cedente para identificar o Título. Para código de movimento igual a '01' (Entrada de Títulos), caso esteja preenchido com zeros, a numeração será feita pelo Banco.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 57, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3P", "Código da carteira", "Código adotado pela FEBRABAN, para identificar a característica dos títulos dentro das modalidades de cobrança existentes no banco DominioCodigoCarteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 58, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3P", "Forma de cadastro do título no banco", "Código adotado pela FEBRABAN, para indicar a existência de registro do título no banco. DominioFormaCadastroTituloNoBanco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 59, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3P", "Tipo de documento", "Código adotado pela FEBRABAN para identificar a existência material do documento no processo. DominioTipoDocumento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 60, 60, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3P", "Identificação da emissão do bloqueto", "Código adotado pela FEBRABAN para identificar o responsável e a forma de emissão do bloqueto. DominioIdentificacaoEmissaoBloqueto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 61, 61, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3P", "Identificação da distribuição", "Código adotado pela FEBRABAN para identificar o responsável pela distribuição do bloqueto. DominioIdentificacaoDistribuicao", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 62, 62, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3P", "Número do documento de cobrança", "Número adotado e controlado pelo Cliente, para identificar o título de cobrança. Informação utilizada pelos Bancos para referenciar a identificação do documento objeto de cobrança. Poderá conter número de duplicata, no caso de cobrança de duplicatas; número da apólice, no caso de cobrança de seguros, etc.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 77, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3P", "Data de vencimento do título", "Data de vencimento do título de cobrança. A Vista Preencher com 11111111 Contra-apresentação Preencher com 99999999 Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 85, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3P", "Valor nominal do título", "Valor original do Título. Quando o valor for expresso em moeda corrente, utilizar 2 decimais. Quando o valor for expresso em moeda variável, utilizar 5 decimais.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 100, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3P", "Agência encarregada da cobrança", "Código adotado pelo Banco responsável pela cobrança, para identificar o estabelecimento bancário responsável pela cobrança do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 105, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3P", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3P", "Espécie do título", "Código adotado pela FEBRABAN para identificar o tipo de título de cobrança. DominioEspecieTitulo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3P", "Identificação de título aceito/não aceito", "Código adotado pela FEBRABAN para identificar se o título de cobrança foi aceito (reconhecimento da dívida pelo Sacado).DominioAceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 109, 109, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3P", "Data da emissão do título", "Data de emissão do Título. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 110, 117, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3P", "Código do juros de mora", "Código adotado pela FEBRABAN para identificação do tipo de pagamento de juros de mora. DominioCodigoJuros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 118, 118, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3P", "Data do juros mora", "Data indicativa do início da cobrança do Juros de Mora de um título de cobrança. A data informada deverá ser maior que a Data de Vencimento do título de cobrança Caso seja inválida ou não informada será assumida a data do vencimento. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 119, 126, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3P", "Juros de mora por dia/taxa mensal", "Valor ou porcentagem sobre o valor do título a ser cobrada de juros de mora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 141, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3P", "Código do desconto 1", "Código adotado pela FEBRABAN para identificação do tipo de desconto que deverá ser concedido. Ao se optar por valor, os três descontos devem ser expresso em valores. Idem ao se optar por percentual, os três descontos devem ser expressos em percentual. DominioCodigoDesconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 142, 142, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.3P", "Data do desconto 1", "Data limite do desconto do título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 150, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.3P", "Valor/Percentual desconto a ser concedido", "Valor ou percentual de desconto a ser concedido sobre o título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 165, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.3P", "Valor do IOF a ser recolhido", "Valor original do IOF - Imposto sobre Operações Financeiras - de um título prêmio de seguro na sua data de emissão, expresso de acordo com o tipo de moeda. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 180, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.3P", "Valor do abatimento", "Valor do abatimento (redução do valor do documento, devido a algum problema), expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 181, 195, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.3P", "Identificação do título na empresa", "Campo destinado para uso da Empresa Cedente para identificação do Título.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 196, 220, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.3P", "Código para protesto", "Código adotado pela FEBRABAN para identificar o tipo de prazo a ser considerado para o protesto. DominioCodigoProtesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 221, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.3P", "Número de dias para protesto", "Número de dias decorrentes após a data de vencimento para inicialização do processo de cobrança via protesto.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 222, 223, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.3P", "Código para baixa/devolução", "Código adotado pela FEBRABAN para identificar qual o procedimento a ser adotado com o Título. DominioCodigoBaixa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 224, 224, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.3P", "Número de dias para baixa/devolução", "Número de dias corridos após a data de vencimento de um Título não pago, que deverá ser baixado e devolvido para o Cedente. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 225, 227, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.3P", "Código da moeda", "Código adotado pela FEBRABAN para identificar a moeda referenciada no Título DominioCodigoMoeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 229, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.3P", "Número do contrato da operação de crédito", "Número adotado pela Empresa Cedente para identificação do número do contrato.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 230, 239, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.3P", "Uso livre banco/empresa ou autorizacao de pagamento parcial", "Sem ajuda", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 240, 240, 1, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoPFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
