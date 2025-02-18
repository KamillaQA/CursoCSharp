using ProjetoCSharp.Modelos;

class Podcast
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
    void ExibirDetalhes()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");

            // Se a banda tem um podcast associado, exibir detalhes do podcast
            if (banda.Podcast != null)
            {
                Console.WriteLine($"\nPodcast {banda.Podcast.Nome} apresentado por {banda.Podcast.Host} com duração de {banda.Podcast.Duracao} minutos.\n");

                foreach (Episodio episodio in banda.Podcast.episodios.OrderBy(e => e.Ordem))
                {
                    Console.WriteLine(episodio.Resumo);
                }

                Console.WriteLine($"\nTotal de episódios: {banda.Podcast.TotalEpisodios}.");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("\nBanda não encontrada!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

}


}
