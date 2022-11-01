#pragma warning disable
#line 1 "Services\\CatalogServiceMock.cs"
#pragma warning disable
#line 1 "Services\\CatalogServiceMock.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Models.Infrastructure;
using eShopLegacyWebForms.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{

   [Observable]
   public partial class CatalogServiceMock : ICatalogService
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Generic.List<eShopLegacyWebForms.Models.CatalogItem> catalogItems_k__BackingField;
#line 16


      [Intercepted]
      private List<CatalogItem> catalogItems 
#line 16
                                             { 
#line 16
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_catalogItems)<=0){this.catalogItems_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Generic.List<eShopLegacyWebForms.Models.CatalogItem>>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_catalogItems;}return this.catalogItems_k__BackingField;} 
#line 16

#line 16
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<List<CatalogItem> >(this,_Mobilize_References,0,this.catalogItems_k__BackingField,(System.Collections.Generic.List<eShopLegacyWebForms.Models.CatalogItem>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_catalogItems;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_catalogItems;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.catalogItems_k__BackingField=(System.Collections.Generic.List<eShopLegacyWebForms.Models.CatalogItem>)value;} 
#line 16
                                                         }

#line 17


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
#pragma warning restore
