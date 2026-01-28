using Dars2._9.Entities;

namespace Dars2._9.Repositories;

public interface IUserRepository
{
    public Guid Add(User user);
    public List<User> GetAll();
    public User? GetById(Guid id);
    public bool Delete(Guid id);
}
