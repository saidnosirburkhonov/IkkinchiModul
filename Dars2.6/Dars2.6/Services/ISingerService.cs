using Dars2._6.Dtos;
using Dars2._6.Dtosl;
using Dars2._6.Models;  

namespace Dars2._6.Services;

public interface ISingerService
{
    public Guid AddSinger(SingerCreateDto singerCreateDto);
    public SingerGetDto? GetSingerById(Guid singerId);
    public List<SingerGetDto> GetAllSingers();
    public bool DeleteSinger(Guid singerId);
    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto);
    public SingerGetDto? GetSingerWithMaxPlays();
    public SingerGetDto? GetSingerWithMaxMusic();
    public SingerGetDto? GetSingerWithMaxAward();
    public SingerGetDto? GetSingerWithMinPlays();
    public SingerGetDto? GetSingerWithMinMusic();
    public SingerGetDto? GetSingerWithMinAward();
    public List<SingerGetDto> GetTopSingerWithMaxPlays(int count);
    public List<SingerGetDto> GetTopSingerWithMinPlays(int count);
    public List<SingerGetDto> GetSingerByGenre(string genre);

}