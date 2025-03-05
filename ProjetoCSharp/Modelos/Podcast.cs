using ProjetoCSharp.Modelos;

internal class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public TimeSpan Duracao { get; set; }
    public int TotalEpisodios => episodios.Count;

    public Podcast(string nome, string host, TimeSpan duracao)
    {
        Nome = nome;
        Host = host;
        Duracao = duracao;
    }

    public void AdicionarEpisodio(Episodio episodio) // Renomeado para evitar conflito
    {
        episodios.Add(episodio); // Agora acessa corretamente a lista privada
    }
}
