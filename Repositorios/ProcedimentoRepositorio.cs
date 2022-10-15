using Microsoft.AspNetCore.Mvc;
using MyHotel.Data;
using MyHotel.Models;

namespace MyHotel.Repositorios;

public class ProcedimentoRepositorio
{   
    //Campo que vai ser injetado
    private ContextoBD _contexto;

    //Construtor que vai inejetar
    public ProcedimentoRepositorio([FromServices] ContextoBD contexto)
    {
        _contexto = contexto;
    }
    public Procedimentos CriarProcedimento(Procedimentos procedimento)
    {
        //Manda salvar no Banco de Dados
        _contexto.Procedimento.Add(procedimento);
        _contexto.SaveChanges();

        //Retorno o modelo
        return procedimento;
    }

    public List<Procedimentos> ListarProcedimentos()
    {
        //retorna uma lista dos procedimentos cadastrados
        return _contexto.Procedimento.ToList();
    }
}
