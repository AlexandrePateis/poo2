using Microsoft.EntityFrameworkCore;
using MyHotel.Models;

namespace MyHotel.Data;

public class ContextoBD : DbContext
{
    //Construtor que vai receber configurações de acesso ao BD
    //Essas configurações virão do Program.cs
    public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
    {

    }

    //TABELAS
    public DbSet<Procedimentos> Procedimento { get; set; }
    public DbSet<Agendamentos> Agendamento { get; set; }
    public DbSet<DiaFuncionamento> DiaFuncionamentos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Perfil> Perfis { get; set; }
    public DbSet<User> Users { get; set; }
}
