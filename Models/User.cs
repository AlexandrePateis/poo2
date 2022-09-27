using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models;

public class User
{
    [Required]
    public int Id { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Nome { get; set; }
    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Email { get; set; }
    [Column(TypeName ="varchar(60)")]
    [Required]
    public string Senha { get; set; }
    [Column(TypeName ="varchar(20)")]
    [Required]
    public string Telefone { get; set; }

    //Propriedade de Navegação

    public Endereco Endereco {get; set;}

    //Propriedade de Navegação
    public List<Agendamentos> Agendamentos { get; set; }

    //Propriedade de Navegação
    public List<Perfil> Perfis { get; set; }
}
