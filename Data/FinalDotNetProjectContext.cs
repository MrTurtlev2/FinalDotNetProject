using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalDotNetProject.Models;
using FinalDotNetProject.Models.Auth;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FinalDotNetProject.Data
{
    public class FinalDotNetProjectContext : IdentityDbContext<AppUser>
    {
        public DbSet<FinalDotNetProject.Models.ProductsModel> ProductsModel { get; set; }
    }
}
