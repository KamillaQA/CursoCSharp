namespace ProjetoCSharp.Modelos;
class Playlist
{
    public string Nome { get; set; }
    public Usuario Usuario { get; set; }
    public List<Musica> Musicas { get; set; } = new List<Musica>();

    public Playlist(string nome, Usuario usuario)
    {
        Nome = nome;
        Usuario = usuario;
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
        Console.WriteLine($"Música '{musica.Nome}' adicionada à playlist '{Nome}'.");
    }
}
