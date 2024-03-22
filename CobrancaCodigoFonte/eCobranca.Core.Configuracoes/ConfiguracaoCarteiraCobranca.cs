using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoCarteiraCobranca : ConfiguracaoECobranca
{
	private string nomeBanco;

	private string tipoCarteiraCobranca;

	private string codigoCarteiraCobranca;

	private string tipoInscricaoBeneficiario;

	private string numeroInscricaoBeneficiario;

	private string nomeBeneficiario;

	private string razaoSocialBeneficiario;

	private string enderecoBeneficiario;

	private string bairroBeneficiario;

	private string cidadeBeneficiario;

	private string ufBeneficiario;

	private string cepBeneficiario;

	private string ramoAtividadeBeneficiario;

	private string diretorioCarteiraCobranca;

	private string chaveLicenca;

	private string versao;

	private DateTime dataVigencia;

	private bool cobrancaRegistrada;

	private bool bancoEmiteBoleto;

	private bool bancoDistribuiBoleto;

	public DateTime DataVigencia => dataVigencia;

	public string Versao => versao;

	public bool BancoEmiteBoleto
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = bancoEmiteBoleto;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					bancoEmiteBoleto = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("BancoEmiteBoleto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool BancoDistribuiBoleto
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = bancoDistribuiBoleto;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				Launcher.GetInstance().Executar(delegate
				{
					bancoDistribuiBoleto = result;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("BancoDistribuiBoleto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
			bancoDistribuiBoleto = value;
		}
	}

	public bool CobrancaRegistrada
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = cobrancaRegistrada;
			});
			return result;
		}
	}

	public string CodigoCarteiraCobranca
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = codigoCarteiraCobranca;
			});
			return result;
		}
	}

	public string NomeBanco
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = nomeBanco;
			});
			return result;
		}
	}

	public string RamoAtividadeBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = ramoAtividadeBeneficiario;
			});
			return result;
		}
	}

	public string UfBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = ufBeneficiario;
			});
			return result;
		}
	}

	public string CidadeBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = cidadeBeneficiario;
			});
			return result;
		}
	}

	public string BairroBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = bairroBeneficiario;
			});
			return result;
		}
	}

	public string EnderecoBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = enderecoBeneficiario;
			});
			return result;
		}
	}

	public string CepBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = cepBeneficiario;
			});
			return result;
		}
	}

	public string NomeBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = nomeBeneficiario;
			});
			return result;
		}
	}

	public string RazaoSocialBeneficiario => razaoSocialBeneficiario;

	public string NumeroInscricaoBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = numeroInscricaoBeneficiario;
			});
			return result;
		}
	}

	public string TipoInscricaoBeneficiario
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoInscricaoBeneficiario;
			});
			return result;
		}
	}

	public string TipoCarteiraCobranca
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = tipoCarteiraCobranca;
			});
			return result;
		}
	}

	public string Banco
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = banco.ToString();
			});
			return result;
		}
	}

	public string DiretorioCarteiraCobranca
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = diretorioCarteiraCobranca;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Directory.Exists(value))
				{
					Launcher.GetInstance().Executar(delegate
					{
						diretorioCarteiraCobranca = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.DiretorioInformadoNaoExiste(value), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("DiretorioCarteiraCobranca", null), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ChaveLicenca
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = chaveLicenca;
			});
			return result;
		}
	}

	public ConfiguracaoCarteiraCobranca(Guid guid, string banco, string nomeBanco, string tipoCarteiraCobranca, string codigoCarteiraCobranca, bool cobrancaRegistrada, bool bancoEmiteBoleto, bool bancoDistribuiBoleto, string tipoInscricaoBeneficiario, string numeroInscricaoBeneficiario, string nomeBeneficiario, string razaoSocialBeneficiario, string enderecoBeneficiario, string bairroBeneficiario, string cidadeBeneficiario, string ufBeneficiario, string cepBeneficiario, string ramoAtividadeBeneficiario, string diretorioDestino, string chaveLicenca, string versao, DateTime dataVigencia)
		: base(guid, banco, (!string.IsNullOrEmpty(chaveLicenca)) ? EnumModoUsoECobranca.COMERCIAL : EnumModoUsoECobranca.DEMONSTRACAO, null)
	{
		try
		{
			Logger.Debug("Criando configuração de carteira de cobrança...");
			this.nomeBanco = nomeBanco;
			this.tipoCarteiraCobranca = tipoCarteiraCobranca;
			this.codigoCarteiraCobranca = codigoCarteiraCobranca;
			this.cobrancaRegistrada = cobrancaRegistrada;
			this.tipoInscricaoBeneficiario = tipoInscricaoBeneficiario;
			this.numeroInscricaoBeneficiario = numeroInscricaoBeneficiario;
			this.nomeBeneficiario = nomeBeneficiario;
			this.razaoSocialBeneficiario = razaoSocialBeneficiario;
			this.enderecoBeneficiario = enderecoBeneficiario;
			this.bairroBeneficiario = bairroBeneficiario;
			this.cidadeBeneficiario = cidadeBeneficiario;
			this.ufBeneficiario = ufBeneficiario;
			this.cepBeneficiario = cepBeneficiario;
			this.ramoAtividadeBeneficiario = ramoAtividadeBeneficiario;
			diretorioCarteiraCobranca = diretorioDestino;
			this.chaveLicenca = chaveLicenca;
			this.bancoEmiteBoleto = bancoEmiteBoleto;
			this.bancoDistribuiBoleto = bancoDistribuiBoleto;
			this.versao = versao;
			this.dataVigencia = dataVigencia;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ConfiguracaoCarteiraCobranca(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		nomeBanco = (string)serobj.GetValue("NomeBanco", typeof(string));
		tipoCarteiraCobranca = (string)serobj.GetValue("TipoCarteiraCobranca", typeof(string));
		codigoCarteiraCobranca = (string)serobj.GetValue("CodigoCarteiraCobranca", typeof(string));
		tipoInscricaoBeneficiario = (string)serobj.GetValue("TipoInscricaoBeneficiario", typeof(string));
		numeroInscricaoBeneficiario = (string)serobj.GetValue("NumeroInscricaoBeneficiario", typeof(string));
		nomeBeneficiario = (string)serobj.GetValue("NomeBeneficiario", typeof(string));
		razaoSocialBeneficiario = (string)serobj.GetValue("RazaoSocialBeneficiario", typeof(string));
		enderecoBeneficiario = (string)serobj.GetValue("EnderecoBeneficiario", typeof(string));
		bairroBeneficiario = (string)serobj.GetValue("BairroBeneficiario", typeof(string));
		cidadeBeneficiario = (string)serobj.GetValue("CidadeBeneficiario", typeof(string));
		ufBeneficiario = (string)serobj.GetValue("UfBeneficiario", typeof(string));
		cepBeneficiario = (string)serobj.GetValue("CepBeneficiario", typeof(string));
		ramoAtividadeBeneficiario = (string)serobj.GetValue("RamoAtividadeBeneficiario", typeof(string));
		diretorioCarteiraCobranca = (string)serobj.GetValue("DiretorioCarteiraCobranca", typeof(string));
		chaveLicenca = (string)serobj.GetValue("ChaveLicenca", typeof(string));
		versao = (string)serobj.GetValue("Versao", typeof(string));
		dataVigencia = (DateTime)serobj.GetValue("DataVigencia", typeof(DateTime));
		cobrancaRegistrada = (bool)serobj.GetValue("CobrancaRegistrada", typeof(bool));
		bancoEmiteBoleto = (bool)serobj.GetValue("BancoEmiteBoleto", typeof(bool));
		bancoDistribuiBoleto = (bool)serobj.GetValue("BancoDistribuiBoleto", typeof(bool));
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("NomeBanco", nomeBanco);
		info.AddValue("TipoCarteiraCobranca", tipoCarteiraCobranca);
		info.AddValue("CodigoCarteiraCobranca", codigoCarteiraCobranca);
		info.AddValue("TipoInscricaoBeneficiario", tipoInscricaoBeneficiario);
		info.AddValue("NumeroInscricaoBeneficiario", numeroInscricaoBeneficiario);
		info.AddValue("NomeBeneficiario", nomeBeneficiario);
		info.AddValue("RazaoSocialBeneficiario", razaoSocialBeneficiario);
		info.AddValue("EnderecoBeneficiario", enderecoBeneficiario);
		info.AddValue("BairroBeneficiario", bairroBeneficiario);
		info.AddValue("CidadeBeneficiario", cidadeBeneficiario);
		info.AddValue("UfBeneficiario", ufBeneficiario);
		info.AddValue("CepBeneficiario", cepBeneficiario);
		info.AddValue("RamoAtividadeBeneficiario", ramoAtividadeBeneficiario);
		info.AddValue("DiretorioCarteiraCobranca", diretorioCarteiraCobranca);
		info.AddValue("ChaveLicenca", chaveLicenca);
		info.AddValue("Versao", versao);
		info.AddValue("DataVigencia", dataVigencia);
		info.AddValue("CobrancaRegistrada", cobrancaRegistrada);
		info.AddValue("BancoEmiteBoleto", bancoEmiteBoleto);
		info.AddValue("BancoDistribuiBoleto", bancoDistribuiBoleto);
	}
}
