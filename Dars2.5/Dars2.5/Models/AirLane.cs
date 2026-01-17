namespace Dars2._5.Models;

public class AirLane
{
    public Guid AirLaneId { get; set; }
    public string Model { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public decimal PricePerFlight { get; set; }
}
