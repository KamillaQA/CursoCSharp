namespace ProjetoCSharp.Modelos;

internal class Banda
{
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public List<Musica> Musicas { get; set; } = new List<Musica>();

    // Adicionando uma propriedade Podcast
    public Podcast Podcast { get; set; }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    //public double Media => notas.Average(a => a.Nota);

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        if (!albums.Contains(album))
        {
            albums.Add(album);
        }
        else
        {
            Console.WriteLine($"O álbum '{album.Nome}' já foi adicionado à banda '{Nome}'.");
        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
