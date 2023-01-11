using System;
namespace Lista04Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com número: ");
            int linha = int.Parse(Console.ReadLine());
            double cont = 1;
            Console.WriteLine();

            for (int i=1;i<=linha;i++)
            {
                
                double result1 = Math.Pow(cont,2);
                double result2 = Math.Pow(cont, 3);

                Console.WriteLine(cont + " " + result1 + " " + result2);
                cont++;
                Console.WriteLine();
                
                
            }
        }
       

    }
}