using System;

namespace Lista02Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "1 - CACHORRO QUENTE: R$ 4.00 \n\r" +
                "2 - X SALADA: R$ 4.50\n\r" +
                "3 - X BACON: R$ 5.00\n\r" +
                "4 - TORRADA: R$ 2.00\n\r" +
                "5 - REFRIGERNTE: R$ 1.50 \n\r" +
                "Entre com número do pedido: " );
            double codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de pedidos");
            double quant = double.Parse(Console.ReadLine());
            double total = 0;
            if ( codigo == 1)
            {
               total = 4.0 * quant;
            }else if(codigo == 2)
            {
                total = 4.5 * quant;
            }else if(codigo == 3)
            {
                total = 5.0 * quant;
            }else if(codigo == 4)
            {
                total= 2.0 * quant;
            }else if(codigo == 5)
            {
                total = 1.50 * quant;
            }
            else
            {
                Console.WriteLine("CÓDIGO INEXISTENTE");
            }
            Console.WriteLine("total R$ {0}", total);


                
            
        }
    }
}
