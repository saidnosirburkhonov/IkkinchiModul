using Dars2._6.Dtos;
using Dars2._6.Dtosl;
using Dars2._6.Models;

namespace Dars2._6.Services;

public class SingerService : ISingerService
{
    List<Singer> Singers;
    public SingerService()
    {
        Singers = new List<Singer>();
    }

    public Guid AddSinger(SingerCreateDto singerCreateDto)
    {
        var singer = new Singer()
        {
            SingerId = Guid.NewGuid(),
            FirstName = singerCreateDto.FirstName,
            LastName = singerCreateDto.LastName,
            SingerName = singerCreateDto.SingerName,
            Password = singerCreateDto.Password,
            MusicName = singerCreateDto.MusicName,
            Genres = singerCreateDto.Genres,
            Awards = singerCreateDto.Awards,
            TotalPlays = 0
        };
        Singers.Add(singer);
        return singer.SingerId;
    }

    public bool DeleteSinger(Guid singerId)
    {
        foreach (var s in Singers)
        {
            if (s.SingerId == singerId)
            {
                Singers.Remove(s);
                return true;
            }
        }
        return false;
    }

    public List<SingerGetDto> GetAllSingers()
    {
        var singetGetDto = ToSingerGetDtos(Singers);
        return singetGetDto;
    }

    private List<SingerGetDto> ToSingerGetDtos(List<Singer> singers)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach (var s in singers)
        {
            singerGetDtos.Add(ToSingerGetDto(s));
        }
        return singerGetDtos;
    }
    private SingerGetDto ToSingerGetDto(Singer singer)
    {
        return new SingerGetDto()
        {
            SingerId = singer.SingerId,
            FirstName = singer.FirstName,
            LastName = singer.LastName,
            SingerName = singer.SingerName,
            MusicName = singer.MusicName,
            Genres = singer.Genres,
            Awards = singer.Awards,
            TotalPlays = singer.TotalPlays
        };
    }

    public List<SingerGetDto> GetSingerByGenre(string genre)
    {
        var singers = new List<SingerGetDto>();
        foreach (var s in Singers)
        {
            if (s.Genres.Contains(genre))
            {
                singers.Add(ToSingerGetDto(s));
            }
        }
        return singers;
    }

    public SingerGetDto? GetSingerById(Guid singerId)
    {
        foreach (var s in Singers)
        {
            if (s.SingerId == singerId)
            {
                return ToSingerGetDto(s);
            }
        }
        return null;
    }

    public SingerGetDto? GetSingerWithMaxAward()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMaxAward = Singers[0];
        foreach (var s in Singers)
        {
            if (s.Awards.Count() > singerWithMaxAward.Awards.Count())
            {
                singerWithMaxAward = s;
            }
        }
        return ToSingerGetDto(singerWithMaxAward);
    }

    public SingerGetDto? GetSingerWithMaxMusic()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMaxMusic = Singers[0];
        foreach (var s in Singers)
        {
            if (s.MusicName.Count() > singerWithMaxMusic.MusicName.Count())
            {
                singerWithMaxMusic = s;
            }
        }
        return ToSingerGetDto(singerWithMaxMusic);
    }

    public SingerGetDto? GetSingerWithMaxPlays()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMaxPlays = Singers[0];
        foreach (var s in Singers)
        {
            if (s.TotalPlays > singerWithMaxPlays.TotalPlays)
            {
                singerWithMaxPlays = s;
            }
        }
        return ToSingerGetDto(singerWithMaxPlays);
    }

    public SingerGetDto? GetSingerWithMinAward()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMinAward = Singers[0];
        foreach (var s in Singers)
        {
            if (s.Awards.Count() < singerWithMinAward.Awards.Count())
            {
                singerWithMinAward = s;
            }
        }
        return ToSingerGetDto(singerWithMinAward);
    }

    public SingerGetDto? GetSingerWithMinMusic()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMinMusic = Singers[0];
        foreach (var s in Singers)
        {
            if (s.MusicName.Count() < singerWithMinMusic.MusicName.Count())
            {
                singerWithMinMusic = s;
            }
        }
        return ToSingerGetDto(singerWithMinMusic);
    }

    public SingerGetDto? GetSingerWithMinPlays()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }
        var singerWithMinPlays = Singers[0];
        foreach (var s in Singers)
        {
            if (s.TotalPlays < singerWithMinPlays.TotalPlays)
            {
                singerWithMinPlays = s;
            }
        }
        return ToSingerGetDto(singerWithMinPlays);
    }

    public List<SingerGetDto> GetTopSingerWithMaxPlays(int count)
    {
        for (var i = 0; i < Singers.Count(); i++)
        {
            var singerWithMaxPlays = Singers[i];
            var index = i;
            for (var j = i + 1; j < Singers.Count(); j++)
            {
                if (singerWithMaxPlays.TotalPlays < Singers[j].TotalPlays)
                {
                    singerWithMaxPlays = Singers[j];
                    index = j;
                }
            }
            var swapSinger = Singers[index];
            Singers[index] = Singers[i];
            Singers[i] = swapSinger;
        }
        var topSingers = new List<Singer>();

        for (var i = 0; i < count; i++)
        {
            topSingers.Add(Singers[i]);
        }
        return ToSingerGetDtos(topSingers);
    }

    public List<SingerGetDto> GetTopSingerWithMinPlays(int count)
    {
        throw new NotImplementedException();
    }

    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto)
    {
        foreach (var s in Singers)
        {
            if (s.SingerId == singerId)
            {
                s.SingerName = singerUpdateDto.SingerName;
                s.FirstName = singerUpdateDto.FirstName;
                s.LastName = singerUpdateDto.LastName;
                s.Awards = singerUpdateDto.Awards;
                s.Password = singerUpdateDto.Password;
                s.MusicName = singerUpdateDto.MusicName;
                s.Genres = singerUpdateDto.Genres;
                return true;
            }
        }
        return false;
    }
}

