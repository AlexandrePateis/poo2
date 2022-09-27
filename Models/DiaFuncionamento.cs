namespace MyHotel.Models;

public class DiaFuncionamento
{
    public int Id { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }

    //Propriedade Navegação
    public List<Agendamentos> Agendamentos { get; set; }
}
