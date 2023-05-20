namespace FloraAPI.Services.FloraService
{
    public interface IFloraService
    {
        Task<List<Flora>> GetAllFlora();
        Task<Flora?> GetMonoFlora(int id);
        Task<List<Flora>> AddFlora(Flora flora);
        Task<List<Flora>?> UpdateFlora(int id, Flora request);
        Task<List<Flora>?> DeleteFlora(int id);
    }
}
