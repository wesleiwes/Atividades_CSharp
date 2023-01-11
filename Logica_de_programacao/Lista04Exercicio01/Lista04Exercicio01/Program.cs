using System;
namespace Lista04Exercicio01
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Entre com um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);''
                }
            }
        }
    }
}