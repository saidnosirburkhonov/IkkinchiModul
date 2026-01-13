namespace Dars2._3.Models;

internal class Cake
{
    public Guid CakeId { get; set; }
    public string Name { get; set; }
    public double WeightKg { get; set; }
    public int Calories { get; set; }
    public bool HasCream { get; set; }
    public decimal Price { get; set; }
    public Cake(string name, double weightKg, int calories, bool hasCream, decimal price)
    {
        Name = name;
        WeightKg = weightKg;
        Calories = calories;
        HasCream = hasCream;
        Price = price;

    }
}
