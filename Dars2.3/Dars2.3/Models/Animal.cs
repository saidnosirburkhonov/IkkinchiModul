namespace Dars2._3.Models;

public class Animal
{
    public Guid AnimalId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public bool IsWild { get; set; }
    public string Color { get; set; }
    public Animal(string name, int age, double weight, bool isWild, string color)
    {
        Color = color;
        Name = name;
        Age = age;
        Weight = weight;
        IsWild = isWild;
    }

}

