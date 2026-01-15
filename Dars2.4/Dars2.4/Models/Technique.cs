namespace Dars2._4.Models;

internal class Technique
{
    public string TechName { get; set; }
    public string TechField { get; set; }
    public Technique(string name, string field)
    {
        TechName = name;
        TechField = field;
        Console.WriteLine("technique ishladi");
    }
}
