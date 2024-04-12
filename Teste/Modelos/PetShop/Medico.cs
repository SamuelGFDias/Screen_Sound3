namespace PetShop.Modelos
{
    internal class Medico
    {
        public Medico(string nome, string especializacao)
        {
            Nome = nome;
            Especializacao = especializacao;
        }

        public string Nome { get; }
        public string Especializacao { get; set; }
    }
}
