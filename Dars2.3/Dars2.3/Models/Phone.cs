namespace Dars2._3.Models;

internal class Phone
{
    public Guid PhoneId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int StorageGb { get; set; }
    public int RamGb { get; set; }
    public double ScreenSize { get; set; }
    public decimal Price { get; set; }

    public Phone(string brand, string model, int storageGb, int ramGb, double screenSize, decimal price)
    {
        Brand = brand;
        Model = model;
        StorageGb = storageGb;
        RamGb = ramGb;
        ScreenSize = screenSize;
        Price = price;
    }
}
