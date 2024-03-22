using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban004;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class ArquivoCobrancaRetornoCnab400Ban004 : ArquivoCobrancaRetornoCnab400
{
	public ArquivoCobrancaRetornoCnab400Ban004(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		Logger.Debug($"Criando arquivo de cobrança de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
		header = new HeaderRetornoCnab400Ban004();
		trailler = new TraillerRetornoCnab400Ban004();
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
					foreach (DetalheRetornoCnab400Ban004 item in base.Lote.SegmentosDetalhe)
					{
						ocorrenciaCobranca = new OcorrenciaCobranca();
						ocorrenciaCobranca.NumeroSequencialRetorno = int.Parse((header as HeaderRetornoCnab400Ban004).SequencialRetorno.Valor.Trim());
						ocorrenciaCobranca.CodigoMovimentoRetorno = item.CodigoOcorrencia.Valor.Trim();
						ocorrenciaCobranca.DescricaoMovimentoRetorno = RepositorioDetalhesOcorrencia.GetInstance().GetDescricaoOcorrencia(EnumChaveContexto.BAN004_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno);
						ocorrenciaCobranca.CodigoBanco = (header as HeaderRetornoCnab400Ban004).NumeroBanco.Valor.Substring(0, 3);
						ocorrenciaCobranca.CodigoAgencia = item.AgenciaBeneficiario.Valor.Trim();
						ocorrenciaCobranca.NumeroContaCorrente = item.ContaCorrenteBeneficiario.Valor.Trim() + item.DigitoContaCorrenteBeneficiario.Valor.Trim();
						ocorrenciaCobranca.Nossonumero = item.NossoNumero.Valor.Trim() + item.DigitoNossoNumero.Valor.Trim();
						ocorrenciaCobranca.NumeroDocumento = item.SeuNumero.Valor.Trim();
						ocorrenciaCobranca.IdentificacaoTituloNoCedente = item.NumeroControle.Valor.Trim();
						ocorrenciaCobranca.DataVencimento = (DateTime?)dateToStringConverter.ConvertBack(item.DataVencimento.Valor.Trim(), typeof(DateTime), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorNominal = (double)doubleToStringConverter.ConvertBack(item.ValorTitulo.Valor, typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack(item.Tarifa.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((header as HeaderRetornoCnab400Ban004).DataCredito.Valor.Trim(), typeof(DateTime?), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorDesconto = (double)doubleToStringConverter.ConvertBack(item.DescontoConcedido.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorAbatimento = (double)doubleToStringConverter.ConvertBack(item.AbatimentoConcedido.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorIOF = 0.0;
						ocorrenciaCobranca.ValorOutrasDespesas = (double)doubleToStringConverter.ConvertBack(item.Outras.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorOutrosCreditos = 0.0;
						ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack(item.ValorRecebido.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.ValorLiquido -= ocorrenciaCobranca.ValorTarifa;
						ocorrenciaCobranca.ValorJuros = (double)doubleToStringConverter.ConvertBack(item.JurosMora.Valor.Trim(), typeof(double), "F2", CultureInfo.CurrentCulture);
						ocorrenciaCobranca.MotivosOcorrencia = CarregarMotivosOcorrencia(ocorrenciaCobranca, item.TabelaErros.Valor.Trim());
						ocorrenciaCobranca.ValorAcrescimos = 0.0;
						ocorrenciaCobranca.ValorPago = ocorrenciaCobranca.ValorNominal + ocorrenciaCobranca.ValorJuros + ocorrenciaCobranca.ValorOutrosCreditos - ocorrenciaCobranca.ValorMulta - ocorrenciaCobranca.ValorDesconto - ocorrenciaCobranca.ValorAbatimento - ocorrenciaCobranca.ValorOutrasDespesas;
						switch (RepositorioDetalhesOcorrencia.GetInstance().GetCodigoMovimentoRetorno(EnumChaveContexto.BAN004_CNAB400, ocorrenciaCobranca.CodigoMovimentoRetorno))
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
		for (int i = 0; i < motivos.Length; i++)
		{
			if (motivos[i] == '1')
			{
				MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(EnumChaveContexto.BAN004_CNAB400, EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2.Codigo(), StringUtil.ZerosLeft(Convert.ToString(i + 1), 2));
				if (motivoOcorrencia != null && !dictionary.ContainsKey(motivoOcorrencia.Codigo))
				{
					dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
					arrayList.Add(motivoOcorrencia);
				}
			}
		}
		return arrayList;
	}
}
