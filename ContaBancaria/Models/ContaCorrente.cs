using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    public class ContaCorrente
    {

        public int NumeroConta { get; private set; }
        public decimal Saldo { get; private set; }

        private decimal saldo;

  
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void Creditar(decimal valor)
        {
            saldo += valor;
        }

        public decimal RetornaSaldo()
        {
            return saldo;
        }
        
        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}