using System.Globalization;
using System.Text;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan084 : ProvedorDadosModeloBoleto
{
	private const string USO_DO_BANCO = "00018";

	public override string GetMoeda()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.Moeda))
			{
				return dc.Moeda.ToEnum<EnumCodigoMoeda>().Sigla().ToUpper();
			}
			return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Sigla().ToUpper();
		}
		return carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Sigla().ToUpper();
	}

	public override string GetLocalPagamento()
	{
		if (!string.IsNullOrEmpty(dc.LocalPagamento))
		{
			return StringUtil.TruncateString(dc.LocalPagamento.ToUpper(), 90);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LocalPagamento))
		{
			return StringUtil.TruncateString(carteira.ConfiguracaoBoleto.LocalPagamento.ToUpper(), 90);
		}
		return StringUtil.TruncateString($"PAGÁVEL EM QUALQUER BANCO ATÉ O VENCIMENTO.", 90);
	}

	public override string GetCodigoUsoBanco()
	{
		return "00018";
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
			text = ((!flag2) ? (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de R$ " + num2.ToString("F2") + ". " + empty) : "")) : (text + ((num2 > 0.0 && dc.GeraMensagemMulta) ? ("Após vencimento cobrar multa de  " + (num2 / dc.ValorDocumento * 100.0).ToString("F2") + "% no valor de R$ " + num2.ToString("F2") + ". " + empty) : "")));
			double num3 = 0.0;
			num3 = ((!(dc.ValorJurosDiasAtraso > 0.0)) ? ((!(dc.PercentualJurosDiaAtraso > 0.0)) ? 0.0 : (num3 = dc.PercentualJurosDiaAtraso / 100.0 * dc.ValorDocumento)) : (num3 = dc.ValorJurosDiasAtraso));
			text = ((!flag2) ? (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")) : (text + ((num3 > 0.0 && dc.GeraMensagemJuros) ? ("Após vencimento cobrar juros de mora ao dia de R$ " + num3.ToString("F2") + ". " + empty) : "")));
			double num4 = 0.0;
			num4 = ((!(dc.ValorDesconto > 0.0)) ? ((!(dc.PercentualDesconto > 0.0)) ? 0.0 : (num4 = dc.PercentualDesconto / 100.0 * dc.ValorDocumento)) : (num4 = dc.ValorDesconto));
			string text2 = (dc.DataLimiteDesconto.HasValue ? (" até " + dc.DataLimiteDesconto.Value.ToString("dd|MM|yyyy", CultureInfo.InvariantCulture) + " ") : "antes do vencimento ");
			text = ((!flag2) ? (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? string.Format("Em caso de pagamento " + text2 + " conceder R$ " + num4.ToString("F2") + " de desconto. " + empty) : "")) : (text + ((num4 > 0.0 && dc.GeraMensagemDesconto) ? ("Em caso de pagamento " + text2 + " conceder " + (num4 / dc.ValorDocumento * 100.0).ToString("F2") + "% de desconto que corresponde a R$ " + num4.ToString("F2") + ". " + empty) : "")));
			if (dc.GeraMensagemProtesto)
			{
				string text3 = string.Empty;
				int num5 = 0;
				if ((string.IsNullOrEmpty(dc.CodigoProtesto) ? ((EnumCodigoProtesto)(object)carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>()) : ((EnumCodigoProtesto)(object)dc.CodigoProtesto.ToEnum<EnumCodigoProtesto>())) != EnumCodigoProtesto.NAO_PROTESTAR2 && carteira.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.Equals(EnumLayoutArquivoRemessa.CNAB400.ToString()))
				{
					num5 = GetDiasCorridosProtesto(dc);
					text3 = string.Format("Protestar após {0} dias corridos da data de vencimento do título. " + empty, num5);
				}
				if (!text3.Equals(string.Empty))
				{
					text += text3;
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

	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.IsNullOrEmpty(StringUtil.ZerosLeft(carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca, 3)) ? "" : StringUtil.ZerosLeft(carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca, 3));
			stringBuilder.Append("/");
			stringBuilder.Append(string.IsNullOrEmpty(dc.NossoNumero) ? "" : dc.NossoNumero);
			return stringBuilder.ToString();
		}
		return "";
	}

	private int GetDiasCorridosProtesto(DocumentoCobranca dc)
	{
		int num = dc.DiasProtesto;
		if (num < 3)
		{
			num = 3;
		}
		if (num > 55)
		{
			num = 55;
		}
		return num;
	}
}
