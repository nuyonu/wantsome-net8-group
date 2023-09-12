using PizzaApp.DataAccess.Entities;

namespace PizzaApp.Application.Models.Users;

public class UserResponseModel
{
    public int Id { get; set; }
    
    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public static UserResponseModel FromUser(User user)
    {
        return new UserResponseModel
        {
            Id = user.Id,
            Email = user.Email,
            Password = user.Password,
            Username = user.Username,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }
}