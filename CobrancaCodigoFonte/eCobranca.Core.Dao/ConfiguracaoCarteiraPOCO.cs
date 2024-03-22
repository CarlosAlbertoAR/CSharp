using System;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Dao;

internal class ConfiguracaoCarteiraPOCO
{
	public string CodigoBanco { get; set; }

	public string EnumeradoBanco { get; set; }

	public string NomeBanco { get; set; }

	public string TipoCarteiraCobranca { get; set; }

	public string CodigoCarteiraCobranca { get; set; }

	public string TipoInscricaoBeneficiario { get; set; }

	public string NumeroInscricaoBeneficiario { get; set; }

	public string NomeBeneficiario { get; set; }

	public string RazaoSocialBeneficiario { get; set; }

	public string EnderecoBeneficiario { get; set; }

	public string BairroBeneficiario { get; set; }

	public string CidadeBeneficiario { get; set; }

	public string UFBeneficiario { get; set; }

	public string CepBeneficiario { get; set; }

	public string RamoAtividadeBeneficiario { get; set; }

	public string DiretorioCarteiraCobranca { get; set; }

	public string ChaveLicenca { get; set; }

	public string Versao { get; set; }

	public DateTime DataVigencia { get; set; }

	public bool CobrancaRegistrada { get; set; }

	public bool BancoEmiteBoleto { get; set; }

	public bool BancoDistribuiBoleto { get; set; }

	public ConfiguracaoCarteiraCobranca ParseTo()
	{
		return new ConfiguracaoCarteiraCobranca(Guid.NewGuid(), EnumeradoBanco, NomeBanco, TipoCarteiraCobranca, CodigoCarteiraCobranca, CobrancaRegistrada, BancoEmiteBoleto, BancoDistribuiBoleto, TipoInscricaoBeneficiario, NumeroInscricaoBeneficiario, NomeBeneficiario, RazaoSocialBeneficiario, EnderecoBeneficiario, BairroBeneficiario, CidadeBeneficiario, UFBeneficiario, CepBeneficiario, RamoAtividadeBeneficiario, DiretorioCarteiraCobranca, ChaveLicenca, Versao, DataVigencia);
	}
}
