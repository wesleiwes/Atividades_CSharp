using System;

namespace AtivListaAgenda
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Numero { get; set; }

        public Contato(string nome)
        {
            Nome = nome;         
        }
        public Contato(string nome, string numero)
        {
            Nome = nome;
            Numero = numero;
        }
        public override string ToString()
        {
            return "Nome: " + Nome 
                + "\r\nNúmero: " + Numero;
        }
    }
}
