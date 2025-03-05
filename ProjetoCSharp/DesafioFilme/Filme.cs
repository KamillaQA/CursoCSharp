using System;
using System.Collections.Generic;
using ProjetoCSharp.Modelos;

namespace ProjetoCSharp.DesafioFilme
{
    public class Filme  // Altere de 'internal' para 'public'
    {
        public string TituloFilme { get; set; }
        public int DuracaoFilme { get; set; }
        public List<ArtistaFilme> Elenco { get; set; }

        public Filme(string titulo, int duracao)
        {
            TituloFilme = titulo;
            DuracaoFilme = duracao;
            Elenco = new List<ArtistaFilme>();
        }

        // Método para adicionar um artista ao elenco
        public void AdicionarArtista(ArtistaFilme artista)
        {
            if (!Elenco.Contains(artista))
            {
                Elenco.Add(artista);
            }

            if (!artista.FilmesAtuados.Contains(this))
            {
                artista.AdicionarFilme(this);
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {TituloFilme}");
            Console.WriteLine($"Duração: {DuracaoFilme} minutos");
            Console.WriteLine("Elenco: ");
            foreach (var artista in Elenco)
            {
                Console.WriteLine($"- {artista.Nome}");
            }
        }
    }
}
