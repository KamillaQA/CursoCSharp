namespace ProjetoCSharp.Modelos;
class Recomendacao
{
    public List<Musica> GerarRecomendacoes(Usuario usuario)
    {
        // Baseado nas músicas mais reproduzidas 
        return usuario.Playlists.SelectMany(p => p.Musicas).Take(5).ToList();
    }
}
