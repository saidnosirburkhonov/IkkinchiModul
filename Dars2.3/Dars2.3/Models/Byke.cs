namespace Dars2._3.Models;

internal class Byke
{
    public Guid BykeId { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public double Weight { get; set; }
    public bool HasBell { get; set; }
    public Byke(string brand, string type, decimal price, double weight, bool hasBell)
    {
        Brand = brand;
        Type = type;
        Price = price;
        Weight = weight;
        HasBell = hasBell;
    }
}
