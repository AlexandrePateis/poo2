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
    public ProcedimentoResposta CriarProcedimento(ProcedimentoCriarAtualizarRequisicao novoProcedimento)
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

        //Copiar os dados do modelo (Procedimento) para a reposta (ProcedimentoRespota)

        var procedimentoResposta = ConverterModeloParaResposta(procedimento);

        return procedimentoResposta;

    }
    
    public List<ProcedimentoResposta> ListarProcedimentos()
    {
        //Buscar todos os procedimentos no reposuitório
        var procedimentos = _procedimentoRepositorio.ListarProcedimentos();

        //Lista de Procedimentos
        List<ProcedimentoResposta> procedimentoRespostas = new();

        //Transformar de Procedimentos (modelo) para PorcedimentoRespota
        foreach(var procedimento in procedimentos)
        {
            //Copiar os dados do modelo para a resporta
            var procedimentoResposta = ConverterModeloParaResposta(procedimento);

            //Adicionar na lista de respota 
            procedimentoRespostas.Add(procedimentoResposta);

        }
          return procedimentoRespostas;
    }

    private ProcedimentoResposta ConverterModeloParaResposta(Procedimentos modelo)
    {
        var procedimentoResposta = new ProcedimentoResposta();
        procedimentoResposta.Id = modelo.Id;
        procedimentoResposta.Nome = modelo.Nome;
        procedimentoResposta.Duracao = modelo.Duracao;
        procedimentoResposta.Preco = modelo.Preco;
        procedimentoResposta.Descricao = modelo.Descricao;

        return procedimentoResposta;
    }

}
