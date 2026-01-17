using Dars2._5.Models;

namespace Dars2._5.Services;

internal class SingerService : ISingerService
{
    List<Singer> Singers;
    public SingerService()
    {
        Singers = new List<Singer>();
    }
    public Guid AddSinger(Singer singer)
    {
        singer.SingerId = Guid.NewGuid();
        Singers.Add(singer);
        return singer.SingerId;
    }

    public void DeleteSingerById(Guid singerId)
    {
        foreach (var s in Singers)
        {
            if(s.SingerId == singerId)
            {
                Singers.Remove(s);
            }
        }
    }

    public List<Singer> GetAllSingers()
    {
        return Singers;
    }

    public Singer? GetSingerById(Guid singerId)
    {
        foreach (var s in Singers)
        {
            if(s.SingerId == singerId)
            {
                return s;
            }
        }
        return null;
    }

    public void UpdateSinger(Guid singerId, Singer newSinger)
    {
        for(var i = 0; i < Singers.Count; i++)
        {
            if (Singers[i].SingerId == singerId)
            {
                Singers[i].Age = newSinger.Age;
                Singers[i].Country = newSinger.Country;
                Singers[i].Name = newSinger.Name;
                Singers[i].SecondName = newSinger.SecondName;
            }
        }
    }
}
