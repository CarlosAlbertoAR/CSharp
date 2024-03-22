using System.Collections;
using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros;

public class ParametrosAdicionaisDisponiveisConfiguracaoImpressao : IParametrosAdicionaisDisponiveisConfiguracaoImpressao
{
	protected ArrayList parametros;

	public ArrayList Parametros => parametros;

	public ParametrosAdicionaisDisponiveisConfiguracaoImpressao()
	{
		parametros = new ArrayList();
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO, EnumChaveContexto.GERAL)));
	}

	public ParametroConfiguracao AlturaPagina()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.IMP_ALTURA_PAGINA_IMPRESSAO);
	}

	public ParametroConfiguracao ImpressoraPersonalizada()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.IMP_IMPRESSORA_PERSONALIZADA);
	}

	public ParametroConfiguracao LarguraPagina()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.IMP_LARGURA_PAGINA_IMPRESSAO);
	}

	public ParametroConfiguracao OrientacaoPagina()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.IMP_TIPO_ORIENTACAO_PAGINA);
	}
}
