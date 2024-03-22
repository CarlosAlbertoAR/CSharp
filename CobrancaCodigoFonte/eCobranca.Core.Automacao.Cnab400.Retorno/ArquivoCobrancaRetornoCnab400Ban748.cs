using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban748 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban748(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
		header = new HeaderRetornoCnab400Ban748();
		trailler = new TraillerRetornoCnab400Ban748();
	}

	public override ArrayList CarregarArquivoRetornoCnab400()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug($"Carregando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				if (base.Lote != null)
				{
					foreach (DetalheRetornoCnab400 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban748).NumeroSequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban748).CodigoBanco.Valor.Substring(0, 3);
						if (item is RegistroTipo1RetornoCnab400Ban748)
						{
							ocorrenciaCobranca.CodigoMovimentoRetorno = (item as RegistroTipo1RetornoCnab400Ban748).CodigoOcorrencia.Valor.Trim();
							ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN748_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
							ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
							ocorrenciaCobranca.Nossonumero = (item as RegistroTipo1RetornoCnab400Ban748).NossoNumero.Valor.Trim();
							ocorrenciaCobranca.NumeroDocumento = (item as RegistroTipo1RetornoCnab400Ban748).SeuNumero.Valor.Trim();
							ocorrenciaCobranca.IdentificacaoTituloNoCedente = string.Empty;
							ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorTitulo.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorDespesasCobranca.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).DataPrevistaCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.AAAAMMDD, CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorDespesasCustasProtesto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorJurosDeMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorMulta = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorMulta.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorAcrescimos = 0.0;
							ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1RetornoCnab400Ban748).ValorPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.OcorrenciaRegistradaBancoSicredi = true;
							ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, (item as RegistroTipo1RetornoCnab400Ban748).MotivosOcorrencia.Valor.Trim());
						}
						else if (item is RegistroTipo1SemRegistroRetornoCnab400Ban748)
						{
							ocorrenciaCobranca.CodigoMovimentoRetorno = (item as RegistroTipo1SemRegistroRetornoCnab400Ban748).CodigoOcorrencia.Valor.Trim();
							ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN748_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
							ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
							ocorrenciaCobranca.Nossonumero = (item as RegistroTipo1SemRegistroRetornoCnab400Ban748).NossoNumero.Valor.Trim();
							ocorrenciaCobranca.NumeroDocumento = (item as RegistroTipo1SemRegistroRetornoCnab400Ban748).SeuNumero.Valor.Trim();
							ocorrenciaCobranca.IdentificacaoTituloNoCedente = string.Empty;
							ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorTitulo.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).DataPrevistaCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.AAAAMMDD, CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorJurosDeMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorMulta = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorMulta.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.ValorAcrescimos = 0.0;
							ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as RegistroTipo1SemRegistroRetornoCnab400Ban748).ValorPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
							ocorrenciaCobranca.OcorrenciaRegistradaBancoSicredi = false;
							ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, (item as RegistroTipo1SemRegistroRetornoCnab400Ban748).MotivosOcorrencia.Valor.Trim());
						}
						switch (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN748_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno))
						{
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO:
						case EnumCodigoMovimentoRetorno.LIQUIDADO_EM_CARTORIO:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO2:
						case EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3:
							ocorrenciaCobranca.OcorreuPagamento = true;
							break;
						default:
							ocorrenciaCobranca.OcorreuPagamento = false;
							ocorrenciaCobranca.ValorPago = 0.0;
							break;
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
			if (motivos.Substring(0, 2) != "00")
			{
				MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(EnumChaveContexto.BAN748_CNAB400, ocorrencia.CodigoMovimentoRetorno, motivos.Substring(0, 2));
				if (motivoOcorrencia != null && !dictionary.ContainsKey(motivoOcorrencia.Codigo))
				{
					dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
					arrayList.Add(motivoOcorrencia);
				}
			}
			if (motivos.Length >= 2)
			{
				motivos = motivos.Substring(2);
			}
		}
		return arrayList;
	}
}
