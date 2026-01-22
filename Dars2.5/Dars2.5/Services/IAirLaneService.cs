using Dars2._5.Models;

namespace Dars2._5.Services;

public interface IAirLaneService
{
    public Guid AddAirLane(AirLane airLane);
    public List<AirLane> GetAllAirLanes();
    public AirLane? GetAirLaneById(Guid airLaneId);
    public void UpdateAirLane(Guid airLineId, AirLane newAirLane);
    public void DeleteAirLane(Guid airLineId);
}
