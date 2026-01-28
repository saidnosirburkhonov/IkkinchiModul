using Dars2._9.Dtos;

namespace Dars2._9.Services;

public interface IUserService
{
    public Guid AddUser(UserCreateDto userCreateDto);
    public List<UserGetDto> GetAllUsers();
    public UserGetDto? GetUserById(Guid id);
    public bool DeleteUser(Guid id);
}
