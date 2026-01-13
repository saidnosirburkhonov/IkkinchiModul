using Dars2._3.Models;

namespace Dars2._3.Services;

internal class FruitService
{
    List<Fruit> Fruits;
    public FruitService()
    {
        Fruits = new List<Fruit>();
    }
    public List<Fruit> GetAllFruits()
    {
        return Fruits;
    }
    public Guid AddFruit(Fruit fruit)
    {
        fruit.FruitId = Guid.NewGuid();
        Fruits.Add(fruit);
        return fruit.FruitId;
    }
    public Fruit? GetFruitById(Guid fruitId)
    {
        foreach (var f in Fruits)
        {
            if (f.FruitId == fruitId)
            {
                return f;
            }
        }
        return null;
    }
    public bool UpdateFruit(Guid fruitId, Fruit newFruit)
    {
        for (var i = 0; i < Fruits.Count; i++)
        {
            if (Fruits[i].FruitId == fruitId)
            {
                Fruits[i].Calories = newFruit.Calories;
                Fruits[i].Color = newFruit.Color;
                Fruits[i].IsSweet = newFruit.IsSweet;
                Fruits[i].Name = newFruit.Name;
                Fruits[i].OriginCountry = newFruit.OriginCountry;
                Fruits[i].Weight = newFruit.Weight;
                return true;
            }
        }
        return false;
    }
    public bool DeleteFruit(Guid fruitId)
    {
        foreach (var f in Fruits)
        {
            if (f.FruitId == fruitId)
            {
                return true;
            }
        }
        return false;
    }
    public List<Fruit>? GetFruitsByCountry(string country)
    {
        var list = new List<Fruit>();
        foreach (var f in Fruits)
        {
            if (f.OriginCountry == country)
            {
                list.Add(f);
            }
        }
        if (list.Count == 0)
        {
            return null;
        }
        return list;
    }
}
