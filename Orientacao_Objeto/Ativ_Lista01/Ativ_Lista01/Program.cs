using System;
using System.Collections.Generic;
namespace Ativ_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> list = new List<string>();

            Console.WriteLine("1. Telefonou para a vítima? ");
            list.Add(Console.ReadLine());

            Console.WriteLine("2. Esteve no local do crime? ");
            list.Add(Console.ReadLine());

            Console.WriteLine("3. Mora perto da vítima? ");
            list.Add(Console.ReadLine());

            Console.WriteLine("4. Devia para a vítima? ");
            list.Add(Console.ReadLine());

            Console.WriteLine("5. Já trabalhou com a vítima? ");
            list.Add(Console.ReadLine());

            Console.WriteLine();
            int resp = 0;

            foreach(string obj in list)
            {
                if(obj == "sim")
                {
                    resp++;    
                    
                }   
            }
            if (resp < 3 & resp > 1)
            {
                Console.WriteLine("Suspeito");
            }
            else if (resp > 2 & resp < 5)
            {
                Console.WriteLine("Cúmplice");
            }
            else if (resp > 4)
            {
                Console.WriteLine("Assassino");
            }
            else
            {
                Console.WriteLine("Inocente");
            }


        }          
    }
}