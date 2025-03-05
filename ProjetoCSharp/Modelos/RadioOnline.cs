namespace ProjetoCSharp.Modelos;
internal class RadioOnline
{
    public void ReproduzirSequenciaAleatoria()
    {
        Console.WriteLine("Reproduzindo sequência aleatória de músicas...");
    }

    public void ReproduzirPorGenero(GeneroMusical genero)
    {
        Console.WriteLine($"Reproduzindo músicas do gênero {genero.Nome}...");
    }
}