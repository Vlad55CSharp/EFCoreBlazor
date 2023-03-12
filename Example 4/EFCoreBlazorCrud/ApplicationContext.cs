using EFCoreBlazorMigrations.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace EFCoreBlazor
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
            //_ = Database.EnsureCreated();
        }
    }
}
