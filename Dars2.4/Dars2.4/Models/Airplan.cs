namespace Dars2._4.Models;

internal class Airplan : AirTechnique
{
    public string PlaneName { get; set; }
    public string PlaneField { get; set; }
    public Airplan(string techName, string techField, string airName, string airField, string planeName, string planeField) : base(techField, techName, airName, airField)
    {
        PlaneName = planeName;
        PlaneField = planeField;
        Console.WriteLine("airplan ishladi");
    }
}
