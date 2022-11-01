#pragma warning disable
#line 1 "Services\\CatalogService.cs"
#pragma warning disable
#line 1 "Services\\CatalogService.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{

   [Observable]
   public partial class CatalogService : ICatalogService
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogDBContext db_k__BackingField;
#line 16


      [Intercepted]
      private CatalogDBContext db 
#line 16
                                  { 
#line 16
                                    get                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_db)<=0){this.db_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogDBContext>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_db;;} return this.db_k__BackingField; } 
#line 16

#line 16
                                         set                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogDBContext>(this,_Mobilize_References,0,this.db_k__BackingField,(eShopLegacyWebForms.Models.CatalogDBContext)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_db;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_db;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.db_k__BackingField=(eShopLegacyWebForms.Models.CatalogDBContext)value;} 
#line 16
                                              }

#line 17


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
#pragma warning restore
