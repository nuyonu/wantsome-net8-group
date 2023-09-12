using PizzaApp.API.DataAccess;
using System.ComponentModel.DataAnnotations;
using PizzaApp.API.DataAccess.Entities;

namespace PizzaApp.API.Models.Products
{
    public class UpdateProductRequestModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        public double Price { get; set; }

        public string? Description { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
