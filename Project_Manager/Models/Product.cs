using System;
using System.Collections.Generic;

namespace Project_Manager.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
