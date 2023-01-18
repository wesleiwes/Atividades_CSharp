using System;
using System.Collections.Generic;

namespace AtivListaAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> list = new List<Contato>();


            Console.WriteLine("SEJA BEM VINDO! ESCOLHA A OPÇÃO ESEJADA! ");
            Console.WriteLine("1 - Adicionar Contato\r\n2 - Remover Contato\r\n3 - Mostrar Contatos\r\n0 - SAIR");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string nome, numero;
            
            while(opcao != 0)
            {
                if (opcao == 1)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Número: ");
                    numero = Console.ReadLine();
                    Console.WriteLine();
                    list.Add(new Contato(nome, numero));
                }
                else if (opcao == 2)
                {
                    Console.Write("Entre com a posição do contato: ");
                    int posicao = int.Parse(Console.ReadLine());
                    list.RemoveAt(posicao);
                    Console.WriteLine();

                }
                else if (opcao == 3)
                {
                    foreach(Contato obj in list)
                    {
                        Console.WriteLine(obj);
                        Console.WriteLine();
                    }

                }
                
                Console.WriteLine("MENU ");
                Console.WriteLine("1 - Adicionar Contato\r\n2 - Remover Contato\r\n3 - Mostrar Contatos\r\n0 - SAIR");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }

            Console.WriteLine("Agenda fechada");
            
            
            
        }
    }
}