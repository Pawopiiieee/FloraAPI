namespace FloraAPI.Services.FloraService;

public interface IFloraService 
{
    Task<List<Flora>> GetAllFlora(CancellationToken cancellationToken);
    Task<Flora?> GetMonoFlora(int id, CancellationToken cancellationToken);
    Task<List<Flora>> AddFlora(Flora flora, CancellationToken cancellationToken);
    Task<List<Flora>?> UpdateFlora(int id, Flora request, CancellationToken cancellationToken);
    Task<List<Flora>?> DeleteFlora(int id, CancellationToken cancellationToken);
    Task<List<Flora>> GetFloraBy(string? name, CancellationToken cancellationToken);
}

