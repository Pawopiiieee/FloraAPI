namespace FloraAPI.Services.FloraService
{
    public interface IFloraService //minimal required methods
    {
        Task<List<Flora>> GetAllFlora();
        Task<Flora?> GetMonoFlora(int id);
        Task<List<Flora>> AddFlora(Flora flora);
        Task<List<Flora>?> UpdateFlora(int id, Flora request);
        Task<List<Flora>?> DeleteFlora(int id);
        Task<List<Flora>> GetFloraBy(string? name, string? family);
    }
}
//interface makes it easier to replace implementation on a fly
