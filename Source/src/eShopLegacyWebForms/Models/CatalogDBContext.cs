using System.Data.Entity;
using eShopLegacyWebForms.Models.Infrastructure;

namespace eShopLegacyWebForms.Models
{
    public class CatalogDBContext : DbContext
    {
        public static bool isInitialized = false;
        public CatalogDBContext(bool initializeDB = true) :
            base(
                @"Data Source=S16-WS12-DB011; Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb;persist security info=True;  user id=productreader;password=curlyLe@f15")
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

        public DbSet<CatalogItem> CatalogItems { get; set; }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }

        public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}
