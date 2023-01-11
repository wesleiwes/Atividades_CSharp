using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ex04
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double Liquido = SalarioBruto - Imposto;
            return Liquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            
            SalarioBruto = (SalarioBruto * porcentagem/100) + SalarioBruto;
            
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + ", Salário Liquido: " + SalarioLiquido();


        }

    }
}
