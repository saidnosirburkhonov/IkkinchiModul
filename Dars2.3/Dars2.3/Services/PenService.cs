using Dars2._3.Modelsl;

namespace Dars2._3.Services;

internal class PenService
{
    List<Pen> Pens;
    public PenService()
    {
        Pens = new List<Pen>();
    }
    public List<Pen> GetAllPens()
    {
        return Pens;
    }
    public Pen? GetPenById(Guid penId)
    {
        foreach (var p in Pens)
        {
            if (p.PenId == penId)
            {
                return p;
            }
        }
        return null;
    }
    public Guid AddPen(Pen pen)
    {
        pen.PenId = Guid.NewGuid();
        Pens.Add(pen);
        return pen.PenId;
    }
    public bool UpdatePen(Guid penId, Pen newPen)
    {
        for (var i = 0; i < Pens.Count; i++)
        {
            if (Pens[i].PenId == penId)
            {
                Pens[i].Length = newPen.Length;
                Pens[i].Price = newPen.Price;
                Pens[i].Brand = newPen.Brand;
                Pens[i].Color = newPen.Color;
                Pens[i].InkType = newPen.InkType;
                Pens[i].IsReusable = newPen.IsReusable;
                return true;
            }
        }
        return false;
    }
    public bool DeletePen(Guid penId)
    {
        foreach (var p in Pens)
        {
            if (p.PenId == penId)
            {
                Pens.Remove(p);
                return true;
            }
        }
        return false;
    }
}
