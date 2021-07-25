using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Chicago.Dal
{
    public class ChicagoDbContext : DbContext
    {
        public ChicagoDbContext(DbContextOptions<ChicagoDbContext> options) : base(options) { }

        public ChicagoDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
