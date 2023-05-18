using FloraAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FloraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloraController : ControllerBase
    {
        [HttpGet]   //only when using swegger
        public async Task<IActionResult> GetAllFlora()
        {
            var floraList = new List<Flora>
            {
                new Flora
                {   
                    Id = 1,
                    Name = "Acanthus mollis",
                    Kingdom = "Plantae",
                    Family = "Acanthaceae",
                    Genus = "Acanthus",
                    Species = "A. mollis"
                }
            };
            return Ok(floraList); 
        }
    }
}
