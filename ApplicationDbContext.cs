using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Dog_Store_App.Data;

namespace Dog_Store_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Dog_Store_App.Data.Dog> Dog { get; set; }
        public DbSet<Dog_Store_App.Data.Pet_Stores> Pet_Stores { get; set; }
    }
}
