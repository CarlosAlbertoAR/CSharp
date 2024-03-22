using System;
using System.Collections;
using System.Collections.Generic;
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

public class ComandoGerarBoletosFisicos : ICommand
{
	private readonly string TAG_INICIO_XML = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + Environment.NewLine;

	private readonly string TAG_INICIO_DATABASE = "<Dataset>" + Environment.NewLine;

	public const int MERGE_MAX_PAGES = 10;

	private CarteiraCobranca carteira;

	private ArrayList dcList;

	private List<string> filaImpressao;

	private ArrayList dadosImpressao;

	private int currentPagesMerged;

	private ModeloBoleto modeloBoleto;

	private ModeloBoleto modeloBoletoSecundario;

	private List<ArquivoEnvioEmail> arquivosParaEnvio;

	private int alturaPagina;

	private int larguraPagina;

	private EnumTipoOrientacaoImpressao oritentacaoPagina;

	private bool impressaoPersonalizada;

	private IList<BoletoStream> boletosStream;

	private byte[] allBytes;

	private bool modoStream;

	private bool modoIndividual;

	private string nomeModeloBoletoSecundario;

	public List<string> FilaImpressao => filaImpressao;

	public List<ArquivoEnvioEmail> ArquivosParaEnvio => arquivosParaEnvio;

	public IList<BoletoStream> BoletosStream => boletosStream;

	public ArrayList DadosImpressao => dadosImpressao;

	public ModeloBoleto ModeloBoleto => modeloBoleto;

	public ModeloBoleto ModeloBoletoSecundario => modeloBoletoSecundario;

	public void Execute()
	{
		try
		{
			if (carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				return;
			}
			ExcluirArquivosTemporarios();
			Logger.Debug("Gerando os boletos com os documentos de cobrança...");
			int num = 0;
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			arrayList.Add(TAG_INICIO_XML);
			arrayList.Add(TAG_INICIO_DATABASE);
			arrayList2.Add(TAG_INICIO_XML);
			arrayList2.Add(TAG_INICIO_DATABASE);
			arrayList3.Add(TAG_INICIO_XML);
			arrayList3.Add(TAG_INICIO_DATABASE);
			allBytes = null;
			filaImpressao.Clear();
			modeloBoletoSecundario = (string.IsNullOrEmpty(nomeModeloBoletoSecundario) ? null : GetInstanciaModeloBoleto((EnumTipoModeloBoleto)(object)EnumUtil.GetEnumByValue(typeof(EnumTipoModeloBoleto), nomeModeloBoletoSecundario)));
			if (File.Exists(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + carteira.ConfiguracaoBoleto.ModeloBoletoPersonalizado))
			{
				modeloBoleto = carteira.FactoryModeloBoleto.GetModelo(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO, carteira);
				if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.FormatoBoletoPersonalizado))
				{
					switch ((EnumFormatoModeloBoleto)(object)carteira.ConfiguracaoBoleto.FormatoBoletoPersonalizado.ToEnum<EnumFormatoModeloBoleto>())
					{
					case EnumFormatoModeloBoleto.PAGINA_INTEIRA:
						carteira.ConfiguracaoBoleto.NumeroBoletosPorPagina = 1;
						break;
					case EnumFormatoModeloBoleto.MEIA_PAGINA:
						carteira.ConfiguracaoBoleto.NumeroBoletosPorPagina = 2;
						break;
					case EnumFormatoModeloBoleto.CARNET_TRES_POR_PAGINA:
						carteira.ConfiguracaoBoleto.NumeroBoletosPorPagina = 3;
						break;
					}
				}
			}
			else if (string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.TipoModeloBoletoUtilizado))
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.TipoModeloBoletoNaoEspecificadoOuNulo(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				modeloBoleto = GetInstanciaModeloBoleto((EnumTipoModeloBoleto)(object)EnumUtil.GetEnumByValue(typeof(EnumTipoModeloBoleto), carteira.ConfiguracaoBoleto.TipoModeloBoletoUtilizado));
			}
			for (int i = 0; i < dcList.Count; i++)
			{
				arrayList.Clear();
				arrayList.Add(TAG_INICIO_XML);
				arrayList.Add(TAG_INICIO_DATABASE);
				arrayList.Add(string.Join(" ", ModeloBoleto.GerarBoleto((DocumentoCobranca)dcList[i])));
				arrayList2.Add(string.Join(" ", ModeloBoleto.GerarBoleto((DocumentoCobranca)dcList[i])));
				arrayList3.Add(arrayList2[arrayList2.Count - 1]);
				num++;
				if (num == carteira.ConfiguracaoBoleto.NumeroBoletosPorPagina || i == dcList.Count - 1)
				{
					currentPagesMerged++;
					if ((EnumModoSaida)(object)carteira.ConfiguracaoImpressao.ModoSaida.ToEnum<EnumModoSaida>() == EnumModoSaida.SAIDA_INDIVIDUAL || (EnumModoSaida)(object)carteira.ConfiguracaoImpressao.ModoSaida.ToEnum<EnumModoSaida>() == EnumModoSaida.SAIDA_COMPOSTA)
					{
						GerarBoletoIndividual(arrayList2, dcList[i] as DocumentoCobranca);
					}
					num = 0;
				}
				if (carteira.ConfiguracaoEmail.EnviaEmail && (dcList[i] as DocumentoCobranca).EmailPagador != string.Empty)
				{
					if (impressaoPersonalizada)
					{
						GerarBoletoParaEnvioPorEmail(arrayList2, dcList[i] as DocumentoCobranca);
					}
					else
					{
						GerarBoletoParaEnvioPorEmail(arrayList, dcList[i] as DocumentoCobranca);
					}
				}
				if ((EnumModoSaida)(object)carteira.ConfiguracaoImpressao.ModoSaida.ToEnum<EnumModoSaida>() == EnumModoSaida.SAIDA_UNIFICADA || (EnumModoSaida)(object)carteira.ConfiguracaoImpressao.ModoSaida.ToEnum<EnumModoSaida>() == EnumModoSaida.SAIDA_COMPOSTA)
				{
					if (impressaoPersonalizada)
					{
						GerarBoletosEmLote(arrayList2, i);
					}
					else
					{
						GerarBoletosEmLote(arrayList3, i);
					}
				}
			}
			if (arrayList3 != null && arrayList3.Count > 0)
			{
				EnviarBoletosFilaImpressao(arrayList3);
				currentPagesMerged = 0;
				arrayList3.Clear();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, ArrayList dcList)
	{
		this.carteira = carteira;
		this.dcList = dcList;
		modoStream = false;
		modoIndividual = false;
		filaImpressao = new List<string>();
		boletosStream = new List<BoletoStream>();
		dadosImpressao = new ArrayList();
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		arquivosParaEnvio = new List<ArquivoEnvioEmail>();
		nomeModeloBoletoSecundario = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_MODELO_BOLETO_SECUNDARIO, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ModeloBoletoSecundario(), carteira.ConfiguracaoBoleto.ParametrosAdicionais);
		if (carteira.ConfiguracaoBoleto.TipoModeloBoletoUtilizado == EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA.ToString())
		{
			empty = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_ALTURA_PAGINA_IMPRESSAO, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.AlturaPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
			empty2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_LARGURA_PAGINA_IMPRESSAO, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.LarguraPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
			empty3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_TIPO_ORIENTACAO_PAGINA, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.OrientacaoPagina(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(empty))
			{
				alturaPagina = int.Parse(empty);
			}
			if (!string.IsNullOrEmpty(empty2))
			{
				larguraPagina = int.Parse(empty2);
			}
			if (!string.IsNullOrEmpty(empty3))
			{
				oritentacaoPagina = (EnumTipoOrientacaoImpressao)(object)empty3.ToEnum<EnumTipoOrientacaoImpressao>();
			}
		}
		impressaoPersonalizada = alturaPagina > 0 && larguraPagina > 0 && (oritentacaoPagina == EnumTipoOrientacaoImpressao.PAISAGEM || oritentacaoPagina == EnumTipoOrientacaoImpressao.RETRATO);
	}

	public void Preparar(CarteiraCobranca carteira, ArrayList dcList, bool modoStream, bool modoIndividual)
	{
		Preparar(carteira, dcList);
		this.modoStream = modoStream;
		this.modoIndividual = modoIndividual;
	}

	private void EnviarBoletosFilaImpressao(ArrayList boletos)
	{
		if (!carteira.ConfiguracaoImpressao.ImpressaoAtiva)
		{
			return;
		}
		string text = "";
		text = AppDomain.CurrentDomain.BaseDirectory + "\\BoletoTemp" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
		FastReportsUtil.SalvarBoleto(carteira, modeloBoleto, boletos, text);
		filaImpressao.Add(text + ".pdf");
		foreach (object boleto in boletos)
		{
			dadosImpressao.Add(boleto);
		}
	}

	private void ExcluirArquivosTemporarios()
	{
		try
		{
			FileManager.RemoverApenasArquivosDoDiretorio(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory), "BoletoTemp.pdf");
			FileManager.LimparDiretorioESubPastas(AppDomain.CurrentDomain.BaseDirectory + "\\Temp\\");
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

	private void GerarBoletoIndividual(ArrayList boleto, DocumentoCobranca documento)
	{
		string nomeArquivo = "";
		if (string.IsNullOrEmpty(documento.NomenclaturaBoleto))
		{
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.TipoNomenclatura))
			{
				switch ((EnumTipoNomenclaturaBoleto)(object)carteira.ConfiguracaoBoleto.TipoNomenclatura.ToEnum<EnumTipoNomenclaturaBoleto>())
				{
				case EnumTipoNomenclaturaBoleto.CNPJ_DOCUMENTO_NN:
					nomeArquivo = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + (string.IsNullOrEmpty(documento.CnpjPagador) ? StringUtil.RemoverMascara(documento.CpfPagador) : StringUtil.RemoverMascara(documento.CnpjPagador)) + "_" + StringUtil.RemoverMascara(documento.NumeroDocumento) + "_" + documento.NossoNumeroSemMascara;
					break;
				case EnumTipoNomenclaturaBoleto.DOCUMENTO_NN:
					nomeArquivo = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + StringUtil.RemoverMascara(documento.NumeroDocumento) + "_" + documento.NossoNumeroSemMascara;
					break;
				case EnumTipoNomenclaturaBoleto.NN:
					nomeArquivo = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + documento.NossoNumeroSemMascara;
					break;
				}
			}
			else
			{
				nomeArquivo = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + documento.NossoNumeroSemMascara;
			}
		}
		else
		{
			nomeArquivo = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + documento.NomenclaturaBoleto;
		}
		if (ModeloBoletoSecundario != null)
		{
			FastReportsUtil.SalvarBoleto(carteira, ModeloBoletoSecundario, boleto, nomeArquivo, EnumFormatoSaida.IMAGEM_ROTACIONADA);
		}
		using (MemoryStream memoryStream = FastReportsUtil.SalvarBoleto(carteira, ModeloBoleto, boleto, nomeArquivo, (EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>()))
		{
			if (modoStream && modoIndividual && memoryStream != null)
			{
				memoryStream.Position = 0L;
				boletosStream.Add(new BoletoStream(memoryStream.ToArray(), (EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>()));
			}
		}
		boleto.Clear();
		boleto.Add(TAG_INICIO_XML);
		boleto.Add(TAG_INICIO_DATABASE);
	}

	private void GerarBoletoParaEnvioPorEmail(ArrayList boleto, DocumentoCobranca documento)
	{
		string text = "";
		if (string.IsNullOrEmpty(documento.NomenclaturaBoleto))
		{
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.TipoNomenclatura))
			{
				switch ((EnumTipoNomenclaturaBoleto)(object)carteira.ConfiguracaoBoleto.TipoNomenclatura.ToEnum<EnumTipoNomenclaturaBoleto>())
				{
				case EnumTipoNomenclaturaBoleto.CNPJ_DOCUMENTO_NN:
					text = carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto + "Temp\\" + carteira.ConfiguracaoBoleto.PrefixoNomenclatura + (string.IsNullOrEmpty(documento.CnpjPagador) ? StringUtil.RemoverMascara(documento.CpfPagador) : StringUtil.RemoverMascara(documento.CnpjPagador)) + "_" + StringUtil.RemoverMascara(documento.NumeroDocumento) + "_" + documento.NossoNumeroSemMascara;
					break;
				case EnumTipoNomenclaturaBoleto.DOCUMENTO_NN:
					text = carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto + "Temp\\" + carteira.ConfiguracaoBoleto.PrefixoNomenclatura + StringUtil.RemoverMascara(documento.NumeroDocumento) + "_" + documento.NossoNumeroSemMascara;
					break;
				case EnumTipoNomenclaturaBoleto.NN:
					text = carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto + "Temp\\" + carteira.ConfiguracaoBoleto.PrefixoNomenclatura + documento.NossoNumeroSemMascara;
					break;
				}
			}
			else
			{
				text = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + documento.NossoNumeroSemMascara;
			}
		}
		else
		{
			text = ((!string.IsNullOrEmpty(documento.DiretorioGeracaoBoleto)) ? documento.DiretorioGeracaoBoleto : carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto) + ((!string.IsNullOrEmpty(documento.PrefixoNomenclaturaBoleto)) ? documento.PrefixoNomenclaturaBoleto : carteira.ConfiguracaoBoleto.PrefixoNomenclatura) + documento.NomenclaturaBoleto;
		}
		text += carteira.ConfiguracaoImpressao.GetExtensaoArquivoSaida();
		FastReportsUtil.SalvarBoleto(carteira, ModeloBoleto, boleto, text, (EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>());
		arquivosParaEnvio.Add(new ArquivoEnvioEmail(text, documento.EmailPagador));
	}

	private void GerarBoletosEmLote(ArrayList todosBoletos, int indexAtual)
	{
		string text = "";
		text = carteira.ConfiguracaoBoleto.DiretorioGeracaoBoleto + "BoletoTemp" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
		if (indexAtual == dcList.Count - 1)
		{
			FastReportsUtil.SalvarBoleto(carteira, ModeloBoleto, todosBoletos, text);
			if (ModeloBoletoSecundario != null)
			{
				FastReportsUtil.SalvarBoleto(carteira, ModeloBoletoSecundario, todosBoletos, text);
			}
		}
	}
}
