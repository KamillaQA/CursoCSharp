using.Program.cs
namespace ProjetoCSharp.Modelos;
class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();
    public double Media => notas.Average();
    public List<Musica> Musicas { get; set; } = new List<Musica>();
    public Banda(string nome)
    {
        Nome = nome; 
    }
    public string Nome { get;}

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
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
    public void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
            }
            else
            {
                Console.WriteLine("\nEntrada inválida! Por favor, insira um número válido.");
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    void RegistrarAlbum()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        ExibirOpcoesDoMenu();
    }
}