using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models;

public class Perfil
{
    [Required]
    public int Id { get; set; }

    [Column(TypeName ="varchar(100)")]
    [Required]
    public string Nome { get; set; }

    //Propriedade de Navegação

    public List<User> Users { get; set; }
}
