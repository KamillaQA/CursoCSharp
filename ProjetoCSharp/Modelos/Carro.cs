using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ProjetoCSharp.Modelos;

class Carro
{
    private int ano;

    public string Fabricante {get; set; }
    public string Modelo {get; set; }
    // public int Ano {  get; set; }
    public int Ano
    {
        get => ano;
        set{
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; }
    public string DescricaoDetalhada => $"Informações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}";

    /* public void DescricaoDetalhada()
    {
        Console.WriteLine($"Informações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}");
    }*/

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }
    public void Frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }
    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}