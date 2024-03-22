namespace eCobranca.Core.Modelo;

public interface IModeloBoleto
{
	int QuantidadeMaximaPorPagina { get; }

	string CaminhoModeloPersonalizadoHtml { get; set; }

	bool FichaCompensacaoPersonalizada { get; set; }

	string[] GerarBoleto(DocumentoCobranca dc);
}
