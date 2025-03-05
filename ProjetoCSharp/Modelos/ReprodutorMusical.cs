namespace ProjetoCSharp.Modelos;
internal class ReprodutorMusical
{
    public int Volume { get; private set; } = 50; 
    public bool EstaReproduzindo { get; private set; }
    public Musica Nome { get; private set; }

    public void Reproduzir(Musica musica)
    {
        Nome = musica;
        EstaReproduzindo = true;
        Console.WriteLine($"Reproduzindo: {musica.Nome} - {musica.Artista.Nome}");
    }

    public void Pausar()
    {
        EstaReproduzindo = false;
        Console.WriteLine("Reprodução pausada.");
    }

    public void Avancar()
    {
        Console.WriteLine("Avançando para a próxima música.");
    }

    public void Retroceder()
    {
        Console.WriteLine("Voltando para a música anterior.");
    }

    public void AjustarVolume(int novoVolume)
    {
        if (novoVolume < 0 || novoVolume > 100)
        {
            Console.WriteLine("Volume deve estar entre 0 e 100.");
            return;
        }

        Volume = novoVolume;
        Console.WriteLine($"Volume ajustado para {Volume}.");
    }
}
