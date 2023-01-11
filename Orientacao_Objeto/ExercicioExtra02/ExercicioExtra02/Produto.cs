using System;


namespace ExercicioExtra02
{
    internal class Produto
    {
        private string Nome {get; set;}
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
              return Quantidade* Preco; 
                
        }

        public void AddProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do Produto: " + Nome + ", R$" + Preco + ", " + Quantidade + " unidades, " + "Total: " + ValorTotalEmEstoque();
                
        }

    }
}
