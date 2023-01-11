using System;
namespace Lista04Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um múmero inteiro: ");
            int N = int.Parse(Console.ReadLine());
            
            double media = 0;

            for(int i=1; i<=N; i++)               
            {             
                double v1 = double.Parse(Console.ReadLine());
                double v2 = double.Parse(Console.ReadLine());
                double v3 = double.Parse(Console.ReadLine());
                media = ((v1*2 + v2*3 + v3*5)/10);
                Console.WriteLine("A média é: " + media);
            }
            

        }
        
    }
}