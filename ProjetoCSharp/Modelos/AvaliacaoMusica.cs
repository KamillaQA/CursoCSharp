namespace ProjetoCSharp.Modelos;
class AvaliacaoMusica
{
    public Usuario Usuario { get; set; }
    public Musica Musica { get; set; }
    public int Pontuacao { get; set; } 
    public string Comentario { get; set; }

    public AvaliacaoMusica(Usuario usuario, Musica musica, int pontuacao, string comentario)
    {
        Usuario = usuario;
        Musica = musica;
        Pontuacao = pontuacao;
        Comentario = comentario;
    }
}
