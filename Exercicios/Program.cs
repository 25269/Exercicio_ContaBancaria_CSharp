using Exercicios;
using System;
using System.Globalization;

namespace MeuNamespace
{
    //Classe
    public class Exercicios
    {
        static void Main(string[] args)
        {
            string NoYes;
            ContaBancaria contaBancaria;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string nomeTitular = (Console.ReadLine());

            Console.Write("Haverá depósito inicial? (s/n): ");
            NoYes = Console.ReadLine();

            if (NoYes == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(nomeTitular, numeroConta, deposito);
            }
            else {
                contaBancaria = new ContaBancaria(nomeTitular, numeroConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine("");
            Console.Write("Digite um valor de depósito: ");
            contaBancaria.AumentaSaldo(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine("");
            Console.Write("Digite um valor de saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);
        }
    }
}