using Dars2._3.Models;

namespace Dars2._3.Services;

internal class HomeService
{
    List<Home> Homes;
    public HomeService()
    {
        Homes = new List<Home>();
    }
    public List<Home> GetAllHomes()
    {
        return Homes;
    }
    public Guid AddHome(Home home)
    {
        home.HomeId = Guid.NewGuid();
        Homes.Add(home);
        return home.HomeId;
    }
    public Home? GetHomeById(Guid homeId)
    {
        foreach (var h in Homes)
        {
            if (h.HomeId == homeId)
            {
                return h;
            }
        }
        return null;
    }
    public bool UpdateHome(Guid homeId, Home newHome)
    {
        for (var i = 0; i < Homes.Count; i++)
        {
            if (Homes[i].HomeId == homeId)
            {
                Homes[i].Adress = newHome.Adress;
                Homes[i].Rooms = newHome.Rooms;
                Homes[i].Price = newHome.Price;
                Homes[i].Area = newHome.Area;
                Homes[i].Floors = newHome.Floors;
                Homes[i].HasGarage = newHome.HasGarage;
                return true;
            }
        }
        return false;
    }
    public bool DeleteHome(Guid homeId)
    {
        foreach (var h in Homes)
        {
            if (h.HomeId == homeId)
            {
                Homes.Remove(h);
                return true;
            }
        }
        return false;
    }
    public List<Home>? GetHomeByPrice(decimal price)
    {
        var NewHomes = new List<Home>();
        foreach (var h in Homes)
        {
            if(h.Price == price)
            {
                NewHomes.Add(h);
            }
        }
        if(NewHomes.Count == 0)
        {
            return null;
        }
        return NewHomes;
    }
}
