namespace ProjetoCSharp.Modelos;
internal class DownloadManager
{
    public void IniciarDownload(Musica musica)
    {
        Console.WriteLine($"Iniciando download da música '{musica.Nome}'...");
    }

    public void IniciarDownload(Album album)
    {
        Console.WriteLine($"Iniciando download do álbum '{album.Nome}'...");
    }
}
