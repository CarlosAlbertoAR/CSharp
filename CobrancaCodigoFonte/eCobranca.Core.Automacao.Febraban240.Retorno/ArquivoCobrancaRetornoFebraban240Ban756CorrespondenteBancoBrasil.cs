using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Retorno;

public class ArquivoCobrancaRetornoFebraban240Ban756CorrespondenteBancoBrasil : ArquivoCobrancaRetornoFebraban240
{
	public ArquivoCobrancaRetornoFebraban240Ban756CorrespondenteBancoBrasil(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
		: base(guid, tipoCarteiraCobranca, banco)
	{
	}

	public override ArrayList CarregarArquivoRetornoFebraban240()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug("Carregando arquivo de retorno...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				{
					foreach (LoteCobrancaRetornoFebraban240 lote in lotes)
					{
						foreach (SegmentoDetalheFebraban240 item in lote.SegmentosDetalhe)
						{
							if (item is SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil && (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).CodigoSegmentoDoRegistroDetalhe.Valor == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_T.Codigo())
							{
								if (!arrayList.Contains(ocorrenciaCobranca) && ocorrenciaCobranca != null)
								{
									arrayList.Add(ocorrenciaCobranca);
								}
								ocorrenciaCobranca = new OcorrenciaCobranca();
								ocorrenciaCobranca.CodigoBanco = (lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).CodigoBancoCompensacao.Valor.Trim();
								ocorrenciaCobranca.CodigoAgencia = (lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).CodigoCooperativaBeneficiario.Valor.Trim();
								ocorrenciaCobranca.NumeroContaCorrente = (lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).NumeroContaCorrente.Valor.Trim();
								ocorrenciaCobranca.Nossonumero = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).NossoNumero.Valor.Trim();
								ocorrenciaCobranca.NumeroDocumento = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).NumeroDocumento.Valor.Trim();
								ocorrenciaCobranca.IdentificacaoTituloNoCedente = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).ControleBeneficiario.Valor.Trim();
								ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).NumeroRemessa.Valor.Trim());
								ocorrenciaCobranca.CodigoMovimentoRetorno = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).CodigoOcorrencia.Valor.Trim();
								ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN756_FEBRABAN240, ocorrenciaCobranca.CodigoMovimentoRetorno);
								ocorrenciaCobranca.NumeroInscricaoSacado = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).NumeroInscricao.Valor.Trim();
								ocorrenciaCobranca.NomeSacado = (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).NomePagador.Valor.Trim();
								ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).ValorNominal.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).ValorTarifa.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.MotivosOcorrencia = ObterMotivosOcorrencia(ocorrenciaCobranca, (item as SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil).MotivosOcorrencia.Valor.Trim());
							}
							if (item is SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil && (item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).CodigoSegmentoDoRegistroDetalhe.Valor == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo())
							{
								ocorrenciaCobranca.CodigoOcorrenciaSacado = (item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).CodigoOcorrencia.Valor.Trim();
								ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataOcorrenciaSacado = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAcrescimos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorJurosMultaEncargos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorDesconto.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorAbatimento.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorIOF = 0.0;
								ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorOutrasDespesas.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorOutrosCreditos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOcorrenciaSacado = 0.0;
								ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorPago.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban756CorrespondenteBancoBrasil).ValorPago.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								if (ocorrenciaCobranca.ValorPago > 0.0)
								{
									ocorrenciaCobranca.OcorreuPagamento = true;
								}
								else
								{
									ocorrenciaCobranca.OcorreuPagamento = false;
								}
								arrayList.Add(ocorrenciaCobranca);
							}
						}
					}
					return arrayList;
				}
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCarregandoArquivoRetornoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}
}
