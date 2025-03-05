namespace ProjetoCSharp.Modelos;
internal class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}
