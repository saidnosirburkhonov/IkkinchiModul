namespace Dars2._3.Modelsl;

internal class Pen
{
    public Guid PenId { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public string InkType { get; set; }
    public bool IsReusable { get; set; }
    public decimal Price { get; set; }
    public double Length { get; set; }
    public Pen(string brand, string color, string inkType, bool isReusable, decimal price, double length)
    {
        Brand = brand;
        Color = color;
        InkType = inkType;
        IsReusable = isReusable;
        Price = price;
        Length = length;
    }
}
