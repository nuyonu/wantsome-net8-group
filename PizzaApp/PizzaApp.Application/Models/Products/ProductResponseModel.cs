using PizzaApp.DataAccess.Entities;

namespace PizzaApp.Application.Models.Products
{
    public class ProductResponseModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Price { get; set; }

        public string? Description { get; set; }

        public Category Category { get; set; }

        public static ProductResponseModel FromProduct(Product product)
        {
            return new ProductResponseModel
            {
                Id = product.Id,
                Category = product.Category,
                Description = product.Description,
                Price = product.Price,
                Name = product.Name
            };
        }
    }
}
