namespace ProjetoCSharp.Modelos;
class Notificacao
{
    public string Mensagem { get; set; }
    public DateTime DataEnvio { get; set; }

    public Notificacao(string mensagem)
    {
        Mensagem = mensagem;
        DataEnvio = DateTime.Now;
    }

    public void EnviarNotificacao(Usuario usuario)
    {
        Console.WriteLine($"Notificação para {usuario.Nome}: {Mensagem} (enviado em {DataEnvio})");
    }
}