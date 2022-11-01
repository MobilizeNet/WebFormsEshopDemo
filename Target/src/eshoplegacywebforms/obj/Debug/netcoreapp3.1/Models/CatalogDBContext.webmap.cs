#pragma warning disable
#line 1 "Models\\CatalogDBContext.cs"
#pragma warning disable
#line 1 "Models\\CatalogDBContext.cs"
using System.Data.Entity;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public partial class CatalogDBContext : DbContext
   {
       public CatalogDBContext():
           base(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb; Integrated Security=True; MultipleActiveResultSets=True;")
       {
       }

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogItem> CatalogItems_k__BackingField;
#line 17


      [Intercepted]

      public DbSet<CatalogItem> CatalogItems 
#line 17
                                             { 
#line 17
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogItems)<=0){this.CatalogItems_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogItem>>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogItems;}return this.CatalogItems_k__BackingField;} 
#line 17

#line 17
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<DbSet<CatalogItem> >(this,_Mobilize_References,0,this.CatalogItems_k__BackingField,(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogItem>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogItems;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogItems;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogItems_k__BackingField=(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogItem>)value;} 
#line 17
                                                         }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogBrand> CatalogBrands_k__BackingField;
#line 21


      [Intercepted]

      public DbSet<CatalogBrand> CatalogBrands 
#line 21
                                               { 
#line 21
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogBrands)<=0){this.CatalogBrands_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogBrand>>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogBrands;}return this.CatalogBrands_k__BackingField;} 
#line 21

#line 21
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<DbSet<CatalogBrand> >(this,_Mobilize_References,1,this.CatalogBrands_k__BackingField,(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogBrand>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogBrands;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogBrands;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogBrands_k__BackingField=(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogBrand>)value;} 
#line 21
                                                           }

#line 22

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogType> CatalogTypes_k__BackingField;
#line 25


      [Intercepted]

      public DbSet<CatalogType> CatalogTypes 
#line 25
                                             { 
#line 25
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogTypes)<=0){this.CatalogTypes_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogType>>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogTypes;}return this.CatalogTypes_k__BackingField;} 
#line 25

#line 25
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<DbSet<CatalogType> >(this,_Mobilize_References,2,this.CatalogTypes_k__BackingField,(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogType>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogTypes;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogTypes;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogTypes_k__BackingField=(System.Data.Entity.DbSet<eShopLegacyWebForms.Models.CatalogType>)value;} 
#line 25
                                                         }

#line 26

   }
}
#pragma warning restore
