//using FloraAPI.Models;
using FloraAPI.Services.FloraService;
using Microsoft.AspNetCore.Mvc;

namespace FloraAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FloraController(IFloraService floraService) : ControllerBase
{
    [HttpGet]   
    public async Task<ActionResult<List<Flora>>> GetAllFlora(CancellationToken cancellationToken)
    {
        return await floraService.GetAllFlora(cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Flora>> GetMonoFlora(int id, CancellationToken cancellationToken)
    {
        var result = await floraService.GetMonoFlora(id,cancellationToken);
        return result is null ? NotFound("NO Flora") : Ok(result);
    }

    [HttpGet("search")]
    public async Task<ActionResult<List<Flora>>> GetFloraBy(string? name, CancellationToken cancellationToken)
    {
        var result = await floraService.GetFloraBy(name,cancellationToken);
        return result;
    }

    [HttpPost]
    public async Task<ActionResult<List<Flora>>> AddFlora(Flora flora, CancellationToken cancellationToken)
    {
        var result = await floraService.AddFlora(flora, cancellationToken);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<Flora>>> UpdateFlora(int id, Flora request, CancellationToken cancellationToken)
    {
        var result = await floraService.UpdateFlora(id, request, cancellationToken);
        return result is null ? NotFound("NO Flora") : Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Flora>>> DeleteFlora(int id, CancellationToken cancellationToken)
    {
        var result = await floraService.DeleteFlora(id,cancellationToken);
        return result is null ? NotFound("NO Flora") : Ok(result);
    }
}