using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Application.Services;
using PizzaApp.DataAccess;
using PizzaApp.DataAccess.Entities;

namespace PizzaApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;
        private readonly CurrentUserService currentUserService;

        public WeatherForecastController(DatabaseContext databaseContext, CurrentUserService currentUserService)
        {
            this.databaseContext = databaseContext;
            this.currentUserService = currentUserService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            this.databaseContext.Orders.Add(new Order
            {
                UserId = currentUserService.Id,
                Products = new List<OrderProduct>
                {
                    new OrderProduct
                    {
                        ProductId = 1
                    },
                    new OrderProduct
                    {
                        ProductId = 2
                    }
                }
            });

            this.databaseContext.SaveChanges();

            return Ok();
        }

        [HttpGet("orders")]
        public IActionResult GetOrders()
        {
            var response = databaseContext.Orders.Include(x => x.User)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .Where(x => x.UserId == currentUserService.Id);
            
            return Ok(response);
        }
    }
}