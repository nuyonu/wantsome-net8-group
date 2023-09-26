using System.Linq.Expressions;
using PizzaApp.DataAccess.Entities;

namespace PizzaApp.DataAccess.Repositories.Interfaces;

public interface IProductRepository
{
    public Task<Product> InsertAsync(Product product);

    public Task<Product> UpdateAsync(Product product);

    Task<List<Product>> ReadAllAsync(string? orderBy, int page, int pageCount);

    public Task<Product> ReadByIdAsync(int id);

    public Task DeleteAsync(int id);
}