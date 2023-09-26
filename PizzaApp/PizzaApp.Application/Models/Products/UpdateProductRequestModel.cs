﻿using System.ComponentModel.DataAnnotations;
using PizzaApp.DataAccess.Entities;

namespace PizzaApp.Application.Models.Products
{
    public class UpdateProductRequestModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        public int Price { get; set; }

        public string? Description { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
