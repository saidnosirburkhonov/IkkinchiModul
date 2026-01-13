using Dars2._3.Models;

namespace Dars2._3.Services;

internal class CakeService
{
    List<Cake> Cakes;
    public CakeService()
    {
        Cakes = new List<Cake>();
    }
    public List<Cake> GetAllCakes()
    {
        return Cakes;
    }
    public Guid AddCake(Cake cake)
    {
        cake.CakeId = Guid.NewGuid();
        Cakes.Add(cake);
        return cake.CakeId;
    }
    public Cake? GetCakeById(Guid cakeId)
    {
        foreach (var c in Cakes)
        {
            if(c.CakeId == cakeId)
            {
                return c;
            }
        }
        return null;
    }
    public Cake? GetCakeByName(string cakeName)
    {
        foreach(var c in Cakes)
        {
            if(c.Name == cakeName)
            {
                return c; 
            }
        }
        return null;
    }
    public bool DeleteCake(Guid cakeId)
    {
        foreach (var c in Cakes)
        {
            if(c.CakeId == cakeId)
            {
                Cakes.Remove(c);
                return true;
            }
        }
        return false;
    }
    public bool UpdateCake(Guid cakeId, Cake newCake)
    {
        for (var i = 0; i < Cakes.Count; i++)
        {
            if (Cakes[i].CakeId == cakeId)
            {
                Cakes[i].Name = newCake.Name;
                Cakes[i].HasCream = newCake.HasCream;
                Cakes[i].Calories = newCake.Calories;
                Cakes[i].WeightKg = newCake.WeightKg;
                Cakes[i].Price = newCake.Price;
                return true;
            }
        }
        return false;
    }
}
