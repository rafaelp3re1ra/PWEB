using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace GestaoLoja.Entities;
public class Categoria
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Mete nome nisso senão não deixo!")]
    public string? Nome { get; set; }
    public int? Ordem { get; set; }
    public string? UrlImagem { get; set; }
    public byte[]? Imagem { get; set; }

    [NotMapped] // Diz à entityCore para não mapear esta propriedade na base de dados
    public IFormFile? ImageFile { get; set; }
}
