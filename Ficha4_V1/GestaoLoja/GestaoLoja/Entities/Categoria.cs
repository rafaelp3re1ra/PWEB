using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoLoja.Entities;
public class Categoria
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int? Ordem { get; set; }
    public string? UrlImagem { get; set; }
    public byte[]? Imagem { get; set; }

    [NotMapped] // Diz à entityCore para não mapear esta propriedade na base de dados
    public IFormFile? ImageFile { get; set; }
}
