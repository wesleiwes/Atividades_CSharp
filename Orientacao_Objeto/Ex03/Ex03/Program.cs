using System;
namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rec = new Retangulo();

            Console.Write("Entre com Altura do retangulo: ");
            rec.Altura = double.Parse(Console.ReadLine());
            Console.Write("Entre com Largura do retangulo: ");
            rec.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(rec);

        }
    }
}