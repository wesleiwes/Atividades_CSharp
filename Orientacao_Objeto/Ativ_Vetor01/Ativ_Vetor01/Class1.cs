﻿namespace Ativ_Vetor01
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set;}
      

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;           
        }            

        
    }
}
