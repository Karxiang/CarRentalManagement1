﻿using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement1.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
		public string? FirstName { get; set; }
        public string? LastName { get; set;}

	}
}
