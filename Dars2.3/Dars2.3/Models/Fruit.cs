namespace Dars2._3.Models;

internal class Fruit
{
    public Guid FruitId { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }
    public bool IsSweet { get; set; }
    public int Calories { get; set; }
    public string OriginCountry { get; set; }

    public Fruit(string name, string color, double weight, bool isSweet, int calories, string originCountry)
    {

        Name = name;
        Color = color;
        Weight = weight;
        IsSweet = isSweet;
        Calories = calories;
        OriginCountry = originCountry;

    }
}
