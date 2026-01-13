using Dars2._3.Models;

namespace Dars2._3.Services;

internal class LaptopService
{
    List<Laptop> Laptops;
    public LaptopService()
    {
        Laptops = new List<Laptop>();
    }
    public List<Laptop> GetAllLaptops()
    {
        return Laptops;
    }
    public Laptop? GetLaptopById(Guid laptopId)
    {
        foreach (var l in Laptops)
        {
            if (l.LaptopId == laptopId)
            {
                return l;
            }
        }
        return null;
    }
    public Guid AddLaptop(Laptop laptop)
    {
        laptop.LaptopId = Guid.NewGuid();
        Laptops.Add(laptop);
        return laptop.LaptopId;
    }
    public bool DeleteLaptop(Guid laptopId)
    {
        foreach (var l in Laptops)
        {
            if (l.LaptopId == laptopId)
            {
                return true;
            }
        }
        return false;
    }
    public bool UpdateLaptop(Guid laptopId, Laptop newLaptop)
    {
        for (var i = 0; i < Laptops.Count; i++)
        {
            if (Laptops[i].LaptopId == laptopId)
            {
                Laptops[i].Cpu = newLaptop.Cpu;
                Laptops[i].RamGb = newLaptop.RamGb;
                Laptops[i].ScreenSize = newLaptop.ScreenSize;
                Laptops[i].Brand = newLaptop.Brand;
                Laptops[i].Price = newLaptop.Price;
                Laptops[i].StorageGb = newLaptop.StorageGb;
                return true;
            }
        }
        return false;
    }
    public Laptop GetTheMostCheapLaptop()
    {
        var firstLaptop = Laptops[0];
        for (var i = 0; i < Laptops.Count; i++)
        {
            if (Laptops[i].Price < firstLaptop.Price)
            {
                firstLaptop = Laptops[i];
            }
        }
        return firstLaptop;
    }
}
