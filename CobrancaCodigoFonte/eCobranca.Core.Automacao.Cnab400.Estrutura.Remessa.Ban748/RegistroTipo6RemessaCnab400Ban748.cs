using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public class RegistroTipo6RemessaCnab400Ban748 : DetalheRemessaCnab400, IRegistroTipo6RemessaCnab400Ban748
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca NossoNumero => campos[1];

	public CampoLayoutArquivoCobranca SeuNumero => campos[2];

	public CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[4];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[5];

	public CampoLayoutArquivoCobranca EnderecoSacadorAvalista => campos[6];

	public CampoLayoutArquivoCobranca CidadeSacadorAvalista => campos[7];

	public CampoLayoutArquivoCobranca CepSacadorAvalista => campos[8];

	public CampoLayoutArquivoCobranca UfSacadorAvalista => campos[9];

	public CampoLayoutArquivoCobranca Filler1 => campos[10];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[11];

	public RegistroTipo6RemessaCnab400Ban748(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRANSACAO TIPO 7 de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.6", "Tipo de registro", "Identificação do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_6.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.6", "Nosso número sicredi", "Nosso número sicredi", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 16, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.6", "Seu número", "Número de controle utilizado pelo beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 17, 26, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.6", "Código do pagador junto ao beneficiário", "Quando não utilizado pode ser deixado em branco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 27, 31, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.6", "Número de inscrição do sacador/avalista", "CPF/CNPJ do sacador/avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 45, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.6", "Nome do sacador/avalista", "Preenchimento obrigatório sem acentuação ou caracteres especiais", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 46, 86, 41, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.6", "Endereço do sacador/avalista", "Preenchimento obrigatório sem acentuação ou caracteres especiais", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 87, 131, 45, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.6", "Cidade do sacador/avalista", "Preenchimento obrigatório sem acentuação ou caracteres especiais", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 132, 151, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.6", "CEP do sacador/avalista", "CEP", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 152, 159, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.6", "UF do sacador/avalista", "UF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 160, 161, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.6", "Filler", "Deixar em branco - sem preenchimento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 162, 394, 233, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.6", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
