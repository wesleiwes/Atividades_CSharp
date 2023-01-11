using System;

    namespace Lista03Exercicio02
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a cordenada X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Entre com a cordenada Y: ");
            int Y = int.Parse(Console.ReadLine());

            while(X != 0 ||Y != 0)
            {
                if (X < 0 & Y > 0)
                {
                    Console.WriteLine("PRIMEIRO QUADRANTE");
                    Console.Write("Entre com a cordenada X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Entre com a cordenada Y: ");
                    Y = int.Parse(Console.ReadLine());
                }
                else if (X > 0 & Y > 0)
                {
                    Console.WriteLine("SEGUNDO QUADRANTE");
                    Console.Write("Entre com a cordenada X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Entre com a cordenada Y: ");
                    Y = int.Parse(Console.ReadLine());
                }
                else if (X < 0 & Y < 0)
                {
                    Console.WriteLine("TERCEIRO QUADRANTE");
                    Console.Write("Entre com a cordenada X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Entre com a cordenada Y: ");
                    Y = int.Parse(Console.ReadLine());
                }
                else if (X > 0 & Y < 0)
                {
                    Console.WriteLine("QUARTO QUADRANTE");
                    Console.Write("Entre com a cordenada X: ");
                    X = int.Parse(Console.ReadLine());
                    Console.Write("Entre com a cordenada Y: ");
                    Y = int.Parse(Console.ReadLine());
                }
                
            }
          




        }
    }
    }
