using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Retorno;

public class ArquivoCobrancaRetornoFebraban240Ban085 : ArquivoCobrancaRetornoFebraban240
{
	public ArquivoCobrancaRetornoFebraban240Ban085(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
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
								ocorrenciaCobranca.CodigoBanco = (headerArquivo as HeaderArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor.Trim();
								ocorrenciaCobranca.CodigoAgencia = (headerArquivo as HeaderArquivoFebraban240Padrao).CodigoAgencia.Valor.Trim() + (headerArquivo as HeaderArquivoFebraban240Padrao).DVAgencia.Valor.Trim();
								ocorrenciaCobranca.NumeroContaCorrente = (headerArquivo as HeaderArquivoFebraban240Padrao).NumeroContaCorrente.Valor.Trim() + (headerArquivo as HeaderArquivoFebraban240Padrao).DVContaCorrente.Valor.Trim();
								ocorrenciaCobranca.Nossonumero = (item as SegmentoDetalheTFebraban240Padrao).IdentificacaoTituloNoBanco.Valor.Trim();
								ocorrenciaCobranca.NumeroDocumento = (item as SegmentoDetalheTFebraban240Padrao).NumeroDocumentoCobranca.Valor.Trim();
								ocorrenciaCobranca.IdentificacaoTituloNoCedente = (item as SegmentoDetalheTFebraban240Padrao).IdentificacaoTituloNaEmpresa.Valor.Trim();
								ocorrenciaCobranca.NumeroSequencialRetorno = headerArquivo.GetNumeroSequencialArquivo();
								ocorrenciaCobranca.CodigoMovimentoRetorno = (item as SegmentoDetalheTFebraban240Padrao).CodigoMovimento.Valor.Trim();
								ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN001_FEBRABAN240, ocorrenciaCobranca.CodigoMovimentoRetorno);
								ocorrenciaCobranca.NumeroInscricaoSacado = (item as SegmentoDetalheTFebraban240Padrao).NumeroInscricaoSacado.Valor.Trim();
								ocorrenciaCobranca.NomeSacado = (item as SegmentoDetalheTFebraban240Padrao).NomeSacado.Valor.Trim();
								ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Padrao).DataVencimentoTitulo.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Padrao).ValorNominalTitulo.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheTFebraban240Padrao).ValorTarifaCustas.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.MotivosOcorrencia = ObterMotivosOcorrencia(ocorrenciaCobranca, (item as SegmentoDetalheTFebraban240Padrao).MotivoOcorrencia.Valor.Trim());
							}
							if (item.CodigoSegmentoRegistroDetalhe.Valor == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo())
							{
								ocorrenciaCobranca.CodigoOcorrenciaSacado = (item as SegmentoDetalheUFebraban240Padrao).CodigoOcorrenciaSacado.Valor.Trim();
								ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).DataEfetivacaoCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataOcorrenciaSacado = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).DataOcorrenciaSacado.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAcrescimos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorAcrescimos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorDesconto.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorAbatimento.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorIOF = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorIOF.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorOutrasDespesas.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorOutrosCreditos.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorOcorrenciaSacado = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorOcorrenciaSacado.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorPago.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheUFebraban240Padrao).ValorLiquido.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
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
