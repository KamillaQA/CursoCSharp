namespace ProjetoCSharp.Modelos;
class Compartilhamento
{
    public void CompartilharMusica(Musica musica, Usuario paraUsuario)
    {
        Console.WriteLine($"A música '{musica.Nome}' foi compartilhada com {paraUsuario.Nome}.");
    }

    public void CompartilharPlaylist(Playlist playlist, Usuario paraUsuario)
    {
        Console.WriteLine($"A playlist '{playlist.Nome}' foi compartilhada com {paraUsuario.Nome}.");
    }
}