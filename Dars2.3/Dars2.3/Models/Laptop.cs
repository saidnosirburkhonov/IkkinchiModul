namespace Dars2._3.Models;

internal class Laptop
{
    public Guid LaptopId { get; set; }
    public string Brand { get; set; }
    public string Cpu { get; set; }
    public int RamGb { get; set; }
    public int StorageGb { get; set; }
    public double ScreenSize { get; set; }
    public decimal Price { get; set; }
    public Laptop(string brand, string cpu, int ramGb, int storageGb, double screenSize, decimal price)
    {
        ScreenSize = screenSize;
        Brand = brand;
        Cpu = cpu;
        RamGb = ramGb;
        StorageGb = storageGb;
        Price = price;

    }
}
