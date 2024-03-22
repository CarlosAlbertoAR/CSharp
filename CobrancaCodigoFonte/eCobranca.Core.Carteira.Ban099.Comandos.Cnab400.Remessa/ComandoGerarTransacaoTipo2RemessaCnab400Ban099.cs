using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban099.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoTipo2RemessaCnab400Ban099 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoTipo2RemessaCnab400Ban099()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 2 da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 2 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).TipoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban099.MENSAGEM.Codigo();
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_DESCONTO);
			if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor))
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor))
				{
					(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor))
				{
					(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem3.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Mensagem4.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).DataDesconto2.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).ValorDesconto2.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).DataDesconto3.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).ValorDesconto3.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Filler1.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Carteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).Agencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).ContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).NossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1);
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).DVNossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).DVNossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2);
			}
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban099).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
