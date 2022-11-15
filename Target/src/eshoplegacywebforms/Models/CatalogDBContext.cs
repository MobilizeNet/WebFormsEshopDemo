using System.Data.Entity;
using eShopLegacyWebForms.Models.Infrastructure;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogDBContext : DbContext
   {

      [Intercepted]
      public static bool isInitialized { get; set; } = false;


      public CatalogDBContext(bool initializeDB = true) :
          base(
              @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb; Integrated Security=True; MultipleActiveResultSets=True;")
      {
          if (isInitialized == false)
          {
              isInitialized = true;
              InitializeDatabase();
          }

      }

      protected virtual void InitializeDatabase()
      {
          var initializaer = new CatalogDBInitializer();
      }

      [Intercepted]

      public DbSet<CatalogItem> CatalogItems { get; set; }

      [Intercepted]

      public DbSet<CatalogBrand> CatalogBrands { get; set; }

      [Intercepted]

      public DbSet<CatalogType> CatalogTypes { get; set; }

   }
}