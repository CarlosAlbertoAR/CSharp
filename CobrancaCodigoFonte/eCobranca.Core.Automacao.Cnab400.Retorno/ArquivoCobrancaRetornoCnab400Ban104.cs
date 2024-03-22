using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban104 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban104(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
		header = new HeaderRetornoCnab400Ban104();
		trailler = new TraillerRetornoCnab400Ban104();
	}

	public override ArrayList CarregarArquivoRetornoCnab400()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (base.TotalRegistros > 0)
			{
				Logger.Debug($"Carregando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				if (base.Lote != null)
				{
					foreach (DetalheRetornoCnab400Ban104 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban104).NumeroSequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoOcorrencia.Valor.Trim();
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN104_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.DataOcorrencia = (DateTime?)dateToStringConverter.ConvertBack(item.DataOcorrencia.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban104).CodigoBanco.Valor.Substring(0, 3);
						ocorrenciaCobranca.CodigoAgencia = item.CodigoAgenciaBeneficiario.Valor.Trim();
						ocorrenciaCobranca.NumeroContaCorrente = item.CodigoBeneficiario.Valor.Trim();
						ocorrenciaCobranca.Nossonumero = item.Modalidade.Valor + item.NossoNumero.Valor;
						ocorrenciaCobranca.NumeroDocumento = item.NumeroDocumento.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.IdentificacaoTituloBeneficiario.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorNominal.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack(item.ValorTarifa.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack(item.DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.ValorDesconto.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.ValorAbatimento.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorIOF = (double)doubleToStringConverter.ConvertBack(item.ValorIOF.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack("0", typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrosCreditos = (double)doubleToStringConverter.ConvertBack("0", typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAcrescimos = 0.0;
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.ValorJuros.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorMulta = (double)doubleToStringConverter.ConvertBack(item.ValorMulta.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack(item.ValorPrincipalPago.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.NomeSacado = "";
						ocorrenciaCobranca.ValorLiquido = ocorrenciaCobranca.ValorPago - ocorrenciaCobranca.ValorTarifa;
						if (ocorrenciaCobranca.ValorPago > 0.0)
						{
							ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, item.CodigoLiquidacaoBaixa.Valor.Trim(), 3);
						}
						else
						{
							ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, item.CodigoMotivoRejeicao.Valor.Trim(), 2);
						}
						switch (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN104_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno))
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

	private ArrayList CarregarMotivosOcorrencia(OcorrenciaCobranca ocorrencia, string motivos, int tamanhoCodigo)
	{
		ArrayList arrayList = new ArrayList();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		while (motivos.Length >= tamanhoCodigo)
		{
			MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(EnumChaveContexto.BAN104_CNAB400, ocorrencia.CodigoMovimentoRetorno, motivos.Substring(0, tamanhoCodigo));
			if (motivoOcorrencia != null && !dictionary.ContainsKey(motivoOcorrencia.Codigo))
			{
				dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
				arrayList.Add(motivoOcorrencia);
			}
			if (motivos.Length >= tamanhoCodigo)
			{
				motivos = motivos.Substring(tamanhoCodigo);
			}
		}
		return arrayList;
	}
}
