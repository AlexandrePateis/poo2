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
    public void PostProcedimento([FromBody] ProcedimentoCriarAtualizarRequisicao novoProcedimento)
    {
        //Enviar os dados da Requisição para a classe de serviço

        _procedimentoServico.CriarProcedimento(novoProcedimento);
    }
}
