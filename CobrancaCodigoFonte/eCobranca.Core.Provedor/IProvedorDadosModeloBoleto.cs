namespace eCobranca.Core.Provedor;

public interface IProvedorDadosModeloBoleto
{
	string GetLogoTipoBanco();

	string GetNumeroBanco();

	string GetVencimento();

	string GetAgenciaCodigoCedente();

	string GetMoeda();

	string GetQuantidade();

	string GetValorDocumento();

	string GetValorDesconto();

	string GetValorJuros();

	string GetNossoNumero();

	string GetNumeroDocumento();

	string GetNomeCedente();

	string GetIdentificacaoCedente();

	string GetLocalPagamento();

	string GetDataDocumento();

	string GetEspecieDocumento();

	string GetAceite();

	string GetDataProcessamento();

	string GetCodigoUsoBanco();

	string GetCarteira();

	string GetInstrucoesCaixa();

	string GetNomeSacado();

	string GetCnpjSacado();

	string GetCpfSacado();

	string GetEnderecoSacado();

	string GetBairroSacado();

	string GetCidadeSacado();

	string GetUfSacado();

	string GetCepSacado();

	string GetIdentificacaoSacado();

	string GetIdentificacaoSacadorAvalista();

	string GetLinhaDigitavel();

	string GetCodigoBarras();

	string GetContatoSac();

	string GetLogotipoCedente();

	string GetValorOutrosAcrescimos();

	string GetDemonstrativo();

	string GetUrlOrigem();

	string GetPropaganda();

	string GetLinhaDigitavelEspelho();

	string GetNumeroBancoRecibo();

	string GetImagemAutenticacaoMecanica();

	string GetAlturaCampoDemonstrativoReciboEntrega();

	string GetAlturaCampoDemonstrativoReciboPagador();

	string GetEstiloLinhaDigitavel();

	string GetEstiloCabecalhoCampoFichaCompensacao();

	string GetEstiloConteudoCampoFichaCompensacao();

	string GetEstiloLogotipoBanco();

	string GetEstiloCodigoBanco();

	string GetEstiloConteudoCampoValorFichaCompensacao();

	string GetEstiloIntrucoesFichaCompensacao();

	string GetEstiloDadosPagador();

	string GetEstiloDadosAvalista();

	string GetEstiloAutenticacaoMecanica();

	string GetTipoPropaganda();

	string GetCelularPagador();

	string GetEnderecoSacadorAvalista();

	string GetNumeroEnderecoSacadorAvalista();

	string GetComplementoSacadorAvalista();

	string GetBairroSacadorAvalista();

	string GetCidadeSacadorAvalista();

	string GetUfSacadorAvalista();

	string GetCepSacadorAvalista();

	string GetTelefoneSacadorAvalista();

	string GetPrefixoNomenclaturaBoleto();

	string GetNomenclaturaBoleto();

	string GetDiretorioGeracaoBoleto();

	string GetInformacoesExtras();
}
