using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo5RemessaCnab400Ban136 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo5RemessaCnab400Ban136()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 5 da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNICRED}]...");
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban136.REGISTRO_TIPO5.Codigo();
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).EderecoEmail.Valor = string.Empty;
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).TipoInscricao.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).TipoInscricao.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else
			{
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).TipoInscricao.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).TipoInscricao.Valor = "000" + StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			if (!string.IsNullOrEmpty(base.Documento.NumeroEnderecoSacadorAvalista))
			{
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Logradouro.Valor = base.Documento.EnderecoSacadorAvalista + ", " + base.Documento.NumeroEnderecoSacadorAvalista;
			}
			else
			{
				(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Logradouro.Valor = base.Documento.EnderecoSacadorAvalista;
			}
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Bairro.Valor = base.Documento.BairroSacadorAvalista + ", " + base.Documento.NumeroEnderecoSacadorAvalista;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Cidade.Valor = base.Documento.CidadeSacadorAvalista;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Estado.Valor = base.Documento.UfSacadorAvalista;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Mensagem1.Valor = string.Empty;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Mensagem2.Valor = string.Empty;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).Filler1.Valor = string.Empty;
			(base.Segmento as IRegistroTipo5RemesaCnab400Ban136).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
