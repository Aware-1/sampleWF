﻿namespace WebApplication2.Data.Model;
using System.ComponentModel.DataAnnotations;

public class OrderDetail
{
    public int Id { get; set; }
    public int Amount { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public int ProductId { get; set; }
     public Product Product { get; set; }
}