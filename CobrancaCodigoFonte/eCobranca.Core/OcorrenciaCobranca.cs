using System;
using System.Collections;
using System.Diagnostics;
using eCobranca.Core.Excecao;

namespace eCobranca.Core;

public class OcorrenciaCobranca
{
	private int numeroSequencialRetorno;

	private string codigoMovimentoRetorno;

	private string descricaoMovimentoRetorno;

	private string codigoBanco;

	private string codigoAgencia;

	private string numeroContaCorrente;

	private string nossoNumero;

	private string numeroDocumento;

	private string identificacaoTituloNoCedente;

	private string numeroInscricaoSacado;

	private string nomeSacado;

	private string codigoOcorrenciaSacado;

	private string complementoOcorrenciaSacado;

	private DateTime? dataVencimento;

	private DateTime? dataOcorrenciaSacado;

	private DateTime? dataCredito;

	private DateTime? dataOcorrencia;

	private double valorNominal;

	private double valorAcrescimos;

	private double valorDesconto;

	private double valorAbatimento;

	private double valorIOF;

	private double valorOutrasDespesas;

	private double valorOutrosCreditos;

	private double valorPago;

	private double valorLiquido;

	private double valorOcorrenciaSacado;

	private double valorTarifa;

	private double valorJuros;

	private double valorMulta;

	private bool ocorreuPagamento;

	private bool ocorrenciaRegistradaBancoSicredi;

	private ArrayList motivosOcorrencia;

	public int NumeroSequencialRetorno
	{
		get
		{
			return numeroSequencialRetorno;
		}
		set
		{
			numeroSequencialRetorno = value;
		}
	}

	public string CodigoMovimentoRetorno
	{
		get
		{
			return codigoMovimentoRetorno;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				codigoMovimentoRetorno = value;
			}
		}
	}

	public string DescricaoMovimentoRetorno
	{
		get
		{
			return descricaoMovimentoRetorno;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				descricaoMovimentoRetorno = value;
			}
		}
	}

	public string CodigoBanco
	{
		get
		{
			return codigoBanco;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				codigoBanco = value;
			}
		}
	}

	public string CodigoAgencia
	{
		get
		{
			return codigoAgencia;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				codigoAgencia = value;
			}
		}
	}

	public string NumeroContaCorrente
	{
		get
		{
			return numeroContaCorrente;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				numeroContaCorrente = value;
			}
		}
	}

	public string Nossonumero
	{
		get
		{
			return nossoNumero;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				nossoNumero = value;
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
			if (!string.IsNullOrEmpty(value))
			{
				numeroDocumento = value;
			}
		}
	}

	public string IdentificacaoTituloNoCedente
	{
		get
		{
			return identificacaoTituloNoCedente;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				identificacaoTituloNoCedente = value;
			}
		}
	}

	public string NumeroInscricaoSacado
	{
		get
		{
			return numeroInscricaoSacado;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				numeroInscricaoSacado = value;
			}
		}
	}

	public string NomeSacado
	{
		get
		{
			return nomeSacado;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				nomeSacado = value;
			}
		}
	}

	public string ComplementoOcorrenciaSacado
	{
		get
		{
			return complementoOcorrenciaSacado;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				complementoOcorrenciaSacado = value;
			}
		}
	}

	public string CodigoOcorrenciaSacado
	{
		get
		{
			return codigoOcorrenciaSacado;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				codigoOcorrenciaSacado = value;
			}
		}
	}

	public DateTime? DataOcorrencia
	{
		get
		{
			return dataOcorrencia;
		}
		set
		{
			dataOcorrencia = value;
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
			dataVencimento = value;
		}
	}

	public DateTime? DataOcorrenciaSacado
	{
		get
		{
			return dataOcorrenciaSacado;
		}
		set
		{
			dataOcorrenciaSacado = value;
		}
	}

	public DateTime? DataCredito
	{
		get
		{
			return dataCredito;
		}
		set
		{
			dataCredito = value;
		}
	}

	public double ValorNominal
	{
		get
		{
			return valorNominal;
		}
		set
		{
			valorNominal = value;
		}
	}

	public double ValorAcrescimos
	{
		get
		{
			return valorAcrescimos;
		}
		set
		{
			valorAcrescimos = value;
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
			valorDesconto = value;
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
			valorAbatimento = value;
		}
	}

	public double ValorIOF
	{
		get
		{
			return valorIOF;
		}
		set
		{
			valorIOF = value;
		}
	}

	public double ValorOutrasDespesas
	{
		get
		{
			return valorOutrasDespesas;
		}
		set
		{
			valorOutrasDespesas = value;
		}
	}

	public double ValorOutrosCreditos
	{
		get
		{
			return valorOutrosCreditos;
		}
		set
		{
			valorOutrosCreditos = value;
		}
	}

	public double ValorPago
	{
		get
		{
			return valorPago;
		}
		set
		{
			valorPago = value;
		}
	}

	public double ValorLiquido
	{
		get
		{
			return valorLiquido;
		}
		set
		{
			valorLiquido = value;
		}
	}

	public double ValorOcorrenciaSacado
	{
		get
		{
			return valorOcorrenciaSacado;
		}
		set
		{
			valorOcorrenciaSacado = value;
		}
	}

	public double ValorTarifa
	{
		get
		{
			return valorTarifa;
		}
		set
		{
			valorTarifa = value;
		}
	}

	public double ValorJuros
	{
		get
		{
			return valorJuros;
		}
		set
		{
			valorJuros = value;
		}
	}

	public double ValorMulta
	{
		get
		{
			return valorMulta;
		}
		set
		{
			valorMulta = value;
		}
	}

	public ArrayList MotivosOcorrencia
	{
		get
		{
			return motivosOcorrencia;
		}
		set
		{
			motivosOcorrencia = value;
		}
	}

	public bool OcorreuPagamento
	{
		get
		{
			return ocorreuPagamento;
		}
		set
		{
			ocorreuPagamento = value;
		}
	}

	public bool OcorrenciaRegistradaBancoSicredi
	{
		get
		{
			return ocorrenciaRegistradaBancoSicredi;
		}
		set
		{
			ocorrenciaRegistradaBancoSicredi = value;
		}
	}

	public OcorrenciaCobranca()
	{
		try
		{
			numeroSequencialRetorno = 0;
			codigoMovimentoRetorno = "";
			descricaoMovimentoRetorno = "";
			codigoBanco = "";
			codigoAgencia = "";
			numeroContaCorrente = "";
			nossoNumero = "";
			numeroDocumento = "";
			identificacaoTituloNoCedente = "";
			numeroInscricaoSacado = "";
			nomeSacado = "";
			codigoOcorrenciaSacado = "";
			complementoOcorrenciaSacado = "";
			dataVencimento = null;
			dataOcorrenciaSacado = null;
			dataCredito = null;
			dataOcorrencia = null;
			valorNominal = 0.0;
			valorAcrescimos = 0.0;
			valorDesconto = 0.0;
			valorAbatimento = 0.0;
			valorIOF = 0.0;
			valorOutrasDespesas = 0.0;
			valorOutrosCreditos = 0.0;
			valorPago = 0.0;
			valorLiquido = 0.0;
			valorOcorrenciaSacado = 0.0;
			valorTarifa = 0.0;
			valorJuros = 0.0;
			valorMulta = 0.0;
			ocorreuPagamento = false;
			motivosOcorrencia = new ArrayList();
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

	public void AdicionarMotivoOcorrencia(string codigo, string descricao)
	{
		MotivoOcorrenciaCobranca value = new MotivoOcorrenciaCobranca(codigo, descricao);
		motivosOcorrencia.Add(value);
	}
}
