using Microsoft.AspNetCore.Mvc;
using PizzaApp.API.DataAccess;
using PizzaApp.API.Models.Users;

namespace PizzaApp.API.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    public UsersController()
    {
        // TODO
    }

    [HttpGet]
    public async Task<List<UserResponseModel>> GetAllUsersAsync()
    {
        return TemporaryStorage.Users.Select(UserResponseModel.FromUser).ToList();
    }

    [HttpPost]
    public async Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel)
    {
        var user = requestModel.ToUser();
        
        TemporaryStorage.Users.Add(user);

        return UserResponseModel.FromUser(user);
    }
}
