using MeuProjeto.Application.Interface;
using MeuProjeto.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjeto.Api.Controller;

[ApiController]
[Route("api/[Controller]")]
public class DespesasController(IDespesaService despesaService) : ControllerBase
{
    private readonly IDespesaService _despesaService = despesaService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Despesa>>> Get()
    {
        var despesas = await _despesaService.ListarTodasAsync();
        return Ok(despesas);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Despesa despesa)
    {
        try
        {
            await _despesaService.AdicionarAsync(despesa);
            return CreatedAtAction(nameof(Get), despesa);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

}

