namespace Dars2._3.Models;

internal class Coffee
{
    public Guid CoffeeId { get; set; }
    public string Name { get; set; }
    public string BeanType { get; set; }
    public int Strength { get; set; }
    public bool HasMilk { get; set; }
    public decimal Price { get; set; }
    public string Country { get; set; }
    public Coffee(string name, string beanType, int strength, bool hasMilk, decimal price, string country)
    {
        Name = name;
        BeanType = beanType;
        Strength = strength;
        HasMilk = hasMilk;
        Price = price;
        Country = country;
    }
}
