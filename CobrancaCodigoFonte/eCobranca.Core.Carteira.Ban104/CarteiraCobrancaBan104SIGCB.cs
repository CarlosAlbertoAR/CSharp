using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Atributos;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Remessa;
using eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Retorno;
using eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;
using eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Retorno;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104;

[Serializable]
public abstract class CarteiraCobrancaBan104SIGCB : CarteiraCobrancaBan104, ISerializable
{
	public CarteiraCobrancaBan104SIGCB(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan104SIGCB(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override FactorySegmentoFebraban240 CarregarFabricaSegmentoFebraban240()
	{
		return new FactorySegmentoFebraban240Ban104();
	}

	protected override ArquivoCobrancaRemessaFebraban240 CarregarArquivoRemessaFebraban240()
	{
		return (ArquivoCobrancaRemessaFebraban240)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL);
	}

	protected override ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400()
	{
		return (ArquivoCobrancaRemessaCnab400Ban104)FactoryArquivoCobranca.CriarArquivoRemessa(GetGuid(), EnumLayoutArquivoRemessa.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL);
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban104(this);
	}

	protected override MacroCommand CarregarComandoGerarRemessaCnab400()
	{
		return new ComandoGerarArquivoRemessaCnab400Ban104();
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
				remessaFebraban240.Preparar(this);
				remessaFebraban240.NovoLote(dcList);
				(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban104).Preparar(this, remessaFebraban240);
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

	protected override string GerarArquivoRemessaCNAB400(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			Logger.Debug($"Gerando arquivo de remessa CNAB400 para o [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			remessaCnab400.Preparar(base.ConfiguracaoArquivoRemessa);
			remessaCnab400.CriarLote(dcList);
			(comandoGerarRemessaCnab400 as ComandoGerarArquivoRemessaCnab400Ban104).Preparar(this, remessaCnab400);
			comandoGerarRemessaCnab400.Execute();
			result = remessaCnab400.GerarArquivoRemessa();
			return result;
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

	protected override ArquivoCobrancaRetornoFebraban240 CarregarArquivoRetornoFebraban240()
	{
		return (ArquivoCobrancaRetornoFebraban240)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.FEBRABAN240, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL);
	}

	protected override ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400()
	{
		return (ArquivoCobrancaRetornoCnab400Ban104)FactoryArquivoCobranca.CriarArquivoRetorno(GetGuid(), EnumLayoutArquivoRetorno.CNAB400, (EnumTipoCarteiraCobranca)(object)base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>(), EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL);
	}

	protected override ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150()
	{
		return null;
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban104(this);
	}

	protected override MacroCommand CarregarComandoProcessarRetornoCnab400()
	{
		return new ComandoCarregarArquivoRetornoCnab400Ban104();
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban150()
	{
		return null;
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban104).Preparar(this, retornoFebraban240);
			comandoProcessarRetornoFebraban240.Execute();
			result = retornoFebraban240.CarregarArquivoRetornoFebraban240();
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoArquivoRetornoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override ArrayList CarregarArquivoRetornoCnab400(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			retornoCnab400.Preparar(base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoCnab400 as ComandoCarregarArquivoRetornoCnab400Ban104).Preparar(this, retornoCnab400);
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

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência bancária", "Agência", "0000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente do beneficiário", "000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoBeneficiario", "Número do beneficiário", "Código do beneficiário", "0000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade da carteira de cobrança", "Modalidade de cobrança", "0", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("InicioNossoNumero", "Sequência inicial para geração do nosso número", "Início nosso número", "000000000000000");
		value.Valor = "000000000000001";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("FimNossoNumero", "Final da sequência para geração do nosso número", "Fim do nosso número", "000000000000000");
		value.Valor = "999999999999999";
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NossoNumeroAtual", "Sequencia atual para geração do nosso número", "Nosso número atual", "000000000000000");
		value.Valor = "000000000000000";
		base.DadosConfiguracao.Add(value);
	}

	protected override string GerarNossoNumeroCompleto(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug($"Obtendo nosso número completo para o documento [{dc.NumeroDocumento}]");
			string nossoNumeroSemDV = GetNossoNumeroSemDV(dc);
			string text = "";
			if (dc.CalculaDacNossoNumero)
			{
				text = GetDVNossoNumero(nossoNumeroSemDV);
			}
			stringBuilder.Append(nossoNumeroSemDV);
			if (text != "")
			{
				stringBuilder.Append("-");
				stringBuilder.Append(text);
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroCompletoDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		dc.NossoNumeroSemMascara = StringUtil.RemoverMascara(stringBuilder.ToString());
		return stringBuilder.ToString();
	}

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug($"Criando nosso número para o documento de cobrança para o banco [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.ToString()}]...");
			string obj = (base.ConfiguracaoCarteiraCobranca.CobrancaRegistrada ? "1" : "2");
			string text = (base.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto ? "1" : "4");
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[6]).Mascara;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[4]).Valor;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
			valor = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor2, valor3, mascara) : StringUtil.IncrementString(valor, valor2, valor3, mascara));
			if (string.IsNullOrEmpty(valor))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor3);
			}
			((DadoConfiguracao)base.DadosConfiguracao[6]).Valor = valor;
			result = obj + text + valor;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroSemDV(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return CalcularDVNossoNumero(nossoNumero);
	}

	protected override string CalcularDVNossoNumero(string nossoNumeroSemDV)
	{
		return DVGenerator.GetDVModulo11(nossoNumeroSemDV);
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			string text = string.Empty;
			if (((DadoConfiguracao)base.DadosConfiguracao[2]).Valor.IsStringNumerica())
			{
				int num = Convert.ToInt32(((DadoConfiguracao)base.DadosConfiguracao[2]).Valor);
				if (num <= 999999)
				{
					text = StringUtil.ZerosLeft(num.ToString(), 6);
					text += DVGenerator.GetDVModulo11(text);
				}
				else
				{
					text = ((DadoConfiguracao)base.DadosConfiguracao[2]).Valor;
				}
			}
			string text2 = dc.NossoNumero.Substring(2, 3);
			string text3 = dc.NossoNumero.Substring(0, 1);
			string text4 = dc.NossoNumero.Substring(5, 3);
			string text5 = dc.NossoNumero.Substring(1, 1);
			string text6 = dc.NossoNumero.Substring(8, 9);
			string dVModulo = DVGenerator.GetDVModulo11(text + text2 + text3 + text4 + text5 + text6);
			result = text + text2 + text3 + text4 + text5 + text6 + dVModulo;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCampoLivre(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public override string GetMascaraNossoNumero()
	{
		return "00000000000000000-0";
	}
}
