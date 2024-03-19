﻿using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{
    public int ProductId { get; set; }

    
    public string? ProductName { get; set; } = String.Empty;

    public String? Summary {get; set;} = String.Empty;

    public String? ImageUrl {get; set;}

    public decimal Price { get; set; }

    public int? CategoryId {get; set;}  //Foreign Key

    public Category? Category {get; set;} //Navigation Property

}
