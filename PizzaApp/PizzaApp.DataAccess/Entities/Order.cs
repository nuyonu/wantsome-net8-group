namespace PizzaApp.DataAccess.Entities;

public class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }
    
    public User User { get; set; }
    
    public List<OrderProduct> Products { get; set; }
}