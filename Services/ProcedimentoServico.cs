using Microsoft.AspNetCore.Mvc;
using MyHotel.Dtos.Procedimento;
using MyHotel.Models;
using MyHotel.Repositorios;

namespace MyHotel.Services;

public class ProcedimentoServico
{
    //Campo que vai ser injetado
    private ProcedimentoRepositorio _procedimentoRepositorio;

    public ProcedimentoServico([FromServices] ProcedimentoRepositorio repositorio)
    {
        _procedimentoRepositorio = repositorio;
    }
    public void CriarProcedimento(ProcedimentoCriarAtualizarRequisicao novoProcedimento)
    {
        //Copiar os dados da req para o modelo
        var procedimento = new Procedimentos();

        procedimento.Nome = novoProcedimento.Nome;
        procedimento.Duracao = novoProcedimento.Duracao;
        procedimento.Preco = novoProcedimento.Preco;
        procedimento.Descricao = novoProcedimento.Descricao;

        //Regras de Negocio especifica 
        var agora = DateTime.Now;
        procedimento.DataCriacao = agora;
        procedimento.DataAtualizacao = agora;

        //Enviar para o Repositório salvar no BD
        _procedimentoRepositorio.CriarProcedimento(procedimento);

    }

}
