using System;
namespace Lista02Exercicio06
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Entre com um valor de 0 a 100");
                double valor = double.Parse(Console.ReadLine());
            if (valor >= 0 & valor <= 25)
            {
                Console.WriteLine("INTERVALO [0, 25]");
            } else if(valor >= 25.00001 & valor <= 50)
            {
                Console.WriteLine("INTERVALO [25, 50]");
            }else if(valor >= 50.00001 & valor <= 75)
            {
                Console.WriteLine("INTERVALO [50, 75]");
            }else if(valor >= 75.00001 & valor <= 100)
            {
                Console.WriteLine("INTERVALO [75, 100]");
            }else
            {
                Console.WriteLine("VALOR INEXISTENTE");
            }


        }
    }
}
