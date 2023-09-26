namespace PizzaApp.Application.Models.Products;

public class ReadProductsRequestModel
{
    public string? OrderBy { get; set; }

    public int Page { get; set; } = 1;

    public int PageCount { get; set; } = 25;
}