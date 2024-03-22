using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheTFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalheTFebraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_T.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE T do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3T", "Agência mantenedora da conta", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 22, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3T", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 23, 23, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3T", "Número da conta corrente", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 35, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3T", "Dígito verificador da conta corrente", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 36, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3T", "Dígito verificador da Agência/Conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 37, 37, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3T", "Identificacao do título no banco (Nosso Número)", "Número adotado pelo Banco Cedente para identificar o Título. Para código de movimento igual a '01' (Entrada de Títulos), caso esteja preenchido com zeros, a numeração será feita pelo Banco.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 38, 57, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3T", "Código da carteira", "Código adotado pela FEBRABAN, para identificar a característica dos títulos dentro das modalidades de cobrança existentes no banco DominioCodigoCarteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 58, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3T", "Número do documento de cobrança", "Número adotado e controlado pelo Cliente, para identificar o título de cobrança. Informação utilizada pelos Bancos para referenciar a identificação do documento objeto de cobrança. Poderá conter número de duplicata, no caso de cobrança de duplicatas; número da apólice, no caso de cobrança de seguros, etc.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 59, 73, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3T", "Data de vencimento do título", "Data de vencimento do título de cobrança. A Vista Preencher com 11111111 Contra-apresentação Preencher com 99999999 Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 74, 81, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3T", "Valor nominal do título", "Valor original do Título. Quando o valor for expresso em moeda corrente, utilizar 2 decimais. Quando o valor for expresso em moeda variável, utilizar 5 decimais.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 82, 96, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3T", "Código do banco recebedor", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 97, 99, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3T", "Código da agência recebedora", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 100, 104, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3T", "Dígito verificado da agência recebedora", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 105, 105, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3T", "Identificação do título na empresa", "Campo destinado para uso da Empresa Cedente para identificação do Título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 130, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3T", "Código da moeda", "Código adotado pela FEBRABAN para identificar a moeda referenciada no Título DominioCodigoMoeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 131, 132, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3T", "Tipo inscrição sacado", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 133, 133, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3T", "Número inscrição do sacado", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 148, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3T", "Nome do sacado", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 149, 188, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3T", "Número do contrato", "Número adotado pela Empresa Cedente para identificação do número do contrato.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 189, 198, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3T", "Valor da tarifa/custas", "Valor da tarifa cobrada pelo serviço prestado pelo Banco Cedente referentes ao Título, expresso em moeda corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 199, 213, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3T", "Motivo da ocorrência", "Código adotado pela FEBRABAN para identificar as ocorrências (rejeições, tarifas, custas, liquidação e baixas) em registros detalhe de títulos de cobrança. Poderão ser informados até cinco ocorrências distintas, incidente sobre o título.DominioMotivoOcorrencia", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 214, 223, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3T", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 224, 240, 17, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoTFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
