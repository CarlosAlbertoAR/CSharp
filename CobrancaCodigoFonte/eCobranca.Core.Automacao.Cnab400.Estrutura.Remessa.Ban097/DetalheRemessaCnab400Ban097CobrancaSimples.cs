using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;

public class DetalheRemessaCnab400Ban097CobrancaSimples : DetalheRemessaCnab400, IDetalheRemessaCnab400Ban097CobrancaSimples
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => base.Campos[1];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => base.Campos[2];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => base.Campos[3];

	public CampoLayoutArquivoCobranca ContaCorrenteBeneficiario => base.Campos[4];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => base.Campos[5];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => base.Campos[7];

	public CampoLayoutArquivoCobranca CodigoOperacao => base.Campos[8];

	public CampoLayoutArquivoCobranca DataOperacao => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[10];

	public CampoLayoutArquivoCobranca NumeroParcela => base.Campos[11];

	public CampoLayoutArquivoCobranca TipoPagamento => base.Campos[12];

	public CampoLayoutArquivoCobranca TipoRecebimento => base.Campos[13];

	public CampoLayoutArquivoCobranca EspecieTitulo => base.Campos[14];

	public CampoLayoutArquivoCobranca TipoProtesto => base.Campos[15];

	public CampoLayoutArquivoCobranca DiasProtesto => base.Campos[16];

	public CampoLayoutArquivoCobranca TipoEnvioProtesto => base.Campos[17];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[18];

	public CampoLayoutArquivoCobranca NumeroDocumento => base.Campos[19];

	public CampoLayoutArquivoCobranca DataVencimento => base.Campos[20];

	public CampoLayoutArquivoCobranca ValorOperacao => base.Campos[21];

	public CampoLayoutArquivoCobranca DataLimitePagamento => base.Campos[22];

	public CampoLayoutArquivoCobranca Filler4 => base.Campos[23];

	public CampoLayoutArquivoCobranca DataEmissaoTitulo => base.Campos[24];

	public CampoLayoutArquivoCobranca Filler5 => base.Campos[25];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => base.Campos[26];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => base.Campos[27];

	public CampoLayoutArquivoCobranca NomePagador => base.Campos[28];

	public CampoLayoutArquivoCobranca NomeFantasiaPagador => base.Campos[29];

	public CampoLayoutArquivoCobranca EnderecoPagador => base.Campos[30];

	public CampoLayoutArquivoCobranca NumeroEnderecoPagador => base.Campos[31];

	public CampoLayoutArquivoCobranca BairroPagador => base.Campos[32];

	public CampoLayoutArquivoCobranca CidadePagador => base.Campos[33];

	public CampoLayoutArquivoCobranca UfPagador => base.Campos[34];

	public CampoLayoutArquivoCobranca CepPagador => base.Campos[35];

	public CampoLayoutArquivoCobranca CelularPagador => base.Campos[36];

	public CampoLayoutArquivoCobranca EmailPagador => base.Campos[37];

	public CampoLayoutArquivoCobranca Filler6 => base.Campos[38];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[39];

	public DetalheRemessaCnab400Ban097CobrancaSimples(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO DE DETALHE de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.1", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban097.DETALHE.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.1", "Tipo de inscrição do beneficiário", "Tipo de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 3, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.1", "Número de inscrição do beneficiário", "Número do CPF/CNPJ do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 4, 17, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.1", "Código da agência", "Prefixo da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.1", "Conta do beneficiário", "Informar a conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 29, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.1", "Dígito verificador da conta corrente", "DV da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 30, 30, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 31, 56, 26, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.1", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 57, 76, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.1", "Código da operação/ocorrência", "Código que identifica qual operação será executada sobre o título 01 - Inclusção de título, 02 - Baixa manual, 03 - Cancelamento, 04 - Alteração dos dados ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 77, 78, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.1", "Data da operação/ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 79, 84, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 85, 90, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.1", "Número da parcela", "Número da parcela do boleto. Valor padrão: 01 (acrescido de 1 unidade, caso possua vários títulos para um conjunto de parcelas)", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 91, 92, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.1", "Tipo de pagamento", "Código que identifica como poderá ser pago o título. Valor padrão 3 - Não aceita pagamento com valor divergente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 93, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.1", "Tipo de recebimento", "Código que identifica como deve ser feito o recebimento do valor do pagamento. Valor fixo: 3 - Não receber valor divergente do informado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 94, 94, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.1", "Espécie do título", "Código que identifica a espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 95, 96, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.1", "Tipo de protesto", "Código que identifica o tipo de dias para carência do título após o vencimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 97, 97, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.1", "Dias para protesto", "Quantidade de dias para carência do título após o vencimento, para envio ao protesto", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 98, 99, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.1", "Tipo de envio através de protesto", "O cooperado poderá escolher entre o envio para o Cartório para realização do Protesto do título ou para o Serasa para Negativação do título Valor padrão: 01 - Cartório", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 100, 101, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 102, 110, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.1", "Número do documento", "Informação utilizada pelos bancos para referenciar a identificação do documento objeto de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 111, 120, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.1", "Data de vencimento", "Informar no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 126, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.1", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 139, 11, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.1", "Data limite pagamento", "Data máxima para o recebimento do título pelas entidades vinculadas a CIP", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 140, 145, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 146, 150, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.1", "Data de emissão do título", "Data de emissão do título no formato DDMMAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 156, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 157, 157, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.1", "Tipo de inscrição do pagador", "01 - CPF, 02 - CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 159, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.1", "Número de inscrição do pagador", "Informar o CPF ou o CNPJ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 160, 173, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.1", "Nome do pagador", "Informar o nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 174, 213, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.1", "Nome fantasia do pagador", "Informar o nome fantasia do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 214, 238, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.1", "Endereço do pagador", "Informar o endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 239, 273, 35, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.1", "Número do endereço do pagador", "Informar o número do endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 274, 279, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.1", "Bairro do pagador", "Informar o bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 280, 304, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("34.1", "Cidade do pagador", "Informar a cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 305, 329, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("35.1", "Uf do pagador", "Informar a Uf do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 330, 331, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("36.1", "CEP do pagador", "Informar o CEP do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 332, 339, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("37.1", "Celular do pagador", "Informar o número do telefone celular do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 340, 350, 11, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("38.1", "Email do pagador", "Informar o email do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 351, 393, 43, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("39.1", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 394, 394, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("40.1", "Sequencial do registro", "Número sequencial do registro na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
