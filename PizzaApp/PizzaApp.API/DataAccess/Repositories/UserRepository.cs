using PizzaApp.API.DataAccess.Entities;

namespace PizzaApp.API.DataAccess.Repositories;

public class UserRepository
{
    public UserRepository()
    {
        
    }

    public async Task<User> InsertUser(User user)
    {
        TemporaryStorage.Users.Add(user);

        return user;
    }

    public async Task<List<User>> ReadAllUsersAsync()
    {
        return TemporaryStorage.Users;
    }

    public async Task DeleteUserAsync(User user)
    {
        TemporaryStorage.Users.Remove(user);
    }
}