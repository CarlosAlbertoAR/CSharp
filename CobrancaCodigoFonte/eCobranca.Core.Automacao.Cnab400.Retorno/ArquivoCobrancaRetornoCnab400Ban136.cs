using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban136;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban136 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban136(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
		header = new HeaderRetornoCnab400Ban136();
		trailler = new TraillerRetornoCnab400Ban136();
	}

	public override ArrayList CarregarArquivoRetornoCnab400()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug($"Carregando arquivo de retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				if (base.Lote != null)
				{
					foreach (RegistroTipo1RetornoCnab400Ban136 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban136).SequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoOcorrencia.Valor.Trim();
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN136_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((header as HeaderRetornoCnab400Ban136).DataGeracao.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban136).IdentificacaoBanco.Valor.Substring(0, 3);
						ocorrenciaCobranca.CodigoAgencia = item.CodigoAgenciaRecebedora.Valor;
						ocorrenciaCobranca.NumeroContaCorrente = item.ContaCorrente.Valor + item.DigitoContaCorrente.Valor;
						ocorrenciaCobranca.Nossonumero = item.NossoNumero.Valor.Trim();
						ocorrenciaCobranca.NumeroDocumento = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorNominal.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack(item.ValorTarifa.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.ValorJuros.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack(item.ValorPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack(item.ValorLiquido.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack(item.DataRepasse.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, item.MotivoOcorrencia.Valor.Trim());
						ocorrenciaCobranca.ValorOutrosCreditos = 0.0;
						ocorrenciaCobranca.ValorAcrescimos = 0.0;
						ocorrenciaCobranca.ValorOutrasDespesas = 0.0;
						if (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN136_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno) == EnumCodigoMovimentoRetorno.LIQUIDACAO)
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

	private ArrayList CarregarMotivosOcorrencia(OcorrenciaCobranca ocorrencia, string motivos)
	{
		ArrayList arrayList = new ArrayList();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		while (motivos.Length >= 2)
		{
			motivos.Substring(0, 2);
			MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(EnumChaveContexto.BAN136_CNAB400, ocorrencia.CodigoMovimentoRetorno, motivos.Substring(0, 2));
			if (motivoOcorrencia != null && !dictionary.ContainsKey(motivoOcorrencia.Codigo))
			{
				dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
				arrayList.Add(motivoOcorrencia);
			}
			if (motivos.Length >= 2)
			{
				motivos = motivos.Substring(2);
			}
		}
		return arrayList;
	}
}
