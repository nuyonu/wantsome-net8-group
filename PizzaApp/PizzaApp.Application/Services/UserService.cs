using PizzaApp.Application.Models.Users;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.DataAccess.Repositories.Interfaces;

namespace PizzaApp.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository repository;

    public UserService(IUserRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<UserResponseModel>> ReadAllUsersAsync()
    {
        // var userRepository = new UserRepository();

        var users = await repository.ReadAllAsync();
        
        return users.Select(UserResponseModel.FromUser).ToList();
    }

    public async Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel)
    {
        var user = requestModel.ToUser();
        //
        // var userRepository = new UserRepository();

        await repository.AddAsync(user);

        return UserResponseModel.FromUser(user);
    }
}
