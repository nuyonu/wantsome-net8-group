using PizzaApp.API.DataAccess.Entities;

namespace PizzaApp.API.DataAccess
{
    public static class TemporaryStorage
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        
        public static List<User> Users { get; set; } = new List<User>();
    }
}
