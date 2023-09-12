using PizzaApp.API.DataAccess.Entities;

namespace PizzaApp.API.Models.Users;

public class CreateUserRequestModel
{
    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public User ToUser()
    {
        return new User
        {
            Username = this.Username,
            Email = this.Email,
            FirstName = this.FirstName,
            LastName = this.LastName,
            Password = this.Password
        };
    }
}
