using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Properties;
using eCobranca.Util;

namespace eCobranca.Core.Modelo;

public abstract class ModeloBoleto : IModeloBoleto
{
	protected const string TEMPLATE_ESTILOS_PERSONALIZADO_HTML = "TEMPLATE_EstilosPersonalizadoHtml.html";

	protected const string TEMPLATE_ESTILOS_PERSONALIZADO_PDF = "TEMPLATE_EstilosPersonalizadoPdf.html";

	protected const string TEMPLATE_RECIBO_SACADO_GRANDE_PERSONALIZADO = "TEMPLATE_ReciboSacadoGrandePersonalizado.html";

	protected const string TEMPLATE_RECIBO_SACADO_NORMAL_PERSONALIZADO = "TEMPLATE_ReciboSacadoNormalPersonalizado.html";

	protected const string TEMPLATE_RECIBO_SACADO_REDUZIDO_PERSONALIZADO = "TEMPLATE_ReciboSacadoReduzidoPersonalizado.html";

	protected const string TEMPLATE_RECIBO_SACADO_SIMPLES_PERSONALIZADO = "TEMPLATE_ReciboSacadoSimplesPersonalizado.html";

	protected const string TEMPLATE_RECIBO_SACADO_CANHOTO_PERSONALIZADO = "TEMPLATE_ReciboSacadoCanhotoPersonalizado.html";

	protected const string TEMPLATE_RECIBO_ENTREGA_CANHOTO_PERSONALIZADO = "TEMPLATE_ReciboEntregaCanhotoPersonalizado.html";

	protected const string TEMPLATE_RECIBO_ENTREGA_NORMAL_PERSONALIZADO = "TEMPLATE_ReciboEntregaNormalPersonalizado.html";

	protected const string TEMPLATE_RECIBO_ENTREGA_REDUZIDO_PERSONALIZADO = "TEMPLATE_ReciboEntregaReduzidoPersonalizado.html";

	protected const string TEMPLATE_RECIBO_ENTREGA_SIMPLES_PERSONALIZADO = "TEMPLATE_ReciboEntregaSimplesPersonalizado.html";

	protected const string TEMPLATE_FICHA_COMPENSACAO_PERSONALIZADO = "TEMPLATE_FichaCompensacaoPersonalizado.html";

	protected const string TEMPLATE_TRACO_PERSONALIZADO = "TEMPLATE_TracoPersonalizado.html";

	protected CarteiraCobranca carteira;

	protected EnumFormatoModeloBoleto formato;

	protected string[] modeloBoletoHtml;

	protected byte[] modeloBoletoFastReports;

	protected List<string> campos;

	protected List<string> valores;

	protected EnumTipoModeloBoleto tipo;

	public int QuantidadeMaximaPorPagina => formato switch
	{
		EnumFormatoModeloBoleto.PAGINA_INTEIRA => 1, 
		EnumFormatoModeloBoleto.MEIA_PAGINA => 2, 
		EnumFormatoModeloBoleto.CARNET_TRES_POR_PAGINA => 3, 
		_ => 1, 
	};

	public string CaminhoModeloPersonalizadoHtml { get; set; }

	public bool FichaCompensacaoPersonalizada { get; set; }

	public EnumTipoModeloBoleto Tipo => tipo;

	public CarteiraCobranca CarteiraCobranca
	{
		get
		{
			return carteira;
		}
		set
		{
			carteira = value;
		}
	}

	public string[] ModeloBoletoHtml => modeloBoletoHtml;

	public byte[] ModeloBoletoFastReports
	{
		get
		{
			if (modeloBoletoFastReports == null)
			{
				modeloBoletoFastReports = GetModeloFastReports();
			}
			return modeloBoletoFastReports;
		}
	}

	protected abstract string[] GetModeloHtml();

	protected abstract byte[] GetModeloFastReports();

	protected List<string> ObterCamposLinhaModeloBoleto(string linha)
	{
		List<string> list = new List<string>();
		try
		{
			Logger.Debug($"Obtendo campos da linha do modelo do boleto [{linha}]");
			if (linha.Length == 0)
			{
				return list;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string text = "";
			while (linha.IndexOf("#") > -1)
			{
				num = linha.IndexOf("#");
				num++;
				num2 = 0;
				num3 = 0;
				text = "";
				for (int i = num; linha[i] != '>'; i++)
				{
					num2 = i;
				}
				num3 = num2 - num + 1;
				text = linha.Substring(num, num3);
				list.Add(text);
				linha = linha.Replace("#" + text, "");
			}
			return list;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return list;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoCamposModeloBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			return list;
		}
	}

	protected List<string> GetValoresParaLinhaModelo(List<string> campos, DocumentoCobranca dc)
	{
		List<string> list = new List<string>();
		int i = 0;
		carteira.ProvedorDadosBoleto.Preparar(carteira, dc, this);
		try
		{
			for (i = 0; i < campos.Count; i++)
			{
				if (Enum.IsDefined(typeof(EnumLayoutBoletoImpressoFields), campos[i].ToString().ToUpper()))
				{
					Logger.Debug($"Obtendo valor para o campo [{campos[i].ToString().ToUpper()}] do modelo do boleto");
					switch ((EnumLayoutBoletoImpressoFields)Enum.Parse(typeof(EnumLayoutBoletoImpressoFields), campos[i].ToString().ToUpper()))
					{
					case EnumLayoutBoletoImpressoFields.LOGOTIPOBANCO:
						list.Add(carteira.ProvedorDadosBoleto.GetLogoTipoBanco());
						break;
					case EnumLayoutBoletoImpressoFields.IMAGEMAUTENTICACAOMECANICA:
						list.Add(carteira.ProvedorDadosBoleto.GetImagemAutenticacaoMecanica());
						break;
					case EnumLayoutBoletoImpressoFields.LOGOTIPOCEDENTE:
						list.Add(carteira.ProvedorDadosBoleto.GetLogotipoCedente());
						break;
					case EnumLayoutBoletoImpressoFields.NUMEROBANCO:
						list.Add(carteira.ProvedorDadosBoleto.GetNumeroBanco());
						break;
					case EnumLayoutBoletoImpressoFields.VENCIMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetVencimento());
						break;
					case EnumLayoutBoletoImpressoFields.AGENCIACODIGOCEDENTE:
						list.Add(carteira.ProvedorDadosBoleto.GetAgenciaCodigoCedente());
						break;
					case EnumLayoutBoletoImpressoFields.MOEDA:
						list.Add(carteira.ProvedorDadosBoleto.GetMoeda());
						break;
					case EnumLayoutBoletoImpressoFields.QUANTIDADE:
						list.Add(carteira.ProvedorDadosBoleto.GetQuantidade());
						break;
					case EnumLayoutBoletoImpressoFields.VALORDOCUMENTOEXIBICAO:
						list.Add(carteira.ProvedorDadosBoleto.GetValorDocumento());
						break;
					case EnumLayoutBoletoImpressoFields.VALORDESCONTOEXIBICAO:
						list.Add(carteira.ProvedorDadosBoleto.GetValorDesconto());
						break;
					case EnumLayoutBoletoImpressoFields.VALORJUROS:
						list.Add(carteira.ProvedorDadosBoleto.GetValorJuros());
						break;
					case EnumLayoutBoletoImpressoFields.NOSSONUMEROEXIBICAO:
						list.Add(carteira.ProvedorDadosBoleto.GetNossoNumero());
						break;
					case EnumLayoutBoletoImpressoFields.NUMERODOCUMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetNumeroDocumento());
						break;
					case EnumLayoutBoletoImpressoFields.NOMECEDENTE:
						list.Add(carteira.ProvedorDadosBoleto.GetNomeCedente());
						break;
					case EnumLayoutBoletoImpressoFields.IDENTIFICACAOCEDENTE:
						list.Add(carteira.ProvedorDadosBoleto.GetIdentificacaoCedente());
						break;
					case EnumLayoutBoletoImpressoFields.NOMESACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetNomeSacado());
						break;
					case EnumLayoutBoletoImpressoFields.LOCALPAGAMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetLocalPagamento());
						break;
					case EnumLayoutBoletoImpressoFields.DATADOCUMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetDataDocumento());
						break;
					case EnumLayoutBoletoImpressoFields.ESPECIEDOCUMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetEspecieDocumento());
						break;
					case EnumLayoutBoletoImpressoFields.ACEITE:
						list.Add(carteira.ProvedorDadosBoleto.GetAceite());
						break;
					case EnumLayoutBoletoImpressoFields.DATAPROCESSAMENTO:
						list.Add(carteira.ProvedorDadosBoleto.GetDataProcessamento());
						break;
					case EnumLayoutBoletoImpressoFields.CODIGOUSOBANCO:
						list.Add(carteira.ProvedorDadosBoleto.GetCodigoUsoBanco());
						break;
					case EnumLayoutBoletoImpressoFields.CARTEIRA:
						list.Add(carteira.ProvedorDadosBoleto.GetCarteira());
						break;
					case EnumLayoutBoletoImpressoFields.INSTRUCOESCAIXA:
						list.Add(carteira.ProvedorDadosBoleto.GetInstrucoesCaixa());
						break;
					case EnumLayoutBoletoImpressoFields.CNPJSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetCnpjSacado());
						break;
					case EnumLayoutBoletoImpressoFields.CPFSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetCpfSacado());
						break;
					case EnumLayoutBoletoImpressoFields.ENDERECOSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetEnderecoSacado());
						break;
					case EnumLayoutBoletoImpressoFields.BAIRROSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetBairroSacado());
						break;
					case EnumLayoutBoletoImpressoFields.CIDADESACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetCidadeSacado());
						break;
					case EnumLayoutBoletoImpressoFields.ESTADOSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetUfSacado());
						break;
					case EnumLayoutBoletoImpressoFields.CEPSACADO:
						list.Add(carteira.ProvedorDadosBoleto.GetCepSacado());
						break;
					case EnumLayoutBoletoImpressoFields.SACADORAVALISTA:
						list.Add(carteira.ProvedorDadosBoleto.GetIdentificacaoSacadorAvalista());
						break;
					case EnumLayoutBoletoImpressoFields.LINHADIGITAVEL:
						list.Add(carteira.ProvedorDadosBoleto.GetLinhaDigitavel());
						break;
					case EnumLayoutBoletoImpressoFields.CODIGOBARRAS:
						list.Add(carteira.ProvedorDadosBoleto.GetCodigoBarras());
						break;
					case EnumLayoutBoletoImpressoFields.CONTATOSAC:
						list.Add(carteira.ProvedorDadosBoleto.GetContatoSac());
						break;
					case EnumLayoutBoletoImpressoFields.VALOROUTROSACRESCIMOSEXIBICAO:
						list.Add(carteira.ProvedorDadosBoleto.GetValorOutrosAcrescimos());
						break;
					case EnumLayoutBoletoImpressoFields.DEMONSTRATIVO:
						list.Add(carteira.ProvedorDadosBoleto.GetDemonstrativo());
						break;
					case EnumLayoutBoletoImpressoFields.URLORIGEM:
						list.Add(carteira.ProvedorDadosBoleto.GetUrlOrigem());
						break;
					case EnumLayoutBoletoImpressoFields.PROPAGANDA:
						list.Add(carteira.ProvedorDadosBoleto.GetPropaganda());
						break;
					case EnumLayoutBoletoImpressoFields.LINHADIGITAVELESPELHO:
						list.Add(carteira.ProvedorDadosBoleto.GetLinhaDigitavelEspelho());
						break;
					case EnumLayoutBoletoImpressoFields.NUMEROBANCORECIBO:
						list.Add(carteira.ProvedorDadosBoleto.GetNumeroBancoRecibo());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOLINHADIGITAVEL:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloLinhaDigitavel());
						break;
					case EnumLayoutBoletoImpressoFields.ALTURACAMPODEMONSTRATIVORECIBOENTREGA:
						list.Add(carteira.ProvedorDadosBoleto.GetAlturaCampoDemonstrativoReciboEntrega());
						break;
					case EnumLayoutBoletoImpressoFields.ALTURACAMPODEMONSTRATIVORECIBOPAGADOR:
						list.Add(carteira.ProvedorDadosBoleto.GetAlturaCampoDemonstrativoReciboPagador());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOCABECALHOCAMPOFICHACOMPENSACAO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloCabecalhoCampoFichaCompensacao());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOCONTEUDOCAMPOFICHACOMPENSACAO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloConteudoCampoFichaCompensacao());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOAUTENTICACAOMECANICA:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloAutenticacaoMecanica());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOCODIGOBANCO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloCodigoBanco());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOCONTEUDOCAMPOVALORFICHACOMPENSACAO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloConteudoCampoValorFichaCompensacao());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILODADOSAVALISTA:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloDadosAvalista());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILODADOSPAGADOR:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloDadosPagador());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOINSTRUCOESFICHACOMPENSACAO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloIntrucoesFichaCompensacao());
						break;
					case EnumLayoutBoletoImpressoFields.ESTILOLOGOTIPOBANCO:
						list.Add(carteira.ProvedorDadosBoleto.GetEstiloLogotipoBanco());
						break;
					}
				}
				else
				{
					Logger.Warn($"Campo [{campos[i].ToString().ToUpper()}] definido no modelo do boleto é inválido.", "ModeloBoleto.ObterCamposLinhaModeloBoleto(string linha)");
					list.Add("");
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return list;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoValorParaCampoModeloBoleto(campos[i].ToString().ToUpper(), ex), new StackTrace().GetFrame(1).GetMethod());
			return list;
		}
	}

	protected List<string> CarregarValoresParaCamposDaEstruturaDoBoleto(List<string> campos)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < campos.Count; i++)
			{
				if (Enum.IsDefined(typeof(EnumCamposLayoutEstruturalBoleto), campos[i].ToString().ToUpper()))
				{
					Logger.Debug($"Obtendo valor para o campo [{campos[i].ToString().ToUpper()}] da estrutura do modelo do boleto");
					switch ((EnumCamposLayoutEstruturalBoleto)(object)campos[i].ToString().ToUpper().ToEnum<EnumCamposLayoutEstruturalBoleto>())
					{
					case EnumCamposLayoutEstruturalBoleto.ESTILOS:
					{
						Stream stream2 = (tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO) ? (((EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>() != 0) ? new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_EstilosPersonalizadoHtml.html")) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_EstilosPersonalizadoPdf.html"))) : (((EnumFormatoSaida)(object)carteira.ConfiguracaoImpressao.FormatoSaida.ToEnum<EnumFormatoSaida>() != 0) ? new MemoryStream(Resources.TEMPLATE_EstilosPadraoHtml) : new MemoryStream(Resources.TEMPLATE_EstilosPadraoPdf)));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream2)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOSACADOGRANDE:
					{
						Stream stream7 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboSacadoGrandePadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboSacadoGrandePersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream7)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOSACADONORMAL:
					{
						Stream stream3 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboSacadoNormalPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboSacadoNormalPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream3)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOSACADOREDUZIDO:
					{
						Stream stream12 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboSacadoReduzidoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboSacadoReduzidoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream12)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOSACADOSIMPLES:
					{
						Stream stream8 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboSacadoSimplesPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboSacadoSimplesPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream8)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOSACADOCANHOTO:
					{
						Stream stream10 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboSacadoCanhotoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboSacadoCanhotoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream10)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOENTREGACANHOTO:
					{
						Stream stream11 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboEntregaCanhotoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboEntregaCanhotoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream11)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOENTREGANORMAL:
					{
						Stream stream6 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboEntregaNormalPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboEntregaNormalPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream6)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOENTREGAREDUZIDO:
					{
						Stream stream4 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboEntregaReduzidoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboEntregaReduzidoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream4)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.RECIBOENTREGASIMPLES:
					{
						Stream stream9 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_ReciboEntregaSimplesPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_ReciboEntregaSimplesPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream9)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.FICHACOMPENSACAO:
					{
						Stream stream5 = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_FichaCompensacaoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_FichaCompensacaoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream5)));
						break;
					}
					case EnumCamposLayoutEstruturalBoleto.TRACO:
					{
						Stream stream = ((!tipo.Equals(EnumTipoModeloBoleto.BOLETO_PERSONALIZADO)) ? new MemoryStream(Resources.TEMPLATE_TracoPadrao) : new MemoryStream(File.ReadAllBytes(carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + "TEMPLATE_TracoPersonalizado.html")));
						list.Add(string.Join(" ", StringUtil.GetStringsFromStream(stream)));
						break;
					}
					}
				}
				else
				{
					Logger.Warn($"Campo [{campos[i].ToString().ToUpper()}] definido no modelo estrutural do boleto é inválido.", "ModeloBoleto.CarregarValoresParaCamposDaEstruturaDoBoleto(ArrayList campos)");
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return list;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoCamposModeloEstruturalBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			return list;
		}
	}

	protected void Init(CarteiraCobranca carteira, EnumFormatoModeloBoleto formato, EnumTipoModeloBoleto tipo, bool fichaCompensacaoPersonalizada, string caminhoModeloPersonalizadoHtml)
	{
		try
		{
			FichaCompensacaoPersonalizada = fichaCompensacaoPersonalizada;
			CaminhoModeloPersonalizadoHtml = caminhoModeloPersonalizadoHtml;
			Init(carteira, formato, tipo);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaInicializandoModeloBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected void Init(CarteiraCobranca carteira, EnumFormatoModeloBoleto formato, EnumTipoModeloBoleto tipo)
	{
		try
		{
			Logger.Debug($"Inicializando modelo de boleto html. Formato [{formato.ToString()}], Tipo [{tipo.ToString()}]");
			this.carteira = carteira;
			this.formato = formato;
			this.tipo = tipo;
			if (CaminhoModeloPersonalizadoHtml == null)
			{
				CaminhoModeloPersonalizadoHtml = "";
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaInicializandoModeloBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected string[] MontarModelo(string[] modelo)
	{
		string[] array = null;
		try
		{
			Logger.Debug("Montando modelo de boleto...");
			array = modelo;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				List<string> list = ObterCamposLinhaModeloBoleto(text);
				if (list.Count <= 0)
				{
					continue;
				}
				List<string> list2 = CarregarValoresParaCamposDaEstruturaDoBoleto(list);
				string text2 = text;
				for (int j = 0; j < list.Count; j++)
				{
					if (j <= list2.Count - 1)
					{
						text2 = text2.Replace("<#" + list[j].ToString() + ">", list2[j].ToString());
					}
				}
				array[i] = text2;
			}
			return array;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return array;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaMontandoModeloBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			return array;
		}
	}

	public virtual string[] GerarBoletoMecanismoHtml(DocumentoCobranca dc)
	{
		string[] array = null;
		try
		{
			modeloBoletoHtml = GetModeloHtml();
			modeloBoletoHtml = MontarModelo(ModeloBoletoHtml);
			array = ModeloBoletoHtml;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				campos = ObterCamposLinhaModeloBoleto(text);
				if (campos.Count <= 0)
				{
					continue;
				}
				valores = GetValoresParaLinhaModelo(campos, dc);
				string text2 = text;
				for (int j = 0; j < campos.Count; j++)
				{
					if (j <= valores.Count - 1)
					{
						text2 = text2.Replace("<#" + campos[j].ToString() + ">", valores[j].ToString());
					}
				}
				array[i] = text2;
			}
			return array;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return array;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaGerandoBoletoParaDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return array;
		}
	}

	public virtual string[] GerarBoletoMecanismoFastReports(DocumentoCobranca dc)
	{
		List<string> list = new List<string>();
		try
		{
			carteira.ProvedorDadosBoleto.Preparar(carteira, dc, this);
			modeloBoletoFastReports = GetModeloFastReports();
			string text = new DocumentoCobrancaXml
			{
				LogotipoBanco = carteira.ProvedorDadosBoleto.GetLogoTipoBanco().RemoverCaracteresInvalidosXml(),
				ImagemAutenticacaoMecanica = carteira.ProvedorDadosBoleto.GetImagemAutenticacaoMecanica().RemoverCaracteresInvalidosXml(),
				LogotipoCedente = carteira.ProvedorDadosBoleto.GetLogotipoCedente().RemoverCaracteresInvalidosXml(),
				NumeroBanco = carteira.ProvedorDadosBoleto.GetNumeroBanco().RemoverCaracteresInvalidosXml(),
				Vencimento = carteira.ProvedorDadosBoleto.GetVencimento().RemoverCaracteresInvalidosXml(),
				AgenciaCodigoCedente = carteira.ProvedorDadosBoleto.GetAgenciaCodigoCedente().RemoverCaracteresInvalidosXml(),
				Moeda = carteira.ProvedorDadosBoleto.GetMoeda().RemoverCaracteresInvalidosXml(),
				Quantidade = carteira.ProvedorDadosBoleto.GetQuantidade().RemoverCaracteresInvalidosXml(),
				ValorDocumento = carteira.ProvedorDadosBoleto.GetValorDocumento().RemoverCaracteresInvalidosXml(),
				ValorDesconto = carteira.ProvedorDadosBoleto.GetValorDesconto().RemoverCaracteresInvalidosXml(),
				ValorJuros = carteira.ProvedorDadosBoleto.GetValorJuros().RemoverCaracteresInvalidosXml(),
				NossoNumero = carteira.ProvedorDadosBoleto.GetNossoNumero().RemoverCaracteresInvalidosXml(),
				NumeroDocumento = carteira.ProvedorDadosBoleto.GetNumeroDocumento().RemoverCaracteresInvalidosXml(),
				NomeCedente = carteira.ProvedorDadosBoleto.GetNomeCedente().RemoverCaracteresInvalidosXml(),
				IdentificacaoCedente = carteira.ProvedorDadosBoleto.GetIdentificacaoCedente().RemoverCaracteresInvalidosXml(),
				NomeSacado = carteira.ProvedorDadosBoleto.GetNomeSacado().RemoverCaracteresInvalidosXml(),
				LocalPagamento = carteira.ProvedorDadosBoleto.GetLocalPagamento().RemoverCaracteresInvalidosXml(),
				DataDocumento = carteira.ProvedorDadosBoleto.GetDataDocumento().RemoverCaracteresInvalidosXml(),
				EspecieDocumento = carteira.ProvedorDadosBoleto.GetEspecieDocumento().RemoverCaracteresInvalidosXml(),
				Aceite = carteira.ProvedorDadosBoleto.GetAceite().RemoverCaracteresInvalidosXml(),
				DataProcessamento = carteira.ProvedorDadosBoleto.GetDataProcessamento().RemoverCaracteresInvalidosXml(),
				CodigoUsoBanco = carteira.ProvedorDadosBoleto.GetCodigoUsoBanco().RemoverCaracteresInvalidosXml(),
				Carteira = carteira.ProvedorDadosBoleto.GetCarteira().RemoverCaracteresInvalidosXml(),
				InstrucoesCaixa = carteira.ProvedorDadosBoleto.GetInstrucoesCaixa().RemoverCaracteresInvalidosXml(),
				CnpjSacado = carteira.ProvedorDadosBoleto.GetCnpjSacado().RemoverCaracteresInvalidosXml(),
				CpfSacado = carteira.ProvedorDadosBoleto.GetCpfSacado().RemoverCaracteresInvalidosXml(),
				EnderecoSacado = carteira.ProvedorDadosBoleto.GetEnderecoSacado().RemoverCaracteresInvalidosXml(),
				BairroSacado = carteira.ProvedorDadosBoleto.GetBairroSacado().RemoverCaracteresInvalidosXml(),
				CidadeSacado = carteira.ProvedorDadosBoleto.GetCidadeSacado().RemoverCaracteresInvalidosXml(),
				UfSacado = carteira.ProvedorDadosBoleto.GetUfSacado().RemoverCaracteresInvalidosXml(),
				CepSacado = carteira.ProvedorDadosBoleto.GetCepSacado().RemoverCaracteresInvalidosXml(),
				IdentificacaoSacado = carteira.ProvedorDadosBoleto.GetIdentificacaoSacado().RemoverCaracteresInvalidosXml(),
				IdentificacaoSacadorAvalista = carteira.ProvedorDadosBoleto.GetIdentificacaoSacadorAvalista().RemoverCaracteresInvalidosXml(),
				LinhaDigitavel = carteira.ProvedorDadosBoleto.GetLinhaDigitavel().RemoverCaracteresInvalidosXml(),
				CodigoBarras = carteira.ProvedorDadosBoleto.GetCodigoBarras().RemoverCaracteresInvalidosXml(),
				ContatoSac = carteira.ProvedorDadosBoleto.GetContatoSac().RemoverCaracteresInvalidosXml(),
				ValorOutrosAcrescimos = carteira.ProvedorDadosBoleto.GetValorOutrosAcrescimos().RemoverCaracteresInvalidosXml(),
				Demonstrativo = carteira.ProvedorDadosBoleto.GetDemonstrativo(),
				InformacoesExtras = carteira.ProvedorDadosBoleto.GetInformacoesExtras(),
				UrlOrigem = carteira.ProvedorDadosBoleto.GetUrlOrigem().RemoverCaracteresInvalidosXml(),
				Propaganda = carteira.ProvedorDadosBoleto.GetPropaganda().RemoverCaracteresInvalidosXml(),
				LinhaDigitavelEspelho = carteira.ProvedorDadosBoleto.GetLinhaDigitavelEspelho().RemoverCaracteresInvalidosXml(),
				NumeroBancoRecibo = carteira.ProvedorDadosBoleto.GetNumeroBancoRecibo().RemoverCaracteresInvalidosXml(),
				EstiloLinhaDigitavel = carteira.ProvedorDadosBoleto.GetEstiloLinhaDigitavel().RemoverCaracteresInvalidosXml(),
				AlturaCampoDemonstrativoReciboEntrega = carteira.ProvedorDadosBoleto.GetAlturaCampoDemonstrativoReciboEntrega().RemoverCaracteresInvalidosXml(),
				AlturaCampoDemonstrativoReciboPagador = carteira.ProvedorDadosBoleto.GetAlturaCampoDemonstrativoReciboPagador().RemoverCaracteresInvalidosXml(),
				TipoPropaganda = carteira.ProvedorDadosBoleto.GetTipoPropaganda().RemoverCaracteresInvalidosXml(),
				CelularPagador = carteira.ProvedorDadosBoleto.GetCelularPagador().RemoverCaracteresInvalidosXml(),
				EnderecoSacadorAvalista = carteira.ProvedorDadosBoleto.GetEnderecoSacadorAvalista().RemoverCaracteresInvalidosXml(),
				NumeroEnderecoSacadorAvalista = carteira.ProvedorDadosBoleto.GetNumeroEnderecoSacadorAvalista().RemoverCaracteresInvalidosXml(),
				ComplementoSacadorAvalista = carteira.ProvedorDadosBoleto.GetComplementoSacadorAvalista().RemoverCaracteresInvalidosXml(),
				BairroSacadorAvalista = carteira.ProvedorDadosBoleto.GetBairroSacadorAvalista().RemoverCaracteresInvalidosXml(),
				CidadeSacadorAvalista = carteira.ProvedorDadosBoleto.GetCidadeSacadorAvalista().RemoverCaracteresInvalidosXml(),
				UfSacadorAvalista = carteira.ProvedorDadosBoleto.GetUfSacadorAvalista().RemoverCaracteresInvalidosXml(),
				CepSacadorAvalista = carteira.ProvedorDadosBoleto.GetCepSacadorAvalista().RemoverCaracteresInvalidosXml(),
				TelefoneSacadorAvalista = carteira.ProvedorDadosBoleto.GetTelefoneSacadorAvalista().RemoverCaracteresInvalidosXml(),
				PrefixoNomenclaturaBoleto = carteira.ProvedorDadosBoleto.GetPrefixoNomenclaturaBoleto().RemoverCaracteresInvalidosXml(),
				NomenclaturaBoleto = carteira.ProvedorDadosBoleto.GetNomenclaturaBoleto().RemoverCaracteresInvalidosXml(),
				DiretorioGeracaoBoleto = carteira.ProvedorDadosBoleto.GetDiretorioGeracaoBoleto().RemoverCaracteresInvalidosXml(),
				FonteCampoInstrucoes = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_FONTE_CAMPO_INSTRUCOES, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.FonteCampoInstrucoes(), carteira.ConfiguracaoBoleto.ParametrosAdicionais),
				NumeroBoletosPorPagina = (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_APLICAR_QUEBRA_PAGINA_GERACAO_BOLETOS, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.AplicarQuebraPaginaGeracaoBoletos(), carteira.ConfiguracaoBoleto.ParametrosAdicionais).Equals("S") ? carteira.ConfiguracaoBoleto.NumeroBoletosPorPagina.ToString() : "-1"),
				QtdeBoletosPagina = "0"
			}.SerializarParaXml();
			text = text.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", string.Empty);
			text = text.Replace("<DocumentoCobrancaXml xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">", "<DocumentoCobrancaXml>");
			list.Add(text);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaGerandoBoletoParaDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Enumerable.ToArray(list);
	}

	public virtual string[] GerarBoleto(DocumentoCobranca dc)
	{
		string[] result = null;
		try
		{
			if (dc != null)
			{
				Logger.Debug($"Gerando boleto para o documento de cobrança [{dc.NumeroDocumento}]");
			}
			return GerarBoletoMecanismoFastReports(dc);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaGerandoBoletoParaDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
