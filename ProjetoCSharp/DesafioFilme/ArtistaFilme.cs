using ProjetoCSharp.DesafioFilme;
using System;
using System.Collections.Generic;

namespace ProjetoCSharp.Modelos
{
    public class ArtistaFilme
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesAtuados { get; set; }

        public ArtistaFilme(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<Filme>();
        }

        // Método para adicionar um filme ao artista
        public void AdicionarFilme(Filme filme)
        {
            if (!FilmesAtuados.Contains(filme))
            {
                FilmesAtuados.Add(filme);
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine("Filmes em que atuou: ");
            foreach (var filme in FilmesAtuados)
            {
                Console.WriteLine($"- {filme.TituloFilme}");
            }
        }
    }
}
