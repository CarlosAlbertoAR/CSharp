using System;
using eCobranca.Util;

namespace eCobranca.Core.Excecao;

public class ExcecaoECobranca : Exception
{
	public static ExcecoesCarteiraCobranca CarteiraCobranca = new ExcecoesCarteiraCobranca();

	public static ExcecoesInfra Infra = new ExcecoesInfra();

	public static ExcecoesRemessa Remessa = new ExcecoesRemessa();

	public static ExcecoesRetorno Retorno = new ExcecoesRetorno();

	public static ExcecoesArquivoCobranca ArquivoCobranca = new ExcecoesArquivoCobranca();

	public static ExcecoesModeloBoleto ModeloBoleto = new ExcecoesModeloBoleto();

	private int codigo;

	public int Codigo => codigo;

	public string Mensagem => Message;

	public ExcecaoECobranca(int codigo, string mensagem, Exception innerException)
		: base($"[{StringUtil.ZerosLeft(codigo.ToString(), 5)}] {mensagem}", innerException)
	{
		this.codigo = codigo;
	}
}
