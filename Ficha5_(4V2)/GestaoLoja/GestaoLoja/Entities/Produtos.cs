using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GestaoLoja.Entities;
public class Produtos
{
    public int Id { get; set; } // Com "Id" a base de dados sabe que isto é a chave principal. É uma convenção (está na ficha)
    [StringLength(100)] // Isto aqui é o tamanho máximo da variável Id
    [Required] // Isto é porque "Id" é Obrigatório
    public string? Nome { get; set; }
    [StringLength(200)]
    [Required]
    public string? Detalhe { get; set; }
    [StringLength(200)]
    public string? UrlImagem { get; set; }
    public byte[]? Imagem { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")] // Define o tipo decimal com precisão 10 e escala de 2
    public decimal Preco { get; set; }
    public bool Promocao { get; set; }
    public bool MaisVendido { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal EmStock { get; set; }
    public bool Disponivel { get; set; }
    public string? Origem { get; set; }
    public int CategoriaId { get; set; } // Chave forasteira
    public Categoria categoria { get; set; }

    [JsonIgnore]
    public int? ModoEntregaId { get; set; }
    public ModoEntrega modoentrega { get; set; }

    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}
