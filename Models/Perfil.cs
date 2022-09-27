namespace MyHotel.Models;

public class Perfil
{
    public int Id { get; set; }
    public string Nome { get; set; }

    //Propriedade de Navegação

    public List<User> Users { get; set; }
}
