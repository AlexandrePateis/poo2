using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models;

public class Endereco
{
    public int Id { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Rua { get; set; }
    [Column(TypeName ="varchar(10)")]
    [Required]
    public string Numero { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Bairro { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Cidade { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Cep { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Complemento { get; set; }

    //Propriedade de Navegação
    public User User { get; set; }

    //Chave Estrangeira
    public int UserId { get; set; }
}
