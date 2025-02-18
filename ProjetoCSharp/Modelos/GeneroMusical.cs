namespace ProjetoCSharp.Modelos;
class GeneroMusical
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public GeneroMusical(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public string DescricaoGenero => $"O genero {Nome} desta música é bom";
}

