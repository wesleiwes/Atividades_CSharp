using System;
namespace AtividadesVetor02Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Pensionato[] v = new Pensionato[10];
            int soma = 1;

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Aluguel #" + soma + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();               
                Console.Write("Número: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                soma++;

                v[quarto] = new Pensionato (nome); 
            }
            
            {
                Console.WriteLine();
                Console.WriteLine("Quartos ocupados: ");
                for(int i=0;i<10; i++)
                {
                    if (v[i] != null)
                    {
                        Console.WriteLine(i + ": " + v[i].Nome);
                    }
                }
               
            }
        }

        
    }
}