using Dars2._9.Dtos;
using Dars2._9.Entities;
using Dars2._9.Repositories;

namespace Dars2._9.Services;

public class UserService : IUserService
{
    private IUserRepository UserRepository;
    public UserService()
    {
        UserRepository = new UserRepository();
    }
    public Guid AddUser(UserCreateDto userCreateDto)
    {
        User user = new User()
        {
            UserId = Guid.NewGuid(),
            UserName = userCreateDto.UserName,
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName,
            Password = userCreateDto.Password,
            RegisteredTime = DateTime.UtcNow
        };
        UserRepository.Add(user);
        return user.UserId;
    }

    public bool DeleteUser(Guid id)
    {
        return UserRepository.Delete(id);
    }

    public List<UserGetDto> GetAllUsers()
    {
        var users = UserRepository.GetAll();
        var usersGetDto = new List<UserGetDto>();
        foreach (var user in users)
        {
            var dto = new UserGetDto()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                RegisteredTime = user.RegisteredTime
            };
            usersGetDto.Add(dto);
        }
        return usersGetDto;
    }

    public UserGetDto? GetUserById(Guid id)
    {
        var user = UserRepository.GetById(id);
        if(user == null ) return null;
        var userGetDto = new UserGetDto()
        {
            UserId = user.UserId,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            RegisteredTime = user.RegisteredTime
        };
        return userGetDto;
    }
}
