using System;
using System.Transactions;

namespace ExerciciosExtra03
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6;

        public static double Conversao(double quantia, double cotacao)
        {
             return (quantia * cotacao * iof / 100) + (quantia * cotacao);
           
        }
    }
}
