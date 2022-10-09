using Microsoft.AspNetCore.Mvc;
using MyHotel.Dtos.Procedimento;
using MyHotel.Services;

namespace MyHotel.Controllers;

[ApiController]
[Route("procedimentos")]
public class ProcedimentoController : ControllerBase
{
    [HttpPost]
    public void PostProcedimento([FromBody] ProcedimentoCriarAtualizarRequisicao novoProcedimento)
    {
        //Enviar os dados da Requisição para a classe de serviço

        ProcedimentoServico servico = new();
        servico.CriarProcedimento(novoProcedimento);
    }
}
