using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237;

[Serializable]
public class CarteiraCobrancaBan237Codigo09Unicred : CarteiraCobrancaBan237, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "09";

	public CarteiraCobrancaBan237Codigo09Unicred(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan237Codigo09Unicred(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa()
	{
		ConfiguracaoArquivoRemessa obj = base.CarregarConfiguracaoArquivoRemessa();
		obj.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.FEBRABAN240.ToString();
		return obj;
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno obj = base.CarregarConfiguracaoArquivoRetorno();
		obj.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.FEBRABAN240.ToString();
		return obj;
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "09";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária fictícia", "Agência", "0000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Conta do cooperado no CobExpress", "Conta corrente", "0000000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("ContaUnicred", "Conta do cooperado na Unicred", "Código do cedente", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca: Utilize um dos valores da lista ConfiguracaoDocumentoCobranca.ModalidadesCobranca", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_BRADESCO, EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "00000000000");
		value.Valor = "00000000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "00000000000");
		value.Valor = "99999999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "00000000000");
		value.Valor = "00000000000";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NomeDaSingular", "Nome da singular que será impresso no boleto", "Nome da singular", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("EnderecoDaSingular", "Endereço completo da singular que será impresso no boleto", "Endereço da singular", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("BairroDaSingular", "Bairro da singular que será impresso no boleto", "Bairro da singular", "TTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CidadeDaSingular", "Cidade da singular que será impresso no boleto", "Cidade da singular", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("UFDaSingular", "UF da singular que será impresso no boleto", "UF da singular", "AA");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CepDaSingular", "CEP da singular que será impresso no boleto", "CEP da singular", "00000-000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InscricaoDaSingular", "Número de inscrição da singular que será impresso no boleto", "Número de inscrição da singular", "00.000.000/0000-00");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoConvenioDaSingular", "Código do convênio da singular", "Código do convênio da singular", "00000000000000000000");
		base.DadosConfiguracao.Add(value);
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan237Unicred();
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban237Unicred(this);
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_BRADESCO}]...");
				remessaFebraban240.Preparar(this);
				remessaFebraban240.NovoLote(dcList);
				(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban237Unicred).Preparar(this, remessaFebraban240);
				comandoGerarRemessaFebraban240.Execute();
				result = remessaFebraban240.GerarArquivoRemessa();
				return result;
			}
			throw ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoArquivoRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban237Unicred();
	}

	protected override string GerarArquivoRemessaCNAB400(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.BANCO_BRADESCO}]...");
				remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
				remessaCnab400.CriarLote(dcList);
				(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban237Unicred).Preparar(this, remessaCnab400);
				comandoGerarRemessaCnab400.Execute();
				result = remessaCnab400.GerarArquivoRemessa();
				return result;
			}
			throw ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoArquivoRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
