using Dars2._3.Models;

namespace Dars2._3.Services;

internal class ActorService
{
    List<Actor> Actors;
    public ActorService()
    {
        Actors = new List<Actor>();
    }
    public Guid AddActor(Actor actor)
    {
        actor.ActorId = Guid.NewGuid();
        Actors.Add(actor);
        return actor.ActorId;   
    }
    public List<Actor> GetAllActors()
    {
        return Actors; 
    }
    public Actor? GetActorById(Guid actorId)
    {
        foreach (var a in Actors)
        {
            if(a.ActorId == actorId)
            {
                return a;
            }
        }
        return null;
    }
    public bool DeleteActorById(Guid actorId)
    {
        foreach (var a in Actors)
        {
            if(a.ActorId == actorId)
            {
                Actors.Remove(a);
                return true;
            }
        }
        return false;
    }
    public bool UpdateActor(Guid actorId, Actor newActor)
    {
        for(var i = 0; i < Actors.Count; i++)
        {
            if (Actors[i].ActorId == actorId)
            {
                Actors[i].Age = newActor.Age;
                Actors[i].AwardsCount = newActor.AwardsCount;
                Actors[i].IsActive = newActor.IsActive;
                Actors[i].FullName = newActor.FullName;
                Actors[i].Nationality = newActor.Nationality;
                Actors[i].MainGenre = newActor.MainGenre;
                return true;
            }
        }
        return false;
    }
    public List<Actor> GetActiveActors()
    {
        var ActiveActors = new List<Actor>();
        foreach (var ac in Actors)
        {
            if(ac.IsActive == true)
            {
                ActiveActors.Add(ac);
            }
        }
        return ActiveActors;
    }
}
