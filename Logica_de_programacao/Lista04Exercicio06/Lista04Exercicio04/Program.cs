using System;
namespace Lista04Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            for(int i=0; i<N; i++)
            {
                Console.WriteLine("Entre com 2 valores");
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());
                double R = n2/n1;
                if(R==0.0)
                {
                    Console.WriteLine("DIVISÃO IMPOSSIVEL ");
                }
                else
                {
                    Console.WriteLine("A DIVISÃO DO SEGUNDO VALOR PELO PRIMEIRO É: "R);
                }
            }
        }
    }
}