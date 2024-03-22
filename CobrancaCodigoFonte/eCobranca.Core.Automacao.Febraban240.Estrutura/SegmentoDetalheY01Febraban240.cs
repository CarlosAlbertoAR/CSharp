using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheY01Febraban240 : SegmentoDetalheOpcionalFebraban240
{
	public SegmentoDetalheY01Febraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumIdentificacaoRegistroOpcionalYFebraban.INFORMACAO_DE_DADOS_DO_SACADOR_AVALISTA.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do DETALHE Y01 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Y", "Tipo inscrição sacador/avalista", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 20, 20, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Y", "Número de inscrição do sacador avalista", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 21, 35, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Y", "Nome sacador/avalista", "Nome que identifica a entidade, pessoa física ou jurídica, Cedente original do título de cobrança. Informação obrigatória quando se tratar de título negociado com terceiros.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 36, 75, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Y", "Endereço do sacador/avalista", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 76, 115, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Y", "Bairro do sacador/avalista", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 116, 130, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Y", "Cep do sacador/avalista", "Código adotado pela EBCT (Empresa Brasileira de Correios e Telégrafos), para identificação de logradouros. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 131, 135, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Y", "Sufixo do cep do sacador/avalista", "Código adotado pela EBCT (Empresa Brasileira de Correios e Telégrafos), para complementação do código de CEP. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 136, 138, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3Y", "Cidade do sacador/avalista", "Texto referente ao nome do município componente do endereço utilizado para entrega de correspondência. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 139, 153, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3Y", "Uf do sacador/avalista", "Código do estado, unidade da federação componente do endereço utilizado para entrega de correspondência. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 154, 155, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3Y", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 156, 240, 85, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoY01Febraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
