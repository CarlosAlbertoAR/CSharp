using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheRFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalheRFebraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_R.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE R do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3R", "Código do desconto 2", "Código adotado pela FEBRABAN para identificação do tipo de desconto que deverá ser concedido. Ao se optar por valor, os três descontos devem ser expresso em valores. Idem ao se optar por percentual, os três descontos devem ser expressos em percentual. DominioCodigoDesconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3R", "Data do desconto 2", "Data limite do desconto do título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 26, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3R", "Valor/percentual de desconto 2 a ser concedido", "Valor ou percentual de desconto a ser concedido sobre o título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 41, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3R", "Código do desconto 3", "Código adotado pela FEBRABAN para identificação do tipo de desconto que deverá ser concedido. Ao se optar por valor, os três descontos devem ser expresso em valores. Idem ao se optar por percentual, os três descontos devem ser expressos em percentual. DominioCodigoDesconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 42, 42, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3R", "Data do desconto 3", "Data limite do desconto do título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 43, 50, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3R", "Valor/percentual de desconto 3 a ser concedido", "Valor ou percentual de desconto a ser concedido sobre o título de cobrança.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 51, 65, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3R", "Código da multa", "Código adotado pela FEBRABAN para identificação do critério de pagamento de pena pecuniária, a ser aplicada pelo atraso do pagamento do Título. DominioCodigoMulta", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 66, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3R", "Data da multa", "Data a partir da qual a multa deverá ser cobrada. Na ausência, será considerada a data de vencimento. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 67, 74, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3R", "Valor/percentual de multa a ser aplicado", "Valor ou percentual de multa a ser aplicado sobre o valor do Título, por atraso no pagamento.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 89, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3R", "Informação ao sacado", "Texto de observações destinado ao envio de informações do Cedente ao Sacado. Este campo só poderá ser utilizado, caso haja troca de arquivos magnéticos entre o Banco e o Sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 90, 99, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3R", "Mensagem 3", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 100, 139, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3R", "Mensagem 4", "Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do bloqueto. As Mensagens 3 e 4 prevalecem sobre as mensagens 1 e 2, bem como as mensagens 5 à 9 prevalecem sobre as anteriores.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 140, 179, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3R", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 180, 199, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3R", "Código de ocorrência do sacado", "Código adotado pela FEBRABAN para identificar a ocorrência do sacado (Descrição A001) a(s) qual(is) o cedente não concorda. Somente será utilizado para o Código de Movimento '30' (Descrição C004).", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 200, 207, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3R", "Código do banco na conta do débito", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 208, 210, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3R", "Código da agência do débito", "Código adotado pelo Banco responsável pela cobrança, para identificar o estabelecimento bancário responsável pela cobrança do título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 211, 215, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3R", "Dígito verificador da agência do débito", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 216, 216, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3R", "Conta corrente para débito", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 217, 228, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3R", "Dígito verificador da conta para débito", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 229, 229, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3R", "Dígito verificador agência/conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 230, 230, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3R", "Aviso para débito automático", "Código adotado pela FEBRABAN para identificação da emissão do aviso de débito automático em conta corrente. DominioAvisoDebitoAutomatico", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 231, 231, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3R", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 232, 240, 9, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoRFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
