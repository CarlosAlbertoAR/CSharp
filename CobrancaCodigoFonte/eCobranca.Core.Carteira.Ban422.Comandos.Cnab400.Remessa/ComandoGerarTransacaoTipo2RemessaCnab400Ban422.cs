using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoTipo2RemessaCnab400Ban422 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoTipo2RemessaCnab400Ban422()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban422.TRANSACAO_TIPO_2.Codigo();
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).EnderecoEmailPagador.Valor = ((!string.IsNullOrEmpty(base.Documento.EmailPagador)) ? base.Documento.EmailPagador : string.Empty);
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).Filler1.Valor = StringUtil.ObterStringComBrancos(100);
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).TipoPessoaBeneficiario.Valor = (base.Carteira.ConfiguracaoCarteiraCobranca.TipoInscricaoBeneficiario.Equals(EnumTipoInscricao.CPF.ToString()) ? EnumTipoInscricao.CPF_PF.Codigo() : EnumTipoInscricao.CNPJ_PJ.Codigo());
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).NumeroInscricaoBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).EnderecoBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).BairroBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).CidadeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).UfBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario;
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).NumeroSequencialArquivoRemessa.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo2RemessaCnab400Ban422).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SAFRA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
