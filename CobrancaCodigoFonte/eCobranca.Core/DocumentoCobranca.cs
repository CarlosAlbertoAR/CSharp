using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core;

public class DocumentoCobranca
{
	private string modalidadeCobranca;

	private string codigoJuros;

	private string codigoProtesto;

	private string codigoDesconto;

	private string codigoMulta;

	private string codigoBaixaDevolucao;

	private string codigoMovimentoRemessa;

	private string aceite;

	private string agenciaDebito;

	private string bairroPagador;

	private string cepPagador;

	private string cidadePagador;

	private string cnpjPagador;

	private string cnpjAvalista;

	private string codigoBarras;

	private string contaCorrenteDebito;

	private string cpfPagador;

	private string cpfAvalista;

	private string enderecoPagador;

	private string ufPagador;

	private string instrucaoCaixa;

	private string linhaDigitavel;

	private string minhaChave;

	private string moeda;

	private string nomePagador;

	private string nomeFantasiaPagador;

	private string nossoNumero;

	private string nossoNumeroSemMascara;

	private string numeroControle;

	private string numeroDocumento;

	private string sacadorAvalista;

	private string enderecoSacadorAvalista;

	private string complementoSacadorAvalista;

	private string bairroSacadorAvalista;

	private string cidadeSacadorAvalista;

	private string ufSacadorAvalista;

	private string cepSacadorAvalista;

	private string telefoneSacadorAvalista;

	private string tipoDocumentoCobranca;

	private string valorExtenso;

	private string localPagamento;

	private string codigoUsoBanco;

	private string demonstrativo;

	private string urlOrigem;

	private string emailPagador;

	private string celularPagador;

	private string prefixoNomenclaturaBoleto;

	private string nomenclaturaBoleto;

	private string diretorioGeracaoBoleto;

	private string informacoesExtras;

	private DateTime? dataDocumento;

	private DateTime? dataLimiteDesconto;

	private DateTime? dataProcessamento;

	private DateTime? dataVencimento;

	private bool geraMensagemJuros;

	private bool geraMensagemMulta;

	private bool geraMensagemProtesto;

	private bool geraMensagemDesconto;

	private bool bancoEmiteBoleto;

	private bool bancoGeraNossoNumero;

	private bool calculaDacNossoNumero;

	private bool protestoDiasUteis;

	private string numeroEnderecoSacadorAvalista;

	private string numeroEnderecoPagador;

	private int numeroParcelaCarnet;

	private int totalParcelasCarnet;

	private int diasBaixaDevolucao;

	private int diasProtesto;

	private int valorInstrucaoCobranca1;

	private int valorInstrucaoCobranca2;

	private int valorInstrucaoCobranca3;

	private double percentualDesconto;

	private double percentualJurosDiaAtraso;

	private double percentualMultaAtraso;

	private double percentualOutrosAcrescimos;

	private double quantidadeMoeda;

	private double valorAbatimento;

	private double valorDesconto;

	private double valorDocumento;

	private double valorJurosDiasAtraso;

	private double valorMultaAtraso;

	private double valorOutrosAcrescimos;

	private ArrayList parametrosAdicionais;

	private ArrayList instrucoesCobranca;

	[Obsolete("A propriedade EmailSacado está em desuso, favor utilizar EmailPagador.")]
	public string EmailSacado
	{
		get
		{
			return emailPagador;
		}
		set
		{
			if (value != null)
			{
				if (value != string.Empty)
				{
					emailPagador = value.Trim();
				}
				else
				{
					emailPagador = string.Empty;
				}
			}
			else
			{
				emailPagador = string.Empty;
			}
		}
	}

	public string EmailPagador
	{
		get
		{
			return emailPagador;
		}
		set
		{
			if (value != null)
			{
				if (value != string.Empty)
				{
					emailPagador = value.Trim();
				}
				else
				{
					emailPagador = string.Empty;
				}
			}
			else
			{
				emailPagador = string.Empty;
			}
		}
	}

	public string CpfAvalista
	{
		get
		{
			return cpfAvalista;
		}
		set
		{
			if (value != null)
			{
				cpfAvalista = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CpfAvalista", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CnpjAvalista
	{
		get
		{
			return cnpjAvalista;
		}
		set
		{
			if (value != null)
			{
				cnpjAvalista = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CnpjAvalista", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoMovimentoRemessa
	{
		get
		{
			return codigoMovimentoRemessa;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoMovimentoRemessa>())
				{
					codigoMovimentoRemessa = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoMovimentoRemessa", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoMovimentoRemessa", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string Aceite
	{
		get
		{
			return aceite;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumTipoAceite), value.ToString().ToUpper()))
				{
					aceite = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("Aceite", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("Aceite", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string AgenciaDebito
	{
		get
		{
			return agenciaDebito;
		}
		set
		{
			if (value != null)
			{
				agenciaDebito = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("AgenciaDebito", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade BairroSacado está em desuso, favor utilizar BairroPagador.")]
	public string BairroSacado
	{
		get
		{
			return bairroPagador;
		}
		set
		{
			if (value != null)
			{
				bairroPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("BairroSacado", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string BairroPagador
	{
		get
		{
			return bairroPagador;
		}
		set
		{
			if (value != null)
			{
				bairroPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("BairroPagador", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool BancoEmiteBoleto
	{
		get
		{
			return bancoEmiteBoleto;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				bancoEmiteBoleto = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("BancoEmiteBoleto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool BancoGeraNossoNumero
	{
		get
		{
			return bancoGeraNossoNumero;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				bancoGeraNossoNumero = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("BancoGeraNossoNumero", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool CalculaDacNossoNumero
	{
		get
		{
			return calculaDacNossoNumero;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				calculaDacNossoNumero = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CalculaDacNossoNumero", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade CepSacado está em desuso, favor utilizar CepPagador.")]
	public string CepSacado
	{
		get
		{
			return cepPagador;
		}
		set
		{
			if (value != null)
			{
				cepPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CepSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CepPagador
	{
		get
		{
			return cepPagador;
		}
		set
		{
			if (value != null)
			{
				cepPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CepPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade CidadeSacado está em desuso, favor utilizar CidadePagador.")]
	public string CidadeSacado
	{
		get
		{
			return cidadePagador;
		}
		set
		{
			if (value != null)
			{
				cidadePagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CidadeSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CidadePagador
	{
		get
		{
			return cidadePagador;
		}
		set
		{
			if (value != null)
			{
				cidadePagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CidadePagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade CnpjSacado está em desuso, favor utilizar CnpjPagador")]
	public string CnpjSacado
	{
		get
		{
			return cnpjPagador;
		}
		set
		{
			if (value != null)
			{
				cnpjPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CnpjSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CnpjPagador
	{
		get
		{
			return cnpjPagador;
		}
		set
		{
			if (value != null)
			{
				cnpjPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CnpjPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ModalidadeCobranca
	{
		get
		{
			return modalidadeCobranca;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumModalidadeCarteiraCobranca>())
				{
					modalidadeCobranca = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ModalidadeCobranca", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ModalidadeCobranca", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoMulta
	{
		get
		{
			return codigoMulta;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoMulta>())
				{
					codigoMulta = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoMulta", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoMulta", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoDesconto
	{
		get
		{
			return codigoDesconto;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoDesconto>())
				{
					codigoDesconto = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoDesconto", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoDesconto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoProtesto
	{
		get
		{
			return codigoProtesto;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoProtesto>())
				{
					codigoProtesto = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoProtesto", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoProtesto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoJuros
	{
		get
		{
			return codigoJuros;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoJuros>())
				{
					codigoJuros = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoJuros", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoJuros", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoBaixaDevolucao
	{
		get
		{
			return codigoBaixaDevolucao;
		}
		set
		{
			if (value != null)
			{
				if (value.ExisteNaEnum<EnumCodigoBaixaDevolucao>())
				{
					codigoBaixaDevolucao = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("CodigoBaixaDevolucao", null), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoBaixaDevolucao", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoBarras
	{
		get
		{
			return codigoBarras;
		}
		set
		{
			if (value != null)
			{
				codigoBarras = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoBarras", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ContaCorrenteDebito
	{
		get
		{
			return contaCorrenteDebito;
		}
		set
		{
			if (value != null)
			{
				contaCorrenteDebito = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ContaCorrenteDebito", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade CpfSacado está em desuso, favor utilizar CpfPagador")]
	public string CpfSacado
	{
		get
		{
			return cpfPagador;
		}
		set
		{
			if (value != null)
			{
				cpfPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CpfSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CpfPagador
	{
		get
		{
			return cpfPagador;
		}
		set
		{
			if (value != null)
			{
				cpfPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CpfPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public DateTime? DataDocumento
	{
		get
		{
			return dataDocumento;
		}
		set
		{
			if (DateTime.TryParse(value.ToString(), out var result))
			{
				dataDocumento = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DataDocumento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public DateTime? DataLimiteDesconto
	{
		get
		{
			return dataLimiteDesconto;
		}
		set
		{
			if (!string.IsNullOrEmpty(value.ToString()))
			{
				if (DateTime.TryParse(value.ToString(), out var result))
				{
					dataLimiteDesconto = result;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DataLimiteDesconto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
		}
	}

	public DateTime? DataProcessamento
	{
		get
		{
			return dataProcessamento;
		}
		set
		{
			if (DateTime.TryParse(value.ToString(), out var result))
			{
				dataProcessamento = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DataProcessamento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public DateTime? DataVencimento
	{
		get
		{
			return dataVencimento;
		}
		set
		{
			if (DateTime.TryParse(value.ToString(), out var result))
			{
				dataVencimento = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DataVencimento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int DiasBaixaDevolucao
	{
		get
		{
			return diasBaixaDevolucao;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				diasBaixaDevolucao = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DiasBaixaDevolucao", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int DiasProtesto
	{
		get
		{
			return diasProtesto;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var _))
			{
				diasProtesto = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("DiasProtesto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade EnderecoSacado está em desuso, favor utilizar EnderecoPagador.")]
	public string EnderecoSacado
	{
		get
		{
			return enderecoPagador;
		}
		set
		{
			if (value != null)
			{
				enderecoPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("EnderecoSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string EnderecoPagador
	{
		get
		{
			return enderecoPagador;
		}
		set
		{
			if (value != null)
			{
				enderecoPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("EnderecoPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade UfSacado está em desuso, favor utilizar UfPagador.")]
	public string UfSacado
	{
		get
		{
			return ufPagador;
		}
		set
		{
			if (value != null)
			{
				ufPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("UfSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string UfPagador
	{
		get
		{
			return ufPagador;
		}
		set
		{
			if (value != null)
			{
				ufPagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("UfPagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string InstrucaoCaixa
	{
		get
		{
			return instrucaoCaixa;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				instrucaoCaixa = value;
			}
			else
			{
				instrucaoCaixa = string.Empty;
			}
		}
	}

	public string LinhaDigitavel
	{
		get
		{
			return linhaDigitavel;
		}
		set
		{
			if (value != null)
			{
				linhaDigitavel = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LinhaDigitavel", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string MinhaChave
	{
		get
		{
			return minhaChave;
		}
		set
		{
			if (value != null)
			{
				minhaChave = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("MinhaChave", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string Moeda
	{
		get
		{
			return moeda;
		}
		set
		{
			if (value != null)
			{
				moeda = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("Moeda", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool GeraMensagemDesconto
	{
		get
		{
			return geraMensagemDesconto;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				geraMensagemDesconto = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("GeraMensagemDesconto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool GeraMensagemJuros
	{
		get
		{
			return geraMensagemJuros;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				geraMensagemJuros = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("GeraMensagemJuros", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool GeraMensagemMulta
	{
		get
		{
			return geraMensagemMulta;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				geraMensagemMulta = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("GeraMensagemMulta", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool GeraMensagemProtesto
	{
		get
		{
			return geraMensagemProtesto;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var result))
			{
				geraMensagemProtesto = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("GeraMensagemProtesto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	[Obsolete("A propriedade NomeSacado está em desuso, favor utilizar NomePagador")]
	public string NomeSacado
	{
		get
		{
			return nomePagador;
		}
		set
		{
			if (value != null)
			{
				nomePagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NomeSacado", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string NomePagador
	{
		get
		{
			return nomePagador;
		}
		set
		{
			if (value != null)
			{
				nomePagador = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NomePagador", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string NossoNumero
	{
		get
		{
			return nossoNumero;
		}
		set
		{
			if (value != null)
			{
				nossoNumero = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NossoNumero", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string NossoNumeroSemMascara
	{
		get
		{
			return nossoNumeroSemMascara;
		}
		set
		{
			if (value != null)
			{
				nossoNumeroSemMascara = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NossoNumeroSemMascara", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string NumeroControle
	{
		get
		{
			return numeroControle;
		}
		set
		{
			if (value != null)
			{
				numeroControle = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NumeroControle", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string NumeroDocumento
	{
		get
		{
			return numeroDocumento;
		}
		set
		{
			if (value != null)
			{
				numeroDocumento = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NumeroDocumento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int NumeroParcelaCarnet
	{
		get
		{
			return numeroParcelaCarnet;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				numeroParcelaCarnet = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("NumeroParcelaCarnet", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualDesconto
	{
		get
		{
			return percentualDesconto;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				percentualDesconto = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualDesconto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualJurosDiaAtraso
	{
		get
		{
			return percentualJurosDiaAtraso;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var result))
			{
				percentualJurosDiaAtraso = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualJurosDiaAtraso", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualMultaAtraso
	{
		get
		{
			return percentualMultaAtraso;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				percentualMultaAtraso = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualMultaAtraso", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double PercentualOutrosAcrescimos
	{
		get
		{
			return percentualOutrosAcrescimos;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var result))
			{
				percentualOutrosAcrescimos = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("PercentualOutrosAcrescimos", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ProtestoDiasUteis
	{
		get
		{
			return protestoDiasUteis;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				protestoDiasUteis = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ProtestoDiasUteis", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double QuantidadeMoeda
	{
		get
		{
			return quantidadeMoeda;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var result))
			{
				quantidadeMoeda = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("QuantidadeMoeda", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string SacadorAvalista
	{
		get
		{
			return sacadorAvalista;
		}
		set
		{
			if (value != null)
			{
				sacadorAvalista = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("SacadorAvalista", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string TipoDocumentoCobranca
	{
		get
		{
			return tipoDocumentoCobranca;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumTipoDocumentoCobranca), value.ToString().ToUpper()))
				{
					tipoDocumentoCobranca = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TipoDocumentoCobranca", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("TipoDocumentoCobranca", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int TotalParcelasCarnet
	{
		get
		{
			return totalParcelasCarnet;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				totalParcelasCarnet = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("TotalParcelasCarnet", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorAbatimento
	{
		get
		{
			return valorAbatimento;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				valorAbatimento = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorAbatimento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorDesconto
	{
		get
		{
			return valorDesconto;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var result))
			{
				valorDesconto = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorDesconto", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorDocumento
	{
		get
		{
			return valorDocumento;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				valorDocumento = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorDocumento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int ValorInstrucaoCobranca1
	{
		get
		{
			return valorInstrucaoCobranca1;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				valorInstrucaoCobranca1 = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorInstrucaoCobranca1", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int ValorInstrucaoCobranca2
	{
		get
		{
			return valorInstrucaoCobranca2;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var _))
			{
				valorInstrucaoCobranca2 = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorInstrucaoCobranca2", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public int ValorInstrucaoCobranca3
	{
		get
		{
			return valorInstrucaoCobranca3;
		}
		set
		{
			if (int.TryParse(value.ToString(), out var result))
			{
				valorInstrucaoCobranca3 = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorInstrucaoCobranca3", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorJurosDiasAtraso
	{
		get
		{
			return valorJurosDiasAtraso;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				valorJurosDiasAtraso = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorJurosDiasAtraso", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorMultaAtraso
	{
		get
		{
			return valorMultaAtraso;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var result))
			{
				valorMultaAtraso = result;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorMultaAtraso", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public double ValorOutrosAcrescimos
	{
		get
		{
			return valorOutrosAcrescimos;
		}
		set
		{
			if (double.TryParse(value.ToString(), out var _))
			{
				valorOutrosAcrescimos = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ValorOutrosAcrescimos", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ValorExtenso
	{
		get
		{
			return valorExtenso;
		}
		set
		{
			if (value != null)
			{
				valorExtenso = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ValorExtenso", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string LocalPagamento
	{
		get
		{
			return localPagamento;
		}
		set
		{
			if (value != null)
			{
				localPagamento = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("LocalPagamento", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string CodigoUsoBanco
	{
		get
		{
			return codigoUsoBanco;
		}
		set
		{
			if (value != null)
			{
				codigoUsoBanco = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("CodigoUsoBanco", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string Demonstrativo
	{
		get
		{
			return demonstrativo;
		}
		set
		{
			if (value != null)
			{
				demonstrativo = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("Demonstrativo", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string URLOrigem
	{
		get
		{
			return urlOrigem;
		}
		set
		{
			if (value != null)
			{
				urlOrigem = value;
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("URLOrigem", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ArrayList ParametrosAdicionais
	{
		get
		{
			return parametrosAdicionais;
		}
		set
		{
			if (value != null)
			{
				if (value != null)
				{
					parametrosAdicionais = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ParametrosConfiguracao", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ParametrosConfiguracao", new InvalidCastException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ArrayList InstrucoesCobranca => instrucoesCobranca;

	public string NomeFantasiaPagador
	{
		get
		{
			return nomeFantasiaPagador;
		}
		set
		{
			nomeFantasiaPagador = value;
		}
	}

	public string NumeroEnderecoPagador
	{
		get
		{
			return numeroEnderecoPagador;
		}
		set
		{
			numeroEnderecoPagador = value;
		}
	}

	public string CelularPagador
	{
		get
		{
			return celularPagador;
		}
		set
		{
			celularPagador = value;
		}
	}

	public string EnderecoSacadorAvalista
	{
		get
		{
			return enderecoSacadorAvalista;
		}
		set
		{
			enderecoSacadorAvalista = value;
		}
	}

	public string NumeroEnderecoSacadorAvalista
	{
		get
		{
			return numeroEnderecoSacadorAvalista;
		}
		set
		{
			numeroEnderecoSacadorAvalista = value;
		}
	}

	public string ComplementoSacadorAvalista
	{
		get
		{
			return complementoSacadorAvalista;
		}
		set
		{
			complementoSacadorAvalista = value;
		}
	}

	public string BairroSacadorAvalista
	{
		get
		{
			return bairroSacadorAvalista;
		}
		set
		{
			bairroSacadorAvalista = value;
		}
	}

	public string CidadeSacadorAvalista
	{
		get
		{
			return cidadeSacadorAvalista;
		}
		set
		{
			cidadeSacadorAvalista = value;
		}
	}

	public string UfSacadorAvalista
	{
		get
		{
			return ufSacadorAvalista;
		}
		set
		{
			ufSacadorAvalista = value;
		}
	}

	public string CepSacadorAvalista
	{
		get
		{
			return cepSacadorAvalista;
		}
		set
		{
			cepSacadorAvalista = value;
		}
	}

	public string PrefixoNomenclaturaBoleto
	{
		get
		{
			return prefixoNomenclaturaBoleto;
		}
		set
		{
			prefixoNomenclaturaBoleto = value;
		}
	}

	public string NomenclaturaBoleto
	{
		get
		{
			return nomenclaturaBoleto;
		}
		set
		{
			nomenclaturaBoleto = value;
		}
	}

	public string DiretorioGeracaoBoleto
	{
		get
		{
			return diretorioGeracaoBoleto;
		}
		set
		{
			diretorioGeracaoBoleto = value;
		}
	}

	public string TelefoneSacadorAvalista
	{
		get
		{
			return telefoneSacadorAvalista;
		}
		set
		{
			telefoneSacadorAvalista = value;
		}
	}

	public string InformacoesExtras
	{
		get
		{
			return informacoesExtras;
		}
		set
		{
			informacoesExtras = value;
		}
	}

	public DocumentoCobranca(string modalidadePadrao)
	{
		try
		{
			codigoMovimentoRemessa = EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.ToString();
			aceite = string.Empty;
			agenciaDebito = string.Empty;
			contaCorrenteDebito = string.Empty;
			cnpjPagador = string.Empty;
			cpfPagador = string.Empty;
			enderecoPagador = string.Empty;
			bairroPagador = string.Empty;
			cidadePagador = string.Empty;
			ufPagador = string.Empty;
			cepPagador = string.Empty;
			emailPagador = string.Empty;
			celularPagador = string.Empty;
			cnpjAvalista = string.Empty;
			cpfAvalista = string.Empty;
			sacadorAvalista = string.Empty;
			enderecoSacadorAvalista = string.Empty;
			complementoSacadorAvalista = string.Empty;
			bairroSacadorAvalista = string.Empty;
			cidadeSacadorAvalista = string.Empty;
			ufSacadorAvalista = string.Empty;
			cepSacadorAvalista = string.Empty;
			codigoBaixaDevolucao = string.Empty;
			codigoBarras = string.Empty;
			linhaDigitavel = string.Empty;
			minhaChave = string.Empty;
			moeda = string.Empty;
			nomePagador = string.Empty;
			nomeFantasiaPagador = string.Empty;
			nossoNumero = string.Empty;
			numeroControle = string.Empty;
			numeroDocumento = string.Empty;
			tipoDocumentoCobranca = string.Empty;
			valorExtenso = string.Empty;
			localPagamento = string.Empty;
			codigoUsoBanco = string.Empty;
			demonstrativo = string.Empty;
			urlOrigem = string.Empty;
			instrucaoCaixa = string.Empty;
			emailPagador = string.Empty;
			numeroEnderecoPagador = string.Empty;
			numeroEnderecoSacadorAvalista = string.Empty;
			prefixoNomenclaturaBoleto = string.Empty;
			nomenclaturaBoleto = string.Empty;
			diretorioGeracaoBoleto = string.Empty;
			informacoesExtras = string.Empty;
			geraMensagemJuros = true;
			geraMensagemMulta = true;
			geraMensagemProtesto = true;
			bancoEmiteBoleto = false;
			bancoGeraNossoNumero = false;
			calculaDacNossoNumero = true;
			protestoDiasUteis = false;
			numeroParcelaCarnet = 0;
			totalParcelasCarnet = 0;
			diasBaixaDevolucao = 0;
			diasProtesto = 0;
			valorInstrucaoCobranca1 = 0;
			valorInstrucaoCobranca2 = 0;
			valorInstrucaoCobranca3 = 0;
			percentualDesconto = 0.0;
			percentualJurosDiaAtraso = 0.0;
			percentualMultaAtraso = 0.0;
			percentualOutrosAcrescimos = 0.0;
			quantidadeMoeda = 0.0;
			valorAbatimento = 0.0;
			valorDesconto = 0.0;
			valorDocumento = 0.0;
			valorJurosDiasAtraso = 0.0;
			valorMultaAtraso = 0.0;
			valorOutrosAcrescimos = 0.0;
			dataDocumento = null;
			dataLimiteDesconto = null;
			dataProcessamento = null;
			dataVencimento = null;
			modalidadeCobranca = modalidadePadrao;
			instrucoesCobranca = new ArrayList();
			parametrosAdicionais = new ArrayList();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ParametroConfiguracao NovoParametroAdicional(ParametroConfiguracao pc)
	{
		Logger.Info("Criando parâmetro de configuração adicional para documento de cobrança...");
		if (parametrosAdicionais == null)
		{
			parametrosAdicionais = new ArrayList();
		}
		parametrosAdicionais.Add(pc);
		return pc;
	}

	public ParametroConfiguracao NovoParametroAdicional()
	{
		Logger.Info("Criando parâmetro de configuração adicional...");
		if (parametrosAdicionais == null)
		{
			parametrosAdicionais = new ArrayList();
		}
		ParametroConfiguracao parametroConfiguracao = new ParametroConfiguracao();
		parametrosAdicionais.Add(parametroConfiguracao);
		return parametroConfiguracao;
	}

	public void LimparParametrosAdicionais()
	{
		parametrosAdicionais = new ArrayList();
	}

	public InstrucaoCobranca NovaInstrucaoCobranca()
	{
		Logger.Info("Criando nova instrução de cobrança...");
		if (instrucoesCobranca == null)
		{
			instrucoesCobranca = new ArrayList();
		}
		InstrucaoCobranca instrucaoCobranca = new InstrucaoCobranca();
		instrucoesCobranca.Add(instrucaoCobranca);
		return instrucaoCobranca;
	}

	public void LimparInstrucoesCobranca()
	{
		instrucoesCobranca = new ArrayList();
	}
}
