using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumShellExecuteError
{
	[Description("O sistema operacional não possui mais memória ou recursos necessários")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	ERROR_SUCCESS,
	[Description("O arquivo especificado não foi encontrado")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	ERROR_FILE_NOT_FOUND,
	[Description("O caminho especificado não foi encontrado")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	ERROR_PATH_NOT_FOUND,
	[Description("O executável informado é inválido (não é um executável Win32 válido)")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	ERROR_BAD_FORMAT,
	[Description("O sistema operacional impediu o acesso ao arquivo especificado")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_ACCESSDENIED,
	[Description("O nome do arquivo está incompleto ou é inválido")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_ASSOCINCOMPLETE,
	[Description("A transação DDE (Dynamic Data Exchange) não pode ser completada porque outra DDE estava sendo executada")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_DDEBUSY,
	[Description("A transação DDE (Dynamic Data Exchange) falhou")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_DDEFAIL,
	[Description("A transação DDE (Dynamic Data Exchange) não pode ser completada por demora no tempo de resposta")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_DDETIMEOUT,
	[Description("A DLL (Dynamic Link Library) informada não foi encontrada")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_DLLNOTFOUND,
	[Description("O arquivo especificado não foi encontrado")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_FNF,
	[Description("Não existe aplicação compatível com a extensão do arquivo ou o arquivo informado não pode ser impresso")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_NOASSOC,
	[Description("Não há memória suficiente para completar a operação")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_OOM,
	[Description("O caminho especificado não foi encontrado")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_PNF,
	[Description("Uma violação de compartilhamento ocorreu")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SE_ERR_SHARE
}
