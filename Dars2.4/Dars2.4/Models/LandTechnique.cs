namespace Dars2._4.Models;

internal class LandTechnique : Technique
{
    public string LandTechName { get; set; }
    public string LandTechField { get; set; }
    public LandTechnique(string techName, string techField, string landTech, string lendField) : base(techName, techField)
    {
        LandTechName = techName;
        LandTechField = techField;
        Console.WriteLine("landtechnique ishladi");
    }
}
