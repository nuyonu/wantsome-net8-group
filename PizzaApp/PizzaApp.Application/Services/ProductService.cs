using PizzaApp.Application.Models.Products;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.DataAccess.Repositories.Interfaces;

namespace PizzaApp.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository productRepository;

    public ProductService(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }
    
    public async Task<ProductResponseModel> CreateAsync(CreateProductRequestModel requestModel)
    {
        var product = requestModel.ToProduct();

        var addedProduct = await productRepository.InsertAsync(product);

        return ProductResponseModel.FromProduct(addedProduct);
    }

    public async Task<List<ProductResponseModel>> ReadAllAsync(ReadProductsRequestModel requestModel)
    {
        var products = await this.productRepository.ReadAllAsync(requestModel.OrderBy, requestModel.Page, requestModel.PageCount);

        return products.Select(ProductResponseModel.FromProduct).ToList();
    }

    public async Task<ProductResponseModel> UpdateAsync(int id, UpdateProductRequestModel requestModel)
    {
        var productFromDb = await this.productRepository.ReadByIdAsync(id);

        productFromDb.Name = requestModel.Name;
        productFromDb.Description = requestModel.Description;
        productFromDb.Price = requestModel.Price;
        productFromDb.Category = requestModel.Category;

        return ProductResponseModel.FromProduct(productFromDb);
    }

    public async Task DeleteAsync(int id)
    {
        await this.productRepository.DeleteAsync(id);
    }

    public async Task<ProductResponseModel> ReadByIdAsync(int id)
    {
        var product = await this.productRepository.ReadByIdAsync(id);

        return ProductResponseModel.FromProduct(product);
    }
}