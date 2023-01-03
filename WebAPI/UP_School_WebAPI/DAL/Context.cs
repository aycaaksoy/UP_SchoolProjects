using Microsoft.EntityFrameworkCore;
using UP_School_WebAPI.DAL.Entities;

namespace UP_School_WebAPI.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-60DI5A8;initial catalog= UPSchoolAPI;User Id=aycaa; Password=admin; integrated security=True;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
