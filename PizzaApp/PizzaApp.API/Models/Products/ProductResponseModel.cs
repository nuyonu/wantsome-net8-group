using PizzaApp.API.DataAccess;

namespace PizzaApp.API.Models.Products
{
    public class ProductResponseModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public Category Category { get; set; }
    }
}
