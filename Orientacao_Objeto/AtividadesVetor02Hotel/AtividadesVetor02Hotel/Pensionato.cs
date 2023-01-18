
namespace AtividadesVetor02Hotel
{
    internal class Pensionato
    {
        public string Nome { get; set; }
      
        public Pensionato(string nome)
        {
            Nome = nome;            
        }

        public override string ToString()
        {
            return Nome;
        }


    }
}
