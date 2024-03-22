using System;
using System.Diagnostics;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Estrutura;

public class CampoLayoutArquivoCobranca
{
	private string codigo;

	private string nome;

	private string descricao;

	private string valor;

	private string valorPadrao;

	private int posicaoInicial;

	private int posicaoFinal;

	private int quantidadeDigitos;

	private int quantidadeDecimais;

	private EnumFormatoCampoLayoutArquivoCobranca formato;

	private bool manterAcentuacao;

	public EnumFormatoCampoLayoutArquivoCobranca Formato => formato;

	public int QuantidadeDecimais => quantidadeDecimais;

	public int QuantidadeDigitos => quantidadeDigitos;

	public int PosicaoFinal => posicaoFinal;

	public int PosicaoInicial => posicaoInicial;

	public string ValorPadrao => valorPadrao;

	public string Descricao => descricao;

	public string Nome => nome;

	public string Codigo => codigo;

	public string Valor
	{
		get
		{
			return valor;
		}
		set
		{
			if (value != null)
			{
				value = ((!manterAcentuacao) ? value.RemoverAcentuacao().RemoverCaracteresEspeciais() : value.RemoverCaracteresEspeciais());
				value = value.RemoverQuebrasLinha();
				if (value.Length > QuantidadeDigitos + QuantidadeDecimais)
				{
					valor = value.Substring(0, QuantidadeDigitos + QuantidadeDecimais).ToUpper();
				}
				else
				{
					valor = value.ToUpper();
				}
			}
		}
	}

	public CampoLayoutArquivoCobranca()
	{
		codigo = string.Empty;
		nome = string.Empty;
		descricao = string.Empty;
		valor = string.Empty;
		valorPadrao = string.Empty;
		posicaoInicial = 0;
		posicaoFinal = 0;
		quantidadeDigitos = 0;
		quantidadeDecimais = 0;
		manterAcentuacao = false;
		formato = EnumFormatoCampoLayoutArquivoCobranca.ALFA;
	}

	public CampoLayoutArquivoCobranca(string codigo, string nome, string descricao, EnumFormatoCampoLayoutArquivoCobranca formato, string valor, string valorPadrao, int posInicial, int posFinal, int qtdDigitos, int qtdDigitosDecimais)
		: this()
	{
		this.codigo = codigo;
		this.nome = nome;
		this.descricao = descricao;
		this.formato = formato;
		this.valor = valor;
		this.valorPadrao = valorPadrao;
		posicaoInicial = posInicial;
		posicaoFinal = posFinal;
		quantidadeDigitos = qtdDigitos;
		quantidadeDecimais = qtdDigitosDecimais;
		manterAcentuacao = false;
	}

	public CampoLayoutArquivoCobranca(string codigo, string nome, string descricao, EnumFormatoCampoLayoutArquivoCobranca formato, string valor, string valorPadrao, int posInicial, int posFinal, int qtdDigitos, int qtdDigitosDecimais, bool manterAcentuacao)
		: this(codigo, nome, descricao, formato, valor, valorPadrao, posInicial, posFinal, qtdDigitos, qtdDigitosDecimais)
	{
		this.manterAcentuacao = manterAcentuacao;
	}

	public CampoLayoutArquivoCobranca(CampoLayoutArquivoCobranca campo)
	{
		codigo = campo.codigo;
		nome = campo.nome;
		descricao = campo.descricao;
		formato = campo.formato;
		valorPadrao = campo.valorPadrao;
		posicaoInicial = campo.posicaoInicial;
		posicaoFinal = campo.posicaoFinal;
		quantidadeDigitos = campo.quantidadeDigitos;
		quantidadeDecimais = campo.quantidadeDecimais;
		manterAcentuacao = campo.manterAcentuacao;
		valor = string.Empty;
	}

	public void Preparar(string codigo, string nome, string descricao, EnumFormatoCampoLayoutArquivoCobranca formato, string valor, string valorPadrao, int posInicial, int posFinal, int qtdDigitos, int qtdDigitosDecimais)
	{
		this.codigo = codigo;
		this.nome = nome;
		this.descricao = descricao;
		this.formato = formato;
		this.valor = valor;
		this.valorPadrao = valorPadrao;
		posicaoInicial = posInicial;
		posicaoFinal = posFinal;
		quantidadeDigitos = qtdDigitos;
		quantidadeDecimais = qtdDigitosDecimais;
		manterAcentuacao = false;
	}

	public void Preparar(string codigo, string nome, string descricao, EnumFormatoCampoLayoutArquivoCobranca formato, string valor, string valorPadrao, int posInicial, int posFinal, int qtdDigitos, int qtdDigitosDecimais, bool manterAcentuacao)
	{
		this.codigo = codigo;
		this.nome = nome;
		this.descricao = descricao;
		this.formato = formato;
		this.valor = valor;
		this.valorPadrao = valorPadrao;
		posicaoInicial = posInicial;
		posicaoFinal = posFinal;
		quantidadeDigitos = qtdDigitos;
		quantidadeDecimais = qtdDigitosDecimais;
		this.manterAcentuacao = manterAcentuacao;
	}

	public string GetValorFormatado()
	{
		string text = "";
		try
		{
			Logger.Debug(string.Format("Formatando valor do campo [{0}]", codigo + " - " + nome));
			switch (formato)
			{
			case EnumFormatoCampoLayoutArquivoCobranca.ALFA:
				text = ((valor.Length < quantidadeDigitos + quantidadeDecimais) ? (valor + StringUtil.ObterStringComBrancos(quantidadeDigitos + quantidadeDecimais - valor.Length)) : valor.Substring(0, quantidadeDigitos + quantidadeDecimais));
				break;
			case EnumFormatoCampoLayoutArquivoCobranca.NUM:
				text = ((valor.Length < quantidadeDigitos + quantidadeDecimais) ? StringUtil.ZerosLeft(valor, quantidadeDigitos + quantidadeDecimais) : valor.Substring(0, quantidadeDigitos + quantidadeDecimais));
				break;
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoValorFormatadoCampoDocumentoCobranca(codigo + " - " + nome, Formato.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return text.ToUpper();
	}
}
