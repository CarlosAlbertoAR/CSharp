using System;

namespace eCobranca.Atributos;

public class AtributoSMTP : Attribute
{
	private string servidorSMTP;

	private int porta;

	private bool possuiAutenticacao;

	private bool utilizaSSL;

	public string ServidorSMTP => servidorSMTP;

	public int Porta => porta;

	public bool PossuiAutenticacao => possuiAutenticacao;

	public bool UtilizaSSL => utilizaSSL;

	public AtributoSMTP()
	{
	}

	public AtributoSMTP(string servidorSMTP, int porta, bool possuiAutenticacao, bool utilizaSSL)
	{
		this.servidorSMTP = servidorSMTP;
		this.porta = porta;
		this.possuiAutenticacao = possuiAutenticacao;
		this.utilizaSSL = utilizaSSL;
	}
}
