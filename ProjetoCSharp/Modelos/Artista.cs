namespace ProjetoCSharp.Modelos;
internal class Artista
{
    public string Nome { get; }
    public string Biografia { get; }
    public List<Musica> Musicas { get; set; } = new List<Musica>();

    public Artista(string nome, string biografia)
    {
        Nome = nome;
        Biografia = biografia;
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}
