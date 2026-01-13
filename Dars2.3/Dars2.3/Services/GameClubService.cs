using Dars2._3.Models;

namespace Dars2._3.Services;

internal class GameClubService
{
    List<GameClub> GameClubs;
    public GameClubService()
    {
        GameClubs = new List<GameClub>();
    }
    public List<GameClub> GetAllGameClubs()
    {
        return GameClubs;
    }
    public GameClub? GetGameClubById(Guid gameClubId)
    {
        foreach (var g in GameClubs)
        {
            if (g.GameClubId == gameClubId)
            {
                return g;
            }
        }
        return null;
    }
    public Guid AddGameClub(GameClub gameClub)
    {
        gameClub.GameClubId = Guid.NewGuid();
        GameClubs.Add(gameClub);
        return gameClub.GameClubId;
    }
    public bool UpdateGameClub(Guid gameClubId, GameClub newGameClub)
    {
        for (var i = 0; i < GameClubs.Count; i++)
        {
            if (GameClubs[i].GameClubId == gameClubId)
            {
                GameClubs[i].Name = newGameClub.Name;
                GameClubs[i].PcCount = newGameClub.PcCount;
                GameClubs[i].IsOpen24Hours = newGameClub.IsOpen24Hours;
                GameClubs[i].HourPrice = newGameClub.HourPrice;
                GameClubs[i].Location = newGameClub.Location;
                GameClubs[i].Rating = newGameClub.Rating;
                return true;
            }
        }
        return false;
    }
    public bool DeleteGameClub(Guid gameClubId)
    {
        foreach (var g in GameClubs)
        {
            if (g.GameClubId == gameClubId)
            {
                GameClubs.Remove(g);
                return true;
            }
        }
        return false;
    }
    public List<GameClub>? GetOpenGameClubByLocation(string location)
    {
        List<GameClub> OpenGameClubs = new List<GameClub>();
        foreach (var g in GameClubs)
        {
            if (g.IsOpen24Hours == true && g.Location == location)
            {
                OpenGameClubs.Add(g);
            }
        }
        if (OpenGameClubs.Count == 0)
        {
            return null;
        }
        return OpenGameClubs;
    }
}
