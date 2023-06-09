﻿using Dating_App.Extentions;
using Microsoft.AspNetCore.Identity;

namespace Dating_App.Entities;

public class AppUser :IdentityUser<int>
{
    public DateTime DateOfBirth { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime LastActive { get; set; } =DateTime.Now;
    public string? KnownAs { get; set; }
    public string? Gender { get; set; }
    public string? Introduction { get; set; }
    public string? LookingFor { get; set; }
    public string? Interests { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public ICollection<Photo> Photos { get; set; }
    public ICollection<AppUserRole> userRoles { get; set; }

 
    public int GetAge()
    {
        return DateOfBirth.CalculateAge();
    }
}