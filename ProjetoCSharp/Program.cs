//using ProjetoCSharp.Modelos;

//ProjetoCSharp.Modelos.Banda ira = new ProjetoCSharp.Modelos.Banda("Ira");

Console.WriteLine("Bem-vindo ao Sistema Musical!");

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
podcast.ExibirDetalhes();

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
