using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Entities;
using PizzaApp.DataAccess.Repositories.Interfaces;

namespace PizzaApp.DataAccess.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DatabaseContext databaseContext;

    public ProductRepository(DatabaseContext databaseContext)
    {
        this.databaseContext = databaseContext;
    }
    
    public async Task<Product> InsertAsync(Product product)
    {
        var addedEntity = await databaseContext.Products.AddAsync(product);

        await databaseContext.SaveChangesAsync();

        return addedEntity.Entity;
    }

    public async Task<Product> UpdateAsync(Product product)
    {
        var updatedEntity = databaseContext.Products.Update(product);

        await databaseContext.SaveChangesAsync();

        return updatedEntity.Entity;
    }

    public async Task<List<Product>> ReadAllAsync(string? orderBy, int page, int pageCount)
    {
        IOrderedQueryable<Product> query = databaseContext.Products.OrderBy(x => x.Name);
        
        if (orderBy != null)
        {
            if (orderBy == "createdAt")
            {
                query = databaseContext.Products.OrderByDescending(x => x.CreatedAt);
            }
        }

        return await query.Skip((page - 1) * pageCount).Take(pageCount).ToListAsync();
    }
    
    public async Task<List<Product>> ReadByFilterAsync(Expression<Func<Product, bool>> predicate)
    {
        return await this.databaseContext.Products.Where(predicate).ToListAsync();
    }

    public async Task<Product> ReadByIdAsync(int id)
    {
        return await this.databaseContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await this.ReadByIdAsync(id);

        this.databaseContext.Products.Remove(product);
        
        await databaseContext.SaveChangesAsync();
    }
}