namespace ProjetoCSharp.Modelos;
class EventoMusical
{
    public string Nome { get; set; }
    public string Local { get; set; }
    public DateTime Data { get; set; }
    public List<Artista> Artistas { get; set; }

    public EventoMusical(string nome, string local, DateTime data, List<Artista> artistas)
    {
        Nome = nome;
        Local = local;
        Data = data;
        Artistas = artistas;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Evento: {Nome}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine("Artistas participantes:");
        Artistas.ForEach(a => Console.WriteLine($"- {a.Nome}"));
    }
}
