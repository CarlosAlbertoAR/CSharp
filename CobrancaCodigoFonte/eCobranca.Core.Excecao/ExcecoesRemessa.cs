using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecoesRemessa
{
	public ExcecaoGenerica LayoutRemessaNaoEspecificado()
	{
		return new ExcecaoGenerica(2000, $"Layout de arquivo de remessa não especificado.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoComandosDaMacroBaseGerarArquivoRemessa(Exception e)
	{
		return new ExcecaoGenerica(2001, $"Falha na geração dos comandos necessários para a macro base gerar arquivo de remessa.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoComandosDaMacroBaseGerarLoteArquivoRemessa(Exception e)
	{
		return new ExcecaoGenerica(2002, $"Falha na geração dos comandos necessários para a macro base gerar lote arquivo de remessa.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoRemessa(string layoutRemessa, Exception e)
	{
		return new ExcecaoGenerica(2003, $"Falha gerando remessa no padrão [{layoutRemessa}].", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica FalhaGerandoComandosDaMacroEspecificaGerarLoteArquivoRemessa(Exception e)
	{
		return new ExcecaoGenerica(2004, $"Falha na geração dos comandos necessários para a macro base gerar lote arquivo de remessa.", e, EnumCategoriaExcecao.GERAL, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica LayoutRemessaAindaNaoImplementado(string layoutRemessa)
	{
		return new ExcecaoGenerica(2005, $"Layout de arquivo de remessa [{layoutRemessa}] ainda não implementado.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica CodigoMovimentoRemessaInvalido(string codigoMovimento)
	{
		return new ExcecaoGenerica(2006, $"Código do movimento de remessa informado [{codigoMovimento}] é inválido.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica NomeDoArquivoDeRemessaNuloOuVazio()
	{
		return new ExcecaoGenerica(2007, $"Nome do arquivo de remessa nulo ou vazio.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica DiretorioArquivoRemessaNuloOuVazio()
	{
		return new ExcecaoGenerica(2008, $"Diretório do arquivo de remessa nulo ou vazio.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}

	public ExcecaoGenerica LimiteArquivosRemessaAtingido(int quantidade)
	{
		return new ExcecaoGenerica(2009, $"Limite de remessas diárias atingido. Você pode gerar apenas {quantidade} remessas por dia.", null, EnumCategoriaExcecao.VALIDACAO, EnumTipoExcecaoECobranca.WARNING);
	}
}
