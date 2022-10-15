using Microsoft.AspNetCore.Mvc;
using MyHotel.Dtos.Procedimento;
using MyHotel.Services;

namespace MyHotel.Controllers;

[ApiController]
[Route("procedimentos")]
public class ProcedimentoController : ControllerBase
{
    //Campo injetado no construtor
    private ProcedimentoServico _procedimentoServico;

    //Injetando o servico no construtor
    public ProcedimentoController([FromServices] ProcedimentoServico servico)
    {
        _procedimentoServico = servico;
    }

    [HttpPost]
    public ProcedimentoResposta PostProcedimento
    ([FromBody] ProcedimentoCriarAtualizarRequisicao novoProcedimento)
    {
        //Enviar os dados da Requisição para a classe de serviço
        return _procedimentoServico.CriarProcedimento(novoProcedimento);
    }

    [HttpGet]
    public List<ProcedimentoResposta> GetProcedimentos()
    {
        //Pegar e rotornar a lista de procedimento serviço
        return _procedimentoServico.ListarProcedimentos();
    }
}
