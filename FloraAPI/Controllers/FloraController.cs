using FloraAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FloraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloraController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllFlora()
        {
            var floraList = new List<Flora>
            {
                new Flora { Id = 1,}
            }
        }
    }
}
