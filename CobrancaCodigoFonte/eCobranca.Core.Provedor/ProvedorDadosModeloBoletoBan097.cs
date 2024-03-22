using System.Globalization;
using System.Linq;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan097 : ProvedorDadosModeloBoleto
{
	public override string GetMoeda()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.Moeda))
			{
				return dc.Moeda.ToEnum<EnumCodigoMoeda>().Descricao().ToUpper();
			}
			return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Descricao().ToUpper();
		}
		return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Descricao().ToUpper();
	}

	public override string GetLocalPagamento()
	{
		if (!(ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") || 1 == 0)
		{
			if (!string.IsNullOrEmpty(dc.LocalPagamento))
			{
				return StringUtil.TruncateString(dc.LocalPagamento.ToUpper(), 90);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LocalPagamento))
			{
				return StringUtil.TruncateString(carteira.ConfiguracaoBoleto.LocalPagamento.ToUpper(), 90);
			}
			return StringUtil.TruncateString($"Pagável Preferencialmente em qualquer Agência do Sistema CrediSIS.", 90);
		}
		return StringUtil.TruncateString($"Pagável Apenas nas Agências do Sistema CrediSIS", 90);
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
			string text2 = ((!string.IsNullOrEmpty(dc.CodigoMulta)) ? dc.CodigoMulta : ((!string.IsNullOrEmpty(carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? carteira.ConfiguracaoDocumentoCobranca.CodigoMulta : string.Empty));
			if (!string.IsNullOrEmpty(text2) && !text2.Equals(EnumCodigoMulta.ISENTO.ToString()) && !text2.Equals(EnumCodigoMulta.SEM_MULTA.ToString()))
			{
				double num2 = 0.0;
				num2 = ((!(dc.ValorMultaAtraso > 0.0)) ? ((!(dc.PercentualMultaAtraso > 0.0)) ? 0.0 : (num2 = dc.PercentualMultaAtraso / 100.0 * dc.ValorDocumento)) : (num2 = dc.ValorMultaAtraso));
				text = ((!flag2) ? (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de R$ " + num2.ToString("F2") + ". " + empty) : "")) : (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de  " + (num2 / dc.ValorDocumento * 100.0).ToString("F2") + "% no valor de R$ " + num2.ToString("F2") + ". " + empty) : "")));
			}
			string text3 = ((!string.IsNullOrEmpty(dc.CodigoJuros)) ? dc.CodigoJuros : ((!string.IsNullOrEmpty(carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? carteira.ConfiguracaoDocumentoCobranca.CodigoJuros : string.Empty));
			if (!string.IsNullOrEmpty(text3) && !text3.Equals(EnumCodigoJuros.ISENTO4.ToString()) && !text3.Equals(EnumCodigoJuros.ISENTO2.ToString()) && !text3.Equals(EnumCodigoJuros.ISENTO.ToString()))
			{
				double num3 = 0.0;
				if (text3.Equals(EnumCodigoJuros.VALOR_FIXO.ToString()) || text3.Equals(EnumCodigoJuros.VALOR_POR_DIA.ToString()) || text3.Equals(EnumCodigoJuros.PORCENTAGEM2.ToString()) || text3.Equals(EnumCodigoJuros.TAXA_MENSAL2.ToString()))
				{
					num3 = ((!(dc.ValorJurosDiasAtraso > 0.0)) ? ((!(dc.PercentualJurosDiaAtraso > 0.0)) ? 0.0 : (num3 = dc.PercentualJurosDiaAtraso / 100.0 * dc.ValorDocumento)) : (num3 = dc.ValorJurosDiasAtraso));
				}
				text = ((!flag2) ? (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")) : (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")));
			}
			string text4 = ((!string.IsNullOrEmpty(dc.CodigoDesconto)) ? dc.CodigoDesconto : ((!string.IsNullOrEmpty(carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto)) ? carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto : string.Empty));
			if (!string.IsNullOrEmpty(text4) && !text4.Equals(EnumCodigoDesconto.ISENTO.ToString()) && !text4.Equals(EnumCodigoDesconto.SEM_DESCONTO.ToString()) && !text4.Equals(EnumCodigoDesconto.SEM_DESCONTO2.ToString()))
			{
				double num4 = 0.0;
				num4 = ((!(dc.ValorDesconto > 0.0)) ? ((!(dc.PercentualDesconto > 0.0)) ? 0.0 : (num4 = dc.PercentualDesconto / 100.0 * dc.ValorDocumento)) : (num4 = dc.ValorDesconto));
				string text5 = (dc.DataLimiteDesconto.HasValue ? (" até " + dc.DataLimiteDesconto.Value.ToString("dd|MM|yyyy", CultureInfo.InvariantCulture) + " ") : "antes do vencimento ");
				text = ((!flag2) ? (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? string.Format("Em caso de pagamento " + text5 + " conceder R$ " + num4.ToString("F2") + " de desconto. " + empty) : "")) : (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? ("Em caso de pagamento " + text5 + " conceder " + (num4 / dc.ValorDocumento * 100.0).ToString("F2") + "% de desconto que corresponde a R$ " + num4.ToString("F2") + ". " + empty) : "")));
			}
			if (dc.GeraMensagemProtesto)
			{
				EnumCodigoProtesto value = CodigoProtestoVigente();
				if (!codigosParaNaoProtestar.Contains(value))
				{
					text += ((!dc.GeraMensagemProtesto || (dc.DiasProtesto <= 0 && carteira.ConfiguracaoDocumentoCobranca.DiasProtesto <= 0)) ? "" : ((dc.DiasProtesto <= 0) ? "" : (ProtestarEmDiasUteis(value) ? string.Format("Protestar após {0} dias úteis da data de vencimento do título. " + empty, dc.DiasProtesto) : string.Format("Protestar após {0} dias corridos da data de vencimento do título. " + empty, dc.DiasProtesto))));
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
		return StringUtil.TruncateString(text, 400);
	}
}
