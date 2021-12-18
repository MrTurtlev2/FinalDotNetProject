using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalDotNetProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinalDotNetProject.Data
{
    public class FinalDotNetProjectContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public FinalDotNetProjectContext (DbContextOptions<FinalDotNetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsModel> ProductsModel { get; set; }
    }
}
