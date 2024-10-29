namespace FloraAPI.Models;

public class Flora
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Kingdom { get; set; } = string.Empty;
    public string Family { get; set; } = string.Empty;
    public string Genus { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;

}