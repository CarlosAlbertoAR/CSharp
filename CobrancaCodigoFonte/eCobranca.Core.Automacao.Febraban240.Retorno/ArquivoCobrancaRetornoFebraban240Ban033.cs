using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Retorno;

public class ArquivoCobrancaRetornoFebraban240Ban033 : ArquivoCobrancaRetornoFebraban240
{
	public ArquivoCobrancaRetornoFebraban240Ban033(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
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
							if (item.CodigoSegmentoRegistroDetalhe.Valor == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_T.Codigo())
							{
								if (!arrayList.Contains(ocorrenciaCobranca) && ocorrenciaCobranca != null)
								{
									arrayList.Add(ocorrenciaCobranca);
								}
								ocorrenciaCobranca = new OcorrenciaCobranca();
								ocorrenciaCobranca.CodigoBanco = (headerArquivo as HeaderArquivoRetornoFebraban240Ban033).CodigoBancoCompensacao.Valor.Trim();
								ocorrenciaCobranca.CodigoAgencia = (lote.HeaderLote as HeaderLoteRetornoFebraban240Ban033).AgenciaBeneficiario.Valor.Trim() + (lote.HeaderLote as HeaderLoteRetornoFebraban240Ban033).DVAgenciaBeneficiario.Valor.Trim();
								ocorrenciaCobranca.NumeroContaCorrente = (lote.HeaderLote as HeaderLoteRetornoFebraban240Ban033).NumeroContaCorrenteBeneficiario.Valor.Trim() + (lote.HeaderLote as HeaderLoteRetornoFebraban240Ban033).DvContaCorrenteBeneficiario.Valor.Trim();
								ocorrenciaCobranca.Nossonumero = (item as SegmentoDetalheTFebraban240Ban033).NossoNumero.Valor.Trim();
								ocorrenciaCobranca.NumeroDocumento = (item as SegmentoDetalheTFebraban240Ban033).NumeroDocumentoCobranca.Valor.Trim();
								ocorrenciaCobranca.IdentificacaoTituloNoCedente = (item as SegmentoDetalheTFebraban240Ban033).IdentificacaoTituloBeneficiario.Valor.Trim();
								ocorrenciaCobranca.NumeroSequencialRetorno = headerArquivo.GetNumeroSequencialArquivo();
								ocorrenciaCobranca.CodigoMovimentoRetorno = (item as SegmentoDetalheTFebraban240Ban033).CodigoOcorrencia.Valor.Trim();
								ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN033_FEBRABAN240, ocorrenciaCobranca.CodigoMovimentoRetorno);
								ocorrenciaCobranca.NumeroInscricaoSacado = (item as SegmentoDetalheTFebraban240Ban033).NumeroInscricaoPagador.Valor.Trim();
								ocorrenciaCobranca.NomeSacado = (item as SegmentoDetalheTFebraban240Ban033).NomePagador.Valor.Trim();
								ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban033).DataVencimentoTitulo.Valor.Trim(), typeof(DateTime), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban033).ValorNominalTitulo.Valor.Trim(), typeof(double), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Ban033).ValorTarifa.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.MotivosOcorrencia = ObterMotivosOcorrencia(ocorrenciaCobranca, (item as SegmentoDetalheTFebraban240Ban033).MotivosOcorrencia.Valor.Trim());
							}
							if (item.CodigoSegmentoRegistroDetalhe.Valor == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo())
							{
								ocorrenciaCobranca.CodigoOcorrenciaSacado = (item as SegmentoDetalheUFebraban240Ban033).CodigoOcorrenciaPagador.Valor.Trim();
								ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataOcorrenciaSacado = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).DataOcorrenciaPagador.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAcrescimos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorJurosMultaEncargos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorDesconto.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorAbatimento.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorIOF = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorIOF.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorOutrasDespesas.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorOutrosCreditos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOcorrenciaSacado = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorOcorrenciaPagador.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorPago.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Ban033).ValorLiquido.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
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
