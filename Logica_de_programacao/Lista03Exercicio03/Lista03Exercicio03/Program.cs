using System;
namespace Lista03Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código dos produtos: : 1 - Álcool \r\n 2 - Gasolina \n\r 3 - Diesel\r\n 4 - Fim");
            Console.WriteLine("Entre com o Código do produto");
            int cod = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (cod != 4)
            {
                if(cod == 1)
                {
                    alcool++;

                }else if(cod == 2)
                {
                    gasolina++;

                }else if(cod == 3)
                {
                    diesel++;

                }else if(cod == 4)
                {
                    
                }
                cod = int.Parse(Console.ReadLine());
             
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: {0}\r\n" +
                  "Gasolina: {1}\r\n" +
                  "Diesel: {2}", alcool, gasolina, diesel);


        }
    }
}