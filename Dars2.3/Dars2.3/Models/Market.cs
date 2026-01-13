namespace Dars2._3.Models;

internal class Market
{
    public Guid MarketId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int ProductCount { get; set; }
    public bool IsOpen { get; set; }
    public int Employees { get; set; }
    public double Rating { get; set; }
    public Market(string name, string location, int productCount, bool isOpen, int employees, double rating)
    {
        Name = name;
        Location = location;
        ProductCount = productCount;    
        IsOpen = isOpen;
        Employees = employees;
        Rating = rating;

    }
}
