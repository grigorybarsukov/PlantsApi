namespace Plants.Domain;

public class Plant
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string LatinName { get; set; }    
    public Illumination? Illumination { get; set; }
    public IList<string>? SoilAttributes { get; set; }
    public string Watering { get; set; }
    public string Temperature { get; set; }
    public string Humidity { get; set; }
    public string Complexity { get; set; }
    public string ToxicToPets { get; set; }
}