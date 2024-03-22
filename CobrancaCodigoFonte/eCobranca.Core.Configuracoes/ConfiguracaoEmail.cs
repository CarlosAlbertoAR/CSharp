using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Atributos;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoEmail : ConfiguracaoECobranca
{
	private string remetente;

	private string usuarioSMTP;

	private string senhaSMTP;

	private string assunto;

	private string mensagem;

	private string hostSMTP;

	private int portaSMTP;

	private bool enviaEmail;

	private bool possuiAutenticacao;

	private bool utilizaSSL;

	private string servidorSMTP;

	private ArrayList servidoresSMTP;

	public string UsuarioSMTP
	{
		get
		{
			return usuarioSMTP;
		}
		set
		{
			usuarioSMTP = value;
		}
	}

	public string ServidorSMTP
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = servidorSMTP;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumServidorSMTP), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						servidorSMTP = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ServidorSMTP", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			if (!string.IsNullOrEmpty(servidorSMTP))
			{
				AtributoSMTP attribute = servidorSMTP.ToEnum<EnumServidorSMTP>().GetAttribute<AtributoSMTP>();
				hostSMTP = attribute.ServidorSMTP;
				portaSMTP = attribute.Porta;
				utilizaSSL = attribute.UtilizaSSL;
				possuiAutenticacao = attribute.PossuiAutenticacao;
			}
		}
	}

	public ArrayList ServidoresSMTP => servidoresSMTP;

	public bool UtilizaSSL
	{
		get
		{
			return utilizaSSL;
		}
		set
		{
			utilizaSSL = value;
		}
	}

	public bool PossuiAutenticacao
	{
		get
		{
			return possuiAutenticacao;
		}
		set
		{
			possuiAutenticacao = value;
		}
	}

	public string SenhaSMTP
	{
		get
		{
			return senhaSMTP;
		}
		set
		{
			senhaSMTP = value;
		}
	}

	public bool EnviaEmail
	{
		get
		{
			return enviaEmail;
		}
		set
		{
			enviaEmail = value;
		}
	}

	public int PortaSMTP
	{
		get
		{
			return portaSMTP;
		}
		set
		{
			portaSMTP = value;
		}
	}

	public string Remetente
	{
		get
		{
			return remetente;
		}
		set
		{
			remetente = value;
		}
	}

	public string Assunto
	{
		get
		{
			return assunto;
		}
		set
		{
			assunto = value;
		}
	}

	public string Mensagem
	{
		get
		{
			return mensagem;
		}
		set
		{
			mensagem = value;
		}
	}

	public string HostSMTP
	{
		get
		{
			return hostSMTP;
		}
		set
		{
			hostSMTP = value;
		}
	}

	public ConfiguracaoEmail(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
		: base(guid, banco, modoUso, carteira)
	{
		remetente = string.Empty;
		usuarioSMTP = string.Empty;
		assunto = string.Empty;
		mensagem = string.Empty;
		enviaEmail = false;
		senhaSMTP = string.Empty;
		RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>());
		CarregarListas(repositorio);
	}

	public ConfiguracaoEmail(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		remetente = (string)serobj.GetValue("Remetente", typeof(string));
		usuarioSMTP = (string)serobj.GetValue("UsuarioSMTP", typeof(string));
		assunto = (string)serobj.GetValue("Assunto", typeof(string));
		mensagem = (string)serobj.GetValue("Mensagem", typeof(string));
		hostSMTP = (string)serobj.GetValue("HostSMTP", typeof(string));
		portaSMTP = (int)serobj.GetValue("PortaSMTP", typeof(int));
		enviaEmail = (bool)serobj.GetValue("EnviaEmail", typeof(bool));
		senhaSMTP = (string)serobj.GetValue("SenhaSMTP", typeof(string));
		possuiAutenticacao = (bool)serobj.GetValue("PossuiAutenticacao", typeof(bool));
		utilizaSSL = (bool)serobj.GetValue("UtilizaSSL", typeof(bool));
		servidoresSMTP = (ArrayList)serobj.GetValue("ServidoresSMTP", typeof(ArrayList));
	}

	public bool ConfiguracaoValida(string emailDestinatario)
	{
		bool flag = true;
		try
		{
			if (string.IsNullOrEmpty(emailDestinatario))
			{
				emailDestinatario = remetente;
			}
			return EmailUtil.EnviarEmail(new List<string> { emailDestinatario }, this);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		servidoresSMTP = repositorio.ServidoresSMTP;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Remetente", remetente);
		info.AddValue("UsuarioSMTP", usuarioSMTP);
		info.AddValue("SenhaSMTP", senhaSMTP);
		info.AddValue("Assunto", assunto);
		info.AddValue("Mensagem", mensagem);
		info.AddValue("HostSMTP", hostSMTP);
		info.AddValue("PortaSMTP", portaSMTP);
		info.AddValue("EnviaEmail", enviaEmail);
		info.AddValue("PossuiAutenticacao", possuiAutenticacao);
		info.AddValue("UtilizaSSL", utilizaSSL);
		info.AddValue("ServidoresSMTP", servidoresSMTP);
	}
}
