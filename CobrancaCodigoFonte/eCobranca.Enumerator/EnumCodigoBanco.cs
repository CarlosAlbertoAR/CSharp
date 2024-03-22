using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoBanco
{
	[Description("BANCO DO BRASIL S.A.")]
	[AtributoDominio("001", "BANCODOBRASIL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_BRASIL = 0,
	[Description("BANCO DA AMAZÔNIA")]
	[AtributoDominio("003", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DA_AMAZONIA = 1,
	[Description("BANCO DO NORDESTE DO BRASIL")]
	[AtributoDominio("004", "B. DO NORDESTE", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_NORDESTE_DO_BRASIL = 2,
	[Description("BANCO DO ESTADO DO ESPÍRITO SANTO")]
	[AtributoDominio("021", "BANESTES", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DO_ESPIRITO_SANTO = 3,
	[Description("BANCO DO ESTADO DE PERNAMBUCO")]
	[AtributoDominio("024", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DE_PERNAMBUCO = 4,
	[Description("BANCO ALFA")]
	[AtributoDominio("025", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_ALFA = 5,
	[Description("BANCO DO ESTADO DE SANTA CATARINA")]
	[AtributoDominio("027", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DE_SANTA_CATARINA = 6,
	[Description("BANCO SANTANDER")]
	[AtributoDominio("033", "BANCO SANTANDER", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_SANTANDER = 7,
	[Description("BANCO DO ESTADO PARÁ")]
	[AtributoDominio("037", "BANPARA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DO_PARA = 55,
	[Description("BANCO DO ESTADO DO RIO GRANDE DO SUL")]
	[AtributoDominio("041", "BANRISUL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL = 8,
	[Description("BANCO BVA")]
	[AtributoDominio("044", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_BVA = 9,
	[Description("BANCO DO ESTADO DE SERGIPE")]
	[AtributoDominio("047", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DO_ESTADO_DE_SERGIPE = 10,
	[Description("BPN BRASIL BANCO MÚLTIPLO")]
	[AtributoDominio("069", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BPN_BRASIL_BANCO_MULTIPLO = 11,
	[Description("BANCO DE BRASÍLIA")]
	[AtributoDominio("070", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DE_BRASILIA = 12,
	[Description("BANCO J SAFRA")]
	[AtributoDominio("0074", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_J_SAFRA = 13,
	[Description("UNIPRIME NORTE DO PARANÁ - COOPERATIVA CENTRAL DE ECONOMIA E CREDITO MUTUO DAS UNICRED")]
	[AtributoDominio("084", "UNIPRIME", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	UNIPRIME_NORTE_PARANA = 58,
	[Description("COOPERATIVA CENTRAL AILOS")]
	[AtributoDominio("085", "AILOS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	COOPERATIVA_CENTRAL_AILOS = 14,
	[Description("COOPERATIVA CENTRAL DE CRÉDITO NOROESTE BRASILEIRO")]
	[AtributoDominio("097", "CENTRALCREDI", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO = 15,
	[Description("UNIPRIME CENTRAL - COOPERATIVA CENTRAL DE ECONOMIA E CREDITO MUTUO DAS UNICRED")]
	[AtributoDominio("099", "UNIPRIME", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED = 16,
	[Description("CAIXA ECONÔMICA FEDERAL")]
	[AtributoDominio("104", "CAIXA ECONOMICA FEDERAL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CAIXA_ECONOMICA_FEDERAL = 17,
	[Description("CRESOL")]
	[AtributoDominio("133", "CRESOL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CRESOL = 57,
	[Description("UNICRED")]
	[AtributoDominio("136", "UNICRED", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	UNICRED = 56,
	[Description("BANCO BBM")]
	[AtributoDominio("107", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_BBM = 18,
	[Description("BANCO FIBRA")]
	[AtributoDominio("224", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_FIBRA = 19,
	[Description("BANCO BRADESCO")]
	[AtributoDominio("237", "BRADESCO", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_BRADESCO = 20,
	[Description("BANCO ABC BRASIL")]
	[AtributoDominio("246", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_ABC_BRASIL = 21,
	[Description("BANCO CACIQUE")]
	[AtributoDominio("263", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_CACIQUE = 22,
	[Description("BANCO CÉDULA")]
	[AtributoDominio("266", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_CEDULA = 23,
	[Description("BANCO INDL E COML BICBANCO")]
	[AtributoDominio("320", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_INDL_E_COML_BICBANCO = 24,
	[Description("BANCO ITAÚ SA")]
	[AtributoDominio("341", "BANCO ITAU SA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_ITAU = 25,
	[Description("BANCO ABN AMRO")]
	[AtributoDominio("356", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_ABN_AMRO = 26,
	[Description("BANCO MERCANTIL DO BRASIL")]
	[AtributoDominio("389", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_MERCANTIL_DO_BRASIL = 27,
	[Description("BANCO BMC")]
	[AtributoDominio("394", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_BMC = 28,
	[Description("HSBC BANK BRASIL")]
	[AtributoDominio("399", "HSBC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HSBC_BANK_BRASIL = 29,
	[Description("BANCO SAFRA")]
	[AtributoDominio("422", "SAFRA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_SAFRA = 30,
	[Description("BANCO RURAL")]
	[AtributoDominio("453", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_RURAL = 31,
	[Description("BANCO LUSO BRASILEIRO")]
	[AtributoDominio("600", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_LUSO_BRASILEIRO = 32,
	[Description("BANCO INDUSTRIAL DO BRASIL")]
	[AtributoDominio("604", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_INDUSTRIAL_DO_BRASIL = 33,
	[Description("BANCO PAULISTA")]
	[AtributoDominio("611", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_PAULISTA = 34,
	[Description("BANCO PANAMERICANO")]
	[AtributoDominio("623", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_PANAMERICANO = 35,
	[Description("BANCO INTERCAP")]
	[AtributoDominio("630", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_INTERCAP = 36,
	[Description("BANCO RENDIMENTO")]
	[AtributoDominio("633", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_RENDIMENTO = 37,
	[Description("BANCO TRIBANCO")]
	[AtributoDominio("634", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_TRIBANCO = 38,
	[Description("BANCO SOFISA")]
	[AtributoDominio("637", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_SOFISA = 39,
	[Description("BANCO PINE")]
	[AtributoDominio("643", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_PINE = 40,
	[Description("BANCO INDUSVAL")]
	[AtributoDominio("653", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_INDUSVAL = 41,
	[Description("BANCO VOTORANTIM")]
	[AtributoDominio("655", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_VOTORANTIM = 42,
	[Description("BANCO DAYCIVAL")]
	[AtributoDominio("707", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_DAYCOVAL = 43,
	[Description("BANCO BANIF PRIMUS")]
	[AtributoDominio("719", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_BANIF_PRIMUS = 44,
	[Description("BANCO CREDIBEL")]
	[AtributoDominio("721", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_CREDIBEL = 45,
	[Description("BANCO GERDAU")]
	[AtributoDominio("734", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_GERDAU = 46,
	[Description("BANCO MORADA")]
	[AtributoDominio("738", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_MORADA = 47,
	[Description("BANCO GALVÃO DE NEGÓCIOS")]
	[AtributoDominio("739", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_GALVAO_DE_NEGOCIOS = 48,
	[Description("BANCO RIBEIRÃO PRETO")]
	[AtributoDominio("741", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_RIBEIRAO_PRETO = 49,
	[Description("BANCO CITIBANK")]
	[AtributoDominio("263", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_CITIBANK = 50,
	[Description("BANCO COOPERATIVO SICREDI")]
	[AtributoDominio("748", "SICREDI", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_COOPERATIVO_SICREDI = 51,
	[Description("BR BANCO MERCANTIL")]
	[AtributoDominio("749", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BR_BANCO_MERCANTIL = 52,
	[Description("NBC BANK BRASIL BANCO MÚLTIPLO")]
	[AtributoDominio("753", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	NBC_BANK_BRASIL_BANCO_MULTIPLO = 53,
	[Description("BANCO COOPERATIVO DO BRASIL")]
	[AtributoDominio("756", "BANCOOBCED", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BANCO_COOPERATIVO_DO_BRASIL = 54
}
