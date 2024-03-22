using System;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033;

[Serializable]
public class CarteiraCobrancaBan033CodigoECR_NOVA_400 : CarteiraCobrancaBan033Nova, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "ECR";

	public CarteiraCobrancaBan033CodigoECR_NOVA_400(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Clear();
		ItemLista value = new ItemLista(EnumLayoutArquivoRemessa.CNAB400.Codigo(), EnumLayoutArquivoRemessa.CNAB400.Descricao(), EnumLayoutArquivoRemessa.CNAB400.Sigla(), EnumLayoutArquivoRemessa.CNAB400.Ajuda(), EnumLayoutArquivoRemessa.CNAB400.ToString());
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Add(value);
		base.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.CNAB400.ToString();
		base.ConfiguracaoArquivoRetorno.LayoutsArquivoRetorno.Clear();
		value = new ItemLista(EnumLayoutArquivoRetorno.CNAB400.Codigo(), EnumLayoutArquivoRetorno.CNAB400.Descricao(), EnumLayoutArquivoRetorno.CNAB400.Sigla(), EnumLayoutArquivoRetorno.CNAB400.Ajuda(), EnumLayoutArquivoRetorno.CNAB400.ToString());
		base.ConfiguracaoArquivoRetorno.LayoutsArquivoRetorno.Add(value);
		base.ConfiguracaoArquivoRetorno.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.CNAB400.ToString();
	}

	public CarteiraCobrancaBan033CodigoECR_NOVA_400(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "ECR";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Agência do beneficiário", "Código da agência", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "000000000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "PSK código do beneficiário", "Código do beneficiário", "0000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoTransmissao", "Código de transmissão", "Código de transmissão", "00000000000000000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400, EnumCodigoBanco.BANCO_SANTANDER)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "0000000");
		value.Valor = "0000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "0000000");
		value.Valor = "9999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "0000000");
		value.Valor = "0000000";
		base.DadosConfiguracao.Add(value);
	}

	public override string GetMascaraNossoNumero()
	{
		return "0000000-0";
	}
}
