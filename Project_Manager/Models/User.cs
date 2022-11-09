using System;
using System.Collections.Generic;

namespace Project_Manager.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Fullname { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public string? Mobile { get; set; }

    public string? Cccd { get; set; }

    public string? Address { get; set; }

    public int? Gender { get; set; }

    public string? Dob { get; set; }

    public int? Verify { get; set; }

    public string? Code { get; set; }
}
