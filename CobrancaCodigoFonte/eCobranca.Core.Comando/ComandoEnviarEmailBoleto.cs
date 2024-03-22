using System.Collections.Generic;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Patterns.Command;
using eCobranca.Util;

namespace eCobranca.Core.Comando;

public class ComandoEnviarEmailBoleto : ICommand
{
	private CarteiraCobranca carteira;

	private List<ArquivoEnvioEmail> arquivosParaEnvio;

	public CarteiraCobranca Carteira => carteira;

	public List<ArquivoEnvioEmail> ArquivosParaEnvio => arquivosParaEnvio;

	public void Execute()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (ArquivoEnvioEmail item in arquivosParaEnvio)
		{
			list.Clear();
			list2.Clear();
			list.Add(item.Email);
			list2.Add(item.Nome);
			EmailUtil.EnviarEmail(list, carteira.ConfiguracaoEmail, list2);
		}
		ExcluirAnexos(arquivosParaEnvio);
	}

	public void Preparar(CarteiraCobranca carteira, List<ArquivoEnvioEmail> arquivos)
	{
		this.carteira = carteira;
		arquivosParaEnvio = arquivos;
	}

	private void ExcluirAnexos(List<ArquivoEnvioEmail> arquivos)
	{
		foreach (ArquivoEnvioEmail arquivo in arquivos)
		{
			if (File.Exists(arquivo.Nome) && !FileManager.IsFileInUse(arquivo.Nome))
			{
				File.Delete(arquivo.Nome);
			}
		}
	}
}
