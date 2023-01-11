using System;
using System.Transactions;

namespace Ativ_Vetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] v = new Produto[n];
            
            for(int i=0; i<n; i++)
            {
                Console.Write("Entre com o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Entre com o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                v[i] = new Produto(nome, preco);
            }
            double soma = 0;
            for(int i=0; i<n ; i++)
            {
                soma += v[i].Preco;
            }
            double media = soma / n;

            Console.WriteLine("A média dos produtos é: R$ " + media.ToString("F2"));
        }
    }
}