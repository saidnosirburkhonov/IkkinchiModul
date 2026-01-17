using Dars2._5.Models;

namespace Dars2._5.Services;

public class AirLaneService : IAirLaneService
{
    List<AirLane> AirLanes;
    public AirLaneService()
    {
        AirLanes = new List<AirLane>();
    }
    public Guid AddAirLane(AirLane airLane)
    {
        airLane.AirLaneId = Guid.NewGuid();
        AirLanes.Add(airLane);
        return airLane.AirLaneId;
    }

    public void DeleteAirLane(Guid airLineId)
    {
        foreach (var a in AirLanes)
        {
            if(a.AirLaneId == airLineId)
            {
                AirLanes.Remove(a);
            }
        }
    }

    public AirLane? GetAirLaneById(Guid airLaneId)
    {
        foreach (var a in AirLanes)
        {
            if(a.AirLaneId == airLaneId)
            {
                return a;
            }
        }
        return null;
    }

    public List<AirLane> GetAllAirLanes()
    {
        return AirLanes;
    }

    public void UpdateAirLane(Guid airLineId, AirLane newAirLane)
    {
        for(var i = 0; i < AirLanes.Count; i++)
        {
            if (AirLanes[i].AirLaneId == airLineId)
            {
                AirLanes[i].PricePerFlight = newAirLane.PricePerFlight;
                AirLanes[i].From = newAirLane.From;
                AirLanes[i].Model = newAirLane.Model;
                AirLanes[i].To = newAirLane.To;
            }
        }
    }
}
