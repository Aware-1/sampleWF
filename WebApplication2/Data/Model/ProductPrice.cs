namespace WebApplication2.Data.Model;

public class ProductPrice
{
    public int Id { get; set; }
    public int Price { get; set; }
    public bool Active { get; set; }
    public DateTime startDate { get; set; }
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
}