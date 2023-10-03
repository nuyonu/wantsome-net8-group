using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Application.Exceptions;
using PizzaApp.Application.Models.Users;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.Shared.Models.Users;

namespace PizzaApp.API.Controllers;

[ApiController]
[Route("users")]
[Authorize(Roles = "Admin")]
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

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> LoginAsync(LoginRequestModel requestModel)
    {
        try
        {
            var response = await userService.LoginAsync(requestModel);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return BadRequest(ex.Message);
        } 
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> CreateUserAsync(CreateUserRequestModel requestModel)
    {
        var response = await userService.CreateUserAsync(requestModel);

        return Ok(response);
    }
}
