using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{

   [Observable]
   public class CatalogService : ICatalogService
   {

      [Intercepted]
      private CatalogDBContext db { get; set; }


      public CatalogService()
      {
          this.db = new CatalogDBContext();
      }

      public CatalogItemsViewModel<CatalogItem> GetCatalogItems()
      {
          var totalItems = db.CatalogItems.LongCount();

          var itemsOnPage = db.CatalogItems
              .Include(c => c.CatalogBrand)
              .Include(c => c.CatalogType)
              .OrderBy(c => c.Id)
              .ToList();

          return new CatalogItemsViewModel<CatalogItem>(itemsOnPage);
      }

      public CatalogItem FindCatalogItem(int id)
      {
          return db.CatalogItems.Include(c => c.CatalogBrand).Include(c => c.CatalogType).FirstOrDefault(ci => ci.Id == id);
      }

      public IEnumerable<CatalogType> GetCatalogTypes()
      {
          return db.CatalogTypes.ToList();
      }

      public IEnumerable<CatalogBrand> GetCatalogBrands()
      {
          return db.CatalogBrands.ToList();
      }

      public void CreateCatalogItem(CatalogItem catalogItem)
      {
          db.CatalogItems.Add(catalogItem);
          db.SaveChanges();
      }

      public void UpdateCatalogItem(CatalogItem catalogItem)
      {
          db.Entry(catalogItem).State = EntityState.Modified;
          db.SaveChanges();
      }

      public void RemoveCatalogItem(CatalogItem catalogItem)
      {
          db.CatalogItems.Remove(catalogItem);
          db.SaveChanges();
      }

      public void Dispose()
      {
          db.Dispose();
      }

   }
}