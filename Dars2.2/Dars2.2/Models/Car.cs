namespace Dars2._2.Models;

public class Car
{
    public Guid CarId { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string FuelType { get; set; }
    public DateTime RelaiseYear { get; set; }
    public bool IsNew { get; set; }
}
