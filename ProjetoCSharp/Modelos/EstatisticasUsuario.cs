namespace ProjetoCSharp.Modelos;
internal class EstatisticasUsuario
{
    public Musica ObterMusicaMaisReproduzida(Usuario usuario)
    {
        // Pega a primeira música da playlist
       return usuario.Playlists.SelectMany(p => p.Musicas).FirstOrDefault();
    }

    public Artista ObterArtistaFavorito(Usuario usuario)
    {
        return usuario.Playlists
                      .SelectMany(p => p.Musicas)
                      .Select(m => new Artista(m.Artista.Nome, "Biografia não disponível")) 
                      .FirstOrDefault();
    }


}