using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Cnab400.Remessa;

public class ComandoGerarMensagemMultaRemessaCnab400Ban001 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarMensagemMultaRemessaCnab400Ban001()
	{
		Logger.Debug($"Criando comando para gerar o MENSAGEM MULTA da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			(base.Segmento as MensagemRemessaCnab400Ban001Multa).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_MULTA.Codigo();
			(base.Segmento as MensagemRemessaCnab400Ban001Multa).TipoServico.Valor = EnumTipoServico.COBRANCA_DE_MULTA.Codigo();
			ConfigurarMulta();
			(base.Segmento as MensagemRemessaCnab400Ban001Multa).Filler1.Valor = "";
			(base.Segmento as MensagemRemessaCnab400Ban001Multa).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarMensagemArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as MensagemRemessaCnab400Ban001Multa).DataMulta.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
		(base.Segmento as MensagemRemessaCnab400Ban001Multa).CodigoMulta.Valor = EnumCodigoMulta.DISPENSAR_MULTA.Codigo();
		(base.Segmento as MensagemRemessaCnab400Ban001Multa).ValorPercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.DISPENSAR_MULTA));
			DateTime? dataVencimento = base.Documento.DataVencimento;
			double num = 0.0;
			switch (enumCodigoMulta)
			{
			case EnumCodigoMulta.DISPENSAR_MULTA:
				return;
			case EnumCodigoMulta.VALOR_FIXO:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoMulta.PERCENTUAL:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as MensagemRemessaCnab400Ban001Multa).DataMulta.Valor = (string)base.DateConverter.Convert(dataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as MensagemRemessaCnab400Ban001Multa).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as MensagemRemessaCnab400Ban001Multa).ValorPercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
