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
public class ConfiguracaoArquivoRemessaBan237Unicred : ConfiguracaoArquivoRemessa
{
	public ConfiguracaoArquivoRemessaBan237Unicred(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira, int limiteRemessasDiaria, bool cobrancaRegistrada, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
		: base(guid, banco, modoUso, carteira, limiteRemessasDiaria, cobrancaRegistrada, tipoCarteira)
	{
		layoutsArquivoRemessa = new ArrayList();
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_FEBRABAN240)));
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_CNAB400)));
		if (layoutsArquivoRemessa.Count > 0)
		{
			layoutArquivoRemessa = ((ItemLista)layoutsArquivoRemessa[0]).Valor;
		}
	}

	public ConfiguracaoArquivoRemessaBan237Unicred(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		base.CarregarListas(repositorio);
		layoutsArquivoRemessa = new ArrayList();
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_FEBRABAN240)));
		layoutsArquivoRemessa.AddRange(EnumUtil.GetEnumByAttributeToItemLista<EnumLayoutArquivoRemessa, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN237_UNICRED_CNAB400)));
	}
}
