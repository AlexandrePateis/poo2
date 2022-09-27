using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models;

public class Procedimentos
{
    [Required]
    public int Id { get; set; }
    [Required]
    [Column(TypeName ="varchar(100)")]
    public string Nome { get; set; }
    [Required]
    public int Duracao { get; set; }
    [Required]
    [Column(TypeName ="decimal(13,2)")]
    public decimal Preco { get; set; }
    [Required]
    public DateTime DataCriacao { get; set; }
    [Required]
    public DateTime DataAtualizacao { get; set; }
    [Required]
    public string Descricao { get; set; }

    //Propriedade de navegação
    public List<Agendamentos> Agendamentos { get; set; }
}
