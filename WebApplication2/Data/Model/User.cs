namespace WebApplication2.Data.Model;

public class User
{
    public int Id { get; set; }
     public string UserName { get; set; }
     public string Name { get; set; }
     public string PassWord { get; set; }
    public ICollection<Order> Orders { get; set; }
}