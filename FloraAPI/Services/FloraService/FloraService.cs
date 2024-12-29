namespace FloraAPI.Services.FloraService;

public class FloraService(DataContext context) : IFloraService //implementation of IFloraService
{
    //inject data

    public async Task<List<Flora>> AddFlora(Flora flora, CancellationToken cancellationToken)
    {
        context.Floras.Add(flora);

        //save change
        await context.SaveChangesAsync(cancellationToken);

        return await context.Floras.ToListAsync(cancellationToken);
    }

    public async Task<List<Flora>?> DeleteFlora(int id, CancellationToken cancellationToken)
    {
        var flora = await context.Floras.FindAsync(id,cancellationToken);
        if (flora is null)
            return null;  

        //remove flora
        context.Floras.Remove(flora);

        //save change
        await context.SaveChangesAsync(cancellationToken);

        return await context.Floras.ToListAsync(cancellationToken);
    }

    public async Task<List<Flora>> GetAllFlora(CancellationToken cancellationToken)
    {
        //showing all flora
        var allFlora =await context.Floras.ToListAsync(cancellationToken);
        return allFlora;
    }

    public async Task<Flora?> GetMonoFlora(int id, CancellationToken cancellationToken)
    {
        var monoFlora = await context.Floras.FindAsync([id], cancellationToken);
        return monoFlora is null ? null : monoFlora;
    }

    public async Task<List<Flora>> GetFloraBy(string? name, CancellationToken cancellationToken)
    {
        //ToListAsync gets all
        //Where = specify filter
        var flora = await context.Floras
            .Where(
                f => name == null || f.Name.ToLower().Contains(name.ToLower()))
            .ToListAsync(cancellationToken);
        return flora;
    }

    public async Task<List<Flora>?> UpdateFlora(int id, Flora request, CancellationToken cancellationToken) //List<Flora>? = flora returns list || null
    {
        var flora = await context.Floras.FindAsync([id], cancellationToken);
        if (flora is null)
            return null;

        flora.Name = request.Name;
        flora.Kingdom = request.Kingdom;
        flora.Family = request.Family;
        flora.Genus = request.Genus;
        flora.Species = request.Species;
        flora.NativeRange = request.NativeRange;
        flora.Habitat = request.Habitat;

        await context.SaveChangesAsync(cancellationToken);

        return await context.Floras.ToListAsync(cancellationToken);
    }
}