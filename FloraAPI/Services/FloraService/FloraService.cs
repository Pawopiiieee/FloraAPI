namespace FloraAPI.Services.FloraService
{
    public class FloraService : IFloraService
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

        public List<Flora> AddFlora(Flora flora)
        {
            allFlora.Add(flora);
            return allFlora; 
        }

        public List<Flora>? DeleteFlora(int id)
        {
            var flora = allFlora.Find(x => x.Id == id);
            if (flora == null)
                return null;   //can return proper status code

            allFlora.Remove(flora);

            return allFlora;
        }

        public List<Flora> GetAllFlora()
        {
            return allFlora;
        }

        public Flora? GetMonoFlora(int id)
        {
            var monoFlora = allFlora.Find(x => x.Id == id);
            if (monoFlora == null)
                return null;
            return monoFlora; 
        }

        public List<Flora>? UpdateFlora(int id, Flora request) //List<Flora>? = flora returns list || null
        {
            var flora = allFlora.Find(x => x.Id == id);
            if (flora == null)
                return null;

            //manually amend data
            flora.Name = request.Name;
            flora.Kingdom = request.Kingdom;
            flora.Family = request.Family;
            flora.Genus = request.Genus;
            flora.Species = request.Species;

            return allFlora;

        }
    }
}
