using System;
namespace Lista04Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor inteiro: ");
            int N = int.Parse(Console.ReadLine());
            int valor = 0;
            int cont0 = 0;
            int cont1 = 0;

            for (int i = 1; i <= N; i++){
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 & valor <= 20)
                {
                    cont0++;
                }
                else
                {
                    cont1++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont0 + "in");
            Console.WriteLine(cont1 + "out");

        }
    }
}