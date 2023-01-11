using System;
namespace ExerciciosExtra03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());  
            Console.Write("Quantos dolares prentende comprar: ");
            double quantia = double.Parse(Console.ReadLine());

            double conversor = ConversorDeMoeda.Conversao(cotacao, quantia);

            Console.Write("Valor a ser pago em reais = " + conversor.ToString("F2"));
        }
    }
}