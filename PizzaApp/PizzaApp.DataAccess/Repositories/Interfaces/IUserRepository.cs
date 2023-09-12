using PizzaApp.DataAccess.Entities;

namespace PizzaApp.DataAccess.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User> AddAsync(User user);

    Task<List<User>> ReadAllAsync();

    Task DeleteAsync(User user);
}