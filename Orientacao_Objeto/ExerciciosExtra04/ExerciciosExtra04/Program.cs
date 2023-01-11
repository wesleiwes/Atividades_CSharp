using System;
namespace ExerciciosExtra04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja fazer um deposito Inicial? ");
            string opcao = Console.ReadLine();
            double depositoInicial = 0;
            if (opcao.Equals("sim"))
            {
                Console.Write("Valor do depósito: ");
                depositoInicial = double.Parse(Console.ReadLine());                
            }
            else if(opcao.Equals("não"))
            {                

            }

            ContaBanco conta = new ContaBanco(nome, numeroConta, depositoInicial);
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor de saque: ");
            quantia= double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

        }
    }
}