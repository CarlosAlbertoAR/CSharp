using System.Collections;
using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Parametros;

public class ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca : IParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca
{
	private ArrayList parametros;

	public ArrayList Parametros => parametros;

	public ParametrosAdicionaisDisponiveisConfiguracaoCarteiraCobranca()
	{
		parametros = new ArrayList();
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_CARTEIRA_COBRANCA, EnumChaveContexto.GERAL)));
	}
}
