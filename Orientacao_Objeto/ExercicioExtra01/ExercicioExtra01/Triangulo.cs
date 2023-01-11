using System;

namespace ExercicioExtra01
{
    internal class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public Triangulo()
        {
        }

       

        public double Area()
        {
            double p = (LadoA + LadoB + LadoC) / 2;
            double area  = p * (p - LadoA) * (p - LadoB) * (p - LadoC);
            return Math.Sqrt(area);
        }

    }
}
