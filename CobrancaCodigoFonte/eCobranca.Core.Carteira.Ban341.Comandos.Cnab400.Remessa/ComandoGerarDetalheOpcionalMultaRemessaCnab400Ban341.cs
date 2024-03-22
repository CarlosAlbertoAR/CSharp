using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheOpcionalMultaRemessaCnab400Ban341 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheOpcionalMultaRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban341.DETALHE_OPCIONAL_MULTA.Codigo();
			ConfigurarMulta();
			(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).Brancos.Valor = "";
			(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).NumeroSequencial.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_ITAU, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).CodigoMulta.Valor = EnumCodigoMulta.NAO_REGISTRA_MULTA.Codigo();
		(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).DataMulta.Valor = "0";
		(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).Multa.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.NAO_REGISTRA_MULTA));
			DateTime? dataVencimento = base.Documento.DataVencimento;
			double num = 0.0;
			switch (enumCodigoMulta)
			{
			case EnumCodigoMulta.NAO_REGISTRA_MULTA:
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
				(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).DataMulta.Valor = (string)base.DateConverter.Convert(dataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheOpcionalMultaRemessaCnab400Ban341).Multa.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
