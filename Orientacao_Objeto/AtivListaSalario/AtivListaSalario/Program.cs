using System;
using System.Collections.Generic;

namespace AtivListaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com Número de funcionários: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com Id do funcionário que terá o salário incrementado: ");
            int localizandoID = int.Parse(Console.ReadLine());

            Funcionario fun = list.Find(x => x.Id == localizandoID);
            if (fun != null)
            {
                Console.Write("Entre com a porcentagem do incremento salarial: ");
                double porcentagem = double.Parse(Console.ReadLine());
                fun.IncrementoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }
            Console.WriteLine();

            Console.WriteLine("Lista de Funcionários: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }

}