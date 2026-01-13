using Dars2._3.Models;

namespace Dars2._3.Services;

internal class BagService
{
    List<Bag> Bags;
    public BagService()
    {
        Bags = new List<Bag>();
    }
    public List<Bag> GetAllBags()
    {
        return Bags;
    }
    public Guid AddBag(Bag bag)
    {
        bag.BagId = Guid.NewGuid();
        Bags.Add(bag);
        return bag.BagId;
    }
    public Bag? GetBagById(Guid bagId)
    {
        foreach (var b in Bags)
        {
            if(b.BagId == bagId)
            {
                return b;
            }
        }
        return null;
    }
    public bool DeleteBag(Guid bagId)
    {
        foreach (var b in Bags)
        {
            if(b.BagId == bagId)
            {
                Bags.Remove(b);
                return true;
            }
        }
        return false;
    }
    public bool UpdateBag(Guid bagId, Bag newBag)
    {
        for(var i = 0; i < Bags.Count; i++)
        {
            if (Bags[i].BagId == bagId)
            {
                Bags[i].IsWaterProof = newBag.IsWaterProof;
                Bags[i].Material = newBag.Material;
                Bags[i].Price = newBag.Price;
                Bags[i].Brand = newBag.Brand;
                Bags[i].Color = newBag.Color;
                return true;
            }
        }
        return false;
    }
    public Bag GetMinPriceBag()
    {
        var MinPriceBag = Bags[0];
        foreach (var b in Bags)
        {
            if(b.Price < MinPriceBag.Price)
            {
                MinPriceBag = b;
            }
        }
        return MinPriceBag;
    }
    public List<Bag>? GetWaterProofAndMinPriceBag()
    {
        var MinPrice = GetMinPriceBag();
        List<Bag> NewBag = new List<Bag>();
        foreach (var b in Bags)
        {
            if(b.IsWaterProof == true && b.Price == MinPrice.Price)
            {
                NewBag.Add(b);
                return NewBag;
            }
        }
        return null;
    }
}
