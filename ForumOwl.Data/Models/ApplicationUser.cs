﻿using Microsoft.AspNetCore.Identity;
using System;

namespace ForumOwl.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int Rating { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime MemeberSince { get; set; }
        public bool IsActive { get; set; }
    }
}
