using System;
using System.Collections;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Configuracoes;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban004;

[Serializable]
public class CarteiraCobrancaBan004Codigo241 : CarteiraCobrancaBan004, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "241";

	public CarteiraCobrancaBan004Codigo241(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan004Codigo241(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "0000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "0000000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca: Utilize um dos valores da lista ConfiguracaoDocumentoCobranca.ModalidadesCobranca", "Modalidade de cobrança", "00", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumTipoCarteiraCobranca.BAN004_COD_241, EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL)));
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
		value = new DadoConfiguracao("CodigoUsuario", "Código da caixa postal no sistema EDI (Forncecido pelo banco)", "Código do usuário", "000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContrato", "Número do contrato para cobrança vinculada", "Número do contrato", "0000000000");
		value.Valor = "0000000000";
		base.DadosConfiguracao.Add(value);
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "241";
	}
}
