namespace Dars2._4.Models;

internal class AirTechnique : Technique
{
    public string AirTechName { get; set; }
    public string AirTechField { get; set; }
    public AirTechnique(string techName, string techField, string airName, string airField) : base(techName, techField)
    {
        AirTechName = airName;
        AirTechField = airField;
        Console.WriteLine("airtechnique ishladi");
    }
}
