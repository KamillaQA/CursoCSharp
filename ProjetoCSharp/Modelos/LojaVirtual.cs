namespace ProjetoCSharp.Modelos;
class LojaVirtual
{
    public void ComprarMusica(Musica musica, Usuario usuario)
    {
        Console.WriteLine($"{usuario.Nome} comprou a música '{musica.Nome}'.");
    }

    public void ComprarAlbum(Album album, Usuario usuario)
    {
        Console.WriteLine($"{usuario.Nome} comprou o álbum '{album.Nome}'.");
    }
}