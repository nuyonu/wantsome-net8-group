using PizzaApp.Application.Models.Users;
using PizzaApp.Shared.Models.Users;

namespace PizzaApp.Application.Services.Interfaces;

public interface IUserService
{
    Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel);

    Task<List<UserResponseModel>> ReadAllUsersAsync();

    Task<LoginResponseModel> LoginAsync(LoginRequestModel requestModel);
}