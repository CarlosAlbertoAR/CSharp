using System;
using System.Collections;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoArquivoRetornoBan237Unicred : ConfiguracaoArquivoRetorno
{
	public ConfiguracaoArquivoRetornoBan237Unicred(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(guid, banco, modoUso, carteira, tipoCarteira)
	{
		layoutsArquivoRetorno = new ArrayList();
		layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_CNAB400)));
		if (layoutsArquivoRetorno.Count > 0)
		{
			layoutArquivoRetorno = (layoutsArquivoRetorno[0] as ItemLista).Valor;
		}
	}

	public ConfiguracaoArquivoRetornoBan237Unicred(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		base.CarregarListas(repositorio);
		layoutsArquivoRetorno = new ArrayList();
		layoutsArquivoRetorno.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRetorno, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_CNAB400)));
	}
}
