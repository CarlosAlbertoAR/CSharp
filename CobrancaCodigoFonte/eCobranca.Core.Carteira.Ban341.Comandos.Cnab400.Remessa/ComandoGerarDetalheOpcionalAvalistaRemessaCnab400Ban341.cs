using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban341 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheOpcionalAvalistaRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban341.DETALHE_OPCIONAL.Codigo();
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).Filler1.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).EnderecoSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_ENDERECO_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.EnderecoSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).BairroSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_BAIRRO_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.BairroSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).CepSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CEP_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.CepSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).CidadeSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CIDADE_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.CidadeSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).UFSacadorAvalista.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_UF_SACADOR_AVALISTA, base.Carteira.ParametrosDisponiveis.Documento.UfSacadorAvalista(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).Filler2.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban341).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
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
}
