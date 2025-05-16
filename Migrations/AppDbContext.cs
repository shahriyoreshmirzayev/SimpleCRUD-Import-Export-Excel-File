using Microsoft.EntityFrameworkCore;
using SImpleCRUD.DataAccess;
using SImpleCRUD.DataAccess.Entities;

namespace SImpleCRUD.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.GenerateSeed();
        }
    }
}
