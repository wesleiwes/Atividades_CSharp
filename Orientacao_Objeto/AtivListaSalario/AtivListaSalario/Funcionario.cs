using System;
using System.Collections.Generic;


namespace AtivListaSalario
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set;}

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementoSalario (double porcentagem)
        {
            Salario = Salario * porcentagem / 100 + Salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", R$" + Salario;
        }
    }
}
