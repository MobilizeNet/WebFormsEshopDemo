using System.Data.Entity;

namespace eShopLegacyWebForms.Models
{
    public class CatalogDBContext : DbContext
    {
        public CatalogDBContext():
            base(@"Data Source=localhost; Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb; Integrated Security=True; MultipleActiveResultSets=True;")
        {
        }

        public DbSet<CatalogItem> CatalogItems { get; set; }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }

        public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}
