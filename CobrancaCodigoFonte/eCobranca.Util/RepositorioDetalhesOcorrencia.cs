using System;
using System.Collections.Generic;
using System.Linq;
using eCobranca.Atributos;
using eCobranca.Core;
using eCobranca.Enumerator;

namespace eCobranca.Util;

public class RepositorioDetalhesOcorrencia
{
	private const string OCORRENCIA_NAO_ENCONTRADA = "Descrição da ocorrência não encontrada";

	private const string MOTIVO_OCORRENCIA_NAO_ENCONTRADO = "Descrição do motivo da ocorrência não encontrada";

	private static RepositorioDetalhesOcorrencia uniqueInstance;

	private static object semaforo = new object();

	private Dictionary<ChaveMultipla, MotivoOcorrenciaCobranca> dicionarioMotivosOcorrencia;

	private Dictionary<ChaveMultipla, string> dicionarioDescricaoOcorrencias;

	private Dictionary<ChaveMultipla, EnumCodigoMovimentoRetorno> dicionarioCodigoMovimentoRetorno;

	private RepositorioDetalhesOcorrencia()
	{
		dicionarioMotivosOcorrencia = new Dictionary<ChaveMultipla, MotivoOcorrenciaCobranca>();
		dicionarioDescricaoOcorrencias = new Dictionary<ChaveMultipla, string>();
		dicionarioCodigoMovimentoRetorno = new Dictionary<ChaveMultipla, EnumCodigoMovimentoRetorno>();
	}

	public static RepositorioDetalhesOcorrencia GetInstance()
	{
		if (uniqueInstance == null)
		{
			lock (semaforo)
			{
				if (uniqueInstance == null)
				{
					uniqueInstance = new RepositorioDetalhesOcorrencia();
				}
			}
		}
		return uniqueInstance;
	}

	public MotivoOcorrenciaCobranca GetMotivoOcorrencia(EnumChaveContexto chaveContexto, string codigoOcorrencia, string codigoMotivo)
	{
		lock (semaforo)
		{
			MotivoOcorrenciaCobranca motivoOcorrenciaCobranca = null;
			ChaveMultipla chaveInformada = new ChaveMultipla(chaveContexto, codigoOcorrencia, codigoMotivo);
			ChaveMultipla chaveMultipla = (from x in dicionarioMotivosOcorrencia.AsParallel()
				select x.Key).FirstOrDefault((ChaveMultipla x) => x.Chaves[0].Equals(chaveInformada.Chaves[0]) && x.Chaves[1].Equals(chaveInformada.Chaves[1]) && x.Chaves[2].Equals(chaveInformada.Chaves[2]));
			if (chaveMultipla != null)
			{
				motivoOcorrenciaCobranca = dicionarioMotivosOcorrencia[chaveMultipla];
			}
			if (motivoOcorrenciaCobranca != null)
			{
				if (motivoOcorrenciaCobranca.Descricao == string.Empty)
				{
					return null;
				}
				return motivoOcorrenciaCobranca;
			}
			CarregarMotivoOcorrencia(chaveContexto, codigoOcorrencia, codigoMotivo);
			return GetMotivoOcorrencia(chaveContexto, codigoOcorrencia, codigoMotivo);
		}
	}

	public string GetDescricaoOcorrencia(EnumChaveContexto chaveContexto, string codigoOcorrencia)
	{
		lock (semaforo)
		{
			string text = null;
			ChaveMultipla chaveInformada = new ChaveMultipla(chaveContexto, codigoOcorrencia);
			ChaveMultipla chaveMultipla = (from x in dicionarioDescricaoOcorrencias.AsParallel()
				select x.Key).FirstOrDefault((ChaveMultipla x) => x.Chaves[0].Equals(chaveInformada.Chaves[0]) && x.Chaves[1].Equals(chaveInformada.Chaves[1]));
			if (chaveMultipla != null)
			{
				text = dicionarioDescricaoOcorrencias[chaveMultipla];
			}
			if (text != null)
			{
				if (text == string.Empty && chaveMultipla != null)
				{
					return "Descrição da ocorrência não encontrada";
				}
				return text;
			}
			CarregarOcorrenciaCobranca(chaveContexto, codigoOcorrencia);
			return GetDescricaoOcorrencia(chaveContexto, codigoOcorrencia);
		}
	}

	public string GetDescricaoOcorrencia(EnumChaveContexto chaveContexto, EnumTipoCarteiraCobranca tipoCarteira, string codigoOcorrencia)
	{
		lock (semaforo)
		{
			string text = null;
			ChaveMultipla chaveInformada = new ChaveMultipla(chaveContexto, tipoCarteira, codigoOcorrencia);
			ChaveMultipla chaveMultipla = (from x in dicionarioDescricaoOcorrencias.AsParallel()
				select x.Key).FirstOrDefault((ChaveMultipla x) => x.Chaves[0].Equals(chaveInformada.Chaves[0]) && x.Chaves[1].Equals(chaveInformada.Chaves[1]) && x.Chaves[2].Equals(chaveInformada.Chaves[2]));
			if (chaveMultipla != null)
			{
				text = dicionarioDescricaoOcorrencias[chaveMultipla];
			}
			if (text != null)
			{
				if (text == string.Empty && chaveMultipla != null)
				{
					return "Descrição da ocorrência não encontrada";
				}
				return text;
			}
			CarregarOcorrenciaCobranca(chaveContexto, tipoCarteira, codigoOcorrencia);
			return GetDescricaoOcorrencia(chaveContexto, tipoCarteira, codigoOcorrencia);
		}
	}

	public EnumCodigoMovimentoRetorno GetCodigoMovimentoRetorno(EnumChaveContexto chaveContexto, string codigoOcorrencia)
	{
		lock (semaforo)
		{
			EnumCodigoMovimentoRetorno? enumCodigoMovimentoRetorno = null;
			ChaveMultipla chaveInformada = new ChaveMultipla(chaveContexto, codigoOcorrencia);
			ChaveMultipla chaveMultipla = (from x in dicionarioCodigoMovimentoRetorno.AsParallel()
				select x.Key).FirstOrDefault((ChaveMultipla x) => x.Chaves[0].Equals(chaveInformada.Chaves[0]) && x.Chaves[1].Equals(chaveInformada.Chaves[1]));
			if (chaveMultipla != null)
			{
				enumCodigoMovimentoRetorno = dicionarioCodigoMovimentoRetorno[chaveMultipla];
			}
			if (enumCodigoMovimentoRetorno.HasValue)
			{
				return enumCodigoMovimentoRetorno.Value;
			}
			CarregarCodigoMovimentoRetorno(chaveContexto, codigoOcorrencia);
			return GetCodigoMovimentoRetorno(chaveContexto, codigoOcorrencia);
		}
	}

	private void CarregarMotivoOcorrencia(EnumChaveContexto chaveContexto, string codigoOcorrencia, string codigoMotivo)
	{
		lock (semaforo)
		{
			ChaveMultipla chave = new ChaveMultipla(chaveContexto, codigoOcorrencia, codigoMotivo);
			if ((from x in dicionarioMotivosOcorrencia
				select x.Key into x
				where x.Chaves[0] == chave.Chaves[0] && x.Chaves[1] == chave.Chaves[1] && x.Chaves[2] == chave.Chaves[2]
				select x).ToList().Count <= 0)
			{
				MotivoOcorrenciaCobranca motivoOcorrenciaCobranca = new MotivoOcorrenciaCobranca();
				motivoOcorrenciaCobranca.Codigo = codigoMotivo;
				string value = EnumUtil.ObterValorEnumeradoPeloCodigoEChave<EnumCodigoMovimentoRetorno>(codigoOcorrencia, chaveContexto).ToString();
				motivoOcorrenciaCobranca.Descricao = EnumUtil.ObterDescricaoPeloCodigoEChave<EnumMotivoOcorrencia>(motivoOcorrenciaCobranca.Codigo, new AtributoChave((EnumCodigoMovimentoRetorno)Enum.Parse(typeof(EnumCodigoMovimentoRetorno), value), chaveContexto));
				if (!dicionarioMotivosOcorrencia.ContainsKey(chave))
				{
					dicionarioMotivosOcorrencia.Add(chave, motivoOcorrenciaCobranca);
				}
			}
		}
	}

	private void CarregarOcorrenciaCobranca(EnumChaveContexto chaveContexto, string codigoOcorrencia)
	{
		ChaveMultipla key = new ChaveMultipla(chaveContexto, codigoOcorrencia);
		string value = EnumUtil.ObterDescricaoPeloCodigoEChave<EnumCodigoMovimentoRetorno>(codigoOcorrencia, chaveContexto);
		dicionarioDescricaoOcorrencias.Add(key, value);
	}

	private void CarregarOcorrenciaCobranca(EnumChaveContexto chaveContexto, EnumTipoCarteiraCobranca tipoCarteira, string codigoOcorrencia)
	{
		ChaveMultipla key = new ChaveMultipla(chaveContexto, tipoCarteira, codigoOcorrencia);
		string value = EnumUtil.ObterDescricaoPeloCodigoEChave<EnumCodigoMovimentoRetorno>(codigoOcorrencia, new AtributoChave(chaveContexto, tipoCarteira));
		dicionarioDescricaoOcorrencias.Add(key, value);
	}

	private void CarregarCodigoMovimentoRetorno(EnumChaveContexto chaveContexto, string codigoOcorrencia)
	{
		ChaveMultipla key = new ChaveMultipla(chaveContexto, codigoOcorrencia);
		EnumCodigoMovimentoRetorno value = EnumUtil.ObterValorEnumeradoPeloCodigoEChave<EnumCodigoMovimentoRetorno>(codigoOcorrencia, chaveContexto);
		dicionarioCodigoMovimentoRetorno.Add(key, value);
	}
}
