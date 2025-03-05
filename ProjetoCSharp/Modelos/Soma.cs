namespace ProjetoCSharp.Modelos;
internal class Calculadora
{
    public int a;
    public int b;
    public int Somar(int a, int b)
    {
        return a + b;
    }
}
class Resultado
{
    private static int a;
    private static int b;

    void Calculadora ()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Somar(a, b);
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }
}