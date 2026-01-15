namespace Dars2._4.Models;

internal class WaterTechnique : Technique
{
    public string WaterTechName { get; set; }
    public string WaterTechField { get; set; }
    public WaterTechnique(string waterTechName, string waterTechField, string techName, string techField) : base(techName, techField)
    {
        Console.WriteLine("watertechnique ishladi");
        WaterTechName = waterTechName;
        WaterTechField = waterTechField;
    }
}
