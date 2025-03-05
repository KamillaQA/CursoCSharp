using ProjetoCSharp.Modelos;

namespace ProjetoCSharp.Menus;

internal class MenuAvaliarBanda : Menu
{
    
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
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
    }
}

