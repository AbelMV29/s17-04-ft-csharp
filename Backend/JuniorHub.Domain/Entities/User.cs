﻿using Microsoft.AspNetCore.Identity;

namespace JuniorHub.Domain.Entities;

public class User : IdentityUser<int>
{
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    //es null, ya que no es obligatorio que tenga una foto cuando se registre.
    public string? MediaUrl { get; set; }
}