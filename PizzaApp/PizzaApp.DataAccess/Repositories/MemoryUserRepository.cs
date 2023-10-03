using PizzaApp.DataAccess.Entities;
using PizzaApp.DataAccess.Repositories.Interfaces;

namespace PizzaApp.DataAccess.Repositories;

public class MemoryUserRepository : IUserRepository
{
    public async Task<User> AddAsync(User user)
    {
        TemporaryStorage.Users.Add(user);

        return user;
    }

    public async Task<List<User>> ReadAllAsync()
    {
        return TemporaryStorage.Users;
    }

    public async Task DeleteAsync(User user)
    {
        TemporaryStorage.Users.Remove(user);
    }

    public Task<User?> GetByUsername(string username)
    {
        throw new NotImplementedException();
    }
}