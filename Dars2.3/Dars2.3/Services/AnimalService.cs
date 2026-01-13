using Dars2._3.Models;

namespace Dars2._3.Services;

internal class AnimalService
{
    List<Animal> Animals;
    public AnimalService()
    {
        Animals = new List<Animal>();
    }
    public List<Animal> GetAllAnimals()
    {
        return Animals;
    }
    public Guid AddAnimal(Animal animal)
    {
        animal.AnimalId = Guid.NewGuid();
        Animals.Add(animal);
        return animal.AnimalId;
    }
    public Animal? GetAnimalById(Guid animalId)
    {
        foreach (var a in Animals)
        {
            if (a.AnimalId == animalId)
            {
                return a;
            }
        }
        return null;
    }
    public bool DeleteAnimalById(Guid animalId)
    {
        foreach (var a in Animals)
        {
            if (a.AnimalId == animalId)
            {
                Animals.Remove(a);
                return true;
            }
        }
        return false;
    }
    public bool UpdateAnimal(Guid animalId, Animal newAnimal)
    {
        for (var i = 0; i < Animals.Count; i++)
        {
            if (Animals[i].AnimalId == animalId)
            {
                Animals[i].Age = newAnimal.Age;
                Animals[i].Weight = newAnimal.Weight;
                Animals[i].Name = newAnimal.Name;
                Animals[i].Color = newAnimal.Color;
                Animals[i].IsWild = newAnimal.IsWild;
                return true;
            }
        }
        return false;
    }
    public List<Animal> GetWildAnimals()
    {
        List<Animal> WildAnimals = new List<Animal>();
        foreach (var a in Animals)
        {
            if (a.IsWild == true)
            {
                WildAnimals.Add(a);
            }
        }
        return WildAnimals;
    }
}
