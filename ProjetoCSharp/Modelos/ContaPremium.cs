namespace ProjetoCSharp.Modelos;
internal class ContaPremium
{
    public Usuario Usuario { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public ContaPremium(Usuario usuario, DateTime dataInicio, DateTime dataFim)
    {
        Usuario = usuario;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    public bool VerificarValidade() => DateTime.Now <= DataFim;

    public void ExibirBeneficios()
    {
        Console.WriteLine("Benefícios da Conta Premium:");
        Console.WriteLine("- Reprodução ilimitada");
        Console.WriteLine("- Qualidade de áudio superior");
        Console.WriteLine("- Sem anúncios");
    }
}