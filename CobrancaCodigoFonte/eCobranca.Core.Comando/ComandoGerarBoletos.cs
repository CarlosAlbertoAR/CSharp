using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Command;
using eCobranca.Util;

namespace eCobranca.Core.Comando;

public class ComandoGerarBoletos : ICommand
{
	private CarteiraCobranca carteira;

	private ComandoGerarBoletosFisicos comandoGerarBoletos;

	private ComandoImprimirBoletos comandoImprimirBoletos;

	private ComandoEnviarEmailBoleto comandoEnviarBoletos;

	private IList<BoletoStream> boletosStream;

	public IList<BoletoStream> BoletosStream => boletosStream;

	public ComandoGerarBoletos()
	{
		boletosStream = new List<BoletoStream>();
		GerarComandos();
	}

	private void GerarComandos()
	{
		comandoGerarBoletos = new ComandoGerarBoletosFisicos();
		comandoImprimirBoletos = new ComandoImprimirBoletos();
		comandoEnviarBoletos = new ComandoEnviarEmailBoleto();
	}

	public void Execute()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		FontUtil.InstallAllFonts();
		stopwatch.Stop();
		Logger.Info($"Tempo gasto para instalação das fontes em milisegundos: {stopwatch.ElapsedMilliseconds}");
		stopwatch.Restart();
		comandoGerarBoletos.Execute();
		boletosStream = comandoGerarBoletos.BoletosStream;
		if (carteira.ConfiguracaoEmail.EnviaEmail)
		{
			comandoEnviarBoletos.Preparar(carteira, comandoGerarBoletos.ArquivosParaEnvio);
			comandoEnviarBoletos.Execute();
		}
		comandoImprimirBoletos.Preparar(carteira, comandoGerarBoletos.FilaImpressao, comandoGerarBoletos.DadosImpressao, comandoGerarBoletos.ModeloBoleto);
		comandoImprimirBoletos.Execute();
		stopwatch.Stop();
		Logger.Info($"Tempo gasto em milisegundos: {stopwatch.ElapsedMilliseconds}");
	}

	public void Preparar(CarteiraCobranca carteira, ArrayList dcList)
	{
		this.carteira = carteira;
		comandoGerarBoletos.Preparar(carteira, dcList);
	}

	public void Preparar(CarteiraCobranca carteira, ArrayList dcList, bool modoStream, bool modoIndividual)
	{
		this.carteira = carteira;
		comandoGerarBoletos.Preparar(carteira, dcList, modoStream, modoIndividual);
	}
}
