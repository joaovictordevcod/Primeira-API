namespace ApiTeste.Cliente
{
    public class Client
    {
     public string Nome { get; set; }
     public string Telefone { get; set; }
     public string Email { get; set; }
    }

    public class ClientePF : Client  
    {
     public int CPF { get; set; }
    }

    public class ClientePJ : Client
    {
     public int CNPJ { get; set; }
    }
}
