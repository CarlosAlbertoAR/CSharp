using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesRetorno
{
	public ExcecaoGenerica LayoutRetornoNaoEspecificado()
	{
		return new ExcecaoGenerica(3000, $"Layout de arquivo de retorno não especificado.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoComandosDaMacroBaseCarregarArquivoRetorno(Exception e)
	{
		return new ExcecaoGenerica(3001, $"Falha na geração dos comandos necessários para o macro comando base carregar arquivo de retorno.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoComandosDaMacroBaseCarregarLoteArquivoRetorno(Exception e)
	{
		return new ExcecaoGenerica(3002, $"Falha na geração dos comandos necessários para o macro comando base carregar lote arquivo de retorno.", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaCarregandoArquivoRetorno(string layoutRetorno, Exception e)
	{
		return new ExcecaoGenerica(3003, $"Falha no carregamento do arquivo de retorno no padrão [{layoutRetorno}].", e, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica LayoutRetornoAindaNaoImplementado(string layoutRetorno)
	{
		return new ExcecaoGenerica(3004, $"Layout de arquivo de retorno [{layoutRetorno}] ainda não implementado.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}
}
