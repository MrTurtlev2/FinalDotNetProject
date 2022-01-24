//using Microsoft.EntityFrameworkCore;
//using FinalDotNetProject.Models;

//namespace FinalDotNetProject.Data
//{
//    public class ApplicationDbContext : DbContext
//    {
//        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=FinalDotNetProjectContext-b395314e-80e0-461b-bb7d-64cfa3ea50c1;MultipleActiveResultSets=true";
//        public ApplicationDbContext (DbContextOptions options): base(options)
//        {
//        }

//        public DbSet<ProductsModel> ProductsModel { get; set; }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(_connectionString);
//        }
//    }
//}
