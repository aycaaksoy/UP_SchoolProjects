using CQRS.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.DAL.Context
{
    public class ProductContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-60DI5A8;Database=DbCQRS;User Id=aycaa; Password=admin; integrated security=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
