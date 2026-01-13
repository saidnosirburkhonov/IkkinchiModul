using Dars2._3.Models;

namespace Dars2._3.Services;

internal class CoffeeService
{
    List<Coffee> Coffees;
    public CoffeeService()
    {
        Coffees = new List<Coffee>();
    }
    public List<Coffee> GetAllCoffees()
    {
        return Coffees;
    }
    public Coffee? GetCoffeeById(Guid coffeeId)
    {
        foreach (var c in Coffees)
        {
            if(c.CoffeeId == coffeeId)
            {
                return c;
            }
        }
        return null;
    }
    public Guid AddCoffee(Coffee coffee)
    {
        coffee.CoffeeId = Guid.NewGuid();
        Coffees.Add(coffee);
        return coffee.CoffeeId;
    }
    public bool DeleteCoffee(Guid coffeeId)
    {
        foreach (var c in Coffees)
        {
            if(c.CoffeeId == coffeeId)
            {
                Coffees.Remove(c);
                return true;
            }
        }
        return false;
    }
    public bool UpdateCoffee(Guid coffeeId, Coffee newCoffee)
    {
        for (var i = 0; i < Coffees.Count; i++)
        {
            if (Coffees[i].CoffeeId == coffeeId)
            {
                Coffees[i].Name = newCoffee.Name;
                Coffees[i].BeanType = newCoffee.BeanType;
                Coffees[i].HasMilk = newCoffee.HasMilk;
                Coffees[i].Strength = newCoffee.Strength;
                Coffees[i].Price = newCoffee.Price;
                Coffees[i].Country = newCoffee.Country;
                return true;
            }
        }
        return false;
    }
    public List<Coffee>? GetCoffeeByCountry(string  country)
    {
        List<Coffee> Countries = new List<Coffee>();
        foreach (var c in Coffees)
        {
            if(c.Country == country)
            {
                Countries.Add(c); 
            }
        }
        if(Countries.Count == 0)
        {
            return null;
        }
        return Countries;
    }
}
