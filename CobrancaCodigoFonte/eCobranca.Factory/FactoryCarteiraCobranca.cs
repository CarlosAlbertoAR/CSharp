using System;
using System.Diagnostics;
using eCobranca.Core.Carteira;
using eCobranca.Core.Carteira.Ban001;
using eCobranca.Core.Carteira.Ban003;
using eCobranca.Core.Carteira.Ban004;
using eCobranca.Core.Carteira.Ban021;
using eCobranca.Core.Carteira.Ban033;
using eCobranca.Core.Carteira.Ban037;
using eCobranca.Core.Carteira.Ban041;
using eCobranca.Core.Carteira.Ban084;
using eCobranca.Core.Carteira.Ban085;
using eCobranca.Core.Carteira.Ban097;
using eCobranca.Core.Carteira.Ban099;
using eCobranca.Core.Carteira.Ban104;
using eCobranca.Core.Carteira.Ban133;
using eCobranca.Core.Carteira.Ban136;
using eCobranca.Core.Carteira.Ban237;
using eCobranca.Core.Carteira.Ban341;
using eCobranca.Core.Carteira.Ban399;
using eCobranca.Core.Carteira.Ban422;
using eCobranca.Core.Carteira.Ban748;
using eCobranca.Core.Carteira.Ban756;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactoryCarteiraCobranca
{
	private static FactoryCarteiraCobranca uniqueInstance;

	private static object syncRoot = new object();

	private FactoryCarteiraCobranca()
	{
	}

	public static FactoryCarteiraCobranca GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de carteiras de cobrança...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new FactoryCarteiraCobranca();
					}
				}
			}
			return uniqueInstance;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaAoCriarFabricaCarteiraCobranca(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public CarteiraCobranca GetCarteira(ConfiguracaoCarteiraCobranca configuracaoCarteira)
	{
		CarteiraCobranca result = null;
		try
		{
			Logger.Debug($"Obtendo instância de carteira de cobrança [{configuracaoCarteira.TipoCarteiraCobranca}]");
			if (Enum.IsDefined(typeof(EnumTipoCarteiraCobranca), configuracaoCarteira.TipoCarteiraCobranca))
			{
				switch ((EnumTipoCarteiraCobranca)Enum.Parse(typeof(EnumTipoCarteiraCobranca), configuracaoCarteira.TipoCarteiraCobranca))
				{
				case EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo11(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo11(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_11_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo11(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo12(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo12(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo12(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_15_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo15(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_15_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo15(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_15_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo15(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_16_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo16(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_16_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo16(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_16_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo16(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_16_CONVENIO_6_NOSSO_NUMERO_LIVRE_17:
					result = new CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17PosicoesCodigo16(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo17(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo17(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_17_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo17(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_18_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo18(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_18_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo18(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_18_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo18(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_18_CONVENIO_6_NOSSO_NUMERO_LIVRE_17:
					result = new CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17PosicoesCodigo18(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo31(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo31(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_31_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo31(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_4:
					result = new CarteiraCobrancaBan001Convenio4DigitosCodigo51(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_6:
					result = new CarteiraCobrancaBan001Convenio6DigitosCodigo51(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN001_COD_51_CONVENIO_7:
					result = new CarteiraCobrancaBan001Convenio7DigitosCodigo51(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN003_CNR:
					result = new CarteiraCobrancaBan003CodigoCNR(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN003_CODIGO_1:
					result = new CarteiraCobrancaBan003Codigo1(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN004_COD_121:
					result = new CarteiraCobrancaBan004Codigo121(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN004_COD_241:
					result = new CarteiraCobrancaBan004Codigo241(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN004_COD_421:
					result = new CarteiraCobrancaBan004Codigo421(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN004_COD_541:
					result = new CarteiraCobrancaBan004Codigo541(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN004_COD_I51:
					result = new CarteiraCobrancaBan004CodigoI51(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN021_COD_01:
					result = new CarteiraCobrancaBan021Codigo01(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN021_COD_11:
					result = new CarteiraCobrancaBan021Codigo11(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN021_COD_13:
					result = new CarteiraCobrancaBan021Codigo13(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_ECR_400:
					result = new CarteiraCobrancaBan033CodigoECR_400(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240:
					result = new CarteiraCobrancaBan033CodigoECR_NOVA_240(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240:
					result = new CarteiraCobrancaBan033CodigoRCR_NOVA_240(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400:
					result = new CarteiraCobrancaBan033CodigoECR_NOVA_400(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400:
					result = new CarteiraCobrancaBan033CodigoRCR_NOVA_400(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_CSR:
					result = new CarteiraCobrancaBan033CodigoCSR(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN033_CSR_NOVA:
					result = new CarteiraCobrancaBan033CodigoCSR_NOVA(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN037_CR_240:
					result = new CarteiraCobrancaBan037CodigoCR(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN041_COBRANCA_SIMPLES:
					result = new CarteiraCobrancaBan041Codigo1_Simples(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN041_COBRANCA_CSB:
					result = new CarteiraCobrancaBan041CodigoD_CSB(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN041_COBRANCA_VENDOR:
					result = new CarteiraCobrancaBan041CodigoS_Vendor(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN041_COBRANCA_DESCONTADA:
					result = new CarteiraCobrancaBan041CodigoR_Descontada(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN084_COD_09:
					result = new CarteiraCobrancaBan084Codigo09(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN085_CODIGO_01:
					result = new CarteiraCobrancaBan085Codigo01(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN097_CODIGO_18:
					result = new CarteiraCobrancaBan097Codigo18(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN097_SIMPLES:
					result = new CarteiraCobrancaBan097SIMPLES(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN099_COD_09:
					result = new CarteiraCobrancaBan099Codigo09(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN104_SIG11:
					result = new CarteiraCobrancaBan104SIGCBCodigoSIG11(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN104_SIG14:
					result = new CarteiraCobrancaBan104SIGCBCodigoSIG14(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN104_SIG21:
					result = new CarteiraCobrancaBan104SIGCBCodigoSIG21(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN104_SIG24:
					result = new CarteiraCobrancaBan104SIGCBCodigoSIG24(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN133_CODIGO_09:
					result = new CarteiraCobrancaBan133Codigo09(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN136_COD_21:
					result = new CarteiraCobrancaBan136Codigo21(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_02:
					result = new CarteiraCobrancaBan237Codigo02(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_03:
					result = new CarteiraCobrancaBan237Codigo03(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_04:
					result = new CarteiraCobrancaBan237Codigo04(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_06:
					result = new CarteiraCobrancaBan237Codigo06(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_07:
					result = new CarteiraCobrancaBan237Codigo07(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_09:
					result = new CarteiraCobrancaBan237Codigo09(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED:
					result = new CarteiraCobrancaBan237Codigo09Unicred(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL:
					result = new CarteiraCobrancaBan237Codigo09Cresol(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_12:
					result = new CarteiraCobrancaBan237Codigo12(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_16:
					result = new CarteiraCobrancaBan237Codigo16(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_17:
					result = new CarteiraCobrancaBan237Codigo17(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_19:
					result = new CarteiraCobrancaBan237Codigo19(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_21:
					result = new CarteiraCobrancaBan237Codigo21(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_22:
					result = new CarteiraCobrancaBan237Codigo22(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN237_COD_27:
					result = new CarteiraCobrancaBan237Codigo27(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_102:
					result = new CarteiraCobrancaBan341Codigo102(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_103:
					result = new CarteiraCobrancaBan341Codigo103(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_104:
					result = new CarteiraCobrancaBan341Codigo104(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_105:
					result = new CarteiraCobrancaBan341Codigo105(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_106:
					result = new CarteiraCobrancaBan341Codigo106(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_107:
					result = new CarteiraCobrancaBan341Codigo107(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_108:
					result = new CarteiraCobrancaBan341Codigo108(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_109:
					result = new CarteiraCobrancaBan341Codigo109(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_110:
					result = new CarteiraCobrancaBan341Codigo110(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_111:
					result = new CarteiraCobrancaBan341Codigo111(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_112:
					result = new CarteiraCobrancaBan341Codigo112(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_113:
					result = new CarteiraCobrancaBan341Codigo113(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_114:
					result = new CarteiraCobrancaBan341Codigo114(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_115:
					result = new CarteiraCobrancaBan341Codigo115(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_120:
					result = new CarteiraCobrancaBan341Codigo120(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_121:
					result = new CarteiraCobrancaBan341Codigo121(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_122:
					result = new CarteiraCobrancaBan341Codigo122(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_126:
					result = new CarteiraCobrancaBan341Codigo126(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_129:
					result = new CarteiraCobrancaBan341Codigo129(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_131:
					result = new CarteiraCobrancaBan341Codigo131(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_138:
					result = new CarteiraCobrancaBan341Codigo138(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_139:
					result = new CarteiraCobrancaBan341Codigo139(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_140:
					result = new CarteiraCobrancaBan341Codigo140(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_141:
					result = new CarteiraCobrancaBan341Codigo141(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_142:
					result = new CarteiraCobrancaBan341Codigo142(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_143:
					result = new CarteiraCobrancaBan341Codigo143(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_146:
					result = new CarteiraCobrancaBan341Codigo146(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_147:
					result = new CarteiraCobrancaBan341Codigo147(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_150:
					result = new CarteiraCobrancaBan341Codigo150(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_166:
					result = new CarteiraCobrancaBan341Codigo166(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_168:
					result = new CarteiraCobrancaBan341Codigo168(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_169:
					result = new CarteiraCobrancaBan341Codigo169(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_172:
					result = new CarteiraCobrancaBan341Codigo172(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_173:
					result = new CarteiraCobrancaBan341Codigo173(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_174:
					result = new CarteiraCobrancaBan341Codigo174(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_175:
					result = new CarteiraCobrancaBan341Codigo175(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_177:
					result = new CarteiraCobrancaBan341Codigo177(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_178:
					result = new CarteiraCobrancaBan341Codigo178(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_179:
					result = new CarteiraCobrancaBan341Codigo179(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_180:
					result = new CarteiraCobrancaBan341Codigo180(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_195:
					result = new CarteiraCobrancaBan341Codigo195(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_196:
					result = new CarteiraCobrancaBan341Codigo196(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_198:
					result = new CarteiraCobrancaBan341Codigo198(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_210:
					result = new CarteiraCobrancaBan341Codigo210(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_212:
					result = new CarteiraCobrancaBan341Codigo212(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_221:
					result = new CarteiraCobrancaBan341Codigo221(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_280:
					result = new CarteiraCobrancaBan341Codigo280(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_305:
					result = new CarteiraCobrancaBan341Codigo305(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_352:
					result = new CarteiraCobrancaBan341Codigo352(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_354:
					result = new CarteiraCobrancaBan341Codigo354(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_358:
					result = new CarteiraCobrancaBan341Codigo358(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_359:
					result = new CarteiraCobrancaBan341Codigo359(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_364:
					result = new CarteiraCobrancaBan341Codigo364(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_365:
					result = new CarteiraCobrancaBan341Codigo365(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_458:
					result = new CarteiraCobrancaBan341Codigo458(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_459:
					result = new CarteiraCobrancaBan341Codigo459(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_880:
					result = new CarteiraCobrancaBan341Codigo880(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN341_986:
					result = new CarteiraCobrancaBan341Codigo986(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN399_CSB_COBRANCA_DIRETIVA:
					result = new CarteiraCobrancaBan399CodigoCSB(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN399_CNR_COBRANCA_SEM_REGISTRO:
					result = new CarteiraCobrancaBan399CodigoCNR(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN422_CODIGO_1:
					result = new CarteiraCobrancaBan422Codigo1(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN422_CODIGO_2:
					result = new CarteiraCobrancaBan422Codigo2(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN748_A:
					result = new CarteiraCobrancaBan748CodigoA(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN748_C:
					result = new CarteiraCobrancaBan748CodigoC(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN756_SIMPLES_COM_REGISTRO:
					result = new CarteiraCobrancaBan756Codigo01ComRegistro(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN756_SIMPLES_SEM_REGISTRO:
					result = new CarteiraCobrancaBan756Codigo02SemRegistro(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN756_CAUCIONADA_GARANTIDA:
					result = new CarteiraCobrancaBan756Codigo03Garantida(configuracaoCarteira);
					return result;
				case EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL:
					result = new CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos(configuracaoCarteira);
					return result;
				default:
					return result;
				case EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA:
					return result;
				}
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CodigoCarteiraCobrancaNaoDefinidoOuInvalido(), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCarregandoCarteiraCobranca(configuracaoCarteira.TipoCarteiraCobranca.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
