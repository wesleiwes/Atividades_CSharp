using System;
using System.Reflection.Metadata;

namespace Lista03Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com a senha de 4 digitos: ");
                int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Acesso Negado! Tente Novamente.");
                Console.WriteLine("Entre com a senha de 4 digitos: ");
               senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
       
}
