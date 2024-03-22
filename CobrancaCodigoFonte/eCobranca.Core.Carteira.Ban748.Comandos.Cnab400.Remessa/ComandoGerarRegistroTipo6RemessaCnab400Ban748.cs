using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo6RemessaCnab400Ban748 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo6RemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 6 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TIPO 6 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_6.Codigo();
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).SeuNumero.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).CodigoPagadorNoBeneficiario.Valor = "0";
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as RegistroTipo6RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else
			{
				(base.Segmento as RegistroTipo6RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).EnderecoSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_ENDERECO_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.EnderecoSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).CidadeSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CIDADE_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.CidadeSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).CepSacadorAvalista.Valor = StringUtil.RemoverMascara(ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CEP_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.CepSacadorAvalista(), base.Documento.ParametrosAdicionais));
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).UfSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_UF_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.UfSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).Filler1.Valor = "";
			(base.Segmento as RegistroTipo6RemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
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
