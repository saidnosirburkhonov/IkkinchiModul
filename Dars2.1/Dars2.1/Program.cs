namespace Dars2._1;

internal class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product()
        {
            Name = "Cake",
            Price = 200000,
            DateRelease = DateTime.Now,
            ShelfLife = 7
        };

        Console.WriteLine($"{product1.DateRelease.Day + product1.ShelfLife}");
    }
}
