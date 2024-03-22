using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban097 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban097(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
		header = new HeaderRetornoCnab400Ban097();
		trailler = new TraillerRetornoCnab400Ban097();
	}

	public override ArrayList CarregarArquivoRetornoCnab400()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug("Carregando arquivo de retorno...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				if (base.Lote != null)
				{
					foreach (DetalheRetornoCnab400Ban097 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban097).SequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoTipoLancamento.Valor.Trim();
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN097_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban097).IdentificacaoBanco.Valor.Substring(0, 3);
						ocorrenciaCobranca.CodigoAgencia = item.CodigoAgenciaBeneficiario.Valor.Trim();
						ocorrenciaCobranca.NumeroContaCorrente = item.ContaCorrenteBeneficiario.Valor.Trim() + item.DVContaCorrenteBeneficiario.Valor.Trim();
						ocorrenciaCobranca.Nossonumero = item.NossoNumero.Valor.Trim();
						ocorrenciaCobranca.NumeroDocumento = item.NumeroControleBeneficiario.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.NumeroControleBeneficiario.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorNominal, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack(item.DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack(item.OutrosRecebimentos.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAcrescimos = 0.0;
						ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack(item.ValorRecebido.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack(item.ValorLancamento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.JurosDeMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.NumeroInscricaoSacado = item.NumeroInscricaoSacado.Valor.Trim();
						EnumCodigoMovimentoRetorno codigoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN097_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						if (codigoMovimentoRetorno == EnumCodigoMovimentoRetorno.BAIXA_NO_BANCO || codigoMovimentoRetorno == EnumCodigoMovimentoRetorno.BAIXA_NO_ESTABELECIMENTO)
						{
							ocorrenciaCobranca.OcorreuPagamento = true;
						}
						else
						{
							ocorrenciaCobranca.OcorreuPagamento = false;
							ocorrenciaCobranca.ValorPago = 0.0;
						}
						arrayList.Add(ocorrenciaCobranca);
					}
					return arrayList;
				}
				return arrayList;
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return arrayList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCarregandoArquivoRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}
}
