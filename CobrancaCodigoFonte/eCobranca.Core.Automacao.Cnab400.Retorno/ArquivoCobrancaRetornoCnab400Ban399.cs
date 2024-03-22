using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban399 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban399(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
		header = new HeaderRetornoCnab400Ban399();
		trailler = new TraillerRetornoCnab400Ban399();
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
					foreach (DetalheRetornoCnab400Ban399 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban399).NumeroSequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoOcorrencia.Valor.Trim();
						ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack(item.DataOcorrencia.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN399_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban399).CodigoBanco.Valor;
						ocorrenciaCobranca.CodigoAgencia = (header as HeaderRetornoCnab400Ban399).AgenciaBeneficiario.Valor.Trim();
						ocorrenciaCobranca.NumeroContaCorrente = (header as HeaderRetornoCnab400Ban399).NumeroContaCorrenteBeneficiario.Valor.Substring(4);
						ocorrenciaCobranca.Nossonumero = item.NossoNumero.Valor.Trim();
						ocorrenciaCobranca.NumeroDocumento = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.NumeroControleParticipante.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorNominal, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack(item.ValorTarifa.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAcrescimos = 0.0;
						ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack(item.ValorPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.ValorJurosDeMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, item.ComplementoOcorrencia.Valor.Trim());
						switch (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN399_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno))
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
			MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(EnumChaveContexto.BAN399_CNAB400, ocorrencia.CodigoMovimentoRetorno, motivos.Substring(0, 2));
			if (motivoOcorrencia != null)
			{
				if (!dictionary.ContainsKey(motivoOcorrencia.Codigo))
				{
					dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
					arrayList.Add(motivoOcorrencia);
				}
				if (motivos.Length >= 2)
				{
					motivos = motivos.Substring(2);
				}
			}
		}
		return arrayList;
	}
}
