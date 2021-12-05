using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalDotNetProject.Models;

namespace FinalDotNetProject.Data
{
    public class FinalDotNetProjectContext : DbContext
    {
        public FinalDotNetProjectContext (DbContextOptions<FinalDotNetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalDotNetProject.Models.ProductsModel> ProductsModel { get; set; }
    }
}
