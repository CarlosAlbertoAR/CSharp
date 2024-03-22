using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class HeaderArquivoFebraban240 : SegmentoFebraban240
{
	public HeaderArquivoFebraban240()
	{
		try
		{
			Logger.Debug("Criando campos do HEADER DE ARQUIVO do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.0", "Código do banco na Compensação", "Código fornecido pelo Banco Central para identificação do Banco que está recebendo ou enviando o arquivo, com o qual se firmou o contrato de prestação de serviços.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.0", "Lote de Serviço", "Número seqüencial para identificar univocamente um lote de serviço. Criado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo. Preencher com '0001' para o primeiro lote do arquivo. Para os demais: número do lote anterior acrescido de 1. O número não poderá ser repetido dentro do arquivo.Se registro for Header do Arquivo preencher com '0000'. Se registro for Trailler do Arquivo preencher com '9999' ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0000", "0000", 4, 7, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.0", "Tipo de Registro", "Código adotado pela FEBRABAN para identificar o tipo de registro. Domínio: '0' = Header de Arquivo '1' = Header de Lote '2' = Registros Iniciais do Lote '3' = Detalhe '4' = Registros Finais do Lote '5' = Trailler de Lote '9' = Trailler de Arquivo ", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo(), EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo(), 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.0", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 9, 17, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.0", "Tipo de inscrição da Empresa", "Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. DominioTipoInscricao", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.0", "Número de inscrição da Empresa", "Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental. Quando o Tipo de Inscrição for igual a zero (não informado), preencher com zeros.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 32, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.0", "Código do convênio no Banco", "Código adotado pelo Banco para identificar o Contrato entre este e a Empresa Cliente.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 33, 52, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.0", "Agência mantenedora da Conta", "Código adotado pelo Banco responsável pela conta, para identificar a qual unidade está vinculada a conta corrente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 57, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.0", "Dígito verificador da agência", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do Código da Agência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 58, 58, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.0", "Número da conta corrente", "Número adotado pelo Banco, para identificar univocamente a conta corrente utilizada pelo Cliente.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 70, 12, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.0", "Dígito verificador da conta corrente", "Código adotado pelo responsável pela conta corrente, para verificação da autenticidade do Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 1ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 71, 71, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.0", "Dígito verificador da Agência e Conta", "Código adotado pelo Banco responsável pela conta corrente, para verificação da autenticidade do par Código da Agência / Número da Conta Corrente. Para os Bancos que se utilizam de duas posições para o Dígito Verificador do Número da Conta Corrente, preencher este campo com a 2ª posição deste dígito.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 72, 72, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.0", "Nome da Empresa", "Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 102, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.0", "Nome do Banco", "Nome que identifica o Banco que está recebendo ou enviando o arquivo.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 103, 132, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.0", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 133, 142, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.0", "Código de Remessa/Retorno", "Código adotado pela FEBRABAN para qualificar o envio ou devolução de arquivo entre a Empresa Cliente e o Banco prestador dos Serviços. Domínio: '1' = Remessa (Cliente > Banco)'2' = Retorno (Banco > Cliente)", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 143, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.0", "Data de geração do arquivo", "Data da criação do arquivo. Utilizar o formato DDMMAAAA.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 144, 151, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.0", "Hora de geração do arquivo", "Hora da criação do arquivo. Utilizar o formato HHMMSS.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 152, 157, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.0", "Número sequencial do arquivo", "Número seqüencial adotado e controlado pelo responsável pela geração do arquivo para ordenar a disposição dos arquivos encaminhados. Evoluir um número seqüencial a cada header de arquivo.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 163, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.0", "Número da versão do layout do Arquivo", "Código adotado pela FEBRABAN para identificar qual a versão de layout do arquivo encaminhado. O código é composto de: Versão = 2 dígitos, Release = 1 dígito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "089", "089", 164, 166, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.0", "Densidade de gravação do Arquivo", "Densidade de gravação (BPI), do arquivo encaminhado. Domínio: 1600 BPI, 6250 BPI.", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 167, 171, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.0", "Para uso reservado do Banco", "Texto de observações destinado para uso exclusivo do Banco.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 172, 191, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.0", "Para uso reservado da Empresa", "Texto de observações destinado para uso exclusivo da Empresa.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 192, 211, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.0", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 212, 240, 29, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoHeaderArquivoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public abstract int GetNumeroSequencialArquivo();
}
