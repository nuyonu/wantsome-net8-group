using PizzaApp.Application.Models.Users;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.DataAccess.Repositories;

namespace PizzaApp.Application.Services;

public class MockUserService : IUserService
{
    private readonly MemoryUserRepository repository;

    public MockUserService(MemoryUserRepository repository)
    {
        this.repository = repository;
    }
    
    public async Task<List<UserResponseModel>> ReadAllUsersAsync()
    {
        return new List<UserResponseModel>
        {
            new UserResponseModel
            {
                Id = 1,
                Email = "fake@gmail.com"
            }
        };
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