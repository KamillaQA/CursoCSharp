namespace ProjetoCSharp.Modelos;
internal class ContaBancaria
{
    public ContaBancaria(Titular titular, int agencia, int numeroDaConta, double saldo = 0, double limite = 0, string senha = "1234")
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
        Senha = senha;
    }

    public int Numero { get; set; }
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; private set; } // Saldo deve ser apenas leitura
    public double Limite { get; set; }
    public string Senha { get; set; }

    public void Conta()
    {
        Console.WriteLine($"Sua conta Bancaria é: {this.Numero}");
        Console.WriteLine($"O nome do titular é: {this.Titular.Nome}");
        Console.WriteLine($"Seu saldo Bancario é: {this.Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}
