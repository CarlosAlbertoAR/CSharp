using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo7RemessaCnab400Ban748 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo7RemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 7 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TIPO 7 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Segmento as RegistroTipo7RemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_7.Codigo();
			(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as RegistroTipo7RemessaCnab400Ban748).SeuNumero.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).DataDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).DataDesconto2.Valor = valorParametroAdicional;
			}
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional2))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).ValorPercentualDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).ValorPercentualDesconto2.Valor = valorParametroAdicional2;
			}
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO3, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto3(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional3))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).DataDesconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).DataDesconto3.Valor = valorParametroAdicional3;
			}
			string valorParametroAdicional4 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO3, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto3(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional4))
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).ValorPercentualDesconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTipo7RemessaCnab400Ban748).ValorPercentualDesconto3.Valor = valorParametroAdicional4;
			}
			(base.Segmento as RegistroTipo7RemessaCnab400Ban748).Filler1.Valor = "";
			(base.Segmento as RegistroTipo7RemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
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
