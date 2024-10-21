namespace WebApplication2.Data.Model;
using System.ComponentModel.DataAnnotations;

public class OrderDetail
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int Amount { get; set; }
    
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int OrderId { get; set; }

    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int ProductId { get; set; }
}