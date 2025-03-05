namespace ProjetoCSharp.Modelos;
internal class LetraMusica
{
    public string Conteudo { get; set; }

    public LetraMusica(string conteudo)
    {
        Conteudo = conteudo;
    }

    public void ExibirLetra() => Console.WriteLine(Conteudo);

    public bool BuscarTrecho(string trecho) => Conteudo.Contains(trecho, StringComparison.OrdinalIgnoreCase);
}
