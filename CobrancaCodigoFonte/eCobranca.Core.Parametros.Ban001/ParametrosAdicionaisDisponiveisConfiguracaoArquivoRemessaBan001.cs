using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban001;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_DO_BRASIL)));
	}

	public ParametroConfiguracao GeraDetalheRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_DETALHE_REMESSA_CNAB400);
	}

	public ParametroConfiguracao GeraMensagemRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_MENSAGEM_REMESSA_CNAB400);
	}
}
