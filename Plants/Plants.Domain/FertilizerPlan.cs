using System.Security.AccessControl;

namespace Plants.Domain;

public class FertilizerPlan
{
    public Fertilizer Fertilizer { get; set; }
    public int TimesPerYear { get; set; }
}