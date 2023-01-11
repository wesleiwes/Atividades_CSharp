using System;
namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Entre com as notas (N1, N2 e N3): ");
            a.Nota01 = double.Parse(Console.ReadLine());
            a.Nota02 = double.Parse(Console.ReadLine());
            a.Nota03= double.Parse(Console.ReadLine());

            Console.WriteLine(a);

            if(a.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double NotaFaltante = 60 - a.NotaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + NotaFaltante);
            }

        }
    }
}