namespace FloraAPI.Services.FloraService
{
    public class FloraService : IFloraService
    {
        private readonly DataContext _context;
        public FloraService(DataContext context) //inject data
        {
            _context = context;
        }
        public async Task<List<Flora>> AddFlora(Flora flora)
        {
            _context.Floras.Add(flora);

            //save change
            await _context.SaveChangesAsync();

            return await _context.Floras.ToListAsync();
        }

        public async Task<List<Flora>?> DeleteFlora(int id)
        {
            var flora = await _context.Floras.FindAsync(id);
            if (flora == null)
                return null;   //can return proper status code

            //remove flora
            _context.Floras.Remove(flora);

            //save change
            await _context.SaveChangesAsync();

            return await _context.Floras.ToListAsync();
        }

        public async Task<List<Flora>> GetAllFlora()
        {
            var allFlora =await _context.Floras.ToListAsync();
            return allFlora;
        }

        public async Task<Flora?> GetMonoFlora(int id)
        {
            var monoFlora = await _context.Floras.FindAsync(id);
            if (monoFlora == null)
                return null;
            return monoFlora; 
        }

        public async Task<List<Flora>> GetFloraBy(string? name, string? family)
        {
            //ToListAsync gets all
            //Where = specify filter
            var flora = await _context.Floras
                .Where(f => (name == null || f.Name == name)
                && (family == null || f.Family == family)).ToListAsync();
            return flora;
        }

        public async Task<List<Flora>?> UpdateFlora(int id, Flora request) //List<Flora>? = flora returns list || null
        {
            var flora = await _context.Floras.FindAsync(id);
            if (flora == null)
                return null;

            //manually amend data
            flora.Name = request.Name;
            flora.Kingdom = request.Kingdom;
            flora.Family = request.Family;
            flora.Genus = request.Genus;
            flora.Species = request.Species;

            //save change
            await _context.SaveChangesAsync();

            return await _context.Floras.ToListAsync();
        }
    }
}
