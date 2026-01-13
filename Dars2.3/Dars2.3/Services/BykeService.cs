using Dars2._3.Models;

namespace Dars2._3.Services;

internal class BykeService
{
    List<Byke> Bykes;
    public BykeService()
    {
        Bykes = new List<Byke>();
    }
    public List<Byke> GetAllBykes()
    {
        return Bykes;
    }
    public Guid AddByke(Byke byke)
    {
        byke.BykeId = Guid.NewGuid();
        Bykes.Add(byke);
        return byke.BykeId;
    }
    public  Byke? GetBykeById(Guid bykeId)
    {
        foreach (var b in Bykes)
        {
            if(b.BykeId == bykeId)
            {
                return b;
            }
        }
        return null;
    }
    public bool DeleteByke(Guid bykeId)
    {
        foreach (var b in Bykes)
        {
            if(bykeId == b.BykeId)
            {
                Bykes.Remove(b);
                return true;
            }
        }
        return false;   
    }
    public bool UpdateByke(Guid bykeId, Byke newByke)
    {
        for(var i = 0; i < Bykes.Count; i++)
        {
            if (Bykes[i].BykeId == bykeId)
            {
                Bykes[i].HasBell = newByke.HasBell;
                Bykes[i].Brand = newByke.Brand;
                Bykes[i].Price = newByke.Price;
                Bykes[i].Type = newByke.Type;
                Bykes[i].Weight = newByke.Weight;
                return true;
            }
        }
        return false;
    }
    public List<Byke> GetNikeBykes()
    {
        var NikeBykes = new List<Byke>();
        foreach (var b in Bykes)
        {
            if(b.Brand == "Nike")
            {
                NikeBykes.Add(b);
            }
        }
        return NikeBykes;
    }
}
