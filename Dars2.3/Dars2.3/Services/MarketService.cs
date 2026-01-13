using Dars2._3.Models;

namespace Dars2._3.Services;

internal class MarketService
{
    List<Market> Markets;
    public MarketService()
    {
        Markets = new List<Market>();
    }
    public List<Market> GetAllMarkets()
    {
        return Markets;
    }
    public Market? GetMarketById(Guid marketId)
    {
        foreach (var m in Markets)
        {
            if(m.MarketId == marketId)
            {
                return m;
            }
        }
        return null;
    }
    public Guid AddMarket(Market market)
    {
        market.MarketId = Guid.NewGuid();
        Markets.Add(market);
        return market.MarketId;
    }
    public bool UpdateMarket(Guid marketId, Market newMarket)
    {
        for (int i = 0; i < Markets.Count; i++)
        {
            if(Markets[i].MarketId == marketId)
            {
                Markets[i].Name = newMarket.Name;
                Markets[i].IsOpen = newMarket.IsOpen;
                Markets[i].Employees = newMarket.Employees;
                Markets[i].Location = newMarket.Location;
                Markets[i].ProductCount = newMarket.ProductCount;
                Markets[i].Rating = newMarket.Rating;
                return true;
            }
        }
        return false;
    }
    public bool DeleteMarket(Guid marketId)
    {
        foreach (var m in Markets)
        {
            if(m.MarketId == marketId)
            {
                Markets.Remove(m);
                return true;
            }
        }
        return false;
    }

}
