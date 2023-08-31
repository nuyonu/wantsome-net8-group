﻿using PizzaApp.API.DataAccess;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.API.Models.Products
{
    public class CreateProductRequestModel
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
