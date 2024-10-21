using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Data.Model;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public bool IsFinally { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

}