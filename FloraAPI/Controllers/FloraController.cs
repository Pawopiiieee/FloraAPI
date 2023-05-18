using FloraAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FloraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloraController : ControllerBase
    {
        private static List<Flora> allFlora = new List<Flora>
            {
                new Flora
                {
                    Id = 1,
                    Name = "Acanthus mollis",
                    Kingdom = "Plantae",
                    Family = "Acanthaceae",
                    Genus = "Acanthus",
                    Species = "A. mollis"
                },
                new Flora
                {
                    Id = 2,
                    Name = "Cistus monspeliensis",
                    Kingdom = "Plantae",
                    Family = "Cistaceae",
                    Genus = "Cistus",
                    Species = "C. monspeliensis"
                },
                new Flora
                {
                    Id = 3,
                    Name = "Cota tinctoria",
                    Kingdom = "Plantae",
                    Family = "Asteraceae",
                    Genus = "Cota",
                    Species =  "C. tinctoria"
                }
            };

        [HttpGet]   //only when using swegger
        public async Task<ActionResult<List<Flora>>> GetAllFlora()
        {
            return Ok(allFlora); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flora>> GetMonoFlora(int id)
        {
            var monoFlora = allFlora.Find(x => x.Id == id);
            if (monoFlora == null)
                    return NotFound("Flora is not in a list");
            return Ok(monoFlora);
        }

        [HttpPost]
        public async Task<ActionResult<List<Flora>>> AddFlora(Flora flora)
        {
            allFlora.Add(flora);
            return Ok(allFlora);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Flora>>> UpdateFlora(int id, Flora request)
        {
            var flora = allFlora.Find(x => x.Id == id);
            if (flora == null)
                return NotFound("Flora is not in a list");

            //manually amend data
            flora.Name = request.Name;
            flora.Kingdom = request.Kingdom;
            flora.Family = request.Family;
            flora.Genus = request.Genus;
            flora.Species = request.Species;

            return Ok(allFlora);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Flora>>> DeleteeFlora(int id)
        {
            var flora = allFlora.Find(x => x.Id == id);
            if (flora == null)
                return NotFound("Flora is not in a list");

            allFlora.Remove(flora);

            return Ok(allFlora);
        }
    }
}
