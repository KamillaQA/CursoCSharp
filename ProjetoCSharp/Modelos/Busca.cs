namespace ProjetoCSharp.Modelos;
class Busca
{
    public List<Musica> PesquisarMusicas(string criterio, List<Musica> musicas)
    {
        return musicas.Where(m => m.Nome.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Artista> PesquisarArtistas(string criterio, List<Artista> artistas)
    {
        return artistas.Where(a => a.Nome.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Album> PesquisarAlbuns(string criterio, List<Album> albuns)
    {
        return albuns.Where(a => a.Nome.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Playlist> PesquisarPlaylists(string criterio, List<Playlist> playlists)
    {
        return playlists.Where(p => p.Nome.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}