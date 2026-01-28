using Dars2._9.Entities;

namespace Dars2._9.Repositories;

public class UserRepository : IUserRepository
{
    private List<User> Users;
    public UserRepository()
    {
        Users = new List<User>();
    }

    public Guid Add(User user)
    {
        Users.Add(user);
        return Guid.NewGuid();
    }
    public bool Delete(Guid id)
    {
        foreach (var user in Users)
        {
            if(user.UserId == id)
            {
                Users.Remove(user);
                return true;
            }
        }
        return false;
    }
    public List<User> GetAll()
    {
        return Users;
    }
    public User? GetById(Guid id)
    {
        foreach (var user in Users)
        {
            if(id == user.UserId)
            {
                return user;
            }
        }
        return null;
    }

}
