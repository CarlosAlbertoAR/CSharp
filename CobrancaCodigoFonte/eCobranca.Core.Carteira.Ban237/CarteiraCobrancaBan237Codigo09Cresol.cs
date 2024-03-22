using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237;

[Serializable]
public class CarteiraCobrancaBan237Codigo09Cresol : CarteiraCobrancaBan237, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "09";

	public CarteiraCobrancaBan237Codigo09Cresol(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan237Codigo09Cresol(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa()
	{
		ConfiguracaoArquivoRemessa obj = base.CarregarConfiguracaoArquivoRemessa();
		obj.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.CNAB400.ToString();
		return obj;
	}

	protected override ArquivoCobrancaRemessaFebraban240 CarregarArquivoRemessaFebraban240()
	{
		return null;
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban237)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_BRADESCO);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban237Cresol();
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return null;
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		return string.Empty;
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
				(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban237Cresol).Preparar(this, remessaCnab400);
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

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		return string.Empty;
	}

	protected override ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno()
	{
		ConfiguracaoArquivoRetorno obj = base.CarregarConfiguracaoArquivoRetorno();
		obj.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.CNAB400.ToString();
		return obj;
	}

	protected override ArquivoCobrancaRetornoFebraban240 CarregarArquivoRetornoFebraban240()
	{
		return null;
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban237)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.BANCO_BRADESCO);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban237();
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return null;
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FuncionalidadeNaoImplementadaAinda("CarregarArquivoRetornoFebraban240"), new StackTrace().GetFrame(1).GetMethod());
		return null;
	}

	protected override ArrayList CarregarArquivoRetornoCnab400(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban237).Preparar(this, retornoCnab400);
			comandoProcessarRetornoCnab400.Execute();
			result = retornoCnab400.CarregarArquivoRetornoCnab400();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoArquivoRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FuncionalidadeNaoImplementadaAinda("CarregarArquivoRetornoFebraban150"), new StackTrace().GetFrame(1).GetMethod());
		return null;
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "09";
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária do bradesco utilizada pela cresol", "Agência", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Conta da unidade do cresol no bradesco", "Conta corrente", "0000000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Convenio", "Convênio da unidade cresol junto ao bradesco", "Código do convênio", "0000000");
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
		value = new DadoConfiguracao("NomeDaUnidadeCresol", "Nome da unidade da cresol que será impresso no boleto", "Nome da unidade cresol", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("EnderecoDaUnidadeCresol", "Endereço completo da unidade cresol que será impresso no boleto", "Endereço da unidade", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("BairroDaUnidadeCresol", "Bairro da unidade cresol que será impresso no boleto", "Bairro da unidade cresol", "TTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CidadeDaUnidadeCresol", "Cidade da unidade cresol que será impresso no boleto", "Cidade da unidade cresol", "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT*");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("UFDaUnidadeCresol", "UF da unidade cresol que será impresso no boleto", "UF da unidade cresol", "AA");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CepDaUnidadeCresol", "CEP da unidade cresol que será impresso no boleto", "CEP da unidade cresol", "00000-000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InscricaoDaUnidadeCresol", "Número de inscrição da unidade cresol que será impresso no boleto", "Número de inscrição da unidade cresol", "00.000.000/0000-00");
		base.DadosConfiguracao.Add(value);
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan237Cresol();
	}
}
