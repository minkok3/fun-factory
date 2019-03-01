using System.Data.Entity;
using WebApp.Domain;

namespace WebApp.Data
{
    public class FunFactoryDbContext : DbContext
    {
        public FunFactoryDbContext() : base("FunFactoryContext")
        {
        }

        public DbSet<Component> Products { get; set; }
        public DbSet<KitComponent> Components { get; set; }
    }
}