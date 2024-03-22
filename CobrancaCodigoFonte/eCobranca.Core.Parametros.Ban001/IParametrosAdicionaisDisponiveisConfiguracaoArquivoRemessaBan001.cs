namespace eCobranca.Core.Parametros.Ban001;

public interface IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan001 : IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa
{
	ParametroConfiguracao GeraDetalheRemessaCnab400();

	ParametroConfiguracao GeraMensagemRemessaCnab400();
}
