//using FloraAPI.Models;
using FloraAPI.Services.FloraService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FloraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloraController : ControllerBase
    {
        private readonly IFloraService _floraService;
        public FloraController(IFloraService floraService)
        {
            _floraService = floraService; //interface
            
        }

        [HttpGet]   //only when using swegger
        public async Task<ActionResult<List<Flora>>> GetAllFlora()
        {
            return await _floraService.GetAllFlora();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flora>> GetMonoFlora(int id)
        {
            var result = await _floraService.GetMonoFlora(id);
            if (result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<ActionResult<List<Flora>>> GetFloraBy(string? name, string? family)
        {
            var result = await _floraService.GetFloraBy(name,family);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<List<Flora>>> AddFlora(Flora flora)
        {
            var result = await _floraService.AddFlora(flora);
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Flora>>> UpdateFlora(int id, Flora request)
        {
            var result = await _floraService.UpdateFlora(id, request);
            if (result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Flora>>> DeleteFlora(int id)
        {
            var result = await _floraService.DeleteFlora(id);
            if ( result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }
    }
}
