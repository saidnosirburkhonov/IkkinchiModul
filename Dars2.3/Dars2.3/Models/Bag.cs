namespace Dars2._3.Models;

internal class Bag
{
    public Guid BagId { get; set; }
    public string Brand { get; set; }
    public string Material { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public bool IsWaterProof { get; set; }
    public Bag(string brand, string material, string color, double price, bool isWaterProof)
    {
        Brand = brand;
        Material = material;
        Color = color;
        Price = price;
        IsWaterProof = isWaterProof;
    }
}
