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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<User>()
			.Property(u => u.Name)
			.HasColumnName("name");

            modelBuilder.Entity<Address>().Ignore(a => a.City);
            modelBuilder.Entity<Address>().Property(u => u.PostIndex).HasColumnName("postal_index");
			modelBuilder.Entity<User>().Property(u => u.Name).IsRequired(true);
		}
	}
}
