using System;
using System.Runtime.CompilerServices;

namespace ExerciciosExtra04
{
    internal class ContaBanco
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        private double Saldo { get; set; }

        public ContaBanco()
        {
        }

        public ContaBanco(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public ContaBanco(string nome, int numeroConta, double saldo)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
             Saldo += quantia;
        }

        public void Saque(double quantia)
        {
             Saldo -= quantia +5;
        }
        public override string ToString()
        {
            return "Conta: " + NumeroConta
                + ", Titular: " + Nome                
                + ", Saldo: " + Saldo.ToString("F2");
        }

    }
}
