namespace MyHotel.Models;

public class Agendamentos
{
    public int Id { get; set; }
    public DateTime Horario { get; set; }
    public bool Confirmado { get; set; }
    public DateTime DataCriacao { get; set; }

    //Propriedade de Navegação
    public Procedimentos Procedimento { get; set; }

    //Chave Estrangeira
    public int ProcedimentoId { get; set; }

    //Propriedade navegação
    public DiaFuncionamento DiaFuncionamento { get; set; }

    //Chave Estrangeira
    public int DiaFuncionamentoId { get; set; }

    //Propriedade navegação
    public User Cliente { get; set; }

    //Chave estrangeira
    public int UserId { get; set; }
}
