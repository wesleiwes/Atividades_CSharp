using System;
namespace ExercicioExtra02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            
            Console.WriteLine(p);

            Console.WriteLine("Digite a quantidade de produtos a serem adicionadas: ");
            int qnt = int.Parse(Console.ReadLine());
            p.AddProduto(qnt);

            Console.WriteLine("\r\n" + p);

            Console.WriteLine("Digite a quantidade de produtos a serem removidas: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoverProduto(qnt);

            Console.WriteLine("\r\n" + p);
        }

    }
}