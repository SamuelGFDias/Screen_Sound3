﻿namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    public static int ContadorDeObjetos = 0;
    private List<Musica> musicas = new();
    private List<Avaliacao> notas = new();
    public Album(string nome) 
    {
        Nome = nome;
        ContadorDeObjetos++;
    } 
    public string Nome { get; }
    public int DuracaoTotal => 
        musicas.Sum(m => m.Duracao);
    public double Media
    {
        get
        {
            if (notas.Count == 0)
                return 0;
            return notas.Average(a => a.Nota);
        }
    }
    public IEnumerable<Musica> Musicas => musicas;
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}
