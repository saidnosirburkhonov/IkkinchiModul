namespace Dars2._3.Models;

internal class GameClub
{
    public Guid GameClubId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int PcCount { get; set; }
    public bool IsOpen24Hours { get; set; }
    public decimal HourPrice { get; set; }
    public double Rating { get; set; }

    public GameClub(string name, string location, int pcCount, bool isOpen24Hours, decimal price, double rating)
    {
        Name = name;
        Location = location;
        PcCount = pcCount;
        IsOpen24Hours = isOpen24Hours;
        HourPrice = price;
        Rating = rating;
    }
}
