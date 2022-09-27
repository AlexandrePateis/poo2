namespace MyHotel.Models;

public class User
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Telefone { get; set; }

    //Propriedade de Navegação

    public Endereco Endereco {get; set;}

    //Propriedade de Navegação
    public List<Agendamentos> Agendamentos { get; set; }

    //Propriedade de Navegação
    public List<Perfil> Perfis { get; set; }
}
