using Dars2._5.Models;

namespace Dars2._5.Services;

public interface ISingerService
{
    public Guid AddSinger(Singer singer);
    public List<Singer> GetAllSingers();
    public Singer? GetSingerById(Guid singerId);
    public void DeleteSingerById(Guid singerId);
    public void UpdateSinger(Guid singerId, Singer newSinger);
}
