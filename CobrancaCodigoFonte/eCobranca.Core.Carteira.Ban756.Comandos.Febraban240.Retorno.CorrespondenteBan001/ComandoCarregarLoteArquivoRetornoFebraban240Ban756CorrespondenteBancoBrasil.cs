using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno.CorrespondenteBan001;

public class ComandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil : MacroCommand
{
	[NonSerialized]
	private CarteiraCobranca carteira;

	[NonSerialized]
	private LoteCobrancaRetornoFebraban240 lote;

	public ComandoCarregarLoteArquivoRetornoFebraban240Ban756CorrespondenteBancoBrasil(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para carregar o lote do arquivo de retorno do layout FEBRABAN240...");
		this.carteira = carteira;
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Gerando comandos integrantes...");
			base.Comandos.Clear();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.FalhaGerandoComandosDaMacroBaseCarregarLoteArquivoRetorno(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRetornoFebraban240 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
		base.Comandos.Clear();
		foreach (string item in lote.LinhasLote)
		{
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo())
			{
				ComandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil comandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil = new ComandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil();
				comandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, lote, item);
				base.Comandos.Add(comandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil);
			}
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.DETALHE.Codigo())
			{
				if (item.Substring(13, 1) == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_T.Codigo())
				{
					SegmentoDetalheFebraban240 segmento = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_T, 0L, 0L, segmentoDeRemessa: false) as SegmentoDetalheFebraban240;
					segmento = lote.AdicionarSegmento(segmento);
					ComandoCarregarSegmentoTRetornoFebraban240Ban756CorrespondenteBancoBrasil comandoCarregarSegmentoTRetornoFebraban240Ban756CorrespondenteBancoBrasil = new ComandoCarregarSegmentoTRetornoFebraban240Ban756CorrespondenteBancoBrasil();
					comandoCarregarSegmentoTRetornoFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, segmento, item);
					base.Comandos.Add(comandoCarregarSegmentoTRetornoFebraban240Ban756CorrespondenteBancoBrasil);
				}
				if (item.Substring(13, 1) == EnumTipoSegmentoDetalheFebraban240.SEGMENTO_U.Codigo())
				{
					SegmentoDetalheFebraban240 segmento2 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_U, 0L, 0L, segmentoDeRemessa: false) as SegmentoDetalheFebraban240;
					segmento2 = lote.AdicionarSegmento(segmento2);
					ComandoCarregarSegmentoURetornoFebraban240Ban756CorrespondenteBancoBrasil comandoCarregarSegmentoURetornoFebraban240Ban756CorrespondenteBancoBrasil = new ComandoCarregarSegmentoURetornoFebraban240Ban756CorrespondenteBancoBrasil();
					comandoCarregarSegmentoURetornoFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, segmento2, item);
					base.Comandos.Add(comandoCarregarSegmentoURetornoFebraban240Ban756CorrespondenteBancoBrasil);
				}
			}
			if (item.Substring(7, 1) == EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo())
			{
				ComandoCarregarTraillerLoteRetornoFebraban240Ban756CorrespondenteBancoBrasil comandoCarregarTraillerLoteRetornoFebraban240Ban756CorrespondenteBancoBrasil = new ComandoCarregarTraillerLoteRetornoFebraban240Ban756CorrespondenteBancoBrasil();
				comandoCarregarTraillerLoteRetornoFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, lote, item);
				base.Comandos.Add(comandoCarregarTraillerLoteRetornoFebraban240Ban756CorrespondenteBancoBrasil);
			}
		}
	}
}
