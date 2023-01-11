using System;
namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(f);

            Console.Write("Digite a porcentagem a ser aumentada: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);

            Console.WriteLine(f);


        }
    }
}