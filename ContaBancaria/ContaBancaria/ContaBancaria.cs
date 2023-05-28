using System;
using System.Globalization;
namespace Banco
{
    class ContaBancaria
    {
        private double _saldo;
        public string Nome;
        public int NumeroConta;

        public ContaBancaria()
        {
            _saldo = 0;
        }

        public ContaBancaria(int numeroConta, string nome) : this()
        {
            if (nome != null && nome.Length > 2)
            {
                this.Nome = nome;
            }
            this.NumeroConta = numeroConta;
        }

        public void deposito(double valor)
        {
            _saldo += valor;
        }
        
        public void saque(double valor) 
        {
            _saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
