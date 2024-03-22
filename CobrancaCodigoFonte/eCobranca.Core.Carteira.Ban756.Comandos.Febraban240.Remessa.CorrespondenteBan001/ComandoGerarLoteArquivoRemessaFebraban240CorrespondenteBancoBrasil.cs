using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil : MacroCommand
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRemessaFebraban240 lote;

	public ComandoGerarLoteArquivoRemessaFebraban240CorrespondenteBancoBrasil(CarteiraCobranca carteira)
	{
		Logger.Debug("Criando macro comando para gerar lote de arquivo de remessa no layout FEBRABAN240...");
		this.carteira = carteira;
		GerarComandos();
	}

	private void GerarComandos()
	{
		try
		{
			Logger.Debug("Criando comandos integrantes...");
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoComandosDaMacroBaseGerarLoteArquivoRemessa(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(LoteCobrancaRemessaFebraban240 lote)
	{
		this.lote = lote;
		base.Comandos.Clear();
		ComandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil comandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil = (ComandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil)Activator.CreateInstance(typeof(ComandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil));
		comandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, lote);
		base.Comandos.Add(comandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil);
		foreach (DocumentoCobranca documento in lote.Documentos)
		{
			if (lote.GeraSegmentoDetalheP)
			{
				SegmentoDetalheFebraban240 segmento = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_P, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
				segmento = lote.AdicionarSegmento(segmento);
				ComandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil comandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil = (ComandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil)Activator.CreateInstance(typeof(ComandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil));
				comandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, segmento, documento);
				base.Comandos.Add(comandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil);
			}
			if (lote.GeraSegmentoDetalheQ)
			{
				SegmentoDetalheFebraban240 segmento2 = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.SEGMENTO_Q, 0L, 0L, segmentoDeRemessa: true) as SegmentoDetalheFebraban240;
				segmento2 = lote.AdicionarSegmento(segmento2);
				ComandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil comandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil = (ComandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil)Activator.CreateInstance(typeof(ComandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil));
				comandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, segmento2, documento);
				base.Comandos.Add(comandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil);
			}
		}
		ComandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil comandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil = (ComandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil)Activator.CreateInstance(typeof(ComandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil));
		comandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil.Preparar(carteira, lote);
		base.Comandos.Add(comandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil);
	}
}
