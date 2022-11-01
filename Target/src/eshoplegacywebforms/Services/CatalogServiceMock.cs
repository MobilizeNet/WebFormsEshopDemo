using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Models.Infrastructure;
using eShopLegacyWebForms.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{

   [Observable]
   public class CatalogServiceMock : ICatalogService
   {

      [Intercepted]
      private List<CatalogItem> catalogItems { get; set; }


      public CatalogServiceMock()
      {
          catalogItems = new List<CatalogItem>(PreconfiguredData.GetPreconfiguredCatalogItems());
      }

      public CatalogItemsViewModel<CatalogItem> GetCatalogItems()
      {
          var items = ComposeCatalogItems(catalogItems);

          var itemsOnPage = items
              .OrderBy(c => c.Id)
              .ToList();

          return new CatalogItemsViewModel<CatalogItem>(itemsOnPage);
      }

      public CatalogItem FindCatalogItem(int id)
      {
          return catalogItems.FirstOrDefault(x => x.Id == id);
      }

      public IEnumerable<CatalogType> GetCatalogTypes()
      {
          return PreconfiguredData.GetPreconfiguredCatalogTypes();
      }

      public IEnumerable<CatalogBrand> GetCatalogBrands()
      {
          return PreconfiguredData.GetPreconfiguredCatalogBrands();
      }

      public void CreateCatalogItem(CatalogItem catalogItem)
      {
          var maxId = catalogItems.Max(i => i.Id);
          catalogItem.Id = ++maxId;
          catalogItems.Add(catalogItem);
      }

      public void UpdateCatalogItem(CatalogItem modifiedItem)
      {
          var originalItem = FindCatalogItem(modifiedItem.Id);
          if (originalItem != null)
          {
              catalogItems[catalogItems.IndexOf(originalItem)] = modifiedItem;
          }
      }

      public void RemoveCatalogItem(CatalogItem catalogItem)
      {
          catalogItems.Remove(catalogItem);
      }

      public void Dispose()
      {
      }

      private List<CatalogItem> ComposeCatalogItems(List<CatalogItem> items)
      {
          var catalogTypes = PreconfiguredData.GetPreconfiguredCatalogTypes();
          var catalogBrands = PreconfiguredData.GetPreconfiguredCatalogBrands();
          items.ForEach(i => i.CatalogBrand = catalogBrands.First(b => b.Id == i.CatalogBrandId));
          items.ForEach(i => i.CatalogType = catalogTypes.First(b => b.Id == i.CatalogTypeId));

          return items;
      }

   }
}