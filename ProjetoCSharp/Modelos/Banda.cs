namespace ProjetoCSharp.Modelos;

class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();
    public double Media => notas.Average();
    public List<Musica> Musicas { get; set; } = new List<Musica>();

    // Adicionando uma propriedade Podcast
    public Podcast Podcast { get; set; }

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

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
    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
    public void AdicionarNota(int novaNota)
    {
        notas.Add(novaNota);
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
