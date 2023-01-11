using System;
namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1= new Funcionario();
            Funcionario f2= new Funcionario();

            Console.WriteLine("Entre com os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine()); 

            Console.WriteLine();

            Console.WriteLine("Entre com os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("A média salarial e: R$" + media);
        }
    }
}