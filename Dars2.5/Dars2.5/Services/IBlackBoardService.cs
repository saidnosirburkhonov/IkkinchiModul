using Dars2._5.Models;

namespace Dars2._5.Services;

public interface IBlackBoardService
{
    public Guid AddBlackBoard(BlackBoard blackboard);
    public List<BlackBoard> GetBlackBoards();
    public BlackBoard? GetBlackBoardById(Guid blackBoardId);
    public void UpdateBlackBoard(Guid blackBoardId,  BlackBoard newBlackboard);
    public void DeleteBlackBoard(Guid blackBoardId);

}
