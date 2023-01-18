using System;

namespace AtivMatriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com numero da ordem da matriz: ");
            int N = int.Parse(Console.ReadLine());

            int[,] m = new int[N, N];

            Console.WriteLine("Entre com os números da matriz");

            for (int i = 0; i < N; i++)
            {
                for(int j =0; j < N; j++)
                {                    
                    m[i, j] = int.Parse(Console.ReadLine());    
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS NEGATIVOS: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (m[i,j] < 0)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                }

            }
        }
    }
}