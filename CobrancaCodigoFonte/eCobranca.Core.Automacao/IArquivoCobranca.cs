using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao;

public interface IArquivoCobranca
{
	EnumPadraoArquivoCobranca Padrao { get; }

	EnumTipoArquivoCobranca Tipo { get; }

	string Diretorio { get; set; }

	string Versao { get; }

	DateTime DataGeracao { get; set; }

	long Sequencia { get; set; }
}
