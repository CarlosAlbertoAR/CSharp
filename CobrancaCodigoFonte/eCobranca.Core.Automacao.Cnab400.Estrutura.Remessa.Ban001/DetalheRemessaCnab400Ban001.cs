using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;

public class DetalheRemessaCnab400Ban001 : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban001
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca NumeroConvenio => campos[7];

	public CampoLayoutArquivoCobranca CodigoControleEmpresa => campos[8];

	public CampoLayoutArquivoCobranca NossoNumero => campos[9];

	public CampoLayoutArquivoCobranca NumeroPrestacao => campos[10];

	public CampoLayoutArquivoCobranca GrupoValor => campos[11];

	public CampoLayoutArquivoCobranca Filler1 => campos[12];

	public CampoLayoutArquivoCobranca IndicativoMensagemOuSacadorAvalista => campos[13];

	public CampoLayoutArquivoCobranca PrefixoTitulo => campos[14];

	public CampoLayoutArquivoCobranca VariacaoCarteira => campos[15];

	public CampoLayoutArquivoCobranca ContaCaucao => campos[16];

	public CampoLayoutArquivoCobranca NumeroBordero => campos[17];

	public CampoLayoutArquivoCobranca TipoCobranca => campos[18];

	public CampoLayoutArquivoCobranca CarteiraCobranca => campos[19];

	public CampoLayoutArquivoCobranca Comando => campos[20];

	public CampoLayoutArquivoCobranca SeuNumero => campos[21];

	public CampoLayoutArquivoCobranca DataVencimento => campos[22];

	public CampoLayoutArquivoCobranca ValorTitulo => campos[23];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[24];

	public CampoLayoutArquivoCobranca CodigoAgenciaCobradora => campos[25];

	public CampoLayoutArquivoCobranca DVAgenciaCobradora => campos[26];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[27];

	public CampoLayoutArquivoCobranca AceiteTitulo => campos[28];

	public CampoLayoutArquivoCobranca DataEmissao => campos[29];

	public CampoLayoutArquivoCobranca InstrucaoCodificada1 => campos[30];

	public CampoLayoutArquivoCobranca InstrucaoCodificada2 => campos[31];

	public CampoLayoutArquivoCobranca JurosAoDia => campos[32];

	public CampoLayoutArquivoCobranca DataDesconto => campos[33];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[34];

	public CampoLayoutArquivoCobranca ValorIOF => campos[35];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[36];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[37];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[38];

	public CampoLayoutArquivoCobranca NomePagador => campos[39];

	public CampoLayoutArquivoCobranca Filler2 => campos[40];

	public CampoLayoutArquivoCobranca EnderecoPagador => campos[41];

	public CampoLayoutArquivoCobranca BairroPagador => campos[42];

	public CampoLayoutArquivoCobranca CepPagador => campos[43];

	public CampoLayoutArquivoCobranca CidadePagador => campos[44];

	public CampoLayoutArquivoCobranca UFPagador => campos[45];

	public CampoLayoutArquivoCobranca ObservacoesOuMensagemOuSacadorAvalista => campos[46];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[47];

	public CampoLayoutArquivoCobranca Filler3 => campos[48];

	public CampoLayoutArquivoCobranca SequencialRegistro => campos[49];

	public DetalheRemessaCnab400Ban001(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.7", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.7", "Tipo de inscrição do cedente", "Tipo de inscrição do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.7", "Número de inscrição do cedente", "Número do CPF/CNPJ do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.7", "Código da agência", "Prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.7", "Dígito verificador da agência", "Dígito verificador - D.V. - do prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 22, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.7", "Número da conta corrente", "Número da conta corrente do cedente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 30, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.7", "Dígito verificador da conta corrente", "Dígito verificador - D.V - do número da conta corrente do cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 31, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.7", "Número do convênio", "Número do convênio de cobrança do cedente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 38, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.7", "Código de controle da empresa", "Pode conter qualquer informação de interesse da Empresa. Será mantido na base de dados do sistema do Banco sem qualquer tipo de tratamento. A informação contida neste campo sempre retornará com o respectivo título no arquivo-retorno.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 39, 63, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.7", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 64, 80, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.7", "Número da prestação", "Número da prestação. Preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 81, 82, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.7", "Grupo de valor", "Grupo de valor. Preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 84, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.7", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 85, 87, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.7", "Indicativo de mensagem ao Sacador/Avalista", "Indicativo de mensagem ao Sacador/Avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 88, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.7", "Prefixo do título", "Prefixo do título: Preencher com brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 89, 91, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.7", "Variação da carteira", "Variação da carteira de cobrança fornecido pelo banco do brasil.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 92, 94, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.7", "Conta caução", "Conta caução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 95, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.7", "Número do borderô", "Número do borderô. Preencher com zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 96, 101, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.7", "Tipo de cobrança", "Tipo de modalidade de cobrança. DominioTipoCobranca", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 102, 106, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.7", "Carteira de cobrança", "Código da carteira de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.7", "Comando", "Favor utilizar um dos valores defenidos em DominioComando", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 110, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.7", "Seu número", "Número do título atribuído pelo cedente", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.7", "Data de vencimento", "Data de vencimento no formato DDMMAA. Para vencimento à vista informar 888888. Para vencimento na apresentação informar 999999", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.7", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.7", "Número do banco", "Número do banco. Informar 001", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 142, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.7", "Código da agência cobradora", "Prefixo da agência cobradora. Informar 0000", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 146, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.7", "Dígito verificador da agência cobradora", "DV da agência cobradora. Informar brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 147, 147, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.7", "Espécie do título", "Espécie do título. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 148, 149, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.7", "Aceite do título", "Aceite do título. DominioTipoAceite ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 150, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.7", "Data de emissão", "Data de emissão do título no formato DDMMAA. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.7", "Instrução codificada", "Instrução codificada. DominioInstrucaoCodificadaComnado01, DominioInstrucaoCodificadaComnado02, DominioInstrucaoCodificadaComnado09", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 157, 158, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.7", "Instrução codificada", "Instrução codificada. DominioInstrucaoCodificadaComnado01, DominioInstrucaoCodificadaComnado02, DominioInstrucaoCodificadaComnado09", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 159, 160, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.7", "Juros de mora por dia de atraso", "Taxa de juros mora por dia de atraso.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 161, 173, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.7", "Data desconto / Juros Mora", "Data limite para concessão de desconto, aplicação de juros mora.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 174, 179, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.7", "Valor do desconto", "Informe o valor de desconto incidente sobre o título.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 180, 192, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.7", "Valor de IOF / Qtde unidade variável", "Valor de IOF / Qtde unidade variável", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 193, 205, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.7", "Valor do abatimento", "Valor do abatimento concedido ao título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 206, 218, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.7", "Tipo de inscrição do sacado", "Tipo de inscrição do sacado. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 220, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.7", "Número inscrição do sacado", "Número do CPF ou do CNPJ do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.7", "Nome do sacado", "Nome do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 271, 37, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("41.7", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 272, 274, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("42.7", "Endereço do sacado", "Endereço do sacado.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 275, 314, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("43.7", "Bairro do sacado", "Bairro do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 315, 326, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("44.7", "Cep do sacado", "Cep do sacado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 327, 334, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("45.7", "Cidade do sacado", "Cidade do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 335, 349, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("46.7", "UF do sacado", "UF do sacado", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 350, 351, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("47.7", "Observações/Mensagem ou Sacador/Avalista", "Observações/Mensagem ou Sacador/Avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 352, 391, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("48.7", "Número de dias para protesto", "Número de dias para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 393, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("49.7", "Uso exclusivo CNAB400", "Texto de observações destinado para uso exclusivo do CNAB. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("50.7", "Sequencial do registro", "Número sequencial do registro na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoRemessaCnab400(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
