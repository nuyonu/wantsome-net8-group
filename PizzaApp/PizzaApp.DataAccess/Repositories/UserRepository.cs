using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Entities;
using PizzaApp.DataAccess.Repositories.Interfaces;

namespace PizzaApp.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext databaseContext;

    public UserRepository(DatabaseContext databaseContext)
    {
        this.databaseContext = databaseContext;
    }
    
    public async Task<User> AddAsync(User user)
    {
        var addedEntity = await databaseContext.Users.AddAsync(user);

        await databaseContext.SaveChangesAsync();

        return addedEntity.Entity;
    }

    public async Task<List<User>> ReadAllAsync()
    {
        return await databaseContext.Users.ToListAsync();
    }

    public async Task DeleteAsync(User user)
    {
        databaseContext.Remove(user);

        await databaseContext.SaveChangesAsync();
    }
}