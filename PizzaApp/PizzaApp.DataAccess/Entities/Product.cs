namespace PizzaApp.DataAccess.Entities
{
    public class Product
    {
        public Product()
        {
            this.CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public enum Category
    {
        Pizza = 1,
        Desert = 2,
        Beer = 3
    }
}
