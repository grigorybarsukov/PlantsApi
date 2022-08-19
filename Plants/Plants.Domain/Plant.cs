namespace Plants.Domain;

public class Plant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public GrowingTemperature GrowingTemperature { get; set; }
    public decimal Humidity { get; set; }
    public Illumination Illumination { get; set; }
    public int WateringPerWeek { get; set; }
    public IEnumerable<SoilMixturePart> SoilMixture { get; set; }
    public FertilizerPlan FertilizerPlan { get; set; }
    public string Transplant { get; set; }
    public ReproductionType ReproductionType { get; set; }
    public string Pruning { get; set; }
}