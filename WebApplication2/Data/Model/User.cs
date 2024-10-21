namespace WebApplication2.Data.Model;

public class User
{
    public int Id { get; set; }
    
    
    
    
    public ICollection<Order> Orders { get; set; }
    public ICollection<Product> Products { get; set; }
}