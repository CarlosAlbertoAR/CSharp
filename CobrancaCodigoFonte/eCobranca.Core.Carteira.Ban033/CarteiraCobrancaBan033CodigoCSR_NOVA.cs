using System;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033;

[Serializable]
public class CarteiraCobrancaBan033CodigoCSR_NOVA : CarteiraCobrancaBan033Nova, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "CSR";

	public CarteiraCobrancaBan033CodigoCSR_NOVA(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Clear();
		base.ConfiguracaoArquivoRetorno.LayoutsArquivoRetorno.Clear();
		ItemLista value = new ItemLista(EnumLayoutArquivoRetorno.CNAB400.Codigo(), EnumLayoutArquivoRetorno.CNAB400.Descricao(), EnumLayoutArquivoRetorno.CNAB400.Sigla(), EnumLayoutArquivoRetorno.CNAB400.Ajuda(), EnumLayoutArquivoRetorno.CNAB400.ToString());
		configuracaoArquivoRetorno.LayoutsArquivoRetorno.Add(value);
		value = new ItemLista(EnumLayoutArquivoRetorno.FEBRABAN240.Codigo(), EnumLayoutArquivoRetorno.FEBRABAN240.Descricao(), EnumLayoutArquivoRetorno.FEBRABAN240.Sigla(), EnumLayoutArquivoRetorno.FEBRABAN240.Ajuda(), EnumLayoutArquivoRetorno.FEBRABAN240.ToString());
		configuracaoArquivoRetorno.LayoutsArquivoRetorno.Add(value);
	}

	public CarteiraCobrancaBan033CodigoCSR_NOVA(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "CSR";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Agência do beneficiário", "Código da agência", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "000000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "PSK código do beneficiário", "Código do beneficiário", "0000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoTransmissao", "Código de transmissão", "Código de transmissão", "00000000000000000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumTipoCarteiraCobranca.BAN033_CSR_NOVA, EnumCodigoBanco.BANCO_SANTANDER)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "000000000000");
		value.Valor = "000000000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "000000000000");
		value.Valor = "999999999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "000000000000");
		value.Valor = "000000000000";
		base.DadosConfiguracao.Add(value);
	}
}
