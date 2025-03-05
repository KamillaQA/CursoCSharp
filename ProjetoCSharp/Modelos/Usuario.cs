namespace ProjetoCSharp.Modelos;
internal class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; private set; }
    public List<Playlist> Playlists { get; set; } = new List<Playlist>();

    public Usuario(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;
    }

    public void CriarPlaylist(string nome)
    {
        Playlists.Add(new Playlist(nome, this));
        Console.WriteLine($"Playlist '{nome}' criada.");
    }
}
