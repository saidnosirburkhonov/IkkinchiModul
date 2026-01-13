namespace Dars2._3.Models;

internal class Home
{
    public Guid HomeId { get; set; }
    public string Adress { get; set; }
    public int Rooms { get; set; }
    public double Area { get; set; }
    public int Floors { get; set; }
    public bool HasGarage { get; set; }
    public decimal Price { get; set; }

    public Home(string adress, int rooms, double area, int floors, bool hasGarage, decimal price)
    {
        Adress = adress;
        Rooms = rooms;
        Area = area;
        Floors = floors;
        HasGarage = hasGarage;
        Price = price;

    }
}
