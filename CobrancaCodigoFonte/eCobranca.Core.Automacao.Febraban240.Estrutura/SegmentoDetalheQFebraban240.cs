using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheQFebraban240 : SegmentoDetalheFebraban240
{
	public SegmentoDetalheQFebraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO Q do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3Q", "Tipo de inscrição do sacado", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Q", "Número de inscrição do sacado", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 33, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Q", "Nome do sacado", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 34, 73, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Q", "Endereço do sacado", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 113, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Q", "Bairro do sacado", "Texto referente a localização da rua / avenida, número, complemento e bairro utilizado para entrega de correspondência. Utilizado também para endereço de e-mail para entrega eletrônica da informação e para número de celular para envio de mensagem SMS. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 114, 128, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Q", "Cep do sacado", "Código adotado pela EBCT (Empresa Brasileira de Correios e Telégrafos), para identificação de logradouros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 129, 133, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Q", "Sufixo do cep do sacado", "Código adotado pela EBCT (Empresa Brasileira de Correios e Telégrafos), para complementação do código de CEP.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 136, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Q", "Cidade do sacado", "Texto referente ao nome do município componente do endereço utilizado para entrega de correspondência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 137, 151, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3Q", "Uf do sacado", "Código do estado, unidade da federação componente do endereço utilizado para entrega de correspondência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 153, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3Q", "Tipo de inscrição sacador/avalista", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 154, 154, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3Q", "Número inscrição do sacador/avalista", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 155, 169, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3Q", "Nome do sacador/avalista", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 170, 209, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3Q", "Código do banco correspondente na compensação", "Código fornecido pelo Banco Central para identificação na Câmara de Compensação, do Banco ao qual será repassada a Cobrança do Título. Somente para troca de arquivos entre Bancos. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 210, 212, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3Q", "Nosso número no banco correspondente", "Código fornecido pelo Banco Correspondente para identificação do Título de Cobrança. Somente para troca de arquivos entre Bancos. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 213, 232, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3Q", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 233, 240, 8, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoQFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
