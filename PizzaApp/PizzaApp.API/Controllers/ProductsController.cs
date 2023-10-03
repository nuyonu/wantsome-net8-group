using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Application.Models.Products;
using PizzaApp.Application.Services.Interfaces;

namespace PizzaApp.API.Controllers
{
    [ApiController]
    [Route("products")] // /products
    [Authorize(Roles = "User")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        
        // CRUD
        // C
        [Authorize(Roles = "Admin")]
        [HttpPost("")] // + "" => /products
        public async Task<IActionResult> CreateProductAsync(CreateProductRequestModel requestModel)
        {
            // URAT
            //if (product.Name.Length < 5)
            //{
            //    return BadRequest("Name should be greather than 5 characters.");
            //}

            var response = await this.productService.CreateAsync(requestModel);

            return Created(nameof(ReadProductByIdAsync), response);
        }
        
        //R
        [HttpGet] // + "" => /products?orderBy=createdAt&page=1&pageCount=10
        public async Task<IActionResult> GetAllProductsAsync([FromQuery] ReadProductsRequestModel requestModel)
        {
            var response = await this.productService.ReadAllAsync(requestModel);
            
            return Ok(response);
        }

        [HttpGet("{id}")] // + {id} => /products/{id}
        public async Task<IActionResult> ReadProductByIdAsync(int id)
        {
            var response = await this.productService.ReadByIdAsync(id);
            
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductAsync(int id, UpdateProductRequestModel requestModel)
        {
            var response = await this.productService.UpdateAsync(id, requestModel);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            await this.productService.DeleteAsync(id);
            
            return NoContent();
        }
    }
}
