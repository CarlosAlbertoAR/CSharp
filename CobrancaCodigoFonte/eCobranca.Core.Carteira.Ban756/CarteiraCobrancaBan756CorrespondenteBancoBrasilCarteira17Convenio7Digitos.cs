using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Atributos;
using eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;
using eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno.CorrespondenteBan001;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756;

[Serializable]
public class CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos : CarteiraCobrancaBan756, ISerializable
{
	public CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Clear();
		ItemLista value = new ItemLista(EnumLayoutArquivoRemessa.FEBRABAN240.Codigo(), EnumLayoutArquivoRemessa.FEBRABAN240.Descricao(), EnumLayoutArquivoRemessa.FEBRABAN240.Sigla(), EnumLayoutArquivoRemessa.FEBRABAN240.Ajuda(), EnumLayoutArquivoRemessa.FEBRABAN240.ToString());
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Add(value);
		base.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa = EnumLayoutArquivoRemessa.FEBRABAN240.ToString();
		base.ConfiguracaoArquivoRetorno.LayoutsArquivoRetorno.Clear();
		value = new ItemLista(EnumLayoutArquivoRetorno.FEBRABAN240.Codigo(), EnumLayoutArquivoRetorno.FEBRABAN240.Descricao(), EnumLayoutArquivoRetorno.FEBRABAN240.Sigla(), EnumLayoutArquivoRetorno.FEBRABAN240.Ajuda(), EnumLayoutArquivoRetorno.FEBRABAN240.ToString());
		base.ConfiguracaoArquivoRetorno.LayoutsArquivoRetorno.Add(value);
		base.ConfiguracaoArquivoRetorno.LayoutArquivoRetorno = EnumLayoutArquivoRetorno.FEBRABAN240.ToString();
		base.ConfiguracaoDocumentoCobranca.CodigosJuros.Clear();
		foreach (ItemLista enumByAttributeToItemListum in EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoJuros, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN001_FEBRABAN240)))
		{
			base.ConfiguracaoDocumentoCobranca.CodigosJuros.Add(enumByAttributeToItemListum);
		}
		base.ConfiguracaoDocumentoCobranca.CodigosBaixaDevolucao.Clear();
		foreach (ItemLista enumByAttributeToItemListum2 in EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoBaixaDevolucao, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN001_FEBRABAN240)))
		{
			base.ConfiguracaoDocumentoCobranca.CodigosBaixaDevolucao.Add(enumByAttributeToItemListum2);
		}
		base.ConfiguracaoDocumentoCobranca.CodigosDesconto.Clear();
		foreach (ItemLista enumByAttributeToItemListum3 in EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoDesconto, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN001_FEBRABAN240)))
		{
			base.ConfiguracaoDocumentoCobranca.CodigosDesconto.Add(enumByAttributeToItemListum3);
		}
		base.ConfiguracaoDocumentoCobranca.CodigosMulta.Clear();
		foreach (ItemLista enumByAttributeToItemListum4 in EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoMulta, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN001_FEBRABAN240)))
		{
			base.ConfiguracaoDocumentoCobranca.CodigosMulta.Add(enumByAttributeToItemListum4);
		}
		base.ConfiguracaoDocumentoCobranca.CodigosProtesto.Clear();
		foreach (ItemLista enumByAttributeToItemListum5 in EnumUtil.GetEnumByAttributeToItemLista<EnumCodigoProtesto, AtributoChave>(new AtributoChave(EnumChaveContexto.BAN001_FEBRABAN240)))
		{
			base.ConfiguracaoDocumentoCobranca.CodigosProtesto.Add(enumByAttributeToItemListum5);
		}
	}

	public CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override FactorySegmentoFebraban240 CarregarFabricaSegmentoFebraban240()
	{
		return new FactorySegmentoFebraban240Ban756CorrespondenteBancoDoBrasil();
	}

	protected override string GerarArquivoRemessaFebraban240(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			if (base.ConfiguracaoArquivoRemessa.DataUltimaRemessa == DateTime.Today && base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria >= base.ConfiguracaoArquivoRemessa.LimiteRemessasDiaria)
			{
				throw ExcecaoECobranca.Remessa.LimiteArquivosRemessaAtingido(base.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria);
			}
			Logger.Debug($"Gerando arquivo de remessa FEBRABAN240 para o [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			remessaFebraban240.Preparar(this);
			remessaFebraban240.NovoLote(dcList);
			(comandoGerarRemessaFebraban240 as ComandoGerarArquivoRemessaFebraban240Ban756CorrespondenteBancoBrasil).Preparar(this, remessaFebraban240);
			comandoGerarRemessaFebraban240.Execute();
			result = remessaFebraban240.GerarArquivoRemessa();
			return result;
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
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.RemesssaCnab400NaoImplementadoParaCarteira(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override string GerarArquivoRemessaFebraban150(ArrayList dcList)
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.RemesssaFebraban150NaoImplementadoParaCarteira(), new StackTrace().GetFrame(1).GetMethod());
		return string.Empty;
	}

	protected override MacroCommand CarregarComandoGerarRemessaFebraban240()
	{
		return new ComandoGerarArquivoRemessaFebraban240Ban756CorrespondenteBancoBrasil(this);
	}

	protected override ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug($"Processando arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...)");
			retornoFebraban240.Preparar(this, base.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno, nomeArquivoRetorno);
			(comandoProcessarRetornoFebraban240 as ComandoCarregarArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil).Preparar(this, retornoFebraban240);
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
		return new ArrayList();
	}

	protected override ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno)
	{
		return new ArrayList();
	}

	protected override MacroCommand CarregarComandoProcessarRetornoFebraban240()
	{
		return new ComandoCarregarArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil(this);
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Código da agência", "Código da agência", "0000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NumeroContaCorrente", "Número da conta corrente", "Conta corrente", "00000000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("AgenciaCorrespondente", "Código da agência no banco correspondente", "Código da agência no banco correspondente", "0000-A");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Modalidade", "Modalidade de cobranca: Utilize um dos valores da lista ConfiguracaoDocumentoCobranca.ModalidadesCobranca", "Modalidade de cobrança", "00", EnumUtil.GetEnumByAttributeToItemLista<EnumModalidadeCarteiraCobranca, AtributoChave>(new AtributoChave(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL)));
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("ContaCorrenteCorrespondente", "Número da conta corrente no banco correspondente", "Número da conta corrente no banco correspondente", "00000-0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoConvenio", "Código do convênio", "Código do convênio", "0000000000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("Variacao", "Variação da carteira", "Variação da carteira de cobrança", "000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCobranca", "Código de cobrança Sicoob", "Código de cobrança Sicoob", "0000000");
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

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[10]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[10]).Mascara;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[8]).Valor;
			string valor4 = ((DadoConfiguracao)base.DadosConfiguracao[9]).Valor;
			valor2 = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor3, valor4, mascara) : StringUtil.IncrementString(valor2, valor3, valor4, mascara));
			if (string.IsNullOrEmpty(valor2))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor4);
			}
			((DadoConfiguracao)base.DadosConfiguracao[10]).Valor = valor2;
			result = valor + valor2;
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
		return "";
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = "000000" + StringUtil.RemoverMascara(dc.NossoNumero) + "17";
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

	public override string GetCodigoCarteiraImpressao()
	{
		return EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL.Codigo();
	}

	protected override string GerarNomeArquivoRemessa()
	{
		long sequenciaRemessa = base.ConfiguracaoArquivoRemessa.SequenciaRemessa;
		string text = ((sequenciaRemessa.ToString().Length > 2) ? StringUtil.ZerosLeft("1", 2) : StringUtil.ZerosLeft(sequenciaRemessa.ToString(), 2));
		base.ConfiguracaoArquivoRemessa.SequenciaRemessa = Convert.ToInt32(text) + 1;
		return "CBR" + DateTime.Today.Year + StringUtil.ZerosLeft(DateTime.Today.Month.ToString(), 2) + StringUtil.ZerosLeft(DateTime.Today.Day.ToString(), 2) + text + ".REM";
	}

	protected override string GerarCodigoBarras(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug($"Criando código de barras para o documento de cobrança [{dc.NumeroDocumento}]");
			string text = GerarFatorVencimento(dc);
			string campoLivre = GetCampoLivre(dc);
			string text2 = "";
			text2 = ((!base.ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO)) ? StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10) : StringUtil.FormatValueToSizedString(1.0, 10));
			string codigoBarras = EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + "9" + text + text2 + campoLivre;
			string text3 = CalcularDVCodigoBarras(codigoBarras);
			result = EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + "9" + text3 + text + text2 + campoLivre;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCodigoBarrasDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + "9" + dc.CodigoBarras.Substring(19, 5);
			string text2 = text + CalcularDVLinhaDigitavel(text);
			text2 = text2.Insert(5, ".");
			string text3 = dc.CodigoBarras.Substring(24, 10);
			string text4 = text3 + CalcularDVLinhaDigitavel(text3);
			text4 = text4.Insert(5, ".");
			string text5 = dc.CodigoBarras.Substring(34, 10);
			string text6 = text5 + CalcularDVLinhaDigitavel(text5);
			text6 = text6.Insert(5, ".");
			string text7 = dc.CodigoBarras.Substring(4, 1);
			string text8 = "";
			text8 = ((!base.ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO)) ? (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10)) : (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(1.0, 10)));
			result = text2 + " " + text4 + " " + text6 + " " + text7 + " " + text8;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoLinhaDigitavel(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public override string GetMascaraNossoNumero()
	{
		return "00000000000000000";
	}

	protected override ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto()
	{
		return new ProvedorDadosModeloBoletoBan756Carteira17CorrespondenteBB();
	}

	protected override string GetInicioSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[8]).Valor;
	}

	protected override string GetFimSequenciaNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[9]).Valor;
	}

	protected override string GetSequenciaAtualNossoNumero()
	{
		return ((DadoConfiguracao)base.DadosConfiguracao[10]).Valor;
	}
}
