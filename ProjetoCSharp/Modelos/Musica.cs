namespace ProjetoCSharp.Modelos;
internal class Musica
{
    //definindo obrigatóriedade para o campo
    public Musica(string nome, Banda banda, GeneroMusical genero, TimeSpan duracao)
    {
        Nome = nome;
        Artista = banda;
        GeneroMusical = genero;
        Duracao = duracao;

    }
    //Tipos Primitivos
    public string Nome { get;}
    public Banda Artista { get;}
    //relacionamento entre classes 
    public GeneroMusical GeneroMusical { get; }
    public TimeSpan Duracao { get; set; }
    //Propriedade (começa com pascal case)
    public bool Disponivel { get; set; }    
    //Lambda
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    /*{
        get{
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }*/
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void ExibirDadosDoArtista()
    {
        Console.WriteLine($"Nome: {Nome} - {Artista}");
    }
}
    

