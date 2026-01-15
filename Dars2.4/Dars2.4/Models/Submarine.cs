namespace Dars2._4.Models;

internal class Submarine : WaterTechnique
{
    public string SubmarineName { get; set; }
    public string SubmarineCountry { get; set; }

    public Submarine(string submarineName, string submarineCountry, string waterTechName, string waterTechField, string techName, string techField) : base(waterTechField, waterTechName, techName, techField)
    {
        Console.WriteLine("submarine ishladi");
        SubmarineName = submarineName;
        SubmarineCountry = submarineCountry;
    }
}
