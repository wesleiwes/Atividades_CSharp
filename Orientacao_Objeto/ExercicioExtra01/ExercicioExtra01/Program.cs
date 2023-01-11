using System;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioExtra01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();

            Console.WriteLine("Entre com os lados do triângulo n1: ");
            t1.LadoA = double.Parse(Console.ReadLine());
            t1.LadoB = double.Parse(Console.ReadLine());
            t1.LadoC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os lados do triângulo n2: ");
            t2.LadoA = double.Parse(Console.ReadLine());
            t2.LadoB = double.Parse(Console.ReadLine());
            t2.LadoC = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Área de X = " + t1.Area()
                + "\r\nÁrea de Y = " + t2.Area());

            if(t1.Area() > t2.Area())
            {
                Console.WriteLine("Maior área: X");
            }else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}