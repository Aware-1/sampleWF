namespace WebApplication2.Data.Model;
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int UserId { get; set; }
    
    [Display(Name = "نام محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Name { get; set; }
    
    [Display(Name = "قیمت محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int Price { get; set; }
    
    
    
    
    public ICollection<OrderDetail> OrderDetails { get; set; }

}