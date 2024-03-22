using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Comando;

public class ComandoGerarPreviewBoleto : ICommand
{
	private CarteiraCobranca carteira;

	private ModeloBoleto modeloBoleto;

	private ArrayList boleto = new ArrayList();

	private string nome;

	private DocumentoCobranca dc;

	private int alturaPagina;

	private int larguraPagina;

	private EnumTipoOrientacaoImpressao oritentacaoPagina;

	private bool impressaoPersonalizada;

	public void Execute()
	{
		try
		{
			ExcluirArquivosTemporarios();
			if (File.Exists(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + carteira.ConfiguracaoBoleto.ModeloBoletoPersonalizado))
			{
				modeloBoleto = carteira.FactoryModeloBoleto.GetModelo(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO, carteira);
			}
			else if (string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.TipoModeloBoletoUtilizado))
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.TipoModeloBoletoNaoEspecificadoOuNulo(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				modeloBoleto = GetInstanciaModeloBoleto((EnumTipoModeloBoleto)(object)EnumUtil.GetEnumByValue(typeof(EnumTipoModeloBoleto), carteira.ConfiguracaoBoleto.TipoModeloBoletoUtilizado));
			}
			if (boleto == null)
			{
				boleto = new ArrayList();
			}
			boleto.Clear();
			boleto.Add("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
			boleto.Add("<Dataset>");
			string[] array = modeloBoleto.GerarBoleto(dc);
			foreach (string value in array)
			{
				boleto.Add(value);
			}
			nome = carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto + "preview" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + carteira.ConfiguracaoImpressao.GetExtensaoArquivoSaida();
			FastReportsUtil.SalvarBoleto(carteira, modeloBoleto, boleto, nome, (EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoPreview(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void GetPreview()
	{
		dc = GerarDocumentoPreview();
		Execute();
		Process.Start(nome);
	}

	public void Preparar(CarteiraCobranca carteira)
	{
		this.carteira = carteira;
		string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_ALTURA_PAGINA_IMPRESSAO, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.AlturaPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
		string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_LARGURA_PAGINA_IMPRESSAO, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.LarguraPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
		string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_TIPO_ORIENTACAO_PAGINA, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.OrientacaoPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
		if (!string.IsNullOrEmpty(valorParametroAdicional))
		{
			alturaPagina = int.Parse(valorParametroAdicional);
		}
		if (!string.IsNullOrEmpty(valorParametroAdicional2))
		{
			larguraPagina = int.Parse(valorParametroAdicional2);
		}
		if (!string.IsNullOrEmpty(valorParametroAdicional3))
		{
			oritentacaoPagina = (EnumTipoOrientacaoImpressao)(object)valorParametroAdicional3.ToEnum<EnumTipoOrientacaoImpressao>();
		}
		impressaoPersonalizada = alturaPagina > 0 && larguraPagina > 0 && (oritentacaoPagina == EnumTipoOrientacaoImpressao.PAISAGEM || oritentacaoPagina == EnumTipoOrientacaoImpressao.RETRATO);
	}

	private ModeloBoleto GetInstanciaModeloBoleto(EnumTipoModeloBoleto tmb)
	{
		try
		{
			Logger.Debug($"Obtendo instância do modelo de boleto [{tmb.ToString()}]");
			foreach (ModeloBoleto item in carteira.ConfiguracaoBoleto.ModelosBoleto)
			{
				if (item.Tipo == tmb)
				{
					return item;
				}
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaObtendoModeloBoleto(tmb.ToString().ToUpper(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	private DocumentoCobranca GerarDocumentoPreview()
	{
		ArrayList arrayList = new ArrayList();
		DocumentoCobranca documentoCobranca = new DocumentoCobranca((carteira.ConfiguracaoDocumentoCobranca.ModalidadesCobranca[0] as ItemLista).Valor);
		try
		{
			documentoCobranca.CalculaDacNossoNumero = true;
			documentoCobranca.Aceite = "N";
			documentoCobranca.BancoEmiteBoleto = carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto;
			documentoCobranca.DataDocumento = DateTime.Today;
			documentoCobranca.DataProcessamento = DateTime.Today;
			documentoCobranca.DiasBaixaDevolucao = 0;
			documentoCobranca.DiasProtesto = 10;
			documentoCobranca.MinhaChave = "0000001/001";
			documentoCobranca.Moeda = carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda;
			documentoCobranca.GeraMensagemJuros = true;
			documentoCobranca.GeraMensagemMulta = true;
			documentoCobranca.GeraMensagemProtesto = true;
			documentoCobranca.GeraMensagemDesconto = true;
			documentoCobranca.NomePagador = "NOME DO PAGADOR";
			documentoCobranca.EnderecoPagador = "ENDEREÇO DO PAGADOR";
			documentoCobranca.NumeroDocumento = "0000001/001";
			documentoCobranca.CnpjPagador = "000.000.000-00";
			documentoCobranca.BairroPagador = "BAIRRO DO PAGADOR";
			documentoCobranca.CidadePagador = "CIDADE DO PAGADOR";
			documentoCobranca.UfPagador = "UF DO PAGADOR";
			documentoCobranca.CepPagador = "00000-000";
			documentoCobranca.PercentualDesconto = 0.0;
			documentoCobranca.PercentualJurosDiaAtraso = 0.0;
			documentoCobranca.PercentualMultaAtraso = 0.0;
			documentoCobranca.TipoDocumentoCobranca = (carteira.ConfiguracaoDocumentoCobranca.TiposDocumentosCobranca[0] as ItemLista).Valor;
			documentoCobranca.ValorDocumento = 1.0;
			documentoCobranca.DataVencimento = DateTime.Today;
			documentoCobranca.NumeroControle = "000001001";
			arrayList.Add(documentoCobranca);
			arrayList = carteira.CalcularDadosBoletos(arrayList);
			documentoCobranca = arrayList[0] as DocumentoCobranca;
			return documentoCobranca;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return documentoCobranca;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			return documentoCobranca;
		}
	}

	private void ExcluirArquivosTemporarios()
	{
		try
		{
			FileManager.RemoverApenasArquivosDoDiretorio(new DirectoryInfo(carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto ?? ""), "preview.pdf");
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaExcluindoArquivosTemporarios(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
