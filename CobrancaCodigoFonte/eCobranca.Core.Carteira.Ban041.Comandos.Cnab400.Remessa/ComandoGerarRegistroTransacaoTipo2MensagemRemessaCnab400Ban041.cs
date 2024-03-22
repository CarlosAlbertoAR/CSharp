using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban041 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTransacaoTipo2MensagemRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_2_MENSAGEM.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length < 14)
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1) + StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).Filler1.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).IdentificacaoTituloBeneficiario.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).NossoNumero.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).Filler2.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).CodigoCarteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ControleCanalMensagem1.Valor = "1";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ControleCanalMensagem2.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ControleCanalMensagem1.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_DESCONTO);
			if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor))
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor))
				{
					(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor))
				{
					(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem3.Valor))
					{
						(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).ConteudoMensagem3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).Filler3.Valor = "";
			(base.Segmento as RegistroTransacaoTipo2MensagemRemessaCnab400Ban041).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
