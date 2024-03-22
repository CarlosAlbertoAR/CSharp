using System.Globalization;
using System.Linq;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan748 : ProvedorDadosModeloBoleto
{
	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.NossoNumero))
			{
				return dc.NossoNumero.Substring(0, 2) + "/" + dc.NossoNumero.Substring(2);
			}
			return "";
		}
		return "";
	}

	public override string GetAgenciaCodigoCedente()
	{
		if (((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor == null || ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor == null)
		{
			return "";
		}
		return ((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor + "." + ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor;
	}

	public override string GetInstrucoesCaixa()
	{
		string empty = string.Empty;
		empty = "\n";
		string text = "";
		bool flag = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		int num = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_QUEBRAR_LINHAS_MENSAGENS_AUTOMATICAS, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.QuebrarLinhasMensagensAutomaticas(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? 1 : 0);
		bool flag2 = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_MENSAGEM_HIBRIDA_JUROS_MULTA_DESCONTO, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibeMensagemHibridaDeJurosMultaDesconto(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		bool flag3 = ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_EM_CAIXA_ALTA, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibeConteudoCampoInstrucoesEmCaixaAlta(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") ? true : false);
		if (num == 0)
		{
			empty = " ";
		}
		text += (flag ? string.Format("Pagável somente no {0}." + empty, carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Descricao()) : "");
		if (dc != null)
		{
			double num2 = 0.0;
			num2 = ((!(dc.ValorMultaAtraso > 0.0)) ? ((!(dc.PercentualMultaAtraso > 0.0)) ? 0.0 : (num2 = dc.PercentualMultaAtraso / 100.0 * dc.ValorDocumento)) : (num2 = dc.ValorMultaAtraso));
			text = ((!flag2) ? (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de R$ " + num2.ToString("F2") + "." + empty) : "")) : (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de  " + (num2 / dc.ValorDocumento * 100.0).ToString("F2") + "% no valor de R$ " + num2.ToString("F2") + "." + empty) : "")));
			double num3 = 0.0;
			num3 = ((!(dc.ValorJurosDiasAtraso > 0.0)) ? ((!(dc.PercentualJurosDiaAtraso > 0.0)) ? 0.0 : (num3 = dc.PercentualJurosDiaAtraso / 100.0 * dc.ValorDocumento)) : (num3 = dc.ValorJurosDiasAtraso));
			text = ((!flag2) ? (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")) : (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")));
			double num4 = 0.0;
			num4 = ((!(dc.ValorDesconto > 0.0)) ? ((!(dc.PercentualDesconto > 0.0)) ? 0.0 : (num4 = dc.PercentualDesconto / 100.0 * dc.ValorDocumento)) : (num4 = dc.ValorDesconto));
			string text2 = (dc.DataLimiteDesconto.HasValue ? (" até " + dc.DataLimiteDesconto.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " ") : "antes do vencimento ");
			text = ((!flag2) ? (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? string.Format("Em caso de pagamento " + text2 + " conceder R$ " + num4.ToString("F2") + " de desconto. " + empty) : "")) : (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? ("Em caso de pagamento " + text2 + " conceder " + (num4 / dc.ValorDocumento * 100.0).ToString("F2") + "% de desconto que corresponde a R$ " + num4.ToString("F2") + ". " + empty) : "")));
			if (dc.GeraMensagemProtesto)
			{
				EnumCodigoProtesto value = CodigoProtestoVigente();
				if (!codigosParaNaoProtestar.Contains(value))
				{
					text += ((!dc.GeraMensagemProtesto || dc.DiasProtesto <= 0) ? "" : (ProtestarEmDiasUteis(value) ? string.Format("Protestar após {0} dias úteis da data de vencimento do título. " + empty, GetDiasProtesto(value)) : string.Format("Protestar após {0} dias corridos da data de vencimento do título. " + empty, GetDiasProtesto(value))));
				}
			}
			string empty2 = string.Empty;
			empty2 = dc.InstrucaoCaixa;
			text += empty2;
			if (flag3)
			{
				text = text.ToUpper();
			}
		}
		return text;
	}

	protected override bool ProtestarEmDiasUteis(EnumCodigoProtesto? codigoProtesto)
	{
		bool result = true;
		if (!codigoProtesto.HasValue)
		{
			codigoProtesto = CodigoProtestoVigente();
		}
		switch (codigoProtesto)
		{
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS:
			result = false;
			break;
		case EnumCodigoProtesto.PROTESTO_NORMAL:
			result = dc.DiasProtesto < 5;
			break;
		}
		return result;
	}

	private int GetDiasProtesto(EnumCodigoProtesto? codigoProtesto)
	{
		int result = dc.DiasProtesto;
		if (!codigoProtesto.HasValue)
		{
			codigoProtesto = CodigoProtestoVigente();
		}
		switch (codigoProtesto)
		{
		case EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS:
			result = dc.DiasProtesto;
			break;
		case EnumCodigoProtesto.PROTESTO_NORMAL:
			result = ((dc.DiasProtesto < 4) ? 3 : ((dc.DiasProtesto < 5) ? 4 : ((dc.DiasProtesto < 99) ? dc.DiasProtesto : 99)));
			break;
		}
		return result;
	}
}
