namespace Teste.Modelos.Filme;
class Artista
{
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> FilmesNoElenco { get; } = new(); 

    public void AdicionarFilme(Filme filme) => FilmesNoElenco.Add(filme); 

    public void MostrarFilmesEmQueAtuou()
    {
        Console.WriteLine($"Filmes em que {Nome}:");
        foreach (Filme filme  in FilmesNoElenco)
            Console.WriteLine(filme.Resumo);
        Console.WriteLine();
    }

}