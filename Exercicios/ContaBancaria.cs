using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios
{
    class ContaBancaria
    {
        public string NomeTitular { get; set; }

        public int NumeroConta { get; private set; }

        public double Saldo { get; private set; }

        private double TaxaSaque = 5.00;


        public ContaBancaria(string nomeTitular, int numeroConta, double saldo) : this(nomeTitular, numeroConta)
        {
            Saldo = saldo;
        }

        public ContaBancaria(string nomeTitular, int numeroConta)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
        }

        public void SetNomeTitular(string nomeTitular)
        {
            NomeTitular = nomeTitular;
        }

        public string GetNomeTitular()
        {
            return NomeTitular;
        }

        public int GetNumeroConta()
        {
            return NumeroConta;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void AumentaSaldo(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + TaxaSaque);
        }

        public override string ToString()
        {
            return "Conta: " + this.GetNumeroConta() + ", Titular: " + this.GetNomeTitular()
                + ", Saldo: $ " + this.GetSaldo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
