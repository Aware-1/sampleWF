namespace WebApplication2.Data.Model;
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<ProductPrice> ProductPrices { get; set; }
}