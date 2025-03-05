using ProjetoCSharp.DesafioFilme;
using ProjetoCSharp.Menus;
using ProjetoCSharp.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Bem-vindo ao Sistema Musical!");

        Banda ira = new Banda("Ira!");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(8));
        Banda beatles = new("The Beatles");

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);
        void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        void ExibirOpcoesDoMenu()
        {

            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2  para registrar todos os albuns");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 detalhes da banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            String opcaoEscolhida = Console.ReadLine()!;// o sinal ! é para que não seja aceito valor nulo
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                //case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    RegistrarAlbum();
                    break;
                case 3:
                    MostraBandasRegistradas();
                    break;
                case 4:
                    MenuAvaliarBanda menu4 = new();
                    menu4.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();   
                    break;
                case 5:
                    MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
                    menu5.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case -1:
                    Console.WriteLine("Tchau, Tchau");
                    break;
                default:
                    Console.WriteLine("Opção Invalída");
                    break;
            }
            /*if (opcaoEscolhidaNumerica == 1){
                Console.Write("\nVocêdigitou a opção: "+ opcaoEscolhida);
            } else if (opcaoEscolhidaNumerica == 2){
                Console.Write("\nVocêdigitou a opção: "+ opcaoEscolhida);
            }*/
        }

        void RegistrarBanda()
        {
            Console.Clear();
            Console.Write("Registro das bandas\n");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        /*void AvaliarUmaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar Banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                string entradaNota = Console.ReadLine()!;

                // Validando a entrada da nota com TryParse
                if (int.TryParse(entradaNota, out int nota))
                {
                    banda.AdicionarNota(new Avaliacao(nota));
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida! Por favor, insira um número válido.");
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }*/
        void ExibirMediaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir Média de Banda");
            Console.Write("Digite o nome da Banda: ");
            string nomeDaBanda = Console.ReadLine()!;

            // Verificando se a banda existe no dicionário
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                if (banda.Musicas.Count > 0) // Se a banda tiver músicas registradas
                {
                    double media = banda.Media;
                    Console.WriteLine($"A média de {nomeDaBanda} é {media:F2}.");
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} ainda não possui músicas registradas.");
                }
            }
            else
            {
                Console.WriteLine("Banda não encontrada.");
            }
            ExibirOpcoesDoMenu();
        }
        void RegistrarAlbum()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarNota(nota);
                banda.AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            }

            ExibirOpcoesDoMenu();
        }
        void MostraBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
            /* for (int i = 0; i < listaDasBandas.Count; i++){
                 Console.WriteLine($"Banda: {listaDasBandas[i]}");
             }*/
            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        ExibirOpcoesDoMenu();


        /*
        // **Criando gêneros 
        GeneroMusical Gospel = new GeneroMusical("Cristão", "Gênero caracterizado por festa.");
        GeneroMusical rock = new GeneroMusical("Rock", "Gênero caracterizado por guitarras e bateria.");

        // Criando artistas
        Artista Artista1 = new Artista("Coldplay", "Banda britânica de rock alternativo.");
        Artista Artista2 = new Artista("Kaue", "Banda Cristã atual.");

        // **Criando Banda e Álbum**
        Banda Ekklesia = new Banda("Ekklesia");
        Album albumEkk = new Album("In the Night");

        // Criando músicas após desafio com mais classes
        Musica musica1 = new Musica("Hey Jude", Ekklesia, Gospel, TimeSpan.FromMinutes(7));
        Musica musica2 = new Musica("Let It Be", Ekklesia, Gospel, TimeSpan.FromMinutes(4));

        // Adicionando músicas ao artista
        Artista2.AdicionarMusica(musica1);
        Artista2.AdicionarMusica(musica2);

        // Adicionando músicas a banda
        Ekklesia.AdicionarMusica(musica1);
        Ekklesia.AdicionarMusica(musica2);

        // Adicionando álbum à banda
        albumEkk.AdicionarMusica(musica1);
        albumEkk.AdicionarMusica(musica2);

        //Adcionando músicas ao album 
        Ekklesia.AdicionarAlbum(albumEkk);

        // Criando usuário e playlist
        Usuario usuario = new Usuario("Kamilla", "kams@example.com", "senha123");
        usuario.CriarPlaylist("Favoritas");

        // Adicionando músicas à playlist
        usuario.Playlists[0].AdicionarMusica(musica1);
        usuario.Playlists[0].AdicionarMusica(musica2);

        // Reproduzindo músicas
        ReprodutorMusical reprodutor = new ReprodutorMusical();
        reprodutor.Reproduzir(musica1);
        reprodutor.AjustarVolume(80);

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();
        albumEkk.ExibirMusicasDoAlbum();
        Ekklesia.ExibirDiscografia();

        // Realizando Busca
        Busca busca = new Busca();
        List<Musica> resultadosMusica = busca.PesquisarMusicas("Fix", usuario.Playlists[0].Musicas);
        Console.WriteLine("\nResultado da Busca por Músicas:");
        resultadosMusica.ForEach(m => Console.WriteLine($"- {m.Nome}"));

        // Recomendação
        Recomendacao recomendacao = new Recomendacao();
        List<Musica> recomendadas = recomendacao.GerarRecomendacoes(usuario);
        Console.WriteLine("\nRecomendações de Músicas:");
        recomendadas.ForEach(m => Console.WriteLine($"- {m.Nome}"));

        // Letras de músicas
        LetraMusica letra = new LetraMusica("When you try your best but you don't succeed...");
        Console.WriteLine("\nLetra da Música:");
        letra.ExibirLetra();

        // Exemplo de estatísticas do usuário
        EstatisticasUsuario estatisticas = new EstatisticasUsuario();
        Musica maisReproduzida = estatisticas.ObterMusicaMaisReproduzida(usuario);
        Console.WriteLine("\nMúsica Mais Reproduzida:");
        Console.WriteLine(maisReproduzida?.Nome ?? "Nenhuma música encontrada");

        // Exemplo de notificações
        Notificacao notificacao = new Notificacao("Novo álbum disponível: 30 - Adele");
        notificacao.EnviarNotificacao(usuario);

        // Exemplo de compartilhamento
        Compartilhamento compartilhamento = new Compartilhamento();
        compartilhamento.CompartilharMusica(musica1, usuario);

        // Exemplo de loja virtual
        LojaVirtual loja = new LojaVirtual();
        loja.ComprarMusica(musica1, usuario);

        Episodio ep1 = new(2, "Técnicas de facilitação", 45);
        ep1.AdicionarConvidados("Maria");
        ep1.AdicionarConvidados("Marcelo");
        Console.WriteLine(ep1.Resumo);

        Episodio ep2 = new(1, "Técnicas de aprendizado", 68);
        ep2.AdicionarConvidados("Marta");
        ep2.AdicionarConvidados("Kaue");
        ep2.AdicionarConvidados("Flavia");
        Console.WriteLine(ep2.Resumo);

        // Podcast
        Podcast podcast = new("Especial", "Daniel", TimeSpan.FromMinutes(12));
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        ExibirDetalhes();

        // Exemplo de download manager
        DownloadManager downloadManager = new DownloadManager();
        downloadManager.IniciarDownload(musica1);

        // Exemplo de evento musical
        List<Artista> artistasEvento = new List<Artista> { Artista1, Artista2 };
        EventoMusical evento = new EventoMusical("Rock Fest", "Estádio Nacional", DateTime.Now.AddDays(15), artistasEvento);
        Console.WriteLine("\nDetalhes do Evento Musical:");
        evento.ExibirDetalhes();

        // Exemplo de rádio online
        RadioOnline radio = new RadioOnline();
        radio.ReproduzirSequenciaAleatoria();

        // Exemplo de conta premium
        ContaPremium contaPremium = new ContaPremium(usuario, DateTime.Now, DateTime.Now.AddMonths(1));
        Console.WriteLine("\nConta Premium:");
        contaPremium.ExibirBeneficios();
        Console.WriteLine($"Conta válida? {contaPremium.VerificarValidade()}");

        Console.WriteLine("\nSistema Musical encerrado.");
        // Criando músicas antes do desafio de classes
        /*Musica musica1 = new Musica(ekk, "Love of my life")
        {
            Duracao = 213,
            Disponivel = true,
        };

        Musica musica2 = new Musica(ekk, "Love for my heart")
        {
            Duracao = 354,
            Disponivel = false,
        };*/

        // **Desafio Titular**
        /*Titular titular1 = new Titular("João Silva", "123.456.789-00", "Rua das Flores, 123");*/

        // Exibindo informações do titular
        /*Console.WriteLine("\nInformações do Titular:");
        Console.WriteLine($"Nome: {titular1.Nome}");
        Console.WriteLine($"CPF: {titular1.Cpf}");
        Console.WriteLine($"Endereço: {titular1.Endereco}\n");*/

        // **Desafio ContaBancária com Titular**
        /*Titular titular2 = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
        ContaBancaria c = new ContaBancaria(titular2, 1, 2234, 100000);

        Console.WriteLine("\nInformações da Conta Bancária:");
        Console.WriteLine(c.Informacoes);*/

        /* Código comentado e de testes */

        // **Testes com Músicas**
        /*
        Musica musica3 = new Musica();
        musica3.Nome = "Roxane";
        musica3.Artista = "The Police";
        musica3.Duracao = 273;
        musica3.Disponivel = true;

        Console.WriteLine(musica3.DescricaoResumida);
        musica3.ExibirFichaTecnica();
        */

        // **Testes com Calculadora**
        /*
        Calculadora valor1 = new Calculadora();
        valor1.a = 2;

        Calculadora valor2 = new Calculadora();
        valor2.b = 3;
        */

        // **Testes com Carro**
        /*
        Carro carro1 = new Carro();
        carro1.Fabricante = "Mauricio";
        carro1.Modelo = "sei lá";
        carro1.Ano = 2016;
        carro1.Velocidade = 50;
        carro1.QuantidadePortas = 4;

        Console.WriteLine(carro1.DescricaoDetalhada);
        */

        // **Desafio Conta Bancária com Valores**
        /*
        ContaBancaria contaBancaria = new ContaBancaria();
        contaBancaria.Numero = 2701;
        contaBancaria.Titular = t;
        contaBancaria.Saldo = 259;
        contaBancaria.Senha = "acesso";

        Console.WriteLine($"O nome do titular é: {contaBancaria.titular}");
        Console.WriteLine($"Seu saldo Bancário é: {contaBancaria.saldo}");
        */
    }


}
/*
// Instanciando 5 filmes favoritos
var filme1 = new Filme("O Poderoso Chefão", 175);
var filme2 = new Filme("Matrix", 136);
var filme3 = new Filme("Inception", 148);
var filme4 = new Filme("O Senhor dos Anéis: A Sociedade do Anel", 178);
var filme5 = new Filme("Gladiador", 155);

// Criando artistas
var artista1 = new ArtistaFilme("Marlon Brando", 80);
var artista2 = new ArtistaFilme("Keanu Reeves", 60);
var artista3 = new ArtistaFilme("Leonardo DiCaprio", 50);
var artista4 = new ArtistaFilme("Elijah Wood", 43);
var artista5 = new ArtistaFilme("Russell Crowe", 60);

// Adicionando filmes aos artistas
artista1.AdicionarFilme(filme1);
artista2.AdicionarFilme(filme2);
artista3.AdicionarFilme(filme3);
artista4.AdicionarFilme(filme4);
artista5.AdicionarFilme(filme5);

// Adicionando artistas ao elenco dos filmes
filme1.AdicionarArtista(artista1);
filme2.AdicionarArtista(artista2);
filme3.AdicionarArtista(artista3);
filme4.AdicionarArtista(artista4);
filme5.AdicionarArtista(artista5);

// Adicionando os filmes à lista
var filmesFavoritos = new List<Filme> { filme1, filme2, filme3, filme4, filme5 };

// Exibindo as informações dos filmes no console
foreach (var filme in filmesFavoritos)
{
    filme.ExibirInformacoes();
    Console.WriteLine();  // Linha em branco entre filmes
}

// Exibindo as informações dos artistas
foreach (var artista in new List<ArtistaFilme> { artista1, artista2, artista3, artista4, artista5 })
{
    artista.ExibirInformacoes();
    Console.WriteLine();  // Linha em branco entre artistas
}*/