using PizzaApp.Application.Models.Products;

namespace PizzaApp.Application.Services.Interfaces;

public interface IProductService
{
    Task<ProductResponseModel> CreateAsync(CreateProductRequestModel requestModel);

    Task<ProductResponseModel> UpdateAsync(int id, UpdateProductRequestModel requestModel);

    Task<List<ProductResponseModel>> ReadAllAsync(ReadProductsRequestModel requestModel);

    Task<ProductResponseModel> ReadByIdAsync(int id);

    Task DeleteAsync(int id);
}
