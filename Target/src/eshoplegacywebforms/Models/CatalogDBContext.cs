using System.Data.Entity;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogDBContext : DbContext
   {
       public CatalogDBContext():
           base(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb; Integrated Security=True; MultipleActiveResultSets=True;")
       {
       }

      [Intercepted]

      public DbSet<CatalogItem> CatalogItems { get; set; }

      [Intercepted]

      public DbSet<CatalogBrand> CatalogBrands { get; set; }

      [Intercepted]

      public DbSet<CatalogType> CatalogTypes { get; set; }

   }
}