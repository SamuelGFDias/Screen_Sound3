namespace Teste.Modelos.Filme;
class Filme
{
    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo =>
        $"Título: {Titulo} - Duracao: {Duracao} min";

    public List<Artista> Elenco { get; } = new();

    public void AdicionarArtista(Artista artista)
    {
        Elenco.Add(artista);
        artista.AdicionarFilme(this);
    }
}