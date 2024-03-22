using System;
using eCobranca.Core.Dicionario;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Dicionario;

public class DicionarioCodigoCarteiraBan001 : DicionarioECobranca<Tuple<EnumTipoCarteiraCobranca, EnumModalidadeCarteiraCobranca>, string>
{
	private static DicionarioCodigoCarteiraBan001 uniqueInstance;

	private static object syncRoot = new object();

	private DicionarioCodigoCarteiraBan001()
	{
		Logger.Debug("Criando dicionário para códigos de carteira do banco 001 - BANCO DO BRASIL S.A.");
	}

	public static DicionarioCodigoCarteiraBan001 GetInstance()
	{
		if (uniqueInstance == null)
		{
			lock (syncRoot)
			{
				if (uniqueInstance == null)
				{
					uniqueInstance = new DicionarioCodigoCarteiraBan001();
				}
			}
		}
		return uniqueInstance;
	}

	protected override void CriarDicionario()
	{
		Logger.Debug($"Configurando dicionário CodigoCarteira do banco [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_4, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_6, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_4, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_6, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES), "1");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_4, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_6, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_7, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_4, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_6, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_7, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_4, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_6, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_4, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_6, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7, EnumModalidadeCarteiraCobranca.VINCULADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7, EnumModalidadeCarteiraCobranca.CAUCIONADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4, EnumModalidadeCarteiraCobranca.DESCONTADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6, EnumModalidadeCarteiraCobranca.DESCONTADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7, EnumModalidadeCarteiraCobranca.DESCONTADA), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4, EnumModalidadeCarteiraCobranca.VENDOR), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6, EnumModalidadeCarteiraCobranca.VENDOR), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7, EnumModalidadeCarteiraCobranca.VENDOR), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4, EnumModalidadeCarteiraCobranca.SIMPLES), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6, EnumModalidadeCarteiraCobranca.SIMPLES), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES), "2");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_4, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_6, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_7, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_4, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_6, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4, EnumModalidadeCarteiraCobranca.VINCULADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6, EnumModalidadeCarteiraCobranca.VINCULADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7, EnumModalidadeCarteiraCobranca.VINCULADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4, EnumModalidadeCarteiraCobranca.CAUCIONADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6, EnumModalidadeCarteiraCobranca.CAUCIONADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7, EnumModalidadeCarteiraCobranca.CAUCIONADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7, EnumModalidadeCarteiraCobranca.DESCONTADA), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4, EnumModalidadeCarteiraCobranca.VENDOR), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6, EnumModalidadeCarteiraCobranca.VENDOR), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7, EnumModalidadeCarteiraCobranca.VENDOR), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4, EnumModalidadeCarteiraCobranca.SIMPLES), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6, EnumModalidadeCarteiraCobranca.SIMPLES), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES), "4");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_4, EnumModalidadeCarteiraCobranca.SIMPLES), "7");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_6, EnumModalidadeCarteiraCobranca.SIMPLES), "7");
		dicionario.Add(Tuple.Create(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES), "7");
	}

	protected override void DefinirValorPadrao()
	{
		chavePadrao = new Tuple<EnumTipoCarteiraCobranca, EnumModalidadeCarteiraCobranca>(EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7, EnumModalidadeCarteiraCobranca.SIMPLES);
	}
}
