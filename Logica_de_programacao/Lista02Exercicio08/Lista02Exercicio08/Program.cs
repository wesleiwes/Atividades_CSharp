using System;
using System.Data;
using System.Reflection.Metadata;

namespace Lista02Exercicio08
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ENTRE COM SALARIO EM R$: ");
			double salario = double.Parse(Console.ReadLine());
            double baseDoImposto1 = (salario - 2000.00) * 0.08;
			double baseDoimposto2 = (salario - 3000.00) * 0.18;
			double baseDoImposto3 = (salario - 4500.00) * 0.28;
			double valorDoImposto = 0;

            if (salario > 0 & salario < 2000.00)
			{
				Console.WriteLine("Isento de Imposto");

			}else if(salario > 2000.01 & salario < 3000.00)
			{
				valorDoImposto = baseDoImposto1;
				
			}else if(salario > 3000.01 & salario < 4500.00)
			{
				valorDoImposto = baseDoimposto2 + 80.00;
				
			}else if(salario > 4500.00)
			{
				valorDoImposto = baseDoImposto3 + 350.00;

			}
			else
			{
				Console.WriteLine("Sálario Inexistente");
			}

			Console.WriteLine("Valor a ser pago de imposto sobre o salário é: R$ {0}", valorDoImposto);

		}

	}

	}

