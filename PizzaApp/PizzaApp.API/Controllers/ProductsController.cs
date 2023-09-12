using Microsoft.AspNetCore.Mvc;
using PizzaApp.API.DataAccess;
using PizzaApp.API.DataAccess.Entities;
using PizzaApp.API.Models.Products;

namespace PizzaApp.API.Controllers
{
    [ApiController]
    [Route("products")] // /products
    public class ProductsController : ControllerBase
    {
        // CRUD
        // C
        [HttpPost("")] // + "" => /products
        public async Task<IActionResult> CreateProductAsync(CreateProductRequestModel requestModel)
        {
            // URAT
            //if (product.Name.Length < 5)
            //{
            //    return BadRequest("Name should be greather than 5 characters.");
            //}

            Product product = new Product
            {
                Name = requestModel.Name,
                Description = requestModel.Description,
                Price = requestModel.Price,
                Category = requestModel.Category,
            };
            product.Id = TemporaryStorage.Products.Count;

            TemporaryStorage.Products.Add(product);

            ProductResponseModel response = new ProductResponseModel
            {
                Id = product.Id,
                Category = product.Category,
                Description = product.Description,
                Price = product.Price,
                Name = product.Name,
            };

            return Created(string.Empty, response);
        }

        // R
        [HttpGet] // + "" => /products
        public async Task<ActionResult<List<Product>>> GetAllProductsAsync()
        {
            return TemporaryStorage.Products;
        }

        [HttpGet("{id}")] // + {id} => /products/{id}
        public async Task<ActionResult<Product>> ReadProductByIdAsync(int id)
        {
            Product product = TemporaryStorage.Products.Where(x => x.Id == id).First();

            return product;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductAsync(int id, UpdateProductRequestModel requestModel)
        {
            Product productFromDb = TemporaryStorage.Products.Where(x => x.Id == id).FirstOrDefault();

            if (productFromDb == null) 
            {
                return NotFound();
            }

            productFromDb.Name = requestModel.Name;
            productFromDb.Description = requestModel.Description;
            productFromDb.Price = requestModel.Price;
            productFromDb.Category = requestModel.Category;

            ProductResponseModel response = new ProductResponseModel
            {
                Id = productFromDb.Id,
                Category = productFromDb.Category,
                Description = productFromDb.Description,
                Price = productFromDb.Price,
                Name = productFromDb.Name,
            };

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            Product productFromDb = TemporaryStorage.Products.Where(x => x.Id == id).First();

            int productIndex = TemporaryStorage.Products.IndexOf(productFromDb);

            TemporaryStorage.Products.RemoveAt(productIndex);

            return NoContent();
        }
    }
}
