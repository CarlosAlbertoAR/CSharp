using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo2RemessaCnab400Ban748 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo2RemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 2 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TIPO 2 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_2.Codigo();
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).Filler1.Valor = "";
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_DESCONTO);
			if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor))
			{
				(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor))
				{
					(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor))
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao1.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor))
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			else
			{
				(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_MULTA);
				if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor))
				{
					(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor))
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao2.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
				else
				{
					(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_JUROS);
					if (string.IsNullOrEmpty((base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao3.Valor))
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao3.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
					else
					{
						(base.Segmento as RegistroTipo2RemessaCnab400Ban748).InstrucaoImpressao4.Valor = GetMensagem(EnumTipoMensagemCnab400.MENSAGEM_PROTESTO);
					}
				}
			}
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).SeuNumero.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).Filler2.Valor = "";
			(base.Segmento as RegistroTipo2RemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
