using PizzaApp.WebUI.Validators;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.WebUI.Models
{
    public class CreateProductRequestModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [IsGreaterThan(10)]
        public double Price { get; set; }

        public string? Description { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
