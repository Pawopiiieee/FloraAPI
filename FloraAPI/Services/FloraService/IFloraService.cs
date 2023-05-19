namespace FloraAPI.Services.FloraService
{
    public interface IFloraService
    {
        List<Flora> GetAllFlora();
        Flora? GetMonoFlora(int id);
        List<Flora> AddFlora(Flora flora);
        List<Flora>? UpdateFlora(int id, Flora request);
        List<Flora>? DeleteFlora(int id);
    }
}
