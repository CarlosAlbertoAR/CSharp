using System;
using System.Diagnostics;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Dicionario;

public class DicionarioChaveByBancoLayoutCobranca : DicionarioECobranca<Tuple<EnumCodigoBanco, EnumLayoutCobranca>, EnumChaveContexto>
{
	private static DicionarioChaveByBancoLayoutCobranca uniqueInstance;

	private static object syncRoot = new object();

	private DicionarioChaveByBancoLayoutCobranca()
	{
		Logger.Debug("Criando dicionário ChaveByBancoLayoutCobranca...");
	}

	public static DicionarioChaveByBancoLayoutCobranca GetInstance()
	{
		if (uniqueInstance == null)
		{
			lock (syncRoot)
			{
				if (uniqueInstance == null)
				{
					uniqueInstance = new DicionarioChaveByBancoLayoutCobranca();
				}
			}
		}
		return uniqueInstance;
	}

	protected override void CriarDicionario()
	{
		try
		{
			Logger.Debug($"Configurando dicionário [{GetType().Name}]...");
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_BRASIL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN001_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_BRASIL, EnumLayoutCobranca.CBR641), EnumChaveContexto.BAN001_CBR641);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_BRASIL, EnumLayoutCobranca.CBR643), EnumChaveContexto.BAN001_CBR643);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DA_AMAZONIA, EnumLayoutCobranca.FEBRABAN150), EnumChaveContexto.BAN003_FEBRABAN150);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DA_AMAZONIA, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN003_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DA_AMAZONIA, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN003_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN004_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN004_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN021_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN021_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_SANTANDER, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN033_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_SANTANDER, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN033_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN037_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN037_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN041_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN041_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN084_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN084_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN085_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN085_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN097_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN097_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN099_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN099_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN104_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN104_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.CRESOL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN133_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.CRESOL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN133_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.UNICRED, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN136_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.UNICRED, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN136_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_BRADESCO, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN237_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_BRADESCO, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN237_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_ITAU, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN341_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_ITAU, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN341_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.HSBC_BANK_BRASIL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN399_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.HSBC_BANK_BRASIL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN399_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_SAFRA, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN422_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_SAFRA, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN422_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN748_FEBRABAN240);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN748_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, EnumLayoutCobranca.CNAB400), EnumChaveContexto.BAN756_CNAB400);
			dicionario.Add(Tuple.Create(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, EnumLayoutCobranca.FEBRABAN240), EnumChaveContexto.BAN756_FEBRABAN240);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaCriandoDicionarioDados(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected override void DefinirValorPadrao()
	{
		chavePadrao = new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(EnumCodigoBanco.BANCO_DO_BRASIL, EnumLayoutCobranca.FEBRABAN240);
	}
}
