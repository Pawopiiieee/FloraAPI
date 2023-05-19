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
            return _floraService.GetAllFlora();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flora>> GetMonoFlora(int id)
        {
            var result = _floraService.GetMonoFlora(id);
            if (result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Flora>>> AddFlora(Flora flora)
        {
            var result = _floraService.AddFlora(flora);
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Flora>>> UpdateFlora(int id, Flora request)
        {
            var result = _floraService.UpdateFlora(id, request);
            if (result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Flora>>> DeleteFlora(int id)
        {
            var result = _floraService.DeleteFlora(id);
            if ( result is null)
            {
                return NotFound("NO Flora");
            }
            return Ok(result);
        }
    }
}
