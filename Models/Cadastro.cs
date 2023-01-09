namespace MyScrapBook_Razor.Models;

public class Cadastro
{
    public string Nome {get; set;} = default!;
    public string Email {get; set;} = default!;
    public string? Telefone {get; set;}
    public DateOnly DataNascimento {get; set;}
    public string Senha {get; set;} = default!;
    public string ConfirmaSenha {get; set;} = default!;
}