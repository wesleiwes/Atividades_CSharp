using System;
using System.Net.Http.Headers;
using System.Transactions;

namespace Ex03
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double A = Largura * Altura;
            return A;
        }

        public double Perimetro()
        {
            double P = Largura*2+Altura*2;
            return P;
        }

        public double Diagonal()
        {
            double D = (Math.Pow(Largura,2) + Math.Pow(Altura,2));
            return Math.Sqrt(D);
        }

        public override string ToString(){
            return "Área: " + Area().ToString("F2")
                + ", Perimetro: " + Perimetro().ToString("F2")
                + ", Diagonal: " + Diagonal().ToString("F2");
        }

    }
}
