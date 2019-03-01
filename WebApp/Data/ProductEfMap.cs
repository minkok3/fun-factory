using System.Data.Entity.ModelConfiguration;
using WebApp.Domain;

namespace WebApp.Data
{
    public class ProductEfMap : EntityTypeConfiguration<Component>
    {
        public ProductEfMap()
        {
            HasKey(x => x.Id);
        }
    }
}