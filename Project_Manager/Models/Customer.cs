using System;
using System.Collections.Generic;

namespace Project_Manager.Models;

public partial class Customer
{
    public string Cid { get; set; } = null!;

    public string? Cname { get; set; }

    public string? Caddress { get; set; }

    public string? Cmobile { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
