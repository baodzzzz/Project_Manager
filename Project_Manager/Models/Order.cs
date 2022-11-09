using System;
using System.Collections.Generic;

namespace Project_Manager.Models;

public partial class Order
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string CustomerId { get; set; } = null!;

    public DateTime? Time { get; set; }

    public string? Note { get; set; }

    public int? Count { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
