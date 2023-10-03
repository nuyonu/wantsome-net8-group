using PizzaApp.Application.Exceptions;
using PizzaApp.Application.Helpers;
using PizzaApp.Application.Models.Users;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.DataAccess.Entities;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Shared.Models.Users;

namespace PizzaApp.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async Task<List<UserResponseModel>> ReadAllUsersAsync()
    {
        // var userRepository = new UserRepository();

        var users = await userRepository.ReadAllAsync();
        
        return users.Select(UserResponseModel.FromUser).ToList();
    }

    public async Task<LoginResponseModel> LoginAsync(LoginRequestModel model)
    {
        var user = await this.userRepository.GetByUsername(model.Username);

        if (user == null)
        {
            throw new NotFoundException("Username or password is incorrect.");
        }

        if (user.Password != model.Password)
        {
            throw new NotFoundException("Username or password is incorrect.");
        }

        var token = JwtHelper.GenerateToken(user, "MySuperSecretKey");

        return new LoginResponseModel
        {
            Username = user.Username,
            Id = user.Id,
            Email = user.Email,
            Token = token
        };
    }
    
    public async Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel)
    {
        var user = requestModel.ToUser();
        //
        // var userRepository = new UserRepository();

        await userRepository.AddAsync(user);

        return UserResponseModel.FromUser(user);
    }
}
