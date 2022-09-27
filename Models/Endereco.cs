namespace MyHotel.Models;

public class Endereco
{
    public int Id { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public string Complemento { get; set; }

    //Propriedade de Navegação
    public User User { get; set; }

    //Chave Estrangeira
    public int UserId { get; set; }
}
