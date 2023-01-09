namespace MyScrapBook_Razor.Models;

public class Book
{
    public string? NomeAlbum {get; set;}
    public string? Legenda {get; set;}
    public string? Imagem {get; set;}
    public bool Like {get; set;} = default!;
    public DateOnly DataCriacao {get; set;}
    public string? Comentarios {get; set;} 
    
}