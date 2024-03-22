using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class EmailUtil
{
	public static bool EnviarEmail(List<string> destinatarios, ConfiguracaoEmail configuracao)
	{
		bool result = false;
		try
		{
			foreach (string destinatario in destinatarios)
			{
				if (!ValidarEmail(destinatario.ToLower()))
				{
					throw ExcecaoECobranca.Infra.EmailInvalido(destinatario.ToLower());
				}
				if (!ValidarEmail(configuracao.Remetente))
				{
					throw ExcecaoECobranca.Infra.EmailInvalido(configuracao.Remetente.ToLower());
				}
				using (MailMessage message = new MailMessage(configuracao.Remetente.ToLower(), destinatario.ToLower(), configuracao.Assunto, configuracao.Mensagem))
				{
					SmtpClient smtpClient = new SmtpClient(configuracao.HostSMTP, configuracao.PortaSMTP);
					smtpClient.EnableSsl = configuracao.UtilizaSSL;
					if (configuracao.PossuiAutenticacao)
					{
						smtpClient.Credentials = new NetworkCredential(configuracao.UsuarioSMTP, configuracao.SenhaSMTP);
					}
					smtpClient.Send(message);
				}
				result = true;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaEnviandoEmail(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static bool EnviarEmail(List<string> destinatarios, ConfiguracaoEmail configuracao, List<string> anexos)
	{
		bool result = false;
		try
		{
			foreach (string destinatario in destinatarios)
			{
				if (!ValidarEmail(destinatario.ToLower()))
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.EmailInvalido(destinatario), new StackTrace().GetFrame(1).GetMethod());
					return false;
				}
				if (!ValidarEmail(configuracao.Remetente))
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.EmailInvalido(configuracao.Remetente), new StackTrace().GetFrame(1).GetMethod());
					return false;
				}
				using (MailMessage mailMessage = new MailMessage(configuracao.Remetente.ToLower(), destinatario.ToLower(), configuracao.Assunto, configuracao.Mensagem))
				{
					foreach (string anexo in anexos)
					{
						Attachment item = new Attachment(anexo, "application/octet-stream");
						mailMessage.Attachments.Add(item);
					}
					SmtpClient smtpClient = new SmtpClient(configuracao.HostSMTP, configuracao.PortaSMTP);
					smtpClient.EnableSsl = configuracao.UtilizaSSL;
					if (configuracao.PossuiAutenticacao)
					{
						smtpClient.Credentials = new NetworkCredential(configuracao.UsuarioSMTP, configuracao.SenhaSMTP);
					}
					smtpClient.Send(mailMessage);
				}
				result = true;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaEnviandoEmail(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static bool ValidarEmail(string email)
	{
		bool result = false;
		try
		{
			result = new Regex("\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}").IsMatch(email);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaValidandoEmail(email, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
