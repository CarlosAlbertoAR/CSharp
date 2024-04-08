    
/* Restrições */

/* Não pode começar com dígito: use letra ou _ 

Errado              Correto
int 5 minutos;      int _5minutos

*/

/* Não usar acentos ou til 

Errado              Correto
int salário;        int salario;

*/

/* Não pode ter espaços em branco 

Errado                          Correto
int salario do funcionario;     int salarioDoFuncionario;

/* Convenções */

/* 

Camel Case: lastName (Parâmetros de métodos, variáveis dentro de métodos

Pascal Case: LastName (Namespaces, classe, properties e métodos)

Padrão underline_camel: _lastName (Atributos "internos" da classe)

*/

namespace Convensoes
{
    class ContaBancaria
    {
        public string? Titular { get; set; }
        private double _saldo;

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
    }
}
