namespace ProjetoCSharp.Modelos;
internal class Album
{
    private List<Musica> musicas = new List<Musica>();
    //Gerar construtor
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public int DuracaoTotal => (int)musicas.Sum(m => m.Duracao.TotalSeconds);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}:\n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos.");
    }
}