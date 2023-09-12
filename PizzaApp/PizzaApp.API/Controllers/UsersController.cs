using Microsoft.AspNetCore.Mvc;
using PizzaApp.Application.Models.Users;
using PizzaApp.Application.Services;
using PizzaApp.Application.Services.Interfaces;

namespace PizzaApp.API.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsersAsync()
    {
        var response = await userService.ReadAllUsersAsync();

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserAsync(CreateUserRequestModel requestModel)
    {
        var response = await userService.CreateUserAsync(requestModel);

        return Ok(response);
    }
}
