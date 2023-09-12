using PizzaApp.Application.Models.Users;

namespace PizzaApp.Application.Services.Interfaces;

public interface IUserService
{
    Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel);

    Task<List<UserResponseModel>> ReadAllUsersAsync();
}