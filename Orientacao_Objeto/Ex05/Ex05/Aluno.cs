using System;


namespace Ex05
{
    internal class Aluno
    {
        public String Nome;
        public double Nota01;
        public double Nota02;
        public double Nota03;

        public double NotaFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\r\nNota Final: " + NotaFinal();
        }

    }
}
