using Dars2._5.Models;

namespace Dars2._5.Services;

public class BlackBoardService : IBlackBoardService
{
    List<BlackBoard> BlackBoards;
    public BlackBoardService()
    {
        BlackBoards = new List<BlackBoard>();
    }
    public Guid AddBlackBoard(BlackBoard blackboard)
    {
        blackboard.BlackBoardId = Guid.NewGuid();
        BlackBoards.Add(blackboard);
        return blackboard.BlackBoardId;
    }

    public void DeleteBlackBoard(Guid blackBoardId)
    {
        foreach (var b in BlackBoards)
        {
            if(b.BlackBoardId == blackBoardId)
            {
                BlackBoards.Remove(b);
            }
        }

    }

    public BlackBoard? GetBlackBoardById(Guid blackBoardId)
    {
        foreach (var b in BlackBoards)
        {
            if(b.BlackBoardId == blackBoardId)
            {
                return b;
            }
        }
        return null;
    }

    public List<BlackBoard> GetBlackBoards()
    {
        return BlackBoards;
    }

    public void UpdateBlackBoard(Guid blackBoardId, BlackBoard newBlackboard)
    {
        for (var i = 0; i < BlackBoards.Count; i++)
        {
            if (BlackBoards[i].BlackBoardId == blackBoardId)
            {
                BlackBoards[i].Color = newBlackboard.Color;
                BlackBoards[i].Width = newBlackboard.Width;
                BlackBoards[i].Heigth = newBlackboard.Heigth;
                BlackBoards[i].IsWood = newBlackboard.IsWood;
            }
        }
    }
}
