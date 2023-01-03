using CRM.Business.Layer.Concrete;
using CRM.Entity.Layer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-60DI5A8;Database=DbCRM;User Id=aycaa; Password=admin; integrated security=True;");
            }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<EmployeeTask> EmployeesTasks { get; set; }

            public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }

            public DbSet<Message> Messages { get; set; }

            public DbSet<Message> Announcement { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }
            public DbSet<Contact> Contacts { get; set; }
    }
    
}
