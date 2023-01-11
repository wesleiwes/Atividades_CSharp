using System;
namespace Ex01_Classes
{
    class Program
    {
        static void Main(String[] args)
        {
            
            DadosPessoas dados1 = new DadosPessoas();
            DadosPessoas dados2 = new DadosPessoas();


            Console.WriteLine("Entre com os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            dados1.Nome = Console.ReadLine();
            Console.Write("idade: ");
            dados1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            dados2.Nome = Console.ReadLine();
            Console.Write("idade: ");
            dados2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nome: " + dados1.Nome + "\r\nIdade: " + dados1.Idade);
            Console.WriteLine();
            Console.WriteLine("Nome: " + dados2.Nome + "\r\nIdade: " + dados2.Idade);
            Console.WriteLine();

            if (dados1.Idade > dados2.Idade)
            {
                Console.WriteLine("A maior idade pertence à: " + dados1.Nome);
            }
            else
            {
                Console.WriteLine("A maior idade pertence à: " + dados2.Nome);
            }

        }
    }
}