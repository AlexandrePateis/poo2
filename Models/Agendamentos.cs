using System.ComponentModel.DataAnnotations;

namespace MyHotel.Models;

public class Agendamentos
{
    [Required]
    public int Id { get; set; }

    [Required]
    public DateTime Horario { get; set; }

    public bool? Confirmado { get; set; }
    
    [Required]
    public DateTime DataCriacao { get; set; }

    //Propriedade de Navegação
    public Procedimentos Procedimento { get; set; }

    //Chave Estrangeira
    [Required]
    public int ProcedimentoId { get; set; }

    //Propriedade navegação
    public DiaFuncionamento DiaFuncionamento { get; set; }

    //Chave Estrangeira
    [Required]
    public int DiaFuncionamentoId { get; set; }

    //Propriedade navegação
    public User Cliente { get; set; }

    //Chave estrangeira
    [Required]
    public int UserId { get; set; }
}
